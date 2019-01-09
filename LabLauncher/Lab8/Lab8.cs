using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace LabLauncher
{
    public partial class Lab8 : Form
    {
        public string filename = "Notname";
        public Record[] db = null;
        public bool changed = false;

        public Lab8()
        {
            InitializeComponent();
            Text = $"{filename} - Fenix";
            MaximumSize = new Size(360, 360);
            MinimumSize = MaximumSize;
        }

        private void Close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void createFile_Click(object sender, EventArgs e)
        {
            filename = "Notname";
            db = null;
        }
    }
}
