namespace LabLauncher
{
    partial class LabLauncher
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
            this.button1 = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.lab9Radio = new System.Windows.Forms.RadioButton();
            this.sandboxRadio = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Выберите лабораторную работу:";
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.Location = new System.Drawing.Point(15, 69);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(72, 24);
            this.button1.TabIndex = 2;
            this.button1.Text = "Запустить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(117, 69);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(75, 24);
            this.Exit.TabIndex = 3;
            this.Exit.Text = "Выход";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // lab9Radio
            // 
            this.lab9Radio.AutoSize = true;
            this.lab9Radio.Location = new System.Drawing.Point(15, 25);
            this.lab9Radio.Name = "lab9Radio";
            this.lab9Radio.Size = new System.Drawing.Size(145, 17);
            this.lab9Radio.TabIndex = 4;
            this.lab9Radio.Text = "Лабораторная работа 9";
            this.lab9Radio.UseVisualStyleBackColor = true;
            // 
            // sandboxRadio
            // 
            this.sandboxRadio.AutoSize = true;
            this.sandboxRadio.Checked = true;
            this.sandboxRadio.Location = new System.Drawing.Point(15, 46);
            this.sandboxRadio.Name = "sandboxRadio";
            this.sandboxRadio.Size = new System.Drawing.Size(90, 17);
            this.sandboxRadio.TabIndex = 5;
            this.sandboxRadio.TabStop = true;
            this.sandboxRadio.Text = "\"Песочница\"";
            this.sandboxRadio.UseVisualStyleBackColor = true;
            // 
            // LabLauncher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(204, 105);
            this.Controls.Add(this.sandboxRadio);
            this.Controls.Add(this.lab9Radio);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(220, 144);
            this.MinimumSize = new System.Drawing.Size(220, 144);
            this.Name = "LabLauncher";
            this.Text = "LabLauncher";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.RadioButton lab9Radio;
        private System.Windows.Forms.RadioButton sandboxRadio;
    }
}

