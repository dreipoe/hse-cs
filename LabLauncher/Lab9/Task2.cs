using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabLauncher.Lab9Dir
{
    //TODO: Реализация окончена, осталось отладить

    public partial class Task2 : Form
    {
        private List<Money> accounts;
        private Money addend = null;
        char operation = '\0';

        public Task2()
        {
            InitializeComponent();
            accounts = new List<Money>();
        }

        private void createObject_Click(object sender, EventArgs e)
        {
            accounts.Add(new Money());
            Total.Text = $"Всего объектов: {Money.count}";
            RefreshList();
        }

        private void RefreshList()
        {
            accountsList.DataSource = accounts.ToArray();
            accountsList.DisplayMember = "row";
        }

        private void incOrDecCopeek_Click(object sender, EventArgs e)
        {
            if (accountsList.SelectedIndex == -1) return;

            Money current = accountsList.SelectedItem as Money;
            Button send = sender as Button;

            switch (send.Name)
            {
                case "incCopeek": current++; break;
                case "decCopeek": current--; break;
                case "ConvertMe": convertMe(current);  break;
                case "add": 
                case "subtract": 
                case "equal": break;
                default: return;
            }

            RefreshList();
        }

        private void convertMe(Money m)
        {
            //приведение типов здесь
            int a = (int)m;
            double b = m;

            MessageBox.Show(
                "Результат приведения типов выделенного объекта:\n" +
                $"Integer: {a}\n" +
                $"Double: {b}."
            );
        }

        private void addClick(Money m)
        {
            addend = m;
            operation = '+';
        }

        private void subtractClick(Money m)
        {
            addend = m;
            operation = '-';
        }

        private void equalClick(Money m)
        {
            if (addend == null || operation != '+' && operation != '-') return;

            Money result;
            switch (operation)
            {
                case '+': result = m + addend; break;
                case '-': result = m - addend; break;
                default: return;
            }

            if (m != null)
            {
                accounts.Add(result);
                Total.Text = $"Всего объектов: {Money.count}";
            }
            else
                MessageBox.Show(
                    "Значение уменьшаемого меньше вычитаемого",
                    "Задача 2",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
        }
    }
}
