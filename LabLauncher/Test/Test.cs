using System;
using System.Windows.Forms;

namespace LabLauncher.TestDir
{
    public partial class Test : Form
    {
        public Test()
        {
            InitializeComponent();

            MyList list = new MyList();
            list.Push(1);
            list.Push(2);
            list.Push(3);
            list.Push(4);
            list.Pop();
            int i = list.IndexOf(2);
            MessageBox.Show(i.ToString(), "Test");
        }
    }
}
