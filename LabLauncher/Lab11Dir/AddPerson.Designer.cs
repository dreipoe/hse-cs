namespace LabLauncher.Lab11Dir
{
    partial class AddPerson
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ageField = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.nameField = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.categoryField = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.eduCombo = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.posField = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.shopField = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.expField = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.salaryField = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.engineerCheck = new System.Windows.Forms.RadioButton();
            this.empCheck = new System.Windows.Forms.RadioButton();
            this.workerCheck = new System.Windows.Forms.RadioButton();
            this.personCheck = new System.Windows.Forms.RadioButton();
            this.add = new System.Windows.Forms.Button();
            this.close = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ageField)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.categoryField)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.expField)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salaryField)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ageField);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.nameField);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 69);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(340, 47);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Личные данные:";
            // 
            // ageField
            // 
            this.ageField.Location = new System.Drawing.Point(293, 19);
            this.ageField.Minimum = new decimal(new int[] {
            14,
            0,
            0,
            0});
            this.ageField.Name = "ageField";
            this.ageField.Size = new System.Drawing.Size(40, 20);
            this.ageField.TabIndex = 3;
            this.ageField.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(235, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Возраст:";
            // 
            // nameField
            // 
            this.nameField.Location = new System.Drawing.Point(49, 19);
            this.nameField.Name = "nameField";
            this.nameField.Size = new System.Drawing.Size(180, 20);
            this.nameField.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "ФИО:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.categoryField);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.eduCombo);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.posField);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.shopField);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.expField);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.salaryField);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(12, 122);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(340, 103);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Данные о работе и квалификации";
            // 
            // categoryField
            // 
            this.categoryField.Location = new System.Drawing.Point(293, 72);
            this.categoryField.Maximum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.categoryField.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.categoryField.Name = "categoryField";
            this.categoryField.Size = new System.Drawing.Size(40, 20);
            this.categoryField.TabIndex = 11;
            this.categoryField.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(224, 75);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 13);
            this.label9.TabIndex = 10;
            this.label9.Text = "Категория:";
            // 
            // eduCombo
            // 
            this.eduCombo.FormattingEnabled = true;
            this.eduCombo.Items.AddRange(new object[] {
            "среднее общее",
            "среднее специальное",
            "неоконченное высшее",
            "высшее",
            "послевузовское"});
            this.eduCombo.Location = new System.Drawing.Point(88, 72);
            this.eduCombo.Name = "eduCombo";
            this.eduCombo.Size = new System.Drawing.Size(130, 21);
            this.eduCombo.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 75);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Образование:";
            // 
            // posField
            // 
            this.posField.Location = new System.Drawing.Point(218, 46);
            this.posField.Name = "posField";
            this.posField.Size = new System.Drawing.Size(100, 20);
            this.posField.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(144, 49);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Должность:";
            // 
            // shopField
            // 
            this.shopField.Location = new System.Drawing.Point(37, 46);
            this.shopField.Name = "shopField";
            this.shopField.Size = new System.Drawing.Size(100, 20);
            this.shopField.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 49);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Цех:";
            // 
            // expField
            // 
            this.expField.Location = new System.Drawing.Point(238, 20);
            this.expField.Name = "expField";
            this.expField.Size = new System.Drawing.Size(40, 20);
            this.expField.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(175, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Стаж (лет):";
            // 
            // salaryField
            // 
            this.salaryField.Location = new System.Drawing.Point(105, 20);
            this.salaryField.Maximum = new decimal(new int[] {
            200000,
            0,
            0,
            0});
            this.salaryField.Minimum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.salaryField.Name = "salaryField";
            this.salaryField.Size = new System.Drawing.Size(64, 20);
            this.salaryField.TabIndex = 1;
            this.salaryField.Value = new decimal(new int[] {
            25000,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Зар. плата (руб.):";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.engineerCheck);
            this.groupBox3.Controls.Add(this.empCheck);
            this.groupBox3.Controls.Add(this.workerCheck);
            this.groupBox3.Controls.Add(this.personCheck);
            this.groupBox3.Location = new System.Drawing.Point(12, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(340, 51);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Уровень";
            // 
            // engineerCheck
            // 
            this.engineerCheck.AutoSize = true;
            this.engineerCheck.Location = new System.Drawing.Point(237, 19);
            this.engineerCheck.Name = "engineerCheck";
            this.engineerCheck.Size = new System.Drawing.Size(69, 17);
            this.engineerCheck.TabIndex = 3;
            this.engineerCheck.Text = "инженер";
            this.engineerCheck.UseVisualStyleBackColor = true;
            // 
            // empCheck
            // 
            this.empCheck.AutoSize = true;
            this.empCheck.Location = new System.Drawing.Point(154, 19);
            this.empCheck.Name = "empCheck";
            this.empCheck.Size = new System.Drawing.Size(77, 17);
            this.empCheck.TabIndex = 2;
            this.empCheck.Text = "служащий";
            this.empCheck.UseVisualStyleBackColor = true;
            // 
            // workerCheck
            // 
            this.workerCheck.AutoSize = true;
            this.workerCheck.Location = new System.Drawing.Point(82, 19);
            this.workerCheck.Name = "workerCheck";
            this.workerCheck.Size = new System.Drawing.Size(66, 17);
            this.workerCheck.TabIndex = 1;
            this.workerCheck.Text = "рабочий";
            this.workerCheck.UseVisualStyleBackColor = true;
            // 
            // personCheck
            // 
            this.personCheck.AutoSize = true;
            this.personCheck.Checked = true;
            this.personCheck.Location = new System.Drawing.Point(9, 19);
            this.personCheck.Name = "personCheck";
            this.personCheck.Size = new System.Drawing.Size(67, 17);
            this.personCheck.TabIndex = 0;
            this.personCheck.TabStop = true;
            this.personCheck.Text = "персона";
            this.personCheck.UseVisualStyleBackColor = true;
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(106, 231);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(75, 24);
            this.add.TabIndex = 8;
            this.add.Text = "Добавить";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // close
            // 
            this.close.Location = new System.Drawing.Point(190, 231);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(75, 24);
            this.close.TabIndex = 9;
            this.close.Text = "Отмена";
            this.close.UseVisualStyleBackColor = true;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // AddPerson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 261);
            this.Controls.Add(this.close);
            this.Controls.Add(this.add);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximumSize = new System.Drawing.Size(380, 300);
            this.MinimumSize = new System.Drawing.Size(380, 300);
            this.Name = "AddPerson";
            this.Text = "Добавить человека";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ageField)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.categoryField)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.expField)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salaryField)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown ageField;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox nameField;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.NumericUpDown salaryField;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown expField;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox shopField;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox posField;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox eduCombo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown categoryField;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton engineerCheck;
        private System.Windows.Forms.RadioButton empCheck;
        private System.Windows.Forms.RadioButton workerCheck;
        private System.Windows.Forms.RadioButton personCheck;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button close;
    }
}