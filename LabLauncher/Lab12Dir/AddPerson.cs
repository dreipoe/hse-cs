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

namespace LabLauncher.Lab12Dir
{
    public partial class AddPerson : Form
    {
        public Worker retorn { get; private set; }

        public AddPerson()
        {
            InitializeComponent();
        }

        //Добавить пользователя
        private void add_Click(object sender, EventArgs e)
        {
            if (nameField.TextLength == 0)
            {
                ShowError(1);
                return;
            }

            if (posField.TextLength == 0)
            {
                ShowError(2);
                return;
            }
            retorn = new Worker(nameField.Text, posField.Text, (byte)ageField.Value, (int)salaryField.Value, (int)expField.Value);

            DialogResult = DialogResult.OK;
        }

        private void close_Click(object sender, EventArgs e) { Close(); }

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
