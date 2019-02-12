using System;
using System.Windows.Forms;

namespace LabLauncher.Lab9Dir
{
    public partial class Task3ManualFill : Form
    {
        public Money[] accounts { get; protected set; }
        private int left;

        public Task3ManualFill(int size)
        {
            InitializeComponent();
            accounts = new Money[size];
            left = size;
            label1.Text = $"Осталось заполнить: {left}";
        }

        private void add_Click(object sender, EventArgs e)
        {
            if (left > 0)
            {
                accounts[accounts.Length - left] = new Money(
                    (int)rouble.Value,
                    (byte)copeck.Value
                );

                if (--left == 0) complete.Enabled = true;
                label1.Text = $"Осталось заполнить: {left}";
                accountList.DataSource = null;
                accountList.DataSource = accounts;
            }
            else MessageBox.Show(
                "Массив уже полностью заполнен",
                ""
            );
        }

        private void complete_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }
    }
}
