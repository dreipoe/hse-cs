using System;
using System.Windows.Forms;

namespace LabLauncher.Lab8Dir
{
    public partial class EditRecord : Form
    {
        private Database db;
        private int number;

        public EditRecord(Database db, int number)
        {
            InitializeComponent();
            this.db = db;
            this.number = number;

            //автозаполнение
            Record record = db[number];
            monthField.SelectedIndex = (int)record.mm;
            yearField.Value = record.year;
            profitField.Value = record.profit;
            unitField.Text = record.unit;
        }

        //нажатие кнопки Изменить
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

            db[number + 1] = new Record((Record.month)month, year, unitField.Text, profit);
            DialogResult = DialogResult.OK;
        }
    }
}
