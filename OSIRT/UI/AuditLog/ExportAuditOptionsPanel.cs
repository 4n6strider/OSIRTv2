﻿using System;
using System.Windows.Forms;
using System.Linq;
using System.Collections;
using OSIRT.Database;
using OSIRT.Helpers;
using OSIRT.Extensions;
using System.Diagnostics;
using System.Collections.Generic;
using System.IO;
using OSIRT.Loggers;
using System.Data;
using System.Text;
using System.Globalization;
using Jacksonsoft;
using System.ComponentModel;
using System.Threading;

namespace OSIRT.UI.AuditLog
{
    public partial class ExportAuditOptionsPanel : UserControl
    {

        public string ExportPath { get; private set; }
        public string GSCP { get; private set; }


        public ExportAuditOptionsPanel()
        {
            InitializeComponent();
        }

        private void ExportAuditOptions_Load(object sender, EventArgs e)
        {
            ToggleExportFileButtons(false);
            GSCP = "";
        }


        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            EnableTablesToPrint();
            Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top;
        }

        private void EnableTablesToPrint()
        {
            DatabaseHandler dbHandler = new DatabaseHandler();
            var checkboxes = uiReportSelectionGroupBox.GetChildControls<CheckBox>();
            foreach (CheckBox cb in checkboxes)
            {
                string table = cb.Tag.ToString();
                if (dbHandler.TableIsEmpty(table))
                {
                    cb.Enabled = false;
                    cb.Checked = false;
                }
            }
        }

        private IEnumerable<Tuple<string, string>> GetHtml()
        {
            foreach (string table in GetSelectedTables())
            {
                string save = HtmlHelper.GetFormattedPage(table, ExportPath, GSCP, true);
                yield return Tuple.Create(table, save);
            }
        }

        public List<string> GetSelectedTables()
        {
            List<string> selectedTables = new List<string>();
            var checkboxes = uiReportSelectionGroupBox.GetChildControls<CheckBox>();
            foreach (CheckBox cb in checkboxes)
            {
                if (!cb.Checked) continue;

                selectedTables.Add(cb.Tag.ToString());
            }
            return selectedTables;
        }

        private void uiToggleCheckedButton_Click(object sender, EventArgs e)
        {
        }

        private void uiExportAsHtmlButton_Click(object sender, EventArgs e)
        {
            var backgroundWorker = new BackgroundWorker();
            uiProgressGroupBox.Show();
            EnableOptionsGroupboxes(false);
            backgroundWorker.DoWork += delegate
            {
                ExportAsHtml();
            };
            backgroundWorker.RunWorkerCompleted += delegate
            {
                uiProgressGroupBox.Hide();
                EnableOptionsGroupboxes(true);
                MessageBox.Show("Report successfully exported", "Report Exported", MessageBoxButtons.OK, MessageBoxIcon.Information);
            };
            backgroundWorker.RunWorkerAsync();
        }

        private void ExportAsPdf()
        {
            string page = DatatableToHtml.ConvertToHtml(GetMergedDataTable(), ExportPath);
            string save = HtmlHelper.ReplaceReportDetails(page, GSCP, false);
            HtmLtoPdf.SaveHtmltoPdf(save, "audit log", Path.Combine(ExportPath, Constants.ReportContainerName, Constants.PdfReportName));
            string hash = OsirtHelper.CreateHashForFolder(Path.Combine(ExportPath, Constants.ReportContainerName));
            Logger.Log(new OsirtActionsLog(Enums.Actions.Report, hash, Constants.ReportContainerName));
        }

        private void EnableOptionsGroupboxes(bool enabled)
        {
            uiExportAsGroupBox.Enabled = enabled;
            uiReportOptionsGroupBox.Enabled = enabled;
            uiExportAsGroupBox.Enabled = enabled;
            uiReportSelectionGroupBox.Enabled = enabled;
            uiProgressGroupBox.Enabled = !enabled;
        }

        private void ExportAsHtml()
        {
            
            foreach (var value in GetHtml())
            {
                string savePath = Path.Combine(ExportPath, Constants.ReportContainerName, $"{value.Item1}.html");
                string page = value.Item2.Replace("<%%NAV%%>", HtmlHelper.GetHtmlNavBar(GetSelectedTables()));
                File.WriteAllText(savePath, page);
            }
            //combined
            string combined = DatatableToHtml.ConvertToHtml(GetMergedDataTable(), ExportPath);
            string save = HtmlHelper.ReplaceReportDetails(combined, GSCP, true);
            File.WriteAllText(Path.Combine(ExportPath, Constants.ReportContainerName, "combined.html"), save);
            Thread.Sleep(750);
            string hash = OsirtHelper.CreateHashForFolder(Path.Combine(ExportPath, Constants.ReportContainerName));
            Logger.Log(new OsirtActionsLog(Enums.Actions.Report, hash, Constants.ReportContainerName));
        }


        private DataTable GetMergedDataTable()
        {
            DatabaseHandler db = new DatabaseHandler();
            DataTable merged = new DataTable();
            foreach (string table in GetSelectedTables())
            {
                string columns = DatabaseTableHelper.GetTableColumns(table);
                DataTable dt = db.GetRowsFromColumns(table: table, columns: columns);
                merged.Merge(dt, true, MissingSchemaAction.Add);
            }
            merged.TableName = "merged";
            DataView view = new DataView(merged);
            view.Sort = "date asc, time asc";
            DataTable sortedTable = view.ToTable();
            return sortedTable;
        }



        private void uiExportAsPdfButton_Click(object sender, EventArgs e)
        {
            var backgroundWorker = new BackgroundWorker();
            uiReportExportProgressBar.Show();
            backgroundWorker.DoWork += delegate
            {
                ExportAsPdf();
            };
            backgroundWorker.RunWorkerCompleted += delegate
            {
                uiReportExportLabel.Hide();
                uiReportExportProgressBar.Hide();
                MessageBox.Show("Report successfully exported", "Report Exported", MessageBoxButtons.OK, MessageBoxIcon.Information);
            };
            backgroundWorker.RunWorkerAsync();
        }

        private void uiBrowseButton_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog folderDialog = new FolderBrowserDialog())
            {
                DialogResult result = folderDialog.ShowDialog();
                if (result != DialogResult.OK)
                    return;

                ExportPath = folderDialog.SelectedPath;
                uiPathTextBox.Text = ExportPath;
            }
        }

        private void ToggleExportFileButtons(bool enabled)
        {
            uiExportAsPdfButton.Enabled = enabled;
            uiExportAsHtmlButton.Enabled = enabled;
            uiExportAsCaseFileButton.Enabled = enabled;
    
        }

        private void uiPathTextBox_TextChanged(object sender, EventArgs e)
        {
            if(!string.IsNullOrWhiteSpace(ExportPath))
                ToggleExportFileButtons(true);
        }

        private void uiExportAsHtmlButton_MouseHover(object sender, EventArgs e)
        {
            uiReportExportHelpLabel.Text = "Export report as HTML";
        }

        private void uiExportAsPdfButton_MouseHover(object sender, EventArgs e)
        {
            uiReportExportHelpLabel.Text = "Export report as PDF";
        }

        private void uiExportAsCaseFileButton_MouseHover(object sender, EventArgs e)
        {
            uiReportExportHelpLabel.Text = "Export report as OSRR file";
        }

        private void uiDisplayImagesCheckBox_CheckedChanged(object sender, EventArgs e)
        {

            UserSettings settings = UserSettings.Load();
            settings.PrintImagesInReport = uiDisplayImagesCheckBox.Checked;
            settings.Save();
        }

        private void uiPrintNotesCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            UserSettings settings = UserSettings.Load();
            settings.PrintAuditNotes = uiPrintNotesCheckBox.Checked;
            settings.Save();
        }

        private void uiDisplayVideosCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            UserSettings settings = UserSettings.Load();
            settings.ShowVideosInReport = uiDisplayVideosCheckBox.Checked;
            settings.Save();
        }

        private void uiGSCPComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            GSCP = uiGSCPComboBox.Text;
        }

        private void uiExportAsCaseFileButton_Click(object sender, EventArgs e)
        {
            //export as ossr file


        }
    }
}