using System;
using System.Windows.Forms;

namespace LabLauncher.Lab9Dir
{
    public partial class Task3Viewer : Form
    {
        private MoneyArray x_accounts;

        public Task3Viewer(MoneyArray a)
        {
            InitializeComponent();
            x_accounts = a;
            accountsList.DataSource = a.array;
            accountsList.DisplayMember = "name";
        }

        private void selectMin_Click(object sender, EventArgs e)
        {
            accountsList.SelectedIndex = x_accounts.minIndex;
        }
    }
}
