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
    public partial class Task3ManualFill : Form
    {
        private Money[] x_accounts;
        private int left;

        public Task3ManualFill(int size)
        {
            InitializeComponent();
            x_accounts = new Money[size];
            left = size;
            label1.Text = $"Осталось заполнить: {left}";

            accountList.DataSource = x_accounts;
            accountList.DisplayMember = "row";
        }

        private void add_Click(object sender, EventArgs e)
        {
            if (left > 0)
            {
                x_accounts[x_accounts.Length - left] = new Money(
                    (int)rouble.Value,
                    (byte)copeck.Value
                );

                if (--left == 0) complete.Enabled = true;
            }
            else MessageBox.Show(
                "Массив уже полностью заполнен",
                ""
            );
        }
    }
}
