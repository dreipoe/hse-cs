using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

using Person = LabLauncher.TestDir.Person;

namespace LabLauncher.TestDir
{
    public partial class Add : Form
    {
        Person person;
        public Person pers
        {
            get
            {
                return person;
            }
        }

        public Add()
        {
            InitializeComponent();
        }

        private void Ok_Click(object sender, EventArgs e)
        {
            byte age;
            if (byte.TryParse(ageField.Text, out age))
            {
                person = new Person(firstName.Text, lastName.Text, age);
                DialogResult = DialogResult.OK;
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
