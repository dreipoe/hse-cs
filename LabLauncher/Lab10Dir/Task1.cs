using System;
using System.Windows.Forms;

namespace LabLauncher.Lab10Dir
{
    public partial class Task1 : Form
    {
        public Task1()
        {
            InitializeComponent();
            InitPersonList();
        }

        private void InitPersonList()
        {
            Person[] personArray = new Person[]
            {
                new Person("Василий", "Пупкин", "Иванович", 25),
                new Person("Джон", "Смит", 30),
                new Person("Ольга", "Федулова", "Петровна", 58),
                new Person("Георгий", "Канаш", "Ипполитович", 12),
                new Person("Измаил", "Шимякин", "Глебович", 37),
                new Person("Габриэль", "Мэйсон", 51),
                new Person("Нона", "Бойкова", "Семеновна", 61),
                new Person("Фаина", "Квартина", "Федоровна", 84),
                new Person("Гарольд", "Ванин", "Иванович", 42)
            };

            personList.DataSource = personArray;
        }

        private void closeMe_Click(object sender, EventArgs e) { Close(); }

        private void personList_DoubleClick(object sender, EventArgs e)
        {
            if (personList.SelectedIndex == -1) return;
            Person person = personList.SelectedItem as Person;

            MessageBox.Show(
                person.row,
                "Информация",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }
    }
}
