using System;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;

//TODO: Отладить

namespace LabLauncher.Markoff
{
    public partial class Program : Form
    {
        public Program()
        {
            InitializeComponent();
            ExampleFill();
        }

        private void ExampleFill()
        {
            deskString.Text = "1011";

            rulesTable.RowCount = 9;
            rulesTable[0, 0].Value = "0+"; rulesTable[1, 0].Value = "1.";
            rulesTable[0, 1].Value = "1+"; rulesTable[1, 1].Value = "+0";
            rulesTable[0, 2].Value = "*0"; rulesTable[1, 2].Value = "0*";
            rulesTable[0, 3].Value = "*1"; rulesTable[1, 3].Value = "1*";
            rulesTable[0, 4].Value = "0*"; rulesTable[1, 4].Value = "1.";
            rulesTable[0, 5].Value = "1*"; rulesTable[1, 5].Value = "+0";
            rulesTable[0, 6].Value = "+0"; rulesTable[1, 6].Value = "10.";
            rulesTable[0, 7].Value = "0";  rulesTable[1, 7].Value = "0*";
            rulesTable[0, 8].Value = "1";  rulesTable[1, 8].Value = "1*";
        }

        private void run_Click(object sender, EventArgs e)
        {
            string word = deskString.Text;
            bool ruleApplied, lastRule = false;

            do
            {
                ruleApplied = false;
                for (int i = 0; i < rulesTable.RowCount && !ruleApplied; i++)
                {
                    string L = rulesTable[0, i].Value.ToString();
                    string R = rulesTable[1, i].Value.ToString();

                    if (L == "Л")
                    {
                        word = R + word;
                        //обновить слово
                        ruleApplied = true;
                    }
                    else if (word.Contains(L))
                    {
                        lastRule = R.EndsWith(".");
                        if (lastRule) R = R.Trim('.');

                        Regex search = new Regex(Regex.Escape(L));
                        word = search.Replace(word, R, 1, 0);
                        //обновить слово
                        ruleApplied = true;                      
                    }
                }
            } while (ruleApplied && !lastRule);

            deskString.Text = word;
        }

        private bool checkRules(ref string[] rules)
        {
            foreach (string rule in rules)
                if (rule.Contains("->."))
                    return true;

            return false;
        }

        private void addRule_Click(object sender, EventArgs e)
        {
            rulesTable.RowCount++;
        }

        private void delRule_Click(object sender, EventArgs e)
        {
            if (rulesTable.RowCount > 0) rulesTable.RowCount--;
        }
    }
}
