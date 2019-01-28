namespace LabLauncher.Test
{
    partial class Test
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
            this.dbBox = new System.Windows.Forms.ListBox();
            this.add = new System.Windows.Forms.Button();
            this.edit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dbBox
            // 
            this.dbBox.FormattingEnabled = true;
            this.dbBox.Location = new System.Drawing.Point(12, 18);
            this.dbBox.Name = "dbBox";
            this.dbBox.Size = new System.Drawing.Size(320, 251);
            this.dbBox.TabIndex = 0;
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(139, 285);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(24, 24);
            this.add.TabIndex = 1;
            this.add.Text = "+";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // edit
            // 
            this.edit.Location = new System.Drawing.Point(169, 285);
            this.edit.Name = "edit";
            this.edit.Size = new System.Drawing.Size(24, 24);
            this.edit.TabIndex = 2;
            this.edit.Text = "E";
            this.edit.UseMnemonic = false;
            this.edit.UseVisualStyleBackColor = true;
            // 
            // Test
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 321);
            this.Controls.Add(this.edit);
            this.Controls.Add(this.add);
            this.Controls.Add(this.dbBox);
            this.Name = "Test";
            this.Text = "Test";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox dbBox;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button edit;
    }
}