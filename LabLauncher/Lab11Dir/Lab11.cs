using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabLauncher.Lab11Dir
{
    public partial class Lab11 : Form
    {
        public Lab11()
        {
            InitializeComponent();
        }

        private void Go_Click(object sender, EventArgs e)
        {
            switch ((int)numberField.Value)
            {
                case 1:
                    break;
                case 2:
                case 3:
                    break;
                default:
                    MessageBox.Show(
                        "Нет такого задания",
                        "Лаб. работа №11",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                    break;
            }
        }
    }
}
