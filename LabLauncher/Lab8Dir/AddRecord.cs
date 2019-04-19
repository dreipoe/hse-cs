using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

namespace LabLauncher.Lab8Dir
{
    public partial class AddRecord : Form
    {
        private Database db;

        public AddRecord(Database db)
        {
            InitializeComponent();
            monthField.SelectedIndex++;
            this.db = db;
        }

        //нажатие кнопки Добавить
        private void Accept(object sender, EventArgs e)
        {
            byte month = (byte)monthField.SelectedIndex;
            short year = (short)yearField.Value;
            int profit = (int)profitField.Value;

            if (unitField.TextLength == 0)
            {
                MessageBox.Show(
                    "Заполните поле \"Подразделение\"",
                    "Добавить запись",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                ); return;
            }

            Record record = new Record((Record.month)month, year, unitField.Text, profit);

            if (addToBegin.Checked)
                db.Add(record);
            else if (addToEnd.Checked)
                db.Push(record);
            else if (!db.Add(record, (int)posField.Value))
            {
                MessageBox.Show(
                    "Не удалось добавить файл на указанную позицию.",
                    "Добавить запись",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                ); return;
            }

            DialogResult = DialogResult.OK;
        }
    }
}
