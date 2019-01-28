using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace LabLauncher.TestDir
{
    public partial class Test : Form
    {
        List<Person> db;

        public Test()
        {
            InitializeComponent();

            db = new List<Person>();

            //фиксированный размер окна
            MaximumSize = new Size(Width, Height);
            MinimumSize = MaximumSize;

            refreshBox();
        }

        private void refreshBox()
        {
            dbBox.DataSource = db.ToArray();
            dbBox.DisplayMember = "toString";
            dbBox.ValueMember = "hash";
        }

        private void add_Click(object sender, EventArgs e)
        {
            Add addWindow = new Add();

            if (addWindow.ShowDialog() == DialogResult.OK)
            {
                db.Add(addWindow.pers);
                refreshBox();
            }
        }
    }
}
