using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using LabLauncher.Entities;

namespace LabLauncher.Lab12Dir
{
    public partial class Lab12 : Form
    {
        TestCollections collection;

        public Lab12()
        {
            InitializeComponent();

            collection = new TestCollections(10);
            collection.InitTestCollections();
            peopleList.DataSource = collection.People.ToArray();
        }

        private void Tests()
        {
            DialogResult answer = MessageBox.Show(
                "Запустить тесты, демонстрирующие работу этой программы?",
                "Лаб. работа №12",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (answer == DialogResult.No) return;

            Test1();
            Test2(); 
        }

        private void Test1()
        {
            try
            {
                TestCollections mistake = new TestCollections(-10);
            }
            catch (TestCollectionsException e)
            {
                MessageBox.Show(
                    $"Была произведена попытка создать класс с отрицательной ёмкостью. Возникло исключение: {e.Message}",
                    "Script",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
        }

        private void Test2()
        {

        }

        private void addButton_Click(object sender, EventArgs e)
        {
            AddPerson window = new AddPerson();
            if (window.DialogResult == DialogResult.OK) collection.Add(window.retorn);
            peopleList.DataSource = collection.People.ToArray();
        }

        //TODO: Проверить эту функцию
        private void delButton_Click(object sender, EventArgs e)
        {
            if (peopleList.SelectedIndex == -1) return;

            DialogResult yes = MessageBox.Show(
                "Вы действительно хотите удалить выделенный элемент",
                "Лаб. работа №12",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (yes == DialogResult.Yes) {
                Person person = peopleList.SelectedItem as Person;
                collection.Remove(person);
            }
        }

        //TODO: И эту тоже проверить
        private void searchTimeButton_Click(object sender, EventArgs e)
        {
            double[,] timeTable = collection.SearchTime();
        }
    }
}
