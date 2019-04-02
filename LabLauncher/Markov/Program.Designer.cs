namespace LabLauncher.Markoff
{
    partial class Program
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
            this.deskString = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.runButton = new System.Windows.Forms.Button();
            this.rulesTable = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.delRule = new System.Windows.Forms.Button();
            this.addRule = new System.Windows.Forms.Button();
            this.Left = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Right = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.rulesTable)).BeginInit();
            this.SuspendLayout();
            // 
            // deskString
            // 
            this.deskString.Location = new System.Drawing.Point(64, 15);
            this.deskString.Name = "deskString";
            this.deskString.Size = new System.Drawing.Size(238, 20);
            this.deskString.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Строка:";
            // 
            // runButton
            // 
            this.runButton.Location = new System.Drawing.Point(308, 12);
            this.runButton.Name = "runButton";
            this.runButton.Size = new System.Drawing.Size(24, 24);
            this.runButton.TabIndex = 5;
            this.runButton.Text = "►";
            this.runButton.UseVisualStyleBackColor = true;
            this.runButton.Click += new System.EventHandler(this.run_Click);
            // 
            // rulesTable
            // 
            this.rulesTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.rulesTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Left,
            this.Right});
            this.rulesTable.Location = new System.Drawing.Point(15, 54);
            this.rulesTable.Name = "rulesTable";
            this.rulesTable.Size = new System.Drawing.Size(287, 150);
            this.rulesTable.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(122, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Правила замены:";
            // 
            // delRule
            // 
            this.delRule.Location = new System.Drawing.Point(308, 84);
            this.delRule.Name = "delRule";
            this.delRule.Size = new System.Drawing.Size(24, 24);
            this.delRule.TabIndex = 9;
            this.delRule.Text = "-";
            this.delRule.UseVisualStyleBackColor = true;
            this.delRule.Click += new System.EventHandler(this.delRule_Click);
            // 
            // addRule
            // 
            this.addRule.Location = new System.Drawing.Point(308, 54);
            this.addRule.Name = "addRule";
            this.addRule.Size = new System.Drawing.Size(24, 24);
            this.addRule.TabIndex = 10;
            this.addRule.Text = "+";
            this.addRule.UseVisualStyleBackColor = true;
            this.addRule.Click += new System.EventHandler(this.addRule_Click);
            // 
            // Left
            // 
            this.Left.HeaderText = "Образец";
            this.Left.Name = "Left";
            this.Left.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Left.Width = 120;
            // 
            // Right
            // 
            this.Right.HeaderText = "Замена";
            this.Right.Name = "Right";
            this.Right.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Right.Width = 120;
            // 
            // Program
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 211);
            this.Controls.Add(this.addRule);
            this.Controls.Add(this.delRule);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rulesTable);
            this.Controls.Add(this.runButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.deskString);
            this.MaximumSize = new System.Drawing.Size(360, 250);
            this.MinimumSize = new System.Drawing.Size(360, 250);
            this.Name = "Program";
            this.Text = "Markov";
            ((System.ComponentModel.ISupportInitialize)(this.rulesTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox deskString;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button runButton;
        private System.Windows.Forms.DataGridView rulesTable;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button delRule;
        private System.Windows.Forms.Button addRule;
        private System.Windows.Forms.DataGridViewTextBoxColumn Left;
        private System.Windows.Forms.DataGridViewTextBoxColumn Right;
    }
}

