using System;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Markov
{
    public partial class Form1 : Form
    {
        //TODO: В проге отсутствует валидатор правил замены
        public Form1()
        {
            InitializeComponent();

            //фиксированное окно
            MaximumSize = new Size(Width, Height);
            MinimumSize = MaximumSize;
        }

        private void run_Click(object sender, EventArgs e)
        {
            string[] rules = rulesField.Lines;
            string word = wordField.Text;
            bool ruleApplied;
            bool lastRule = false;

            if (!checkRules(ref rules))
            {
                MessageBox.Show(
                    "В списке отсутствует последнее правило. Его необходимо указать комбинацией \"->.\"",
                    "Markov",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                ); return;
            }

            int actions = 0;

            do
            {
                ruleApplied = false;
                foreach (string rule in rules)
                {
                    string[] splitters = new[] { "->.", "->"};
                    string[] ruleParts = rule.Split(splitters, StringSplitOptions.None);
                    
                    string L = ruleParts[0];
                    string R = ruleParts[1];

                    lastRule = rule.Contains("->.");

                    if (L == "Л")
                    {
                        word = R + word;
                        //обновить слово
                        ruleApplied = true;
                    }
                    else if (word.Contains(R))
                    {
                        Regex search = new Regex(Regex.Escape(L));
                        word = search.Replace(word, R, 1, 0);
                        //обновить слово
                        ruleApplied = true;
                    }

                    lastRule = lastRule || deathCycleGuard(ref actions);
                }

                wordField.Text = word;
            } while (ruleApplied && !lastRule);
        }

        private bool checkRules(ref string[] rules)
        {
            foreach (string rule in rules)
                if (rule.Contains("->."))
                    return true;

            return false;
        }

        private bool deathCycleGuard(ref int actions)
        {
            actions++;

            if (actions == 100000)
            {
                DialogResult guard = MessageBox.Show(
                    "Похоже, программа зациклилась. Продолжить выполнение?",
                    "Защита от зацикливания",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

                if (guard == DialogResult.Yes)
                {
                    actions = 0;
                    return false;
                } else return true;
            }

            return false;
        }
    }
}
