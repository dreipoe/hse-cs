using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

namespace LabLauncher.Lab8Dir
{
    public partial class Lab8 : Form
    {
        private string filename = "Notname";
        private bool notname = false;

        public Lab8()
        {
            InitializeComponent();
        }

        private void Close_Click(object sender, EventArgs e) { Close(); }

        //Создать новый файл
        private void CreateFile_Click(object sender, EventArgs e)
        {
            filename = "Notname";
            Text = $"{filename} - Fenix";

            notname = recordList.Visible = append.Visible = edit.Visible = delete.Visible = true;
        }

        private void Append_Click(object sender, EventArgs e)
        {
            AddRecord addrecord = new AddRecord(filename);

            if (addrecord.ShowDialog() == DialogResult.OK) refreshRecords();
        }

        //TODO: Не реализовано
        private void Edit_Click(object sender, EventArgs e)
        {
            return;
            AddRecord addrecord = new AddRecord(filename);

            if (addrecord.ShowDialog() == DialogResult.OK) refreshRecords();
        }

        //TODO: Не реализовано
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

        private void refreshRecords()
        {
            List<Record> records = new List<Record>();
            FileStream reading = new FileStream($"data/{filename}.fdb", FileMode.Open);
            BinaryFormatter bf = new BinaryFormatter();

            while (reading.Position < reading.Length)
            {
                Record row = bf.Deserialize(reading) as Record;
                records.Add(row);
            }

            recordList.DataSource = records.ToArray();
        }

        private void Lab8_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (notname)
            {
                FileInfo delete = new FileInfo($"{filename}.fdb");
                delete.Delete();
            }
        }
    }
}
