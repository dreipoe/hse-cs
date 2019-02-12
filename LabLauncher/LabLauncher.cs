using System;
using System.Windows.Forms;

using Test = LabLauncher.TestDir.Test;
using Lab9 = LabLauncher.Lab9Dir.Lab9;
using Lab10 = LabLauncher.Lab10Dir.Lab10;

namespace LabLauncher
{
    public partial class LabLauncher : Form
    {
        public LabLauncher()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (lab9Radio.Checked)
                new Lab9().Show();
            else if (lab10Radio.Checked)
                new Lab10().Show();
            else if (sandboxRadio.Checked)
                new Test().Show();
            else return;
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
