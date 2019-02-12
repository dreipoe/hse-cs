namespace LabLauncher.Lab9Dir
{
    partial class Task3ManualFill
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
            this.accountList = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.rouble = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.copeck = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.add = new System.Windows.Forms.Button();
            this.complete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.rouble)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.copeck)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // accountList
            // 
            this.accountList.FormattingEnabled = true;
            this.accountList.ItemHeight = 16;
            this.accountList.Location = new System.Drawing.Point(16, 31);
            this.accountList.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.accountList.Name = "accountList";
            this.accountList.Size = new System.Drawing.Size(212, 196);
            this.accountList.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(237, 31);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Добавить элемент:";
            // 
            // rouble
            // 
            this.rouble.Location = new System.Drawing.Point(241, 50);
            this.rouble.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rouble.Name = "rouble";
            this.rouble.Size = new System.Drawing.Size(53, 22);
            this.rouble.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(296, 53);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "руб.";
            // 
            // copeck
            // 
            this.copeck.Location = new System.Drawing.Point(340, 50);
            this.copeck.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.copeck.Name = "copeck";
            this.copeck.Size = new System.Drawing.Size(43, 22);
            this.copeck.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(391, 53);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "коп.";
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(283, 82);
            this.add.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(100, 28);
            this.add.TabIndex = 7;
            this.add.Text = "Вперёд";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // complete
            // 
            this.complete.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.complete.Enabled = false;
            this.complete.Location = new System.Drawing.Point(241, 199);
            this.complete.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.complete.Name = "complete";
            this.complete.Size = new System.Drawing.Size(175, 28);
            this.complete.TabIndex = 8;
            this.complete.Text = "Завершить работу";
            this.complete.UseVisualStyleBackColor = true;
            this.complete.Click += new System.EventHandler(this.complete_Click);
            // 
            // Task3ManualFill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 238);
            this.Controls.Add(this.complete);
            this.Controls.Add(this.add);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.copeck);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.rouble);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.accountList);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximumSize = new System.Drawing.Size(450, 285);
            this.MinimumSize = new System.Drawing.Size(450, 285);
            this.Name = "Task3ManualFill";
            this.Text = "Заполнить вручную";
            ((System.ComponentModel.ISupportInitialize)(this.rouble)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.copeck)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox accountList;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown rouble;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown copeck;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button complete;
    }
}