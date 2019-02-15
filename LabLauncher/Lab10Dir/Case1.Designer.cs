namespace LabLauncher.Lab10Dir
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
            this.closeMe = new System.Windows.Forms.Button();
            this.virtualFlag = new System.Windows.Forms.CheckBox();
            this.more = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.runButton = new System.Windows.Forms.Button();
            this.Field = new System.Windows.Forms.TextBox();
            this.workerFrom = new System.Windows.Forms.RadioButton();
            this.empAs = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.years = new System.Windows.Forms.NumericUpDown();
            this.expNoLessThan = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.years)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Люди:";
            // 
            // personList
            // 
            this.personList.FormattingEnabled = true;
            this.personList.ItemHeight = 16;
            this.personList.Location = new System.Drawing.Point(15, 29);
            this.personList.Name = "personList";
            this.personList.Size = new System.Drawing.Size(255, 180);
            this.personList.TabIndex = 1;
            // 
            // closeMe
            // 
            this.closeMe.Location = new System.Drawing.Point(382, 29);
            this.closeMe.Name = "closeMe";
            this.closeMe.Size = new System.Drawing.Size(100, 30);
            this.closeMe.TabIndex = 15;
            this.closeMe.Text = "Закрыть";
            this.closeMe.UseVisualStyleBackColor = true;
            this.closeMe.Click += new System.EventHandler(this.closeMe_Click);
            // 
            // virtualFlag
            // 
            this.virtualFlag.AutoSize = true;
            this.virtualFlag.Location = new System.Drawing.Point(488, 35);
            this.virtualFlag.Name = "virtualFlag";
            this.virtualFlag.Size = new System.Drawing.Size(109, 21);
            this.virtualFlag.TabIndex = 17;
            this.virtualFlag.Text = "Virtual Mode";
            this.virtualFlag.UseVisualStyleBackColor = true;
            // 
            // more
            // 
            this.more.Location = new System.Drawing.Point(276, 29);
            this.more.Name = "more";
            this.more.Size = new System.Drawing.Size(100, 30);
            this.more.TabIndex = 18;
            this.more.Text = "Подробнее";
            this.more.UseVisualStyleBackColor = true;
            this.more.Click += new System.EventHandler(this.more_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.runButton);
            this.groupBox1.Controls.Add(this.Field);
            this.groupBox1.Controls.Add(this.workerFrom);
            this.groupBox1.Controls.Add(this.empAs);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.years);
            this.groupBox1.Controls.Add(this.expNoLessThan);
            this.groupBox1.Location = new System.Drawing.Point(276, 65);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(334, 144);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Получить имена:";
            // 
            // runButton
            // 
            this.runButton.Location = new System.Drawing.Point(246, 98);
            this.runButton.Name = "runButton";
            this.runButton.Size = new System.Drawing.Size(75, 30);
            this.runButton.TabIndex = 6;
            this.runButton.Text = "Вперёд";
            this.runButton.UseVisualStyleBackColor = true;
            this.runButton.Click += new System.EventHandler(this.runButton_Click);
            // 
            // Field
            // 
            this.Field.Location = new System.Drawing.Point(6, 102);
            this.Field.Name = "Field";
            this.Field.Size = new System.Drawing.Size(234, 22);
            this.Field.TabIndex = 5;
            // 
            // workerFrom
            // 
            this.workerFrom.AutoSize = true;
            this.workerFrom.Location = new System.Drawing.Point(6, 75);
            this.workerFrom.Name = "workerFrom";
            this.workerFrom.Size = new System.Drawing.Size(215, 21);
            this.workerFrom.TabIndex = 4;
            this.workerFrom.TabStop = true;
            this.workerFrom.Text = "Рабочих из указанного цеха";
            this.workerFrom.UseVisualStyleBackColor = true;
            // 
            // empAs
            // 
            this.empAs.AutoSize = true;
            this.empAs.Location = new System.Drawing.Point(6, 48);
            this.empAs.Name = "empAs";
            this.empAs.Size = new System.Drawing.Size(264, 21);
            this.empAs.TabIndex = 3;
            this.empAs.TabStop = true;
            this.empAs.Text = "Служащих с указанной профессией";
            this.empAs.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(291, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "лет";
            // 
            // years
            // 
            this.years.Location = new System.Drawing.Point(243, 21);
            this.years.Name = "years";
            this.years.Size = new System.Drawing.Size(42, 22);
            this.years.TabIndex = 1;
            // 
            // expNoLessThan
            // 
            this.expNoLessThan.AutoSize = true;
            this.expNoLessThan.Location = new System.Drawing.Point(6, 21);
            this.expNoLessThan.Name = "expNoLessThan";
            this.expNoLessThan.Size = new System.Drawing.Size(231, 21);
            this.expNoLessThan.TabIndex = 0;
            this.expNoLessThan.TabStop = true;
            this.expNoLessThan.Text = "Служащих со стажем не менее";
            this.expNoLessThan.UseVisualStyleBackColor = true;
            // 
            // Case1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 223);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.more);
            this.Controls.Add(this.virtualFlag);
            this.Controls.Add(this.closeMe);
            this.Controls.Add(this.personList);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(640, 270);
            this.MinimumSize = new System.Drawing.Size(640, 270);
            this.Name = "Case1";
            this.Text = "Иерархия классов";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.years)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox personList;
        private System.Windows.Forms.Button closeMe;
        private System.Windows.Forms.CheckBox virtualFlag;
        private System.Windows.Forms.Button more;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button runButton;
        private System.Windows.Forms.TextBox Field;
        private System.Windows.Forms.RadioButton workerFrom;
        private System.Windows.Forms.RadioButton empAs;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown years;
        private System.Windows.Forms.RadioButton expNoLessThan;
    }
}