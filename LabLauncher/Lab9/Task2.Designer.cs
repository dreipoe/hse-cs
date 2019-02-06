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
            this.ConvertMe = new System.Windows.Forms.Button();
            this.createObject = new System.Windows.Forms.Button();
            this.add = new System.Windows.Forms.Button();
            this.subtract = new System.Windows.Forms.Button();
            this.equal = new System.Windows.Forms.Button();
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
            this.accountsList.Size = new System.Drawing.Size(160, 160);
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
            this.incCopeek.Click += new System.EventHandler(this.incOrDecCopeek_Click);
            // 
            // decCopeek
            // 
            this.decCopeek.Location = new System.Drawing.Point(239, 64);
            this.decCopeek.Name = "decCopeek";
            this.decCopeek.Size = new System.Drawing.Size(53, 24);
            this.decCopeek.TabIndex = 3;
            this.decCopeek.Text = "Dec";
            this.decCopeek.UseVisualStyleBackColor = true;
            this.decCopeek.Click += new System.EventHandler(this.incOrDecCopeek_Click);
            // 
            // ConvertMe
            // 
            this.ConvertMe.Location = new System.Drawing.Point(178, 161);
            this.ConvertMe.Name = "ConvertMe";
            this.ConvertMe.Size = new System.Drawing.Size(114, 24);
            this.ConvertMe.TabIndex = 4;
            this.ConvertMe.Text = "Приведение типов";
            this.ConvertMe.UseVisualStyleBackColor = true;
            this.ConvertMe.Click += new System.EventHandler(this.incOrDecCopeek_Click);
            // 
            // createObject
            // 
            this.createObject.Location = new System.Drawing.Point(178, 25);
            this.createObject.Name = "createObject";
            this.createObject.Size = new System.Drawing.Size(114, 23);
            this.createObject.TabIndex = 5;
            this.createObject.Text = "Создать объект";
            this.createObject.UseVisualStyleBackColor = true;
            this.createObject.Click += new System.EventHandler(this.createObject_Click);
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(178, 94);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(53, 24);
            this.add.TabIndex = 6;
            this.add.Text = "+";
            this.add.UseVisualStyleBackColor = true;
            // 
            // subtract
            // 
            this.subtract.Location = new System.Drawing.Point(239, 94);
            this.subtract.Name = "subtract";
            this.subtract.Size = new System.Drawing.Size(53, 24);
            this.subtract.TabIndex = 7;
            this.subtract.Text = "-";
            this.subtract.UseVisualStyleBackColor = true;
            // 
            // equal
            // 
            this.equal.Location = new System.Drawing.Point(178, 124);
            this.equal.Name = "equal";
            this.equal.Size = new System.Drawing.Size(114, 23);
            this.equal.TabIndex = 8;
            this.equal.Text = "=";
            this.equal.UseVisualStyleBackColor = true;
            // 
            // Task2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 201);
            this.Controls.Add(this.equal);
            this.Controls.Add(this.subtract);
            this.Controls.Add(this.add);
            this.Controls.Add(this.createObject);
            this.Controls.Add(this.ConvertMe);
            this.Controls.Add(this.decCopeek);
            this.Controls.Add(this.incCopeek);
            this.Controls.Add(this.accountsList);
            this.Controls.Add(this.Total);
            this.MaximumSize = new System.Drawing.Size(320, 240);
            this.MinimumSize = new System.Drawing.Size(320, 240);
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
        private System.Windows.Forms.Button ConvertMe;
        private System.Windows.Forms.Button createObject;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button subtract;
        private System.Windows.Forms.Button equal;
    }
}