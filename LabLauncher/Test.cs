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
    public partial class Test : Form
    {
        List<Person> db;

        public Test()
        {
            InitializeComponent();

            //фиксированный размер окна
            MaximumSize = new Size(Width, Height);
            MinimumSize = MaximumSize;
        }

        private void add_Click(object sender, EventArgs e)
        {

        }
    }
}
