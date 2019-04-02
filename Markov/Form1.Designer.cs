namespace Markov
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.wordField = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.run = new System.Windows.Forms.Button();
            this.rulesField = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Слово:";
            // 
            // wordField
            // 
            this.wordField.Location = new System.Drawing.Point(61, 12);
            this.wordField.Name = "wordField";
            this.wordField.Size = new System.Drawing.Size(271, 20);
            this.wordField.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(131, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Список правил";
            // 
            // run
            // 
            this.run.Location = new System.Drawing.Point(134, 285);
            this.run.Name = "run";
            this.run.Size = new System.Drawing.Size(75, 24);
            this.run.TabIndex = 3;
            this.run.Text = "Запустить";
            this.run.UseVisualStyleBackColor = true;
            this.run.Click += new System.EventHandler(this.run_Click);
            // 
            // rulesField
            // 
            this.rulesField.Location = new System.Drawing.Point(12, 67);
            this.rulesField.Multiline = true;
            this.rulesField.Name = "rulesField";
            this.rulesField.Size = new System.Drawing.Size(320, 212);
            this.rulesField.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 321);
            this.Controls.Add(this.rulesField);
            this.Controls.Add(this.run);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.wordField);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Markov";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox wordField;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button run;
        private System.Windows.Forms.TextBox rulesField;
    }
}

