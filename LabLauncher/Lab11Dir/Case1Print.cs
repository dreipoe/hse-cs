using System;
using System.Collections;
using System.Collections.Generic;
using System.Windows.Forms;

using LabLauncher.Entities;

namespace LabLauncher.Lab11Dir
{
    public partial class Case1Print : Form
    {
        public Case1Print(ArrayList people)
        {
            InitializeComponent();
            peopleList.DataSource = people.ToArray();
        }

        public Case1Print(Stack<Person> people)
        {
            InitializeComponent();
            peopleList.DataSource = people.ToArray();
        }

        private void closeButton_Click(object sender, EventArgs e) { Close(); }
    }
}
