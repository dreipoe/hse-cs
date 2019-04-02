namespace LabLauncher.Brainfck
{
    partial class Program
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeMe = new System.Windows.Forms.ToolStripMenuItem();
            this.runMe = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutThis = new System.Windows.Forms.ToolStripMenuItem();
            this.redactor = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.runMe,
            this.справкаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(314, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.closeMe});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(57, 24);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // closeMe
            // 
            this.closeMe.Name = "closeMe";
            this.closeMe.Size = new System.Drawing.Size(181, 26);
            this.closeMe.Text = "Выход";
            this.closeMe.Click += new System.EventHandler(this.closeMe_Click);
            // 
            // runMe
            // 
            this.runMe.Name = "runMe";
            this.runMe.Size = new System.Drawing.Size(67, 24);
            this.runMe.Text = "Запуск";
            this.runMe.Click += new System.EventHandler(this.runMe_Click);
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutThis});
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(79, 24);
            this.справкаToolStripMenuItem.Text = "Справка";
            // 
            // aboutThis
            // 
            this.aboutThis.Name = "aboutThis";
            this.aboutThis.Size = new System.Drawing.Size(181, 26);
            this.aboutThis.Text = "О программе";
            this.aboutThis.Click += new System.EventHandler(this.aboutThis_Click);
            // 
            // redactor
            // 
            this.redactor.BackColor = System.Drawing.Color.Black;
            this.redactor.ForeColor = System.Drawing.Color.LawnGreen;
            this.redactor.Location = new System.Drawing.Point(0, 30);
            this.redactor.Multiline = true;
            this.redactor.Name = "redactor";
            this.redactor.Size = new System.Drawing.Size(314, 219);
            this.redactor.TabIndex = 1;
            // 
            // Program
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 253);
            this.Controls.Add(this.redactor);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(332, 300);
            this.MinimumSize = new System.Drawing.Size(332, 300);
            this.Name = "Program";
            this.Text = "Brainf_ck";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeMe;
        private System.Windows.Forms.ToolStripMenuItem runMe;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutThis;
        private System.Windows.Forms.TextBox redactor;
    }
}