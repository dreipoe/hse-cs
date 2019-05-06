using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabLauncher.Lab13Dir
{
    public partial class Lab13 : Form
    {
        MyList list;

        public Lab13()
        {
            InitializeComponent();

            list = new MyList();
            list.Init();
        }
    }
}
