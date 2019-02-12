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
    public partial class Task3 : Form
    {
        private List<MoneyArray> banks;

        public Task3()
        {
            InitializeComponent();
            banks = new List<MoneyArray>();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (countEl.Value > 0)
            {
                if (!manualEl.Checked)
                    banks.Add(
                        new MoneyArray(
                            (byte)countEl.Value
                        )
                    );
                else
                {
                    Task3ManualFill window = new Task3ManualFill((byte)countEl.Value);
                    if (window.ShowDialog() == DialogResult.OK)
                        banks.Add(
                            new MoneyArray(
                                window.accounts
                            )
                        );
                }
            }
            else banks.Add(new MoneyArray());

            bankList.DataSource = banks.ToArray();
        }

        private void viewMe_Click(object sender, EventArgs e)
        {
            if (bankList.SelectedIndex == -1) return;

            Task3Viewer window = new Task3Viewer(bankList.SelectedItem as MoneyArray);
            window.ShowDialog();
        }
    }
}
