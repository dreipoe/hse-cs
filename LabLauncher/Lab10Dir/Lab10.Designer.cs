namespace LabLauncher.Lab10Dir
{
    partial class Lab10
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
            this.task1Radio = new System.Windows.Forms.RadioButton();
            this.task2Radio = new System.Windows.Forms.RadioButton();
            this.task3Radio = new System.Windows.Forms.RadioButton();
            this.Go = new System.Windows.Forms.Button();
            this.closeMe = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Выберите задачу для запуска";
            // 
            // task1Radio
            // 
            this.task1Radio.AutoSize = true;
            this.task1Radio.Location = new System.Drawing.Point(15, 29);
            this.task1Radio.Name = "task1Radio";
            this.task1Radio.Size = new System.Drawing.Size(90, 21);
            this.task1Radio.TabIndex = 1;
            this.task1Radio.TabStop = true;
            this.task1Radio.Text = "Задача 1";
            this.task1Radio.UseVisualStyleBackColor = true;
            // 
            // task2Radio
            // 
            this.task2Radio.AutoSize = true;
            this.task2Radio.Location = new System.Drawing.Point(15, 56);
            this.task2Radio.Name = "task2Radio";
            this.task2Radio.Size = new System.Drawing.Size(90, 21);
            this.task2Radio.TabIndex = 2;
            this.task2Radio.TabStop = true;
            this.task2Radio.Text = "Задача 2";
            this.task2Radio.UseVisualStyleBackColor = true;
            // 
            // task3Radio
            // 
            this.task3Radio.AutoSize = true;
            this.task3Radio.Location = new System.Drawing.Point(15, 83);
            this.task3Radio.Name = "task3Radio";
            this.task3Radio.Size = new System.Drawing.Size(90, 21);
            this.task3Radio.TabIndex = 3;
            this.task3Radio.TabStop = true;
            this.task3Radio.Text = "Задача 3";
            this.task3Radio.UseVisualStyleBackColor = true;
            // 
            // Go
            // 
            this.Go.Location = new System.Drawing.Point(108, 110);
            this.Go.Name = "Go";
            this.Go.Size = new System.Drawing.Size(75, 24);
            this.Go.TabIndex = 4;
            this.Go.Text = "Вперёд";
            this.Go.UseVisualStyleBackColor = true;
            this.Go.Click += new System.EventHandler(this.Go_Click);
            // 
            // closeMe
            // 
            this.closeMe.Location = new System.Drawing.Point(189, 110);
            this.closeMe.Name = "closeMe";
            this.closeMe.Size = new System.Drawing.Size(75, 24);
            this.closeMe.TabIndex = 5;
            this.closeMe.Text = "Выйти";
            this.closeMe.UseVisualStyleBackColor = true;
            this.closeMe.Click += new System.EventHandler(this.closeMe_Click);
            // 
            // Lab10
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 145);
            this.Controls.Add(this.closeMe);
            this.Controls.Add(this.Go);
            this.Controls.Add(this.task3Radio);
            this.Controls.Add(this.task2Radio);
            this.Controls.Add(this.task1Radio);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(380, 192);
            this.MinimumSize = new System.Drawing.Size(380, 192);
            this.Name = "Lab10";
            this.Text = "Лаб. работа №10";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton task1Radio;
        private System.Windows.Forms.RadioButton task2Radio;
        private System.Windows.Forms.RadioButton task3Radio;
        private System.Windows.Forms.Button Go;
        private System.Windows.Forms.Button closeMe;
    }
}