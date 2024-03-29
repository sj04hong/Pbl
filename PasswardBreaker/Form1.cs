using Ionic.Zip;
using Microsoft.WindowsAPICodePack.Dialogs;
using System.IO;
using System.IO.Compression;
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
                CommonOpenFileDialog fileDialog= new CommonOpenFileDialog();

                if(fileDialog.ShowDialog() == CommonFileDialogResult.Ok)
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
            string unZipFileName = "C:\\Users\\USER\\Downloads\\새 폴더\\";
            int[] numberList = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            var upperText = Enumerable.Range('A', 26).Select(x => ((char)x).ToString().ToUpper());
            var lowerText = Enumerable.Range('A', 26).Select(x => ((char)x).ToString().ToLower());
            var specialText = Enumerable.Range(33, 15).Select(x => ((char)x).ToString());

            using (ZipFile zip = new ZipFile(zipFileName))
            {
                if (!Directory.Exists(unZipFileName))
                {
                    zip.Password = "1234";
                    zip.ExtractAll(unZipFileName);  
                }
            }
        }
    }
}
