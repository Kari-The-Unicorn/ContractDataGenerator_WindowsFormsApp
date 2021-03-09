
namespace ContractDataGenerator_WindowsFormsApp
{
    partial class Form1
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.lUploadFileInfo = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.bUploadFile = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lUploadFileInfo);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.bUploadFile);
            this.panel1.Location = new System.Drawing.Point(12, 47);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 288);
            this.panel1.TabIndex = 0;
            // 
            // lUploadFileInfo
            // 
            this.lUploadFileInfo.AutoSize = true;
            this.lUploadFileInfo.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.lUploadFileInfo.Location = new System.Drawing.Point(28, 16);
            this.lUploadFileInfo.Name = "lUploadFileInfo";
            this.lUploadFileInfo.Size = new System.Drawing.Size(182, 25);
            this.lUploadFileInfo.TabIndex = 2;
            this.lUploadFileInfo.Text = "Wybierz plik .doc";
            this.lUploadFileInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // button2
            // 
            this.button2.Enabled = false;
            this.button2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.button2.Location = new System.Drawing.Point(23, 189);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(297, 38);
            this.button2.TabIndex = 1;
            this.button2.Text = "Pobierz plik z danymi";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // bUploadFile
            // 
            this.bUploadFile.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.bUploadFile.Location = new System.Drawing.Point(23, 60);
            this.bUploadFile.Name = "bUploadFile";
            this.bUploadFile.Size = new System.Drawing.Size(297, 38);
            this.bUploadFile.TabIndex = 0;
            this.bUploadFile.Text = "Wgraj plik (plik doc)";
            this.bUploadFile.UseVisualStyleBackColor = true;
            this.bUploadFile.Click += new System.EventHandler(this.bUploadFile_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button bUploadFile;
        private System.Windows.Forms.Label lUploadFileInfo;
    }
}

