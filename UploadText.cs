using System;
using System.Windows.Forms;

namespace ContractDataGenerator_WindowsFormsApp
{
    public partial class UploadText : Form
    {
        public UploadText()
        {
            InitializeComponent();
        }

        private void bUploadFile_Click(object sender, EventArgs e)
        {
            try
            {
                string textToLoad = rtbUploadText.Text;
                if (!string.IsNullOrEmpty(textToLoad))
                {

                }
            }
            catch
            {
                MessageBox.Show("Coś poszło nie tak.");
            }

        }
    }
}
