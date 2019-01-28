using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LabLauncher.TestDir
{
    public partial class Add : Form
    {
        public Add()
        {
            InitializeComponent();
        }

        private void Ok_Click(object sender, EventArgs e)
        {
            byte age;
            if (byte.TryParse(ageField.Text, out age))
            {

            }
            else
            {
                MessageBox.Show(
                    "Введите корректное значение возраста",
                    "Test",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Stop
                );
                ageField.Text = string.Empty;
            }
        }
    }
}
