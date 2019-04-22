namespace LabLauncher.Lab11Dir
{
    partial class Lab11
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
            this.label1 = new System.Windows.Forms.Label();
            this.numberField = new System.Windows.Forms.NumericUpDown();
            this.Go = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numberField)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Выберите № задания:";
            // 
            // numberField
            // 
            this.numberField.Location = new System.Drawing.Point(137, 7);
            this.numberField.Maximum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numberField.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numberField.Name = "numberField";
            this.numberField.Size = new System.Drawing.Size(40, 20);
            this.numberField.TabIndex = 1;
            this.numberField.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Go
            // 
            this.Go.Location = new System.Drawing.Point(183, 4);
            this.Go.Name = "Go";
            this.Go.Size = new System.Drawing.Size(75, 23);
            this.Go.TabIndex = 2;
            this.Go.Text = "Вперёд";
            this.Go.UseVisualStyleBackColor = true;
            this.Go.Click += new System.EventHandler(this.Go_Click);
            // 
            // Lab11
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 41);
            this.Controls.Add(this.Go);
            this.Controls.Add(this.numberField);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(300, 80);
            this.MinimumSize = new System.Drawing.Size(300, 80);
            this.Name = "Lab11";
            this.Text = "Лаб. работа №11";
            ((System.ComponentModel.ISupportInitialize)(this.numberField)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numberField;
        private System.Windows.Forms.Button Go;
    }
}