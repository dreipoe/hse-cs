﻿namespace LabLauncher.Lab11Dir
{
    partial class Case1
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
            this.addButton = new System.Windows.Forms.Button();
            this.delButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.queryButton = new System.Windows.Forms.Button();
            this.q3 = new System.Windows.Forms.RadioButton();
            this.q2 = new System.Windows.Forms.RadioButton();
            this.q1 = new System.Windows.Forms.RadioButton();
            this.cloneButton = new System.Windows.Forms.Button();
            this.sortButton = new System.Windows.Forms.Button();
            this.searchButton = new System.Windows.Forms.Button();
            this.searchField = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Люди:";
            // 
            // personList
            // 
            this.personList.FormattingEnabled = true;
            this.personList.Location = new System.Drawing.Point(12, 25);
            this.personList.Name = "personList";
            this.personList.Size = new System.Drawing.Size(156, 147);
            this.personList.TabIndex = 1;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(12, 177);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 2;
            this.addButton.Text = "Добавить";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // delButton
            // 
            this.delButton.Location = new System.Drawing.Point(93, 177);
            this.delButton.Name = "delButton";
            this.delButton.Size = new System.Drawing.Size(75, 23);
            this.delButton.TabIndex = 3;
            this.delButton.Text = "Удалить";
            this.delButton.UseVisualStyleBackColor = true;
            this.delButton.Click += new System.EventHandler(this.delButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.queryButton);
            this.groupBox1.Controls.Add(this.q3);
            this.groupBox1.Controls.Add(this.q2);
            this.groupBox1.Controls.Add(this.q1);
            this.groupBox1.Location = new System.Drawing.Point(174, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(177, 122);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Три запроса";
            // 
            // queryButton
            // 
            this.queryButton.Location = new System.Drawing.Point(6, 88);
            this.queryButton.Name = "queryButton";
            this.queryButton.Size = new System.Drawing.Size(75, 24);
            this.queryButton.TabIndex = 3;
            this.queryButton.Text = "Вперёд";
            this.queryButton.UseVisualStyleBackColor = true;
            this.queryButton.Click += new System.EventHandler(this.queryButton_Click);
            // 
            // q3
            // 
            this.q3.AutoSize = true;
            this.q3.Location = new System.Drawing.Point(6, 65);
            this.q3.Name = "q3";
            this.q3.Size = new System.Drawing.Size(85, 17);
            this.q3.TabIndex = 2;
            this.q3.TabStop = true;
            this.q3.Text = "radioButton3";
            this.q3.UseVisualStyleBackColor = true;
            // 
            // q2
            // 
            this.q2.AutoSize = true;
            this.q2.Location = new System.Drawing.Point(6, 42);
            this.q2.Name = "q2";
            this.q2.Size = new System.Drawing.Size(121, 17);
            this.q2.TabIndex = 1;
            this.q2.TabStop = true;
            this.q2.Text = "Список инженеров";
            this.q2.UseVisualStyleBackColor = true;
            // 
            // q1
            // 
            this.q1.AutoSize = true;
            this.q1.Location = new System.Drawing.Point(6, 19);
            this.q1.Name = "q1";
            this.q1.Size = new System.Drawing.Size(102, 17);
            this.q1.TabIndex = 0;
            this.q1.TabStop = true;
            this.q1.Text = "Кол-во рабочих";
            this.q1.UseVisualStyleBackColor = true;
            // 
            // cloneButton
            // 
            this.cloneButton.Location = new System.Drawing.Point(174, 140);
            this.cloneButton.Name = "cloneButton";
            this.cloneButton.Size = new System.Drawing.Size(80, 24);
            this.cloneButton.TabIndex = 5;
            this.cloneButton.Text = "Клонир.";
            this.cloneButton.UseVisualStyleBackColor = true;
            this.cloneButton.Click += new System.EventHandler(this.cloneButton_Click);
            // 
            // sortButton
            // 
            this.sortButton.Location = new System.Drawing.Point(271, 140);
            this.sortButton.Name = "sortButton";
            this.sortButton.Size = new System.Drawing.Size(80, 24);
            this.sortButton.TabIndex = 6;
            this.sortButton.Text = "Сортировка";
            this.sortButton.UseVisualStyleBackColor = true;
            this.sortButton.Click += new System.EventHandler(this.sortButton_Click);
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(311, 171);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(24, 24);
            this.searchButton.TabIndex = 7;
            this.searchButton.Text = "🔎";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // searchField
            // 
            this.searchField.Location = new System.Drawing.Point(174, 173);
            this.searchField.Name = "searchField";
            this.searchField.Size = new System.Drawing.Size(131, 20);
            this.searchField.TabIndex = 8;
            // 
            // Case1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 212);
            this.Controls.Add(this.searchField);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.sortButton);
            this.Controls.Add(this.cloneButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.delButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.personList);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(379, 251);
            this.MinimumSize = new System.Drawing.Size(379, 251);
            this.Name = "Case1";
            this.Text = "Задание 1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox personList;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button delButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button queryButton;
        private System.Windows.Forms.RadioButton q3;
        private System.Windows.Forms.RadioButton q2;
        private System.Windows.Forms.RadioButton q1;
        private System.Windows.Forms.Button cloneButton;
        private System.Windows.Forms.Button sortButton;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.TextBox searchField;
    }
}