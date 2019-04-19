namespace LabLauncher.Lab8Dir
{
    partial class EditRecord
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
            this.profitField = new System.Windows.Forms.NumericUpDown();
            this.yearField = new System.Windows.Forms.NumericUpDown();
            this.monthField = new System.Windows.Forms.ComboBox();
            this.unitField = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.add = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.profitField)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yearField)).BeginInit();
            this.SuspendLayout();
            // 
            // profitField
            // 
            this.profitField.Location = new System.Drawing.Point(187, 35);
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
            this.profitField.TabIndex = 32;
            // 
            // yearField
            // 
            this.yearField.Location = new System.Drawing.Point(60, 35);
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
            this.yearField.TabIndex = 31;
            this.yearField.Value = new decimal(new int[] {
            2007,
            0,
            0,
            0});
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
            this.monthField.Location = new System.Drawing.Point(60, 12);
            this.monthField.Name = "monthField";
            this.monthField.Size = new System.Drawing.Size(194, 21);
            this.monthField.TabIndex = 27;
            // 
            // unitField
            // 
            this.unitField.Location = new System.Drawing.Point(107, 56);
            this.unitField.Name = "unitField";
            this.unitField.Size = new System.Drawing.Size(147, 20);
            this.unitField.TabIndex = 26;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 13);
            this.label4.TabIndex = 25;
            this.label4.Text = "Подразделение:";
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Location = new System.Drawing.Point(141, 82);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 24);
            this.button2.TabIndex = 24;
            this.button2.Text = "Отмена";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(60, 82);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(75, 24);
            this.add.TabIndex = 23;
            this.add.Text = "Изменить";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.Accept);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(110, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Прибыль (€):";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Год:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Месяц:";
            // 
            // EditRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 121);
            this.Controls.Add(this.profitField);
            this.Controls.Add(this.yearField);
            this.Controls.Add(this.monthField);
            this.Controls.Add(this.unitField);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.add);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(300, 160);
            this.MinimumSize = new System.Drawing.Size(300, 160);
            this.Name = "EditRecord";
            this.Text = "Изменить запись";
            ((System.ComponentModel.ISupportInitialize)(this.profitField)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yearField)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.NumericUpDown profitField;
        private System.Windows.Forms.NumericUpDown yearField;
        private System.Windows.Forms.ComboBox monthField;
        private System.Windows.Forms.TextBox unitField;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}