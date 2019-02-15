namespace LabLauncher.Lab10Dir
{
    partial class Case2
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
            this.personList = new System.Windows.Forms.ListBox();
            this.sortMe = new System.Windows.Forms.Button();
            this.cloneMe = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.searchMe = new System.Windows.Forms.TextBox();
            this.search = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Люди:";
            // 
            // personList
            // 
            this.personList.FormattingEnabled = true;
            this.personList.Location = new System.Drawing.Point(9, 24);
            this.personList.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.personList.Name = "personList";
            this.personList.Size = new System.Drawing.Size(192, 173);
            this.personList.TabIndex = 1;
            // 
            // sortMe
            // 
            this.sortMe.Location = new System.Drawing.Point(205, 24);
            this.sortMe.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.sortMe.Name = "sortMe";
            this.sortMe.Size = new System.Drawing.Size(148, 24);
            this.sortMe.TabIndex = 2;
            this.sortMe.Text = "Сортировать по алфавиту";
            this.sortMe.UseVisualStyleBackColor = true;
            this.sortMe.Click += new System.EventHandler(this.sortMe_Click);
            // 
            // cloneMe
            // 
            this.cloneMe.Location = new System.Drawing.Point(205, 53);
            this.cloneMe.Name = "cloneMe";
            this.cloneMe.Size = new System.Drawing.Size(148, 23);
            this.cloneMe.TabIndex = 3;
            this.cloneMe.Text = "Клонировать выделенное";
            this.cloneMe.UseVisualStyleBackColor = true;
            this.cloneMe.Click += new System.EventHandler(this.cloneMe_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.search);
            this.groupBox1.Controls.Add(this.searchMe);
            this.groupBox1.Location = new System.Drawing.Point(206, 82);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(145, 115);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Поиск совпадений:";
            // 
            // searchMe
            // 
            this.searchMe.Location = new System.Drawing.Point(6, 19);
            this.searchMe.Name = "searchMe";
            this.searchMe.Size = new System.Drawing.Size(133, 20);
            this.searchMe.TabIndex = 0;
            // 
            // search
            // 
            this.search.Location = new System.Drawing.Point(6, 45);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(133, 23);
            this.search.TabIndex = 1;
            this.search.Text = "Найти и выделить";
            this.search.UseVisualStyleBackColor = true;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // Case2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 212);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cloneMe);
            this.Controls.Add(this.sortMe);
            this.Controls.Add(this.personList);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximumSize = new System.Drawing.Size(379, 251);
            this.MinimumSize = new System.Drawing.Size(379, 251);
            this.Name = "Case2";
            this.Text = "Интерфейсы";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox personList;
        private System.Windows.Forms.Button sortMe;
        private System.Windows.Forms.Button cloneMe;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.TextBox searchMe;
    }
}