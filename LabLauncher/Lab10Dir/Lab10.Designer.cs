namespace LabLauncher.Lab10Dir
{
    partial class Lab10
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
            this.hierarchy = new System.Windows.Forms.RadioButton();
            this.interfaces = new System.Windows.Forms.RadioButton();
            this.go = new System.Windows.Forms.Button();
            this.close = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Выберите реализацию:";
            // 
            // hierarchy
            // 
            this.hierarchy.AutoSize = true;
            this.hierarchy.Checked = true;
            this.hierarchy.Location = new System.Drawing.Point(9, 24);
            this.hierarchy.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.hierarchy.Name = "hierarchy";
            this.hierarchy.Size = new System.Drawing.Size(119, 17);
            this.hierarchy.TabIndex = 1;
            this.hierarchy.TabStop = true;
            this.hierarchy.Text = "Иерархия классов";
            this.hierarchy.UseVisualStyleBackColor = true;
            // 
            // interfaces
            // 
            this.interfaces.AutoSize = true;
            this.interfaces.Location = new System.Drawing.Point(9, 46);
            this.interfaces.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.interfaces.Name = "interfaces";
            this.interfaces.Size = new System.Drawing.Size(90, 17);
            this.interfaces.TabIndex = 2;
            this.interfaces.TabStop = true;
            this.interfaces.Text = "Интерфейсы";
            this.interfaces.UseVisualStyleBackColor = true;
            // 
            // go
            // 
            this.go.Location = new System.Drawing.Point(58, 74);
            this.go.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.go.Name = "go";
            this.go.Size = new System.Drawing.Size(56, 24);
            this.go.TabIndex = 3;
            this.go.Text = "Вперёд";
            this.go.UseVisualStyleBackColor = true;
            this.go.Click += new System.EventHandler(this.go_Click);
            // 
            // close
            // 
            this.close.Location = new System.Drawing.Point(119, 74);
            this.close.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(56, 24);
            this.close.TabIndex = 4;
            this.close.Text = "Назад";
            this.close.UseVisualStyleBackColor = true;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // Lab10
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(240, 115);
            this.Controls.Add(this.close);
            this.Controls.Add(this.go);
            this.Controls.Add(this.interfaces);
            this.Controls.Add(this.hierarchy);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximumSize = new System.Drawing.Size(256, 154);
            this.MinimumSize = new System.Drawing.Size(256, 154);
            this.Name = "Lab10";
            this.Text = "Лаб. работа №10";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton hierarchy;
        private System.Windows.Forms.RadioButton interfaces;
        private System.Windows.Forms.Button go;
        private System.Windows.Forms.Button close;
    }
}