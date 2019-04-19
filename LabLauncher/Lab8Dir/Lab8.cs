using System;
using System.IO;
using System.Windows.Forms;

namespace LabLauncher.Lab8Dir
{
    public partial class Lab8 : Form
    {
        private Database db;
        private bool opened = false;

        public Lab8()
        {
            InitializeComponent();
        }

        private void Close_Click(object sender, EventArgs e) { Close(); }

        //Создаёт новый файл или открывает существующий
        private void CreateFile_Click(object sender, EventArgs e)
        {
            if (opened && MessageBox.Show(
                    "Вы действительно хотите завершить работу с текущим файлом и открыть другой?",
                    "Fenix",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
            ) != DialogResult.Yes) return;

            ToolStripMenuItem _sender = sender as ToolStripMenuItem;
            bool create = (_sender.Name == "createFile") ? true : false;

            SaveFileDialog fetchFileDialog = new SaveFileDialog();
            fetchFileDialog.OverwritePrompt = create;
            fetchFileDialog.Title = (create) ? "Создать файл" : "Открыть файл";
            fetchFileDialog.InitialDirectory = Application.StartupPath + "\\data\\";
            fetchFileDialog.FileName = "MyDB.fdb";
            fetchFileDialog.Filter = "База данных Fenix (*.fdb)|*.fdb|Все файлы (*.*)|*.*";

            if (fetchFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filepath = fetchFileDialog.FileName;
                Text = $"{filepath} - Fenix";
                db = new Database(filepath);

                if (create)
                    new FileStream(filepath, FileMode.Create).Close();
                else recordList.DataSource = db.Show();

                opened = recordList.Visible = append.Visible = edit.Visible = delete.Visible = true;
            }
        }

        private void Append_Click(object sender, EventArgs e)
        {
            AddRecord addrecord = new AddRecord(db);

            if (addrecord.ShowDialog() == DialogResult.OK) recordList.DataSource = db.Show();
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            int number = recordList.SelectedIndex;
            if (number == -1) return;

            EditRecord editrecord = new EditRecord(db, number);

            if (editrecord.ShowDialog() == DialogResult.OK) recordList.DataSource = db.Show();
        }

        private void delete_Click(object sender, EventArgs e)
        {
            if (recordList.SelectedIndex == -1) return;

            DialogResult delete = MessageBox.Show(
                "Вы действительно хотите удалить выделенную запись?",
                "Fenix",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (delete == DialogResult.Yes)
            {
                db.Del(recordList.SelectedIndex);
                recordList.DataSource = db.Show();
            }
        }

        //TODO: В целях отладки, рабочий файл будет автоматически удаляться при закрытии программы
        private void Lab8_FormClosed(object sender, FormClosedEventArgs e)
        {
            /*
            FileInfo delete = new FileInfo($"data/{db.Name}.fdb");
            delete.Delete();
            */
        }
    }
}
