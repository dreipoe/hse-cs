using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace LabLauncher.TestDir
{
    public partial class Test : Form
    {
        public Test()
        {
            InitializeComponent();
        }

        private void run_Click(object sender, EventArgs e)
        {
            bool closed = false;
            string command = cmdLine.Text;
            monitor.AppendText(command + '\n');

            switch (command.ToLower())
            {
                case "hello":
                    monitor.AppendText("Hello, world!\n");
                    break;
                case "exit":
                    closed = true;
                    Close();
                    break;
                default:
                    monitor.AppendText("Неизвестная команда, проверьте правильность её написания\n");
                    break;
            }

            if (!closed) monitor.AppendText(">>> ");
        }
    }
}
