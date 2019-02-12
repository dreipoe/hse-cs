namespace LabLauncher.Lab9Dir
{
    partial class Task3Viewer
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
            this.accountsList = new System.Windows.Forms.ListBox();
            this.selectMin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Список элементов:";
            // 
            // accountsList
            // 
            this.accountsList.FormattingEnabled = true;
            this.accountsList.ItemHeight = 16;
            this.accountsList.Location = new System.Drawing.Point(12, 29);
            this.accountsList.Name = "accountsList";
            this.accountsList.Size = new System.Drawing.Size(258, 196);
            this.accountsList.TabIndex = 1;
            // 
            // selectMin
            // 
            this.selectMin.Location = new System.Drawing.Point(12, 231);
            this.selectMin.Name = "selectMin";
            this.selectMin.Size = new System.Drawing.Size(258, 24);
            this.selectMin.TabIndex = 2;
            this.selectMin.Text = "Выделить мин. элемент";
            this.selectMin.UseVisualStyleBackColor = true;
            this.selectMin.Click += new System.EventHandler(this.selectMin_Click);
            // 
            // Task3Viewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 265);
            this.Controls.Add(this.selectMin);
            this.Controls.Add(this.accountsList);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(300, 312);
            this.MinimumSize = new System.Drawing.Size(300, 312);
            this.Name = "Task3Viewer";
            this.Text = "Просмотр";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox accountsList;
        private System.Windows.Forms.Button selectMin;
    }
}