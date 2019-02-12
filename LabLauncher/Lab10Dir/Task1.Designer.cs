namespace LabLauncher.Lab10Dir
{
    partial class Task1
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
            this.label2 = new System.Windows.Forms.Label();
            this.workerList = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.employeeList = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.engineerList = new System.Windows.Forms.ListBox();
            this.closeMe = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
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
            this.personList.Size = new System.Drawing.Size(255, 84);
            this.personList.TabIndex = 1;
            this.personList.DoubleClick += new System.EventHandler(this.personList_DoubleClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(276, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Рабочие:";
            // 
            // workerList
            // 
            this.workerList.FormattingEnabled = true;
            this.workerList.ItemHeight = 16;
            this.workerList.Location = new System.Drawing.Point(279, 29);
            this.workerList.Name = "workerList";
            this.workerList.Size = new System.Drawing.Size(255, 84);
            this.workerList.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "Служащие:";
            // 
            // employeeList
            // 
            this.employeeList.FormattingEnabled = true;
            this.employeeList.ItemHeight = 16;
            this.employeeList.Location = new System.Drawing.Point(15, 136);
            this.employeeList.Name = "employeeList";
            this.employeeList.Size = new System.Drawing.Size(255, 84);
            this.employeeList.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(276, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 17);
            this.label4.TabIndex = 13;
            this.label4.Text = "Инженеры:";
            // 
            // engineerList
            // 
            this.engineerList.FormattingEnabled = true;
            this.engineerList.ItemHeight = 16;
            this.engineerList.Location = new System.Drawing.Point(279, 136);
            this.engineerList.Name = "engineerList";
            this.engineerList.Size = new System.Drawing.Size(255, 84);
            this.engineerList.TabIndex = 14;
            // 
            // closeMe
            // 
            this.closeMe.Location = new System.Drawing.Point(238, 243);
            this.closeMe.Name = "closeMe";
            this.closeMe.Size = new System.Drawing.Size(75, 24);
            this.closeMe.TabIndex = 15;
            this.closeMe.Text = "Закрыть";
            this.closeMe.UseVisualStyleBackColor = true;
            this.closeMe.Click += new System.EventHandler(this.closeMe_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 223);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(505, 17);
            this.label5.TabIndex = 16;
            this.label5.Text = "Двойной клик на выделенном объекте - просмотр подробной информации";
            // 
            // Task1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 273);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.closeMe);
            this.Controls.Add(this.engineerList);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.employeeList);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.workerList);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.personList);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(560, 320);
            this.MinimumSize = new System.Drawing.Size(560, 320);
            this.Name = "Task1";
            this.Text = "Задача 1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox personList;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox workerList;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox employeeList;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox engineerList;
        private System.Windows.Forms.Button closeMe;
        private System.Windows.Forms.Label label5;
    }
}