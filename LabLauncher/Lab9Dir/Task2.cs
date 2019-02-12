using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace LabLauncher.Lab9Dir
{
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
            accountsList.DataSource = accounts.ToArray();
        }

        private void incOrDecCopeek_Click(object sender, EventArgs e)
        {
            if (accountsList.SelectedIndex == -1) return;

            int save = accountsList.SelectedIndex;
            Money current = accountsList.SelectedItem as Money;
            Button send = sender as Button;

            switch (send.Name)
            {
                case "incCopeek": current++; break;
                case "decCopeek": current--; break;
                case "ConvertMe": convertMe(current);  break;
                case "add": addClick(current); break;
                case "subtract": subtractClick(current); break;
                case "equal": equalClick(current); break;
                default: return;
            }

            accountsList.DataSource = accounts.ToArray();
            accountsList.SelectedIndex = save;
        }

        private void convertMe(Money m)
        {
            //приведение типов здесь
            int a = (int)m;
            double b = m;

            MessageBox.Show(
                $"Результат приведения типов выделенного объекта:\n" +
                $"Integer: {a}\n" +
                $"Double: {b}.",
                "Приведение типов",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
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

        private void equalClick(Money second)
        {
            if (addend == null || operation != '+' && operation != '-') return;

            Money result;
            switch (operation)
            {
                case '+': result = addend + second; break;
                case '-': result = addend - second; break;
                default: return;
            }

            if (result != null)
            {
                accounts.Add(result);
                Total.Text = $"Всего объектов: {Money.count}";
                accountsList.DataSource = accounts.ToArray();
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
