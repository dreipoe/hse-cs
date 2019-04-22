using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabLauncher.Lab8Dir
{
    public partial class MostProfitForm : Form
    {
        Database db;

        public MostProfitForm(Database db)
        {
            InitializeComponent();
            this.db = db;
            MakeSummary();
        }

        private void MakeSummary()
        {
            
        }

        private void CloseMe_Click(object sender, EventArgs e) { Close(); }
    }
}
