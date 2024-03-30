using Ionic.Zip;
using Microsoft.WindowsAPICodePack.Dialogs;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace PasswardBreaker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            this.btn_SelectFile.Click += (s, e) =>
            {
                Decoding();
            };
        }
        private void Decoding()
        {
            //try
            //{
            CommonOpenFileDialog fileDialog = new CommonOpenFileDialog();

            if (fileDialog.ShowDialog() == CommonFileDialogResult.Ok)
            {
                this.txtBox_Path.Text = fileDialog.FileName;

                Decrypt(fileDialog.FileName);
            }
            //}
            //catch
            //{
            //    throw new System.Exception();
            //}
        }

        private void Decrypt(string zipFileName/*, string unZipFileName*/)
        {
            //string unZipFileName = "C:\\Users\\USER\\Downloads\\새 폴더\\";
            int[] numberList = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            var upperText = Enumerable.Range('A', 26).Select(x => ((char)x).ToString().ToUpper());
            var lowerText = Enumerable.Range('A', 26).Select(x => ((char)x).ToString().ToLower());
            var specialText = Enumerable.Range(33, 15).Select(x => ((char)x).ToString());

            //string fileName = zipFileName.Substring(0, zipFileName.LastIndexOf(".")).Split(new string[] { "\\", "" }, StringSplitOptions.None).Last();
            
            string unZipFileName = zipFileName.Substring(0, zipFileName.LastIndexOf("."));
            Random random = new Random();

            if (!Directory.Exists(unZipFileName))
            {
                Directory.CreateDirectory(unZipFileName);
            }
            int length = 4;

            double passwordCase = Math.Pow(numberList.Length, length) * Math.Pow(upperText.Count(), length) *
                                Math.Pow(lowerText.Count(), length) * Math.Pow(specialText.Count(), length);

            string combination = string.Empty;
            HashSet<string> duplicates = new HashSet<string>();
            //for (int i = 0; i < passwordCase; i++)
            int i = 0;
            while (i < passwordCase)
            {
                if (duplicates.Contains(combination))
                {
                    combination = string.Empty;
                    continue;
                }
                try
                {
                    if (!string.IsNullOrEmpty(combination))
                    {
                        using (ZipFile zip = ZipFile.Read(zipFileName))
                        {
                            zip.Password = combination;
                            duplicates.Add(combination);

                            foreach (var entry in zip)
                            {
                                entry.Extract(unZipFileName, ExtractExistingFileAction.OverwriteSilently);
                            }
                            MessageBox.Show("Complete");
                            break;
                        }

                    }


                    for (int j = 0; j < length; j++)
                    {
                        int listIndex = random.Next(0); // numberList, upperText, lowerText, specialText 중 하나의 리스트 선택

                        switch (listIndex)
                        {
                            case 0:
                                combination += numberList[random.Next(numberList.Length)];
                                break;
                            case 1:
                                combination += upperText.ElementAt(random.Next(upperText.Count()));
                                break;
                            case 2:
                                combination += lowerText.ElementAt(random.Next(lowerText.Count()));
                                break;
                            case 3:
                                combination += specialText.ElementAt(random.Next(specialText.Count()));
                                break;
                        }
                    }
                }
                catch { i++; }
            }
            //using (ZipFile zip = ZipFile.Read(zipFileName))
            //{
            //    zip.Password = "1234";

            //    foreach (var entry in zip)
            //    {
            //        entry.Extract(unZipFileName, ExtractExistingFileAction.OverwriteSilently);
            //    }
            //}   
        }
    }
}
