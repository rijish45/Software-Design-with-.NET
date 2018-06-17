namespace Lab6
{
    partial class Settings
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
            this.PColor = new System.Windows.Forms.ListBox();
            this.FColor = new System.Windows.Forms.ListBox();
            this.WPMeasure = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.FillBox = new System.Windows.Forms.CheckBox();
            this.OutlineBox = new System.Windows.Forms.CheckBox();
            this.OkayButton = new System.Windows.Forms.Button();
            this.ButtonCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PColor
            // 
            this.PColor.FormattingEnabled = true;
            this.PColor.Items.AddRange(new object[] {
            "Black",
            "Red",
            "Blue",
            "Green"});
            this.PColor.Location = new System.Drawing.Point(34, 67);
            this.PColor.Margin = new System.Windows.Forms.Padding(2);
            this.PColor.Name = "PColor";
            this.PColor.Size = new System.Drawing.Size(63, 69);
            this.PColor.TabIndex = 0;
            // 
            // FColor
            // 
            this.FColor.FormattingEnabled = true;
            this.FColor.Items.AddRange(new object[] {
            "White",
            "Black",
            "Red",
            "Blue",
            "Green"});
            this.FColor.Location = new System.Drawing.Point(140, 67);
            this.FColor.Margin = new System.Windows.Forms.Padding(2);
            this.FColor.Name = "FColor";
            this.FColor.Size = new System.Drawing.Size(63, 69);
            this.FColor.TabIndex = 1;
            // 
            // WPMeasure
            // 
            this.WPMeasure.FormattingEnabled = true;
            this.WPMeasure.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.WPMeasure.Location = new System.Drawing.Point(251, 67);
            this.WPMeasure.Margin = new System.Windows.Forms.Padding(2);
            this.WPMeasure.Name = "WPMeasure";
            this.WPMeasure.Size = new System.Drawing.Size(120, 134);
            this.WPMeasure.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 37);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Pen Color";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(138, 37);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Fill Color";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(249, 37);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Pen Width";
            // 
            // FillBox
            // 
            this.FillBox.AutoSize = true;
            this.FillBox.Location = new System.Drawing.Point(89, 183);
            this.FillBox.Margin = new System.Windows.Forms.Padding(2);
            this.FillBox.Name = "FillBox";
            this.FillBox.Size = new System.Drawing.Size(38, 17);
            this.FillBox.TabIndex = 6;
            this.FillBox.Text = "Fill";
            this.FillBox.UseVisualStyleBackColor = true;
            // 
            // OutlineBox
            // 
            this.OutlineBox.AutoSize = true;
            this.OutlineBox.Location = new System.Drawing.Point(89, 213);
            this.OutlineBox.Margin = new System.Windows.Forms.Padding(2);
            this.OutlineBox.Name = "OutlineBox";
            this.OutlineBox.Size = new System.Drawing.Size(59, 17);
            this.OutlineBox.TabIndex = 7;
            this.OutlineBox.Text = "Outline";
            this.OutlineBox.UseVisualStyleBackColor = true;
            // 
            // OkayButton
            // 
            this.OkayButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.OkayButton.Location = new System.Drawing.Point(217, 228);
            this.OkayButton.Margin = new System.Windows.Forms.Padding(2);
            this.OkayButton.Name = "OkayButton";
            this.OkayButton.Size = new System.Drawing.Size(73, 23);
            this.OkayButton.TabIndex = 8;
            this.OkayButton.Text = "OK";
            this.OkayButton.UseVisualStyleBackColor = true;
            this.OkayButton.Click += new System.EventHandler(this.OkayButton_Click1);
            // 
            // ButtonCancel
            // 
            this.ButtonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ButtonCancel.Location = new System.Drawing.Point(310, 228);
            this.ButtonCancel.Margin = new System.Windows.Forms.Padding(2);
            this.ButtonCancel.Name = "ButtonCancel";
            this.ButtonCancel.Size = new System.Drawing.Size(73, 23);
            this.ButtonCancel.TabIndex = 9;
            this.ButtonCancel.Text = "Cancel";
            this.ButtonCancel.UseVisualStyleBackColor = true;
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 282);
            this.Controls.Add(this.ButtonCancel);
            this.Controls.Add(this.OkayButton);
            this.Controls.Add(this.OutlineBox);
            this.Controls.Add(this.FillBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.WPMeasure);
            this.Controls.Add(this.FColor);
            this.Controls.Add(this.PColor);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Settings";
            this.Text = "Settings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox PColor;
        private System.Windows.Forms.ListBox FColor;
        private System.Windows.Forms.ListBox WPMeasure;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox FillBox;
        private System.Windows.Forms.CheckBox OutlineBox;
        private System.Windows.Forms.Button OkayButton;
        private System.Windows.Forms.Button ButtonCancel;
    }
}