using System;
using System.Drawing;
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

        private void bUploadFile_Paint(object sender, PaintEventArgs e)
        {
            // 3D button style
            ControlPaint.DrawBorder(e.Graphics, bUploadFile.ClientRectangle, SystemColors.ControlLightLight, 5, ButtonBorderStyle.Outset,
            SystemColors.ControlLightLight, 5, ButtonBorderStyle.Outset,
            SystemColors.ControlLightLight, 5, ButtonBorderStyle.Outset,
            SystemColors.ControlLightLight, 5, ButtonBorderStyle.Outset);
        }
    }
}
