namespace LabLauncher
{
    partial class Lab8
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createFile = new System.Windows.Forms.ToolStripMenuItem();
            this.openFile = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.Close = new System.Windows.Forms.ToolStripMenuItem();
            this.recordGrid = new System.Windows.Forms.DataGridView();
            this.Month = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Profit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.доходыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.самыйПрибыльныйГодToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.самыйДлинныйПериодСНизкимиДоходамиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.recordGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.доходыToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(334, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createFile,
            this.openFile,
            this.toolStripMenuItem1,
            this.Close});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // createFile
            // 
            this.createFile.Name = "createFile";
            this.createFile.Size = new System.Drawing.Size(121, 22);
            this.createFile.Text = "Создать";
            this.createFile.Click += new System.EventHandler(this.createFile_Click);
            // 
            // openFile
            // 
            this.openFile.Name = "openFile";
            this.openFile.Size = new System.Drawing.Size(121, 22);
            this.openFile.Text = "Открыть";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(118, 6);
            // 
            // Close
            // 
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(121, 22);
            this.Close.Text = "Выход";
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // recordGrid
            // 
            this.recordGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.recordGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Month,
            this.Profit});
            this.recordGrid.Location = new System.Drawing.Point(12, 27);
            this.recordGrid.Name = "recordGrid";
            this.recordGrid.RowHeadersWidth = 24;
            this.recordGrid.Size = new System.Drawing.Size(310, 46);
            this.recordGrid.TabIndex = 1;
            // 
            // Month
            // 
            this.Month.HeaderText = "Месяц";
            this.Month.Name = "Month";
            this.Month.ReadOnly = true;
            this.Month.Width = 140;
            // 
            // Profit
            // 
            this.Profit.HeaderText = "Доход";
            this.Profit.Name = "Profit";
            this.Profit.ReadOnly = true;
            this.Profit.Width = 140;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(139, 79);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // доходыToolStripMenuItem
            // 
            this.доходыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.самыйПрибыльныйГодToolStripMenuItem,
            this.самыйДлинныйПериодСНизкимиДоходамиToolStripMenuItem});
            this.доходыToolStripMenuItem.Name = "доходыToolStripMenuItem";
            this.доходыToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.доходыToolStripMenuItem.Text = "Доходы";
            // 
            // самыйПрибыльныйГодToolStripMenuItem
            // 
            this.самыйПрибыльныйГодToolStripMenuItem.Name = "самыйПрибыльныйГодToolStripMenuItem";
            this.самыйПрибыльныйГодToolStripMenuItem.Size = new System.Drawing.Size(325, 22);
            this.самыйПрибыльныйГодToolStripMenuItem.Text = "Самый прибыльный год";
            // 
            // самыйДлинныйПериодСНизкимиДоходамиToolStripMenuItem
            // 
            this.самыйДлинныйПериодСНизкимиДоходамиToolStripMenuItem.Name = "самыйДлинныйПериодСНизкимиДоходамиToolStripMenuItem";
            this.самыйДлинныйПериодСНизкимиДоходамиToolStripMenuItem.Size = new System.Drawing.Size(325, 22);
            this.самыйДлинныйПериодСНизкимиДоходамиToolStripMenuItem.Text = "Самый длинный период с низкими доходами";
            // 
            // Lab8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 311);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.recordGrid);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Lab8";
            this.Text = "Fenix";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.recordGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createFile;
        private System.Windows.Forms.ToolStripMenuItem openFile;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem Close;
        private System.Windows.Forms.DataGridView recordGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Month;
        private System.Windows.Forms.DataGridViewTextBoxColumn Profit;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStripMenuItem доходыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem самыйПрибыльныйГодToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem самыйДлинныйПериодСНизкимиДоходамиToolStripMenuItem;
    }
}