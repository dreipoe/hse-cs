using System;
using System.Windows.Forms;

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
            string sLabName = labName.Text;

            switch (sLabName) {
                case "8":
                    Lab8 lab8 = new Lab8();
                    lab8.Show();
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
