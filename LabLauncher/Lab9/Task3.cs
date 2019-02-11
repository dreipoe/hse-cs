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
                            (int)countEl.Value
                        )
                    );
                else
                {
                    Task3ManualFill window = new Task3ManualFill((int)countEl.Value);
                    window.ShowDialog();
                }
            }
            else banks.Add(new MoneyArray());
        }
    }
}
