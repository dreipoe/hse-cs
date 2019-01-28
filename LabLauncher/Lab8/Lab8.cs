using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

namespace LabLauncher
{
    public partial class Lab8 : Form
    {
        public string filename = "Notname";
        public List<Record> db;
        public bool changed = false;

        public Lab8()
        {
            InitializeComponent();
            db = new List<Record>();
            Text = $"{filename} - Fenix";

            //фиксированный размер окна
            MaximumSize = new Size(Width, Height);
            MinimumSize = MaximumSize;
            RefreshList();
        }

        private void RefreshList()
        {
            recordList.DataSource = db.ToArray();
            recordList.DisplayMember = "row";
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
            db = new List<Record>();
            changed = false;
        }

        private void Append_Click(object sender, EventArgs e)
        {
            AddRecord addrecord = new AddRecord(db);

            if (addrecord.ShowDialog() == DialogResult.OK)
            {
                RefreshList();
            }
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            Record record = recordList.SelectedItem as Record;
            int select = recordList.SelectedIndex;
            AddRecord addrecord = new AddRecord(db, record);

            if (addrecord.ShowDialog() == DialogResult.OK)
            {
                RefreshList();
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
    }
}
