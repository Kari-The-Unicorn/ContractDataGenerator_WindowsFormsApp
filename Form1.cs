using System;
using System.IO;
using System.Windows.Forms;
using GemBox.Document;

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
            openFile.Filter = "DOCX|*.docx|DOC|*.doc";

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
                var document = DocumentModel.Load(safeFileName);
                string text = document.Content.ToString();
                var x = string.Empty;
                //DocumentModel document = new DocumentModel();
                //Section section = new Section(document);
                //document.Sections.Add(section);
                //Paragraph paragraph = new Paragraph(document);
                //section.Blocks.Add(paragraph);
                //Run run = new Run(document, "Hello World!");
                //paragraph.Inlines.Add(run);
                //document.Save("Hello World.docx");

                //using (WordDocument document = new WordDocument(fileName))
                //{
                //    //Gets the Word document text
                //    string text = document.GetText();
                //    //Display Word document's text content.
                //    Console.WriteLine(text);
                //    Console.ReadLine();
                //}
            }
        }
    }
}
