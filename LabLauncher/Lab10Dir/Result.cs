using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabLauncher.Lab10Dir
{
    public partial class Result : Form
    {
        public Result(string results)
        {
            InitializeComponent();
            resultList.Text = results;
        }

        private void back_Click(object sender, EventArgs e) { Close(); }
    }
}
