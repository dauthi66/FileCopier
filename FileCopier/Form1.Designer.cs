namespace FileCopier
{
    partial class FrmFileCopier
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCopyFile = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCopyFile
            // 
            this.btnCopyFile.Location = new System.Drawing.Point(135, 209);
            this.btnCopyFile.Name = "btnCopyFile";
            this.btnCopyFile.Size = new System.Drawing.Size(132, 46);
            this.btnCopyFile.TabIndex = 0;
            this.btnCopyFile.Text = "Copy File";
            this.btnCopyFile.UseVisualStyleBackColor = true;
            this.btnCopyFile.Click += new System.EventHandler(this.btnCopyFile_Click);
            // 
            // FrmFileCopier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 372);
            this.Controls.Add(this.btnCopyFile);
            this.Name = "FrmFileCopier";
            this.Text = "File Copier";
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnCopyFile;
    }
}