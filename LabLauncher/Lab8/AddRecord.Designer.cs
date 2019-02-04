namespace LabLauncher.Lab8Dir
{
    partial class AddRecord
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.add = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.unitField = new System.Windows.Forms.TextBox();
            this.monthField = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.addToBegin = new System.Windows.Forms.RadioButton();
            this.addToEnd = new System.Windows.Forms.RadioButton();
            this.yearField = new System.Windows.Forms.NumericUpDown();
            this.profitField = new System.Windows.Forms.NumericUpDown();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.posField = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.yearField)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.profitField)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.posField)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Месяц:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Год:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(108, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Прибыль (€):";
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(58, 145);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(75, 24);
            this.add.TabIndex = 6;
            this.add.Text = "Добавить";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.Accept);
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Location = new System.Drawing.Point(139, 145);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 24);
            this.button2.TabIndex = 7;
            this.button2.Text = "Отмена";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Подразделение:";
            // 
            // unitField
            // 
            this.unitField.Location = new System.Drawing.Point(105, 51);
            this.unitField.Name = "unitField";
            this.unitField.Size = new System.Drawing.Size(147, 20);
            this.unitField.TabIndex = 9;
            // 
            // monthField
            // 
            this.monthField.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.monthField.FormattingEnabled = true;
            this.monthField.Items.AddRange(new object[] {
            "Январь",
            "Февраль",
            "Март",
            "Апрель",
            "Май",
            "Июнь",
            "Июль",
            "Август",
            "Сентябрь",
            "Октябрь",
            "Ноябрь",
            "Декабрь"});
            this.monthField.Location = new System.Drawing.Point(58, 7);
            this.monthField.Name = "monthField";
            this.monthField.Size = new System.Drawing.Size(194, 21);
            this.monthField.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 91);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Добавление:";
            // 
            // addToBegin
            // 
            this.addToBegin.AutoSize = true;
            this.addToBegin.Location = new System.Drawing.Point(89, 77);
            this.addToBegin.Name = "addToBegin";
            this.addToBegin.Size = new System.Drawing.Size(69, 17);
            this.addToBegin.TabIndex = 12;
            this.addToBegin.Text = "в начало";
            this.addToBegin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.addToBegin.UseVisualStyleBackColor = true;
            // 
            // addToEnd
            // 
            this.addToEnd.AutoSize = true;
            this.addToEnd.Checked = true;
            this.addToEnd.Location = new System.Drawing.Point(89, 100);
            this.addToEnd.Name = "addToEnd";
            this.addToEnd.Size = new System.Drawing.Size(64, 17);
            this.addToEnd.TabIndex = 13;
            this.addToEnd.TabStop = true;
            this.addToEnd.Text = "в конец";
            this.addToEnd.UseVisualStyleBackColor = true;
            // 
            // yearField
            // 
            this.yearField.Location = new System.Drawing.Point(58, 30);
            this.yearField.Maximum = new decimal(new int[] {
            2100,
            0,
            0,
            0});
            this.yearField.Minimum = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            this.yearField.Name = "yearField";
            this.yearField.Size = new System.Drawing.Size(44, 20);
            this.yearField.TabIndex = 16;
            this.yearField.Value = new decimal(new int[] {
            2007,
            0,
            0,
            0});
            // 
            // profitField
            // 
            this.profitField.Location = new System.Drawing.Point(185, 30);
            this.profitField.Maximum = new decimal(new int[] {
            2000000000,
            0,
            0,
            0});
            this.profitField.Minimum = new decimal(new int[] {
            2000000000,
            0,
            0,
            -2147483648});
            this.profitField.Name = "profitField";
            this.profitField.Size = new System.Drawing.Size(67, 20);
            this.profitField.TabIndex = 17;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(89, 123);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(87, 17);
            this.radioButton1.TabIndex = 18;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "на позицию:";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // posField
            // 
            this.posField.Location = new System.Drawing.Point(182, 123);
            this.posField.Name = "posField";
            this.posField.Size = new System.Drawing.Size(32, 20);
            this.posField.TabIndex = 19;
            // 
            // AddRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(264, 181);
            this.Controls.Add(this.posField);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.profitField);
            this.Controls.Add(this.yearField);
            this.Controls.Add(this.addToEnd);
            this.Controls.Add(this.addToBegin);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.monthField);
            this.Controls.Add(this.unitField);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.add);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(280, 220);
            this.MinimumSize = new System.Drawing.Size(280, 220);
            this.Name = "AddRecord";
            this.Text = "Добавить запись";
            ((System.ComponentModel.ISupportInitialize)(this.yearField)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.profitField)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.posField)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox unitField;
        private System.Windows.Forms.ComboBox monthField;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton addToBegin;
        private System.Windows.Forms.RadioButton addToEnd;
        private System.Windows.Forms.NumericUpDown yearField;
        private System.Windows.Forms.NumericUpDown profitField;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.NumericUpDown posField;
    }
}