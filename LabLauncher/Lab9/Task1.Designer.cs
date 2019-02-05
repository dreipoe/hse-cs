namespace LabLauncher.Lab9Dir
{
    partial class Task1
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
            this.addObject = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.copecks = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.copecks)).BeginInit();
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
            // addObject
            // 
            this.addObject.Location = new System.Drawing.Point(178, 25);
            this.addObject.Name = "addObject";
            this.addObject.Size = new System.Drawing.Size(100, 24);
            this.addObject.TabIndex = 2;
            this.addObject.Text = "Создать объект";
            this.addObject.UseVisualStyleBackColor = true;
            this.addObject.Click += new System.EventHandler(this.addObject_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(178, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Добавить";
            // 
            // copecks
            // 
            this.copecks.Location = new System.Drawing.Point(181, 80);
            this.copecks.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.copecks.Name = "copecks";
            this.copecks.Size = new System.Drawing.Size(63, 20);
            this.copecks.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(250, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "коп.";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(178, 106);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Метод класса";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.addCopeek_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(178, 135);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(97, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Статически";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.addCopeek_Click);
            // 
            // Task1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 171);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.copecks);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.addObject);
            this.Controls.Add(this.accountsList);
            this.Controls.Add(this.Total);
            this.MaximumSize = new System.Drawing.Size(300, 210);
            this.MinimumSize = new System.Drawing.Size(300, 210);
            this.Name = "Task1";
            this.Text = "Задача 1";
            ((System.ComponentModel.ISupportInitialize)(this.copecks)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Total;
        private System.Windows.Forms.ListBox accountsList;
        private System.Windows.Forms.Button addObject;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown copecks;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}