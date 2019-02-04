using System;
using System.Windows.Forms;

using Test = LabLauncher.TestDir.Test;
using Lab8 = LabLauncher.Lab8Dir.Lab8;
using Lab9 = LabLauncher.Lab9Dir.Lab9;

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
            string sLabName = labName.Text.ToLower();

            switch (sLabName) {
                case "test":
                    new Test().Show();
                    break;
                case "9":
                    new Lab9().Show();
                    break;
                default:
                    MessageBox.Show(
                        "К сожалению, этой лабораторной работы здесь нет.",
                        "LabLauncher",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );
                    break;
            }
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
