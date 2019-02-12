namespace LabLauncher.Lab9Dir
{
    partial class Task3
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
            this.bankList = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.manualEl = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.countEl = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.viewMe = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.countEl)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Всего объектов: 0";
            // 
            // bankList
            // 
            this.bankList.FormattingEnabled = true;
            this.bankList.ItemHeight = 16;
            this.bankList.Location = new System.Drawing.Point(16, 31);
            this.bankList.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bankList.Name = "bankList";
            this.bankList.Size = new System.Drawing.Size(212, 196);
            this.bankList.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.manualEl);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.countEl);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Location = new System.Drawing.Point(237, 31);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(185, 122);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Создать массив:";
            // 
            // manualEl
            // 
            this.manualEl.AutoSize = true;
            this.manualEl.Location = new System.Drawing.Point(12, 55);
            this.manualEl.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.manualEl.Name = "manualEl";
            this.manualEl.Size = new System.Drawing.Size(160, 21);
            this.manualEl.TabIndex = 9;
            this.manualEl.Text = "Заполнить вручную";
            this.manualEl.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(84, 26);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "злементами";
            // 
            // countEl
            // 
            this.countEl.Location = new System.Drawing.Point(33, 23);
            this.countEl.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.countEl.Name = "countEl";
            this.countEl.Size = new System.Drawing.Size(43, 22);
            this.countEl.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 26);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "с";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(46, 84);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 28);
            this.button1.TabIndex = 4;
            this.button1.Text = "Вперёд";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // viewMe
            // 
            this.viewMe.Location = new System.Drawing.Point(237, 160);
            this.viewMe.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.viewMe.Name = "viewMe";
            this.viewMe.Size = new System.Drawing.Size(185, 28);
            this.viewMe.TabIndex = 3;
            this.viewMe.Text = "Просмотр массива";
            this.viewMe.UseVisualStyleBackColor = true;
            this.viewMe.Click += new System.EventHandler(this.viewMe_Click);
            // 
            // Task3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 238);
            this.Controls.Add(this.viewMe);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.bankList);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximumSize = new System.Drawing.Size(450, 285);
            this.MinimumSize = new System.Drawing.Size(450, 285);
            this.Name = "Task3";
            this.Text = "Задача 3";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.countEl)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox bankList;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown countEl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button viewMe;
        private System.Windows.Forms.CheckBox manualEl;
    }
}