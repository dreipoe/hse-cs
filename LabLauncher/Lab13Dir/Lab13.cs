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

namespace LabLauncher.Lab13Dir
{
    using ComparerByString = Entities.PersonComparers.PersonCompareByString;
    using ComparerByAge = Entities.PersonComparers.PersonCompareByAge;

    public partial class Lab13 : Form
    {
        MyList list;

        public Lab13()
        {
            InitializeComponent();

            list = new MyList();
            list.AddDefaults();
            peopleList.DataSource = list.ToArray();
        }

        //подробная информация об объекте
        private void LearnMore(object sender, EventArgs e)
        {
            if (peopleList.SelectedIndex == -1) return;
            Person person = peopleList.SelectedItem as Person;

            MessageBox.Show(
                person.virtualInfo(),
                "Информация",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }

        //добавить человека в коллекцию
        private void addButton_Click(object sender, EventArgs e)
        {
            AddPerson addPerson = new AddPerson();
            if (addPerson.ShowDialog() == DialogResult.OK) list.Add(addPerson.retorn);
            peopleList.DataSource = list.ToArray();
        }

        //удалить человека из коллекции
        private void delButton_Click(object sender, EventArgs e)
        {
            if (peopleList.SelectedItem == null) return;

            DialogResult delete = MessageBox.Show(
                "Вы действительно хотите удалить этот элемент?",
                "Лаб. работа №13",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (delete == DialogResult.Yes)
            {
                list.RemoveAt(peopleList.SelectedIndex);
                peopleList.DataSource = list.ToArray();
            }
        }

        //очистить коллекцию
        private void clearButton_Click(object sender, EventArgs e)
        {
            if (peopleList.SelectedItem == null) return;

            DialogResult delete = MessageBox.Show(
                "Вы действительно хотите очистить список?",
                "Лаб. работа №13",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (delete == DialogResult.Yes)
            {
                list.Clear();
                peopleList.DataSource = list.ToArray();
            }
        }

        //сортировка 
        private void sortButton_Click(object sender, EventArgs e)
        {
            if (mode1.Checked)
            {
                //по ФИО
                list.Sort(new ComparerByString());
            }
            else if (mode2.Checked)
            {
                //по возрасту
                list.Sort(new ComparerByAge());
            }
            else { }

            peopleList.DataSource = list.ToArray();
        }
    }
}
