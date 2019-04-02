using System;
using System.Windows.Forms;

/* TODO:
 * 1. Нужно добавить проверку текста программы перед выполнением
 * 2. Как насчёт добавления консоли ввода/вывода при запуске программы?
 */

namespace LabLauncher.Brainfck
{
    public partial class Program : Form
    {
        private int i;
        private char[] ram;
        private string output;

        public Program()
        {
            InitializeComponent();
        }

        private void closeMe_Click(object sender, EventArgs e) { Close(); }

        private void runMe_Click(object sender, EventArgs e)
        {
            //инициализация виртуальной машины
            i = 0;
            ram = new char[30000];
            output = string.Empty;

            bool success = true;

            for (int h = 0; h < redactor.TextLength; h++) {
                success = handleSymbol(redactor.Text[h], ref h);
                if (!success) break;
            }

            MessageBox.Show(
                $"Результат: {output}",
                "Brainf_ck",
                MessageBoxButtons.OK,
                MessageBoxIcon.Asterisk
            );
        }

        private bool handleSymbol(char symbol, ref int h)
        {
            if (char.IsControl(symbol) || symbol == ' ') return true;

            switch (symbol)
            {
                case '>': i++; return true;
                case '<': i--; return true;
                case '+': ram[i]++; return true;
                case '-': ram[i]--; return true;
                case '.': output += ram[i]; return true;
                case '[':
                    //если в текущей ячейке нуль, то ищем конец цикла и идём дальше
                    if (ram[i] == 0)
                    {
                        int brc = 1;
                        while (brc != 0)
                        {
                            h++;
                            if (redactor.Text[h] == '[') brc++;
                            else if (redactor.Text[h] == ']') brc--;
                        }
                    }
                    return true;
                case ']':
                    //если в текущей ячейке не нуль, то возвращаемся в начало цикла
                    if (ram[i] != 0)
                    {
                        int brc = 1;
                        while (brc != 0)
                        {
                            h--;
                            if (redactor.Text[h] == '[') brc--;
                            else if (redactor.Text[h] == ']') brc++;
                        }
                    }
                    return true;
                default:
                    MessageBox.Show(
                        $"Неизвестный символ: {symbol}",
                        "Brainf_ck",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Hand
                    );
                    return false;
            }
        }

        private void aboutThis_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Brainf_ck IDE\n" +
                "© Александр Орешкин, 2019",
                "О программе",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information               
            );
        }
    }
}
