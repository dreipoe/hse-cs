using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using LabLauncher.Entities;

namespace LabLauncher.Lab11Dir
{
    using education = Employee.education;
    using category = Engineer.category;

    public partial class AddPerson : Form
    {
        public Person retorn { get; private set; }

        public AddPerson()
        {
            InitializeComponent();
            eduCombo.SelectedIndex = 0;
        }

        //Добавить пользователя
        private void add_Click(object sender, EventArgs e)
        {
            if (nameField.TextLength == 0)
            {
                ShowError(1);
                return;
            }

            if (personCheck.Checked)
            {
                retorn = new Person(nameField.Text, (byte)ageField.Value);
            }
            else if (workerCheck.Checked)
            {
                if (posField.TextLength == 0)
                {
                    ShowError(2);
                    return;
                }
                retorn = new Worker(nameField.Text, posField.Text, (byte)ageField.Value, (int)salaryField.Value, (int)expField.Value);
            }
            else if (empCheck.Checked)
            {
                education edu = (education)eduCombo.SelectedIndex;
                retorn = new Employee(nameField.Text, posField.Text, (byte)ageField.Value, (int)salaryField.Value, (int)expField.Value, edu);
            }
            else
            {
                education edu = (education)eduCombo.SelectedIndex;
                category cat = (category)(3 - categoryField.Value);
                retorn = new Engineer(nameField.Text, posField.Text, (byte)ageField.Value, (int)salaryField.Value, (int)expField.Value, edu, cat);
            }

            DialogResult = DialogResult.OK;
        }

        private void close_Click(object sender, EventArgs e) { Close(); }

        private void checkChanged(object sender, EventArgs e)
        {
            if (personCheck.Checked)
            {
                salaryField.Enabled = expField.Enabled = shopField.Enabled =
                posField.Enabled = eduCombo.Enabled = categoryField.Enabled = false;
            }
            else if (workerCheck.Checked)
            {
                salaryField.Enabled = expField.Enabled = shopField.Enabled =
                posField.Enabled = true;
                eduCombo.Enabled = categoryField.Enabled = false;
            }
            else if (empCheck.Checked)
            {
                salaryField.Enabled = expField.Enabled = shopField.Enabled =
                posField.Enabled = eduCombo.Enabled = true;
                categoryField.Enabled = false;
            }
            else
            {
                salaryField.Enabled = expField.Enabled = shopField.Enabled =
                posField.Enabled = eduCombo.Enabled = categoryField.Enabled = true;
            }
        }

        private void ShowError(byte code)
        {
            string message = string.Empty;
            switch (code)
            {
                case 1: message = "Заполните ФИО"; break;
                case 2: message = "Заполните должность"; break;
            }
            MessageBox.Show(message, "Лаб. №11", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
