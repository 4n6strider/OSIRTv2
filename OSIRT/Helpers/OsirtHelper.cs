﻿using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows;
using System.Windows.Media.Imaging;

namespace OSIRT.Helpers
{
    public class OsirtHelper
    {

        //http://stackoverflow.com/questions/12899876/checking-strings-for-a-strong-enough-password
        public enum PasswordScore
        {
            Blank = 0,
            VeryWeak = 1,
            Weak = 2,
            Medium = 3,
            Strong = 4,
            VeryStrong = 5
        }

      
        public static PasswordScore CheckStrength(string password)
        {
            int score = 0;

            if (password.Length < 1)
                return PasswordScore.Blank;
            if (password.Length < 4)
                return PasswordScore.VeryWeak;

            if (password.Length >= 8)
                score++;
            if (password.Length >= 12)
                score++;
            if (Regex.Match(password, @"\d+", RegexOptions.ECMAScript).Success)
                score++;
            if (Regex.Match(password, @"[a-z]", RegexOptions.ECMAScript).Success &&
                Regex.Match(password, @"[A-Z]", RegexOptions.ECMAScript).Success)
                score++;
            if (Regex.Match(password, @".[!,@,#,$,%,^,&,*,?,_,~,-,£,(,)]", RegexOptions.ECMAScript).Success)
                score++;

            return (PasswordScore)score;
        }
        




        //http://stackoverflow.com/questions/281640/how-do-i-get-a-human-readable-file-size-in-bytes-abbreviation-using-net
        public static string GetHumanReadableFileSize(string fileName)
        {
            if (fileName == null)
                throw new ArgumentException("File name must not be null");

            string[] sizes = { "B", "KB", "MB", "GB" };
            double len = new FileInfo(fileName).Length;
            int order = 0;
            while (len >= 1024 && order + 1 < sizes.Length)
            {
                order++;
                len = len / 1024;
            }

            return $"{len:0.##} {sizes[order]}"; ;
        }


        /// <summary>
        /// Returns the assoicated Enum from a String.
        /// </summary>
        /// <typeparam name="T">The Enum type to parse to</typeparam>
        /// <param name="value">The string you want to parse to EnumT</param>
        /// <returns>An Enum of type T</returns>
        public static T ParseEnum<T>(string value)
        {
            return (T)Enum.Parse(typeof(T), value, true);
        }


        public static Bitmap GetBitmap(BitmapSource source)
        {
            Bitmap bmp = new Bitmap(source.PixelWidth, source.PixelHeight, PixelFormat.Format32bppPArgb);
            BitmapData data = bmp.LockBits(new Rectangle(System.Drawing.Point.Empty, bmp.Size), ImageLockMode.WriteOnly, PixelFormat.Format32bppPArgb);
            source.CopyPixels(Int32Rect.Empty, data.Scan0, data.Height * data.Stride, data.Stride);
            bmp.UnlockBits(data);
            return bmp;
        }

        /// <summary>
        /// Obtains a file's hash using the specified hash
        /// </summary>
        /// <param name="path">The location of the file required to be hashed</param>
        /// <param name="hashWanted">The hash alogorithm required</param>
        /// <returns>Hash of the file</returns>
        public static string GetFileHash(string path, string hashWanted)
        {
            HashService hashService = HashServiceFactory.Create(hashWanted);
            string hash;
            using (FileStream fileStream = File.OpenRead(path))
            {
                hash = hashService.ToHex(hashService.ComputeHash(fileStream));
            }
            return hash;
        }

        /// <summary>
        /// Obtains a file's hash using the saved hash setting
        /// </summary>
        /// <param name="path">The location of the file required to be hashed</param>
        /// <returns>Hash of the file</returns>
        public static string GetFileHash(string path)
        {
            return GetFileHash(path, UserSettings.Load().Hash);
        }


        public static bool IsValidFilename(string fileName)
        {


            //< > : " / \ | ? *
            return !string.IsNullOrWhiteSpace(fileName) && fileName.IndexOfAny(Path.GetInvalidFileNameChars()) == -1;
        }

        public static FileStream WaitForFile(string fullPath)
        {
            for (int numTries = 0; numTries < 10; numTries++)
            {
                try
                {
                    FileStream fs = new FileStream(fullPath, FileMode.Open, FileAccess.ReadWrite, FileShare.None);

                    fs.ReadByte();
                    fs.Seek(0, SeekOrigin.Begin);

                    return fs;
                }
                catch (IOException)
                {
                    Thread.Sleep(50);
                }
            }

            return null;
        }

    }
}
