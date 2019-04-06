namespace LabLauncher.Lab8Dir
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
            this.доходыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.самыйПрибыльныйГодToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.самыйДлинныйПериодСНизкимиДоходамиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.append = new System.Windows.Forms.Button();
            this.edit = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.recordList = new System.Windows.Forms.ListBox();
            this.menuStrip1.SuspendLayout();
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
            this.createFile.Size = new System.Drawing.Size(152, 22);
            this.createFile.Text = "Создать";
            this.createFile.Click += new System.EventHandler(this.CreateFile_Click);
            // 
            // openFile
            // 
            this.openFile.Name = "openFile";
            this.openFile.Size = new System.Drawing.Size(152, 22);
            this.openFile.Text = "Открыть";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(149, 6);
            // 
            // Close
            // 
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(152, 22);
            this.Close.Text = "Выход";
            this.Close.Click += new System.EventHandler(this.Close_Click);
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
            // append
            // 
            this.append.Location = new System.Drawing.Point(52, 275);
            this.append.Name = "append";
            this.append.Size = new System.Drawing.Size(75, 24);
            this.append.TabIndex = 2;
            this.append.Text = "Добавить";
            this.append.UseVisualStyleBackColor = true;
            this.append.Visible = false;
            this.append.Click += new System.EventHandler(this.Append_Click);
            // 
            // edit
            // 
            this.edit.Location = new System.Drawing.Point(133, 275);
            this.edit.Name = "edit";
            this.edit.Size = new System.Drawing.Size(75, 24);
            this.edit.TabIndex = 4;
            this.edit.Text = "Изменить";
            this.edit.UseVisualStyleBackColor = true;
            this.edit.Visible = false;
            this.edit.Click += new System.EventHandler(this.Edit_Click);
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(214, 275);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(75, 24);
            this.delete.TabIndex = 5;
            this.delete.Text = "Удалить";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Visible = false;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // recordList
            // 
            this.recordList.FormattingEnabled = true;
            this.recordList.Location = new System.Drawing.Point(12, 31);
            this.recordList.Name = "recordList";
            this.recordList.Size = new System.Drawing.Size(310, 238);
            this.recordList.TabIndex = 6;
            this.recordList.Visible = false;
            // 
            // Lab8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 311);
            this.Controls.Add(this.recordList);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.edit);
            this.Controls.Add(this.append);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(350, 350);
            this.MinimumSize = new System.Drawing.Size(350, 350);
            this.Name = "Lab8";
            this.Text = "Fenix";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Lab8_FormClosed);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
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
        private System.Windows.Forms.Button append;
        private System.Windows.Forms.ToolStripMenuItem доходыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem самыйПрибыльныйГодToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem самыйДлинныйПериодСНизкимиДоходамиToolStripMenuItem;
        private System.Windows.Forms.Button edit;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.ListBox recordList;
    }
}