using System;
using System.Windows.Forms;

namespace LabLauncher.Lab10Dir
{
    public partial class Lab10 : Form
    {
        public Lab10()
        {
            InitializeComponent();
        }

        private void closeMe_Click(object sender, EventArgs e) { Close(); }

        private void Go_Click(object sender, EventArgs e)
        {
            if (task1Radio.Checked)
                new Task1().Show();
            else if (task2Radio.Checked)
                return;
            else
                return;
        }
    }
}
