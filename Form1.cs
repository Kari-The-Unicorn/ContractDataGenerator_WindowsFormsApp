using System;
using System.Globalization;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using GemBox.Pdf;
using GemBox.Pdf.Content;

namespace ContractDataGenerator_WindowsFormsApp
{
    public partial class Form1 : Form
    {
        private string fileName;

        private string safeFileName;

        public Form1()
        {
            InitializeComponent();
        }

        private void bUploadFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Title = "Wybierz plik";
            //openFile.Filter = "DOCX|*.docx|DOC|*.doc";
            openFile.Filter = "PDF|*.pdf";

            if (openFile.ShowDialog() == DialogResult.OK)
            {
                string errorMessage = string.Empty;
                MessageBox.Show("Kliknij OK żeby potwierdzić plik: " + openFile.SafeFileName + ".");
                if (openFile.FileName != null)
                {
                    //lUploadFileInfo.Text = "Wybrany plik: " + openFile.SafeFileName;
                    fileName = openFile.FileName;
                    safeFileName = openFile.SafeFileName;
                    //safeFileName = "Hello World.docx";
                }
                else
                {
                    errorMessage = "Proszę załączyć plik w formacie .DOCX lub .DOC.";
                    MessageBox.Show(errorMessage);
                }

                //Copy file to destination
                var destinationPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory) + @"UserFiles\" + safeFileName;
                if (File.Exists(destinationPath))
                {
                    string extens = string.Empty;
                    if (destinationPath.Contains("docx"))
                    {
                        extens = ".docx";
                    }
                    else
                    {
                        extens = ".doc";
                    }

                    destinationPath = destinationPath
                        .Replace(".docx", string.Empty)
                        .Replace(".doc", string.Empty) + "_" + DateTime.Now.ToString()
                        .Replace("/", string.Empty)
                        .Replace(":", string.Empty)
                        .Replace(" ", string.Empty)
                        + extens;
                }
                // Save copy to destinationPath
                File.Copy(fileName, destinationPath, false);
                ComponentInfo.SetLicense("FREE-LIMITED-KEY");
                //var document = DocumentModel.Load(safeFileName);
                //string text = document.Content.ToString();

                using (var document = PdfDocument.Load(safeFileName))
                {
                    foreach (var page in document.Pages)
                    {
                        var contractWhereInfo = string.Empty;
                        var contractInvestorInfo = string.Empty;
                        var contractContractorInfo = string.Empty;
                        var pageContent = page.Content.ToString();
                        var whereInfoMatch = Regex.Match(pageContent, 
                            $@"(?<=Zawarta.w)(.*)(?=pomiędzy)",
                            RegexOptions.IgnoreCase);
                        if (whereInfoMatch.Success)
                        {
                            contractWhereInfo = whereInfoMatch.Value.ToString()
                                .Replace("Warszawie", "Warszawa")
                                .Replace("roku", "r.")
                                .Trim();
                        }
                        var contractInvestorInfoMatch = Regex.Match(pageContent, 
                            $@"(?<=pomiędzy)(.*)(?=zwaną.+Inwestorem)",
                            RegexOptions.IgnoreCase);
                        if (contractInvestorInfoMatch.Success)
                        {
                            contractInvestorInfo = contractInvestorInfoMatch.Value.ToString()
                                .Replace(":", string.Empty)
                                .Replace("1.", string.Empty)
                                .Replace("Firmą", string.Empty)
                                .Replace("wpisaną", "wpisana")
                                .Replace("reprezentowaną", "reprezentowana")
                                .Trim();
                        }
                        var contractContractorInfoMatch = Regex.Match(pageContent,
                            $@"(?<=,.a.)(.*)(?=zwaną.+Wykonawcą)",
                            RegexOptions.IgnoreCase);
                        if (contractContractorInfoMatch.Success)
                        {
                            contractContractorInfo = contractContractorInfoMatch.Value.ToString()
                                .Replace(":", string.Empty)
                                .Replace("2.", string.Empty)
                                .Replace("Firmą", string.Empty)
                                .Replace("wpisaną", "wpisana")
                                .Replace("reprezentowaną", "reprezentowana")
                                .Trim();
                        }
                    }

                }
            }
        }
    }
}
