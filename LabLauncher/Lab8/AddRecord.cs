using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

namespace LabLauncher.Lab8Dir
{
    public partial class AddRecord : Form
    {
        protected Record _record;
        protected FileStream stream;

        public Record record
        {
            get
            {
                return _record;
            }
        }

        public AddRecord(FileStream stream)
        {
            InitializeComponent();
            monthField.SelectedIndex = 0;
            this.stream = stream;
        }

        public AddRecord(FileStream stream, Record edit)
        {
            InitializeComponent();            
            _record = edit;
            monthField.SelectedIndex = (int)record.mm;
            yearField.Value = record.year;
            unitField.Text = record.unit;
            profitField.Value = record.profit;
            this.stream = stream;
        }

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

            /*
            _record = new Record((Record.month)month, year, unitField.Text, profit);
            FileStream tmp = Serialize(_record);
            byte[] arrtmp = new byte[tmp.Length];
            tmp.Read(arrtmp, 0, (int)tmp.Length);

            if (addToBegin.Checked)
            {
                stream.Seek(0, SeekOrigin.Begin);
                return;
            }   
            else if (addToEnd.Checked)
            {
                stream.Seek(0, SeekOrigin.End);
                stream.Write(arrtmp, 0, (int)tmp.Length);
            }
            else return;
            */

            DialogResult = DialogResult.OK;
        }

        private FileStream Serialize(Record record)
        {
            FileStream tmp = new FileStream("record.tmp", FileMode.Create);
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(stream, record);
            return tmp;
        }
    }
}
