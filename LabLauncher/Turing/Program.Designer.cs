namespace LabLauncher.Turing
{
    partial class Program
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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeMe = new System.Windows.Forms.ToolStripMenuItem();
            this.runMe = new System.Windows.Forms.ToolStripMenuItem();
            this.tapeField = new System.Windows.Forms.TextBox();
            this.codeGrid = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.alphabetBox = new System.Windows.Forms.TextBox();
            this.moveLeft = new System.Windows.Forms.Button();
            this.moveRight = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.addState = new System.Windows.Forms.Button();
            this.decState = new System.Windows.Forms.Button();
            this.symbols = new System.Windows.Forms.ComboBox();
            this.setme = new System.Windows.Forms.Button();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.about = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.codeGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 178);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(304, 22);
            this.statusStrip1.TabIndex = 0;
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(97, 17);
            this.toolStripStatusLabel1.Text = "Текущий статус:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.runMe,
            this.справкаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(304, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.closeMe});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // closeMe
            // 
            this.closeMe.Name = "closeMe";
            this.closeMe.Size = new System.Drawing.Size(180, 22);
            this.closeMe.Text = "Выйти";
            this.closeMe.Click += new System.EventHandler(this.closeMe_Click);
            // 
            // runMe
            // 
            this.runMe.Name = "runMe";
            this.runMe.Size = new System.Drawing.Size(57, 20);
            this.runMe.Text = "Запуск";
            this.runMe.Click += new System.EventHandler(this.runMe_Click);
            // 
            // tapeField
            // 
            this.tapeField.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tapeField.Location = new System.Drawing.Point(24, 25);
            this.tapeField.MaxLength = 30000;
            this.tapeField.Name = "tapeField";
            this.tapeField.ReadOnly = true;
            this.tapeField.Size = new System.Drawing.Size(255, 23);
            this.tapeField.TabIndex = 2;
            this.tapeField.Text = "===========1101==========";
            // 
            // codeGrid
            // 
            this.codeGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.codeGrid.Location = new System.Drawing.Point(0, 82);
            this.codeGrid.Name = "codeGrid";
            this.codeGrid.Size = new System.Drawing.Size(279, 94);
            this.codeGrid.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 57);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Алфавит:";
            // 
            // alphabetBox
            // 
            this.alphabetBox.Location = new System.Drawing.Point(66, 55);
            this.alphabetBox.Margin = new System.Windows.Forms.Padding(2);
            this.alphabetBox.Name = "alphabetBox";
            this.alphabetBox.Size = new System.Drawing.Size(66, 20);
            this.alphabetBox.TabIndex = 7;
            this.alphabetBox.Text = "01";
            this.alphabetBox.TextChanged += new System.EventHandler(this.alphabetBox_TextChanged);
            this.alphabetBox.Leave += new System.EventHandler(this.alphabetBox_Leave);
            // 
            // moveLeft
            // 
            this.moveLeft.Location = new System.Drawing.Point(0, 24);
            this.moveLeft.Margin = new System.Windows.Forms.Padding(2);
            this.moveLeft.Name = "moveLeft";
            this.moveLeft.Size = new System.Drawing.Size(24, 26);
            this.moveLeft.TabIndex = 8;
            this.moveLeft.Text = "«";
            this.moveLeft.UseVisualStyleBackColor = true;
            this.moveLeft.Click += new System.EventHandler(this.moveLeft_Click);
            // 
            // moveRight
            // 
            this.moveRight.Location = new System.Drawing.Point(279, 24);
            this.moveRight.Margin = new System.Windows.Forms.Padding(2);
            this.moveRight.Name = "moveRight";
            this.moveRight.Size = new System.Drawing.Size(24, 26);
            this.moveRight.TabIndex = 9;
            this.moveRight.Text = "»";
            this.moveRight.UseVisualStyleBackColor = true;
            this.moveRight.Click += new System.EventHandler(this.moveRight_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(144, 51);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "▲";
            // 
            // addState
            // 
            this.addState.Location = new System.Drawing.Point(279, 82);
            this.addState.Name = "addState";
            this.addState.Size = new System.Drawing.Size(24, 24);
            this.addState.TabIndex = 11;
            this.addState.Text = "+";
            this.addState.UseVisualStyleBackColor = true;
            this.addState.Click += new System.EventHandler(this.addState_Click);
            // 
            // decState
            // 
            this.decState.Location = new System.Drawing.Point(279, 108);
            this.decState.Name = "decState";
            this.decState.Size = new System.Drawing.Size(24, 24);
            this.decState.TabIndex = 12;
            this.decState.Text = "-";
            this.decState.UseVisualStyleBackColor = true;
            this.decState.Click += new System.EventHandler(this.decState_Click);
            // 
            // symbols
            // 
            this.symbols.FormattingEnabled = true;
            this.symbols.Items.AddRange(new object[] {
            "0",
            "1",
            "="});
            this.symbols.Location = new System.Drawing.Point(169, 55);
            this.symbols.Name = "symbols";
            this.symbols.Size = new System.Drawing.Size(32, 21);
            this.symbols.TabIndex = 13;
            // 
            // setme
            // 
            this.setme.Location = new System.Drawing.Point(207, 55);
            this.setme.Name = "setme";
            this.setme.Size = new System.Drawing.Size(75, 24);
            this.setme.TabIndex = 14;
            this.setme.Text = "Вставить";
            this.setme.UseVisualStyleBackColor = true;
            this.setme.Click += new System.EventHandler(this.setme_Click);
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.about});
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.справкаToolStripMenuItem.Text = "Справка";
            // 
            // about
            // 
            this.about.Name = "about";
            this.about.Size = new System.Drawing.Size(180, 22);
            this.about.Text = "О программе";
            this.about.Click += new System.EventHandler(this.aboutMenuItem_Click);
            // 
            // Program
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 200);
            this.Controls.Add(this.setme);
            this.Controls.Add(this.symbols);
            this.Controls.Add(this.decState);
            this.Controls.Add(this.addState);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.moveRight);
            this.Controls.Add(this.moveLeft);
            this.Controls.Add(this.alphabetBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.codeGrid);
            this.Controls.Add(this.tapeField);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximumSize = new System.Drawing.Size(320, 239);
            this.MinimumSize = new System.Drawing.Size(320, 239);
            this.Name = "Program";
            this.Text = "Тьюринг";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.codeGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeMe;
        private System.Windows.Forms.ToolStripMenuItem runMe;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.TextBox tapeField;
        private System.Windows.Forms.DataGridView codeGrid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox alphabetBox;
        private System.Windows.Forms.Button moveLeft;
        private System.Windows.Forms.Button moveRight;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button addState;
        private System.Windows.Forms.Button decState;
        private System.Windows.Forms.ComboBox symbols;
        private System.Windows.Forms.Button setme;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem about;
    }
}