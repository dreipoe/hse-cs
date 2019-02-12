namespace LabLauncher.TestDir
{
    partial class Test
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
            this.cmdLine = new System.Windows.Forms.TextBox();
            this.run = new System.Windows.Forms.Button();
            this.monitor = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cmdLine
            // 
            this.cmdLine.Location = new System.Drawing.Point(12, 279);
            this.cmdLine.Name = "cmdLine";
            this.cmdLine.Size = new System.Drawing.Size(383, 22);
            this.cmdLine.TabIndex = 1;
            // 
            // run
            // 
            this.run.Location = new System.Drawing.Point(401, 279);
            this.run.Name = "run";
            this.run.Size = new System.Drawing.Size(45, 24);
            this.run.TabIndex = 2;
            this.run.Text = "Go";
            this.run.UseVisualStyleBackColor = true;
            this.run.Click += new System.EventHandler(this.run_Click);
            // 
            // monitor
            // 
            this.monitor.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.monitor.Cursor = System.Windows.Forms.Cursors.Default;
            this.monitor.ForeColor = System.Drawing.Color.Lime;
            this.monitor.Location = new System.Drawing.Point(12, 12);
            this.monitor.Multiline = true;
            this.monitor.Name = "monitor";
            this.monitor.ReadOnly = true;
            this.monitor.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.monitor.Size = new System.Drawing.Size(434, 260);
            this.monitor.TabIndex = 3;
            this.monitor.Text = "N-Creative Shell\r\n© N-Creative, 2019. Public domain.\r\n>>> ";
            // 
            // Test
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 313);
            this.Controls.Add(this.monitor);
            this.Controls.Add(this.run);
            this.Controls.Add(this.cmdLine);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximumSize = new System.Drawing.Size(480, 360);
            this.MinimumSize = new System.Drawing.Size(480, 360);
            this.Name = "Test";
            this.Text = "N-Creative Shell";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox cmdLine;
        private System.Windows.Forms.Button run;
        private System.Windows.Forms.TextBox monitor;
    }
}