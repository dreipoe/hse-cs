using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

namespace LabLauncher.Lab8Dir
{
    public partial class AddRecord : Form
    {
        private string filename;

        public AddRecord(string filename)
        {
            InitializeComponent();
            monthField.SelectedIndex = 0;
            this.filename = filename;
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

            BinaryFormatter bf = new BinaryFormatter();
            if (addToBegin.Checked)
            {
                FileInfo file = new FileInfo($"data/{filename}.fdb");
                FileInfo tmp = file.CopyTo("data/tmp");

                FileStream fileStream = new FileStream($"data/{filename}.fdb", FileMode.Truncate);
                FileStream tmpStream = new FileStream($"data/tmp", FileMode.Open);
                bf.Serialize(fileStream, record);
                tmpStream.CopyTo(fileStream);
                fileStream.Close();
                tmpStream.Close();
                tmp.Delete();
            }
            else if (addToEnd.Checked)
            {
                FileStream file = new FileStream($"data/{filename}.fdb", FileMode.Append);
                bf.Serialize(file, record);
                file.Close();
            }
            else
            {

            }

            DialogResult = DialogResult.OK;
        }
    }
}
