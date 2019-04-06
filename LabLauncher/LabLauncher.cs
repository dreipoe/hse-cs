using System;
using System.Windows.Forms;

using Test = LabLauncher.TestDir.Test;
using Lab8 = LabLauncher.Lab8Dir.Lab8;
using Lab9 = LabLauncher.Lab9Dir.Lab9;
using Lab10 = LabLauncher.Lab10Dir.Lab10;
using Markov = LabLauncher.Markoff.Program;
using Turin = LabLauncher.Turing.Program;

namespace LabLauncher
{
    public partial class LabLauncher : Form
    {
        public LabLauncher()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            switch (labList.SelectedIndex)
            {
                case 0: new Lab8().Show(); break;
                case 1: new Lab9().Show(); break;
                case 2: new Lab10().Show(); break;
                case 3: new Turin().Show(); break;
                case 4: new Markov().Show(); break;
                case 5: new Test().Show(); break;
                default: return;
            }
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
