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
            this.txtUserDirectory = new System.Windows.Forms.TextBox();
            this.txtDestinationDirectory = new System.Windows.Forms.TextBox();
            this.lblUserDirectory = new System.Windows.Forms.Label();
            this.lblDestinationDirectory = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCopyFile
            // 
            this.btnCopyFile.Location = new System.Drawing.Point(83, 175);
            this.btnCopyFile.Name = "btnCopyFile";
            this.btnCopyFile.Size = new System.Drawing.Size(132, 46);
            this.btnCopyFile.TabIndex = 0;
            this.btnCopyFile.Text = "Copy File";
            this.btnCopyFile.UseVisualStyleBackColor = true;
            this.btnCopyFile.Click += new System.EventHandler(this.btnCopyFile_Click);
            // 
            // txtUserDirectory
            // 
            this.txtUserDirectory.Location = new System.Drawing.Point(12, 32);
            this.txtUserDirectory.Name = "txtUserDirectory";
            this.txtUserDirectory.Size = new System.Drawing.Size(627, 27);
            this.txtUserDirectory.TabIndex = 1;
            // 
            // txtDestinationDirectory
            // 
            this.txtDestinationDirectory.Location = new System.Drawing.Point(12, 109);
            this.txtDestinationDirectory.Name = "txtDestinationDirectory";
            this.txtDestinationDirectory.Size = new System.Drawing.Size(627, 27);
            this.txtDestinationDirectory.TabIndex = 2;
            // 
            // lblUserDirectory
            // 
            this.lblUserDirectory.AutoSize = true;
            this.lblUserDirectory.Location = new System.Drawing.Point(12, 9);
            this.lblUserDirectory.Name = "lblUserDirectory";
            this.lblUserDirectory.Size = new System.Drawing.Size(115, 20);
            this.lblUserDirectory.TabIndex = 3;
            this.lblUserDirectory.Text = "Directory of File";
            // 
            // lblDestinationDirectory
            // 
            this.lblDestinationDirectory.AutoSize = true;
            this.lblDestinationDirectory.Location = new System.Drawing.Point(12, 86);
            this.lblDestinationDirectory.Name = "lblDestinationDirectory";
            this.lblDestinationDirectory.Size = new System.Drawing.Size(232, 20);
            this.lblDestinationDirectory.TabIndex = 4;
            this.lblDestinationDirectory.Text = "Destination Directory to Send File";
            // 
            // FrmFileCopier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 266);
            this.Controls.Add(this.lblDestinationDirectory);
            this.Controls.Add(this.lblUserDirectory);
            this.Controls.Add(this.txtDestinationDirectory);
            this.Controls.Add(this.txtUserDirectory);
            this.Controls.Add(this.btnCopyFile);
            this.Name = "FrmFileCopier";
            this.Text = "File Copier";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnCopyFile;
        private TextBox txtUserDirectory;
        private TextBox txtDestinationDirectory;
        private Label lblUserDirectory;
        private Label lblDestinationDirectory;
    }
}