﻿namespace OSIRT.UI
{
    partial class CaseDetailsPanel
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.uiCaseDetailsPanel = new System.Windows.Forms.Panel();
            this.uiHashHelpLabel = new System.Windows.Forms.Label();
            this.uiNextButton = new System.Windows.Forms.Button();
            this.uiBackButton = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.uiHashFunctionComboBox = new System.Windows.Forms.ComboBox();
            this.uiNotesTextBox = new OSIRT.UI.SpellBox();
            this.hostedComponent8 = new System.Windows.Controls.TextBox();
            this.uiBrowsButton = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.uiCasePathTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.uiEvidenceReferenceTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.uiCaseReferenceTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.uiOperationTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.uiAgencyTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.uiOfficerTextBox = new System.Windows.Forms.TextBox();
            this.uiCaseDetailsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // uiCaseDetailsPanel
            // 
            this.uiCaseDetailsPanel.Controls.Add(this.uiHashHelpLabel);
            this.uiCaseDetailsPanel.Controls.Add(this.uiNextButton);
            this.uiCaseDetailsPanel.Controls.Add(this.uiBackButton);
            this.uiCaseDetailsPanel.Controls.Add(this.label8);
            this.uiCaseDetailsPanel.Controls.Add(this.uiHashFunctionComboBox);
            this.uiCaseDetailsPanel.Controls.Add(this.uiNotesTextBox);
            this.uiCaseDetailsPanel.Controls.Add(this.uiBrowsButton);
            this.uiCaseDetailsPanel.Controls.Add(this.label7);
            this.uiCaseDetailsPanel.Controls.Add(this.uiCasePathTextBox);
            this.uiCaseDetailsPanel.Controls.Add(this.label6);
            this.uiCaseDetailsPanel.Controls.Add(this.label5);
            this.uiCaseDetailsPanel.Controls.Add(this.uiEvidenceReferenceTextBox);
            this.uiCaseDetailsPanel.Controls.Add(this.label4);
            this.uiCaseDetailsPanel.Controls.Add(this.uiCaseReferenceTextBox);
            this.uiCaseDetailsPanel.Controls.Add(this.label3);
            this.uiCaseDetailsPanel.Controls.Add(this.uiOperationTextBox);
            this.uiCaseDetailsPanel.Controls.Add(this.label2);
            this.uiCaseDetailsPanel.Controls.Add(this.uiAgencyTextBox);
            this.uiCaseDetailsPanel.Controls.Add(this.label1);
            this.uiCaseDetailsPanel.Controls.Add(this.uiOfficerTextBox);
            this.uiCaseDetailsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiCaseDetailsPanel.Location = new System.Drawing.Point(0, 0);
            this.uiCaseDetailsPanel.Name = "uiCaseDetailsPanel";
            this.uiCaseDetailsPanel.Size = new System.Drawing.Size(883, 661);
            this.uiCaseDetailsPanel.TabIndex = 0;
            this.uiCaseDetailsPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.uiCaseDetailsPanel_Paint);
            // 
            // uiHashHelpLabel
            // 
            this.uiHashHelpLabel.AutoSize = true;
            this.uiHashHelpLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiHashHelpLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiHashHelpLabel.Location = new System.Drawing.Point(144, 372);
            this.uiHashHelpLabel.Name = "uiHashHelpLabel";
            this.uiHashHelpLabel.Size = new System.Drawing.Size(23, 16);
            this.uiHashHelpLabel.TabIndex = 36;
            this.uiHashHelpLabel.Text = "[?]";
            this.uiHashHelpLabel.Click += new System.EventHandler(this.uiHashHelpLabel_Click);
            // 
            // uiNextButton
            // 
            this.uiNextButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.uiNextButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiNextButton.Location = new System.Drawing.Point(749, 626);
            this.uiNextButton.Name = "uiNextButton";
            this.uiNextButton.Size = new System.Drawing.Size(106, 26);
            this.uiNextButton.TabIndex = 27;
            this.uiNextButton.Text = "Next";
            this.uiNextButton.UseVisualStyleBackColor = true;
            this.uiNextButton.Click += new System.EventHandler(this.uiNextButton_Click);
            // 
            // uiBackButton
            // 
            this.uiBackButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.uiBackButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiBackButton.Location = new System.Drawing.Point(637, 626);
            this.uiBackButton.Name = "uiBackButton";
            this.uiBackButton.Size = new System.Drawing.Size(106, 26);
            this.uiBackButton.TabIndex = 28;
            this.uiBackButton.Text = "Back";
            this.uiBackButton.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(16, 352);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 16);
            this.label8.TabIndex = 35;
            this.label8.Text = "Hash Function";
            // 
            // uiHashFunctionComboBox
            // 
            this.uiHashFunctionComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.uiHashFunctionComboBox.FormattingEnabled = true;
            this.uiHashFunctionComboBox.Items.AddRange(new object[] {
            "md5",
            "sha1",
            "sha256",
            "sha384",
            "sha512"});
            this.uiHashFunctionComboBox.Location = new System.Drawing.Point(17, 371);
            this.uiHashFunctionComboBox.Name = "uiHashFunctionComboBox";
            this.uiHashFunctionComboBox.Size = new System.Drawing.Size(121, 21);
            this.uiHashFunctionComboBox.TabIndex = 34;
            this.uiHashFunctionComboBox.Tag = "hash_function";
            // 
            // uiNotesTextBox
            // 
            this.uiNotesTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uiNotesTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiNotesTextBox.Location = new System.Drawing.Point(14, 419);
            this.uiNotesTextBox.Multiline = true;
            this.uiNotesTextBox.Name = "uiNotesTextBox";
            this.uiNotesTextBox.Size = new System.Drawing.Size(841, 201);
            this.uiNotesTextBox.TabIndex = 33;
            this.uiNotesTextBox.Tag = "notes";
            this.uiNotesTextBox.WordWrap = true;
            // 
            // uiBrowsButton
            // 
            this.uiBrowsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiBrowsButton.Location = new System.Drawing.Point(627, 320);
            this.uiBrowsButton.Name = "uiBrowsButton";
            this.uiBrowsButton.Size = new System.Drawing.Size(90, 20);
            this.uiBrowsButton.TabIndex = 25;
            this.uiBrowsButton.Text = "browse...";
            this.uiBrowsButton.UseVisualStyleBackColor = true;
            this.uiBrowsButton.Click += new System.EventHandler(this.uiBrowseButton_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(15, 301);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 16);
            this.label7.TabIndex = 32;
            this.label7.Text = "Case Location";
            // 
            // uiCasePathTextBox
            // 
            this.uiCasePathTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiCasePathTextBox.Location = new System.Drawing.Point(14, 320);
            this.uiCasePathTextBox.Name = "uiCasePathTextBox";
            this.uiCasePathTextBox.ReadOnly = true;
            this.uiCasePathTextBox.Size = new System.Drawing.Size(606, 20);
            this.uiCasePathTextBox.TabIndex = 30;
            this.uiCasePathTextBox.Tag = "case_location";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(14, 403);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 16);
            this.label6.TabIndex = 31;
            this.label6.Text = "Notes";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(14, 247);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 16);
            this.label5.TabIndex = 29;
            this.label5.Text = "Evidence Reference";
            // 
            // uiEvidenceReferenceTextBox
            // 
            this.uiEvidenceReferenceTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uiEvidenceReferenceTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiEvidenceReferenceTextBox.Location = new System.Drawing.Point(13, 266);
            this.uiEvidenceReferenceTextBox.MaxLength = 200;
            this.uiEvidenceReferenceTextBox.Name = "uiEvidenceReferenceTextBox";
            this.uiEvidenceReferenceTextBox.Size = new System.Drawing.Size(842, 20);
            this.uiEvidenceReferenceTextBox.TabIndex = 24;
            this.uiEvidenceReferenceTextBox.Tag = "evidence_reference";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(15, 191);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 16);
            this.label4.TabIndex = 26;
            this.label4.Text = "Case Reference";
            // 
            // uiCaseReferenceTextBox
            // 
            this.uiCaseReferenceTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uiCaseReferenceTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiCaseReferenceTextBox.Location = new System.Drawing.Point(14, 210);
            this.uiCaseReferenceTextBox.MaxLength = 50;
            this.uiCaseReferenceTextBox.Name = "uiCaseReferenceTextBox";
            this.uiCaseReferenceTextBox.Size = new System.Drawing.Size(841, 20);
            this.uiCaseReferenceTextBox.TabIndex = 22;
            this.uiCaseReferenceTextBox.Tag = "case_reference";
            this.uiCaseReferenceTextBox.Enter += new System.EventHandler(this.uiCaseReferenceTextBox_Enter);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 16);
            this.label3.TabIndex = 23;
            this.label3.Text = "Operation Name";
            // 
            // uiOperationTextBox
            // 
            this.uiOperationTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uiOperationTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiOperationTextBox.Location = new System.Drawing.Point(13, 159);
            this.uiOperationTextBox.MaxLength = 200;
            this.uiOperationTextBox.Name = "uiOperationTextBox";
            this.uiOperationTextBox.Size = new System.Drawing.Size(842, 20);
            this.uiOperationTextBox.TabIndex = 21;
            this.uiOperationTextBox.Tag = "operation_name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 16);
            this.label2.TabIndex = 20;
            this.label2.Text = "Investigating Agency";
            // 
            // uiAgencyTextBox
            // 
            this.uiAgencyTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uiAgencyTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiAgencyTextBox.Location = new System.Drawing.Point(14, 105);
            this.uiAgencyTextBox.MaxLength = 200;
            this.uiAgencyTextBox.Name = "uiAgencyTextBox";
            this.uiAgencyTextBox.Size = new System.Drawing.Size(841, 20);
            this.uiAgencyTextBox.TabIndex = 18;
            this.uiAgencyTextBox.Tag = "investigating_agency";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 16);
            this.label1.TabIndex = 19;
            this.label1.Text = "Investigating Officer";
            // 
            // uiOfficerTextBox
            // 
            this.uiOfficerTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uiOfficerTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiOfficerTextBox.Location = new System.Drawing.Point(14, 49);
            this.uiOfficerTextBox.MaxLength = 200;
            this.uiOfficerTextBox.Name = "uiOfficerTextBox";
            this.uiOfficerTextBox.Size = new System.Drawing.Size(841, 20);
            this.uiOfficerTextBox.TabIndex = 17;
            this.uiOfficerTextBox.Tag = "investigating_officer";
            // 
            // CaseDetailsPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.uiCaseDetailsPanel);
            this.Name = "CaseDetailsPanel";
            this.Size = new System.Drawing.Size(883, 661);
            this.Load += new System.EventHandler(this.CaseDetailsPanel_Load);
            this.uiCaseDetailsPanel.ResumeLayout(false);
            this.uiCaseDetailsPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel uiCaseDetailsPanel;
        //private System.Windows.Controls.TextBox hostedComponent1;
        //private System.Windows.Controls.TextBox hostedComponent2;
        private System.Windows.Controls.TextBox hostedComponent3;
        private System.Windows.Controls.TextBox hostedComponent1;
        private System.Windows.Forms.Button uiNextButton;
        private System.Windows.Forms.Button uiBackButton;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox uiHashFunctionComboBox;
        private SpellBox uiNotesTextBox;
        private System.Windows.Forms.Button uiBrowsButton;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox uiCasePathTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox uiEvidenceReferenceTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox uiCaseReferenceTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox uiOperationTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox uiAgencyTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox uiOfficerTextBox;
        private System.Windows.Controls.TextBox hostedComponent2;
        private System.Windows.Forms.Label uiHashHelpLabel;
        private System.Windows.Controls.TextBox hostedComponent4;
        private System.Windows.Controls.TextBox hostedComponent5;
        private System.Windows.Controls.TextBox hostedComponent6;
        private System.Windows.Controls.TextBox hostedComponent7;
        private System.Windows.Controls.TextBox hostedComponent8;
    }
}