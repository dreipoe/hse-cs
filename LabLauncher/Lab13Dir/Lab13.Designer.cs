namespace LabLauncher.Lab13Dir
{
    partial class Lab13
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
            this.peopleList = new System.Windows.Forms.ListBox();
            this.addButton = new System.Windows.Forms.Button();
            this.delButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.mode1 = new System.Windows.Forms.RadioButton();
            this.mode2 = new System.Windows.Forms.RadioButton();
            this.sortButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // peopleList
            // 
            this.peopleList.FormattingEnabled = true;
            this.peopleList.Location = new System.Drawing.Point(12, 12);
            this.peopleList.Name = "peopleList";
            this.peopleList.Size = new System.Drawing.Size(237, 134);
            this.peopleList.TabIndex = 0;
            this.peopleList.DoubleClick += new System.EventHandler(this.LearnMore);
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(12, 166);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 24);
            this.addButton.TabIndex = 1;
            this.addButton.Text = "Добавить";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // delButton
            // 
            this.delButton.Location = new System.Drawing.Point(93, 166);
            this.delButton.Name = "delButton";
            this.delButton.Size = new System.Drawing.Size(75, 24);
            this.delButton.TabIndex = 2;
            this.delButton.Text = "Удалить";
            this.delButton.UseVisualStyleBackColor = true;
            this.delButton.Click += new System.EventHandler(this.delButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(174, 166);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 24);
            this.clearButton.TabIndex = 3;
            this.clearButton.Text = "Очистить";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.sortButton);
            this.groupBox1.Controls.Add(this.mode2);
            this.groupBox1.Controls.Add(this.mode1);
            this.groupBox1.Location = new System.Drawing.Point(255, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(117, 147);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Сортировка";
            // 
            // mode1
            // 
            this.mode1.AutoSize = true;
            this.mode1.Location = new System.Drawing.Point(6, 19);
            this.mode1.Name = "mode1";
            this.mode1.Size = new System.Drawing.Size(67, 17);
            this.mode1.TabIndex = 0;
            this.mode1.TabStop = true;
            this.mode1.Text = "по ФИО";
            this.mode1.UseVisualStyleBackColor = true;
            // 
            // mode2
            // 
            this.mode2.AutoSize = true;
            this.mode2.Location = new System.Drawing.Point(6, 42);
            this.mode2.Name = "mode2";
            this.mode2.Size = new System.Drawing.Size(86, 17);
            this.mode2.TabIndex = 1;
            this.mode2.TabStop = true;
            this.mode2.Text = "по возрасту";
            this.mode2.UseVisualStyleBackColor = true;
            // 
            // sortButton
            // 
            this.sortButton.Location = new System.Drawing.Point(17, 65);
            this.sortButton.Name = "sortButton";
            this.sortButton.Size = new System.Drawing.Size(80, 24);
            this.sortButton.TabIndex = 2;
            this.sortButton.Text = "Сортировка";
            this.sortButton.UseVisualStyleBackColor = true;
            this.sortButton.Click += new System.EventHandler(this.sortButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 149);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Двойной щелчок по элементу - подробно";
            // 
            // Lab13
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 201);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.delButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.peopleList);
            this.MaximumSize = new System.Drawing.Size(400, 240);
            this.MinimumSize = new System.Drawing.Size(400, 240);
            this.Name = "Lab13";
            this.Text = "Лаб. работа №13";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox peopleList;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button delButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button sortButton;
        private System.Windows.Forms.RadioButton mode2;
        private System.Windows.Forms.RadioButton mode1;
        private System.Windows.Forms.Label label1;
    }
}