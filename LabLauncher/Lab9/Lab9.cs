using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabLauncher.Lab9Dir
{
    public partial class Lab9 : Form
    {
        public Lab9()
        {
            InitializeComponent();
        }

        private void Accept_Click(object sender, EventArgs e)
        {
            if (radioTask1.Checked)
                new Task1().Show();
            else if (radioTask2.Checked)
                new Task2().Show();
            else
                new Task3().Show();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
