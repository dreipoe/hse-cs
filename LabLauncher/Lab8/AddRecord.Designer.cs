namespace LabLauncher
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
            this.yearField = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.profitField = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.unitField = new System.Windows.Forms.TextBox();
            this.monthField = new System.Windows.Forms.ComboBox();
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
            // yearField
            // 
            this.yearField.Location = new System.Drawing.Point(46, 29);
            this.yearField.Name = "yearField";
            this.yearField.Size = new System.Drawing.Size(206, 20);
            this.yearField.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Прибыль (€):";
            // 
            // profitField
            // 
            this.profitField.Location = new System.Drawing.Point(89, 74);
            this.profitField.Name = "profitField";
            this.profitField.Size = new System.Drawing.Size(163, 20);
            this.profitField.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(61, 100);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 24);
            this.button1.TabIndex = 6;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Accept);
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Location = new System.Drawing.Point(142, 100);
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
            this.monthField.Size = new System.Drawing.Size(193, 21);
            this.monthField.TabIndex = 10;
            // 
            // AddRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(264, 136);
            this.Controls.Add(this.monthField);
            this.Controls.Add(this.unitField);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.profitField);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.yearField);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddRecord";
            this.Text = "Добавить запись";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox yearField;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox profitField;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox unitField;
        private System.Windows.Forms.ComboBox monthField;
    }
}