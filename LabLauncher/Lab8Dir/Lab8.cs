using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

namespace LabLauncher.Lab8Dir
{
    public partial class Lab8 : Form
    {
        private string filename = "Notname";
        private FileStream stream = null;
        private bool changed = false;
        private bool notname = false;

        public Lab8()
        {
            InitializeComponent();
        }

        private void Close_Click(object sender, EventArgs e)
        {
            Close();
        }

        //Создать новый файл
        private void CreateFile_Click(object sender, EventArgs e)
        {
            if (changed)
            {
                DialogResult nova = MessageBox.Show(
                    "Вы действительно хотите создать новый файл?\nВсе несохранённые данные будут потеряны!",
                    "Fenix",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

                if (nova == DialogResult.No) return;
            }

            filename = "Notname";
            stream = new FileStream($"{filename}.fdb", FileMode.Create);
            Text = $"{filename} - Fenix";

            changed = false;
            notname = recordList.Visible = append.Visible = edit.Visible = delete.Visible = true;
        }

        private void Append_Click(object sender, EventArgs e)
        {
            AddRecord addrecord = new AddRecord(stream);

            if (addrecord.ShowDialog() == DialogResult.OK)
            {
                //TODO: обновить 

                changed = true;
            }
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            Record record = recordList.SelectedItem as Record;
            int select = recordList.SelectedIndex;
            AddRecord addrecord = new AddRecord(stream, record);

            if (addrecord.ShowDialog() == DialogResult.OK)
            {
                changed = true;
            }
        }

        private void delete_Click(object sender, EventArgs e)
        {
            return;
            DialogResult delete = MessageBox.Show(
                "Вы действительно хотите удалить выделенную запись?",
                "Fenix",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (delete == DialogResult.Yes)
            {
                //удаляем
            }
        }

        private FileStream Serialize(Record record)
        {
            FileStream tmp = new FileStream("record.tmp", FileMode.Create);
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(stream, record);
            return tmp;
        }

        private void Lab8_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (stream != null)
            {
                stream.Close();
            }

            if (notname)
            {
                FileInfo delete = new FileInfo($"{filename}.fdb");
                delete.Delete();
            }
        }
    }
}
