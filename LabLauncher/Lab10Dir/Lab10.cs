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

        private void close_Click(object sender, EventArgs e) { Close();}

        private void go_Click(object sender, EventArgs e)
        {
            if (hierarchy.Checked)
                new Case1().Show();
            else if (interfaces.Checked)
                new Case2().Show();
            else return;
        }
    }
}
