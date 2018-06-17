namespace Lab7
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.EncryptButton = new System.Windows.Forms.Button();
            this.DecryptErrorButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.FileBrowseTextBox = new System.Windows.Forms.TextBox();
            this.FolderButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.KeyTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // EncryptButton
            // 
            this.EncryptButton.Location = new System.Drawing.Point(26, 171);
            this.EncryptButton.Name = "EncryptButton";
            this.EncryptButton.Size = new System.Drawing.Size(75, 23);
            this.EncryptButton.TabIndex = 0;
            this.EncryptButton.Text = "Encrypt";
            this.EncryptButton.UseVisualStyleBackColor = true;
            this.EncryptButton.Click += new System.EventHandler(this.EncryptButton_Click);
            // 
            // DecryptErrorButton
            // 
            this.DecryptErrorButton.Location = new System.Drawing.Point(162, 171);
            this.DecryptErrorButton.Name = "DecryptErrorButton";
            this.DecryptErrorButton.Size = new System.Drawing.Size(75, 23);
            this.DecryptErrorButton.TabIndex = 1;
            this.DecryptErrorButton.Text = "Decrypt";
            this.DecryptErrorButton.UseVisualStyleBackColor = true;
            this.DecryptErrorButton.Click += new System.EventHandler(this.DecryptErrorButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "File Name:";
            // 
            // FileBrowseTextBox
            // 
            this.FileBrowseTextBox.Location = new System.Drawing.Point(26, 64);
            this.FileBrowseTextBox.Name = "FileBrowseTextBox";
            this.FileBrowseTextBox.Size = new System.Drawing.Size(244, 20);
            this.FileBrowseTextBox.TabIndex = 3;
            // 
            // FolderButton
            // 
            this.FolderButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("FolderButton.BackgroundImage")));
            this.FolderButton.Location = new System.Drawing.Point(286, 56);
            this.FolderButton.Name = "FolderButton";
            this.FolderButton.Size = new System.Drawing.Size(34, 34);
            this.FolderButton.TabIndex = 4;
            this.FolderButton.Text = " ";
            this.FolderButton.UseVisualStyleBackColor = true;
            this.FolderButton.Click += new System.EventHandler(this.FolderButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Key:";
            // 
            // KeyTextBox
            // 
            this.KeyTextBox.Location = new System.Drawing.Point(26, 124);
            this.KeyTextBox.Name = "KeyTextBox";
            this.KeyTextBox.Size = new System.Drawing.Size(110, 20);
            this.KeyTextBox.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(372, 220);
            this.Controls.Add(this.KeyTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.FolderButton);
            this.Controls.Add(this.FileBrowseTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DecryptErrorButton);
            this.Controls.Add(this.EncryptButton);
            this.Name = "Form1";
            this.Text = " File Encrypt/Decrypt by Rijish Ganguly";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button EncryptButton;
        private System.Windows.Forms.Button DecryptErrorButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox FileBrowseTextBox;
        private System.Windows.Forms.Button FolderButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox KeyTextBox;
    }
}

