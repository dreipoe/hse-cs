namespace LabLauncher.Lab8Dir
{
    partial class MostProfitForm
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
            this.CloseMe = new System.Windows.Forms.Button();
            this.mostProfitList = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // CloseMe
            // 
            this.CloseMe.Location = new System.Drawing.Point(118, 246);
            this.CloseMe.Name = "CloseMe";
            this.CloseMe.Size = new System.Drawing.Size(75, 23);
            this.CloseMe.TabIndex = 0;
            this.CloseMe.Text = "ОК";
            this.CloseMe.UseVisualStyleBackColor = true;
            this.CloseMe.Click += new System.EventHandler(this.CloseMe_Click);
            // 
            // mostProfitList
            // 
            this.mostProfitList.FormattingEnabled = true;
            this.mostProfitList.Location = new System.Drawing.Point(12, 12);
            this.mostProfitList.Name = "mostProfitList";
            this.mostProfitList.Size = new System.Drawing.Size(280, 225);
            this.mostProfitList.TabIndex = 1;
            // 
            // MostProfitForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 281);
            this.Controls.Add(this.mostProfitList);
            this.Controls.Add(this.CloseMe);
            this.MaximumSize = new System.Drawing.Size(320, 320);
            this.MinimumSize = new System.Drawing.Size(320, 320);
            this.Name = "MostProfitForm";
            this.Text = "Самые прибыльные годы";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CloseMe;
        private System.Windows.Forms.ListBox mostProfitList;
    }
}