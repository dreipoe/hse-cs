namespace LabLauncher.Lab9Dir
{
    partial class Task2
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
            this.Total = new System.Windows.Forms.Label();
            this.accountsList = new System.Windows.Forms.ListBox();
            this.incCopeek = new System.Windows.Forms.Button();
            this.decCopeek = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.createObject = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Total
            // 
            this.Total.AutoSize = true;
            this.Total.Location = new System.Drawing.Point(12, 9);
            this.Total.Name = "Total";
            this.Total.Size = new System.Drawing.Size(100, 13);
            this.Total.TabIndex = 0;
            this.Total.Text = "Всего объектов: 0";
            // 
            // accountsList
            // 
            this.accountsList.FormattingEnabled = true;
            this.accountsList.Location = new System.Drawing.Point(12, 25);
            this.accountsList.Name = "accountsList";
            this.accountsList.Size = new System.Drawing.Size(160, 134);
            this.accountsList.TabIndex = 1;
            // 
            // incCopeek
            // 
            this.incCopeek.Location = new System.Drawing.Point(178, 64);
            this.incCopeek.Name = "incCopeek";
            this.incCopeek.Size = new System.Drawing.Size(53, 24);
            this.incCopeek.TabIndex = 2;
            this.incCopeek.Text = "Inc";
            this.incCopeek.UseVisualStyleBackColor = true;
            // 
            // decCopeek
            // 
            this.decCopeek.Location = new System.Drawing.Point(239, 64);
            this.decCopeek.Name = "decCopeek";
            this.decCopeek.Size = new System.Drawing.Size(53, 24);
            this.decCopeek.TabIndex = 3;
            this.decCopeek.Text = "Dec";
            this.decCopeek.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(178, 134);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 24);
            this.button1.TabIndex = 4;
            this.button1.Text = "Приведение типов";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // createObject
            // 
            this.createObject.Location = new System.Drawing.Point(178, 25);
            this.createObject.Name = "createObject";
            this.createObject.Size = new System.Drawing.Size(114, 23);
            this.createObject.TabIndex = 5;
            this.createObject.Text = "Создать объект";
            this.createObject.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(178, 94);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(53, 24);
            this.button2.TabIndex = 6;
            this.button2.Text = "+";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(239, 94);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(53, 24);
            this.button3.TabIndex = 7;
            this.button3.Text = "-";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // Task2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 171);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.createObject);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.decCopeek);
            this.Controls.Add(this.incCopeek);
            this.Controls.Add(this.accountsList);
            this.Controls.Add(this.Total);
            this.MaximumSize = new System.Drawing.Size(320, 210);
            this.MinimumSize = new System.Drawing.Size(320, 210);
            this.Name = "Task2";
            this.Text = "Задача 2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Total;
        private System.Windows.Forms.ListBox accountsList;
        private System.Windows.Forms.Button incCopeek;
        private System.Windows.Forms.Button decCopeek;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button createObject;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}