using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace LabLauncher
{
    public partial class AddRecord : Form
    {
        protected Record record;
        protected List<Record> db;

        public AddRecord(List<Record> db)
        {
            InitializeComponent();
            monthField.SelectedIndex = 0;
            this.db = db;

            MaximumSize = new Size(Width, Height);
            MinimumSize = MaximumSize;
        }

        public AddRecord(List<Record> db, Record edit)
        {
            InitializeComponent();            
            record = edit;
            monthField.SelectedIndex = (int)record.mm;
            yearField.Text = record.year.ToString();
            unitField.Text = record.unit;
            profitField.Text = record.profit.ToString();
            this.db = db;

            MaximumSize = new Size(Width, Height);
            MinimumSize = MaximumSize;
        }

        private void Accept(object sender, EventArgs e)
        {
            byte month = (byte)monthField.SelectedIndex;
            short year;
            uint profit = 0;
            bool correct;

            correct = short.TryParse(yearField.Text, out year) && uint.TryParse(profitField.Text, out profit);

            if (!correct)
            {
                MessageBox.Show(
                    "Проверьте правильность введённых данных",
                    "Добавить запись",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
            else
            {
                Record.month monthenum = (Record.month)month;
                string key = $"{monthenum}.{year}";

                if (!isDuplicateKey(key))
                {
                    record = new Record(monthenum, year, unitField.Text, profit);

                    if (sender.Equals(addToBegin))
                    {
                        db.Insert(0, record);
                    }
                    else if (sender.Equals(addToEnd))
                    {
                        db.Add(record);
                    }

                    DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show(
                        "Запись с указанным месяцем и годом уже есть в файле",
                        "Добавить запись",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                }
            }
        }

        protected bool isDuplicateKey(string key)
        {
            bool duplicate = false;

            foreach (Record item in db)
            {
                if (key == item.key)
                {
                    duplicate = true;
                    break;
                }
            }

            return duplicate;
        }
    }
}
