﻿namespace LabLauncher.Lab9Dir
{
    partial class Lab9
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
            this.radioTask1 = new System.Windows.Forms.RadioButton();
            this.radioTask3 = new System.Windows.Forms.RadioButton();
            this.Accept = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.radioTask2 = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Выберите задачу для запуска:";
            // 
            // radioTask1
            // 
            this.radioTask1.AutoSize = true;
            this.radioTask1.Checked = true;
            this.radioTask1.Location = new System.Drawing.Point(20, 31);
            this.radioTask1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioTask1.Name = "radioTask1";
            this.radioTask1.Size = new System.Drawing.Size(90, 21);
            this.radioTask1.TabIndex = 1;
            this.radioTask1.TabStop = true;
            this.radioTask1.Text = "Задача 1";
            this.radioTask1.UseVisualStyleBackColor = true;
            // 
            // radioTask3
            // 
            this.radioTask3.AutoSize = true;
            this.radioTask3.Location = new System.Drawing.Point(20, 87);
            this.radioTask3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioTask3.Name = "radioTask3";
            this.radioTask3.Size = new System.Drawing.Size(90, 21);
            this.radioTask3.TabIndex = 3;
            this.radioTask3.TabStop = true;
            this.radioTask3.Text = "Задача 3";
            this.radioTask3.UseVisualStyleBackColor = true;
            // 
            // Accept
            // 
            this.Accept.Location = new System.Drawing.Point(78, 116);
            this.Accept.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Accept.Name = "Accept";
            this.Accept.Size = new System.Drawing.Size(100, 28);
            this.Accept.TabIndex = 4;
            this.Accept.Text = "Вперёд";
            this.Accept.UseVisualStyleBackColor = true;
            this.Accept.Click += new System.EventHandler(this.Accept_Click);
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(186, 116);
            this.closeButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(100, 28);
            this.closeButton.TabIndex = 5;
            this.closeButton.Text = "Выйти";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // radioTask2
            // 
            this.radioTask2.AutoSize = true;
            this.radioTask2.Location = new System.Drawing.Point(20, 59);
            this.radioTask2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioTask2.Name = "radioTask2";
            this.radioTask2.Size = new System.Drawing.Size(90, 21);
            this.radioTask2.TabIndex = 2;
            this.radioTask2.Text = "Задача 2";
            this.radioTask2.UseVisualStyleBackColor = true;
            // 
            // Lab9
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 145);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.Accept);
            this.Controls.Add(this.radioTask3);
            this.Controls.Add(this.radioTask2);
            this.Controls.Add(this.radioTask1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximumSize = new System.Drawing.Size(380, 192);
            this.MinimumSize = new System.Drawing.Size(380, 192);
            this.Name = "Lab9";
            this.Text = "Лаб. работа №9";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioTask1;
        private System.Windows.Forms.RadioButton radioTask3;
        private System.Windows.Forms.Button Accept;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.RadioButton radioTask2;
    }
}