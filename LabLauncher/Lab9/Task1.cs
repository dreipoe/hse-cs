using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace LabLauncher.Lab9Dir
{
    public partial class Task1 : Form
    {
        private List<Money> accounts;

        public Task1()
        {
            InitializeComponent();
            accounts = new List<Money>();
        }

        private void addObject_Click(object sender, EventArgs e)
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

        private void addCopeek_Click(object sender, EventArgs e)
        {
            if (accountsList.SelectedIndex == -1) return;

            Money current = accountsList.SelectedItem as Money;
            Button send = sender as Button;

            if (send.Name == "button1")
                current.addCopeeks((int)copecks.Value);
            else
                Money.addCopeeks(current, (int)copecks.Value);

            RefreshList();
        }
    }
}
