using System;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;

//TODO: Добавить функцию, которая создаёт массив символов алфавита, включая пустой

namespace LabLauncher.Turing
{
    public partial class Program : Form
    {
        const string pattern = @"(?<symbol>[A-z0-9]|=)(?<direction>L|R|S)q(?<stateNumber>\d+)";

        int head = 12;
        string tape;
        bool alphabetChanged = false;

        public Program()
        {
            InitializeComponent();
            tapeField.Select(12, 1);
            tape = tapeField.Text;

            initRows();

            codeGrid.ColumnCount = 2;
            for (int i = 0; i < codeGrid.ColumnCount; i++)
            {
                DataGridViewColumn column = codeGrid.Columns[i];
                column.HeaderText = $"q{i + 1}";
                column.Width = 35;
            }

            initTest();
            symbols.SelectedIndex = 0;           
        }

        private void initRows()
        {
            string alphabet = alphabetBox.Text;
            int alphabetLength = alphabet.Length;
            codeGrid.RowCount = alphabetLength + 1;

            for (int i = 0; i < alphabetLength; i++)
                codeGrid.Rows[i].HeaderCell.Value = alphabet.Substring(i, 1);

            codeGrid.Rows[alphabetLength].HeaderCell.Value = "=";
        }

        private void initTest()
        {            
            codeGrid[0, 0].Value = "0Rq1"; codeGrid[1, 0].Value = "1Sq0";
            codeGrid[0, 1].Value = "1Rq1"; codeGrid[1, 1].Value = "0Lq2";
            codeGrid[0, 2].Value = "=Lq2"; codeGrid[1, 2].Value = "1Sq0";
        }

        private void closeMe_Click(object sender, EventArgs e) { Close(); }

        private void moveLeft_Click(object sender, EventArgs e)
        {
            if (head <= 12)
                tape = '=' + tape;
            else head--;

            refreshTapeField();
        }

        private void moveRight_Click(object sender, EventArgs e)
        {
            if (tape.Length <= head + 13)
                tape += '=';
            head++;

            refreshTapeField();
        }

        private void refreshTapeField()
        {
            tapeField.Text = tape.Substring(head - 12, 25);
            tapeField.Focus();
            tapeField.Select(12, 1);
        }

        private void runMe_Click(object sender, EventArgs e)
        {
            int state = 1;

            do {
                char symbol = tape[head];
                char[] fullAlphabet = (alphabetBox.Text + '=').ToCharArray();
                int rowIndex = Array.IndexOf(fullAlphabet, symbol);
                if (rowIndex == -1) rowIndex++;

                string command = codeGrid[state - 1, rowIndex].Value.ToString();
                Match m = Regex.Match(command, pattern);

                try {
                    if (!m.Success) throw new Exception("Синтаксическая ошибка");

                    string nextSymbol = m.Groups["symbol"].Value;
                    string direction = m.Groups["direction"].Value;
                    string nextState = m.Groups["stateNumber"].Value;

                    if (Array.IndexOf(fullAlphabet, nextSymbol[0]) == -1) throw new Exception("Неалфавитный символ.");

                    setSymbol(nextSymbol[0]);
                    move(direction[0], nextState, ref state);
                    refreshTapeField();
                } catch (Exception ex) {
                    ShowError(ex.Message, symbol, state);
                    state = 0;
                }
            } while (state != 0);
        }

        private void move(char dir, string next, ref int state)
        {
            switch (dir)
            {
                case 'L': head--; break;
                case 'R': head++; break;
                case 'S': break;
            }

            if (head < 12)
            {
                tape = '=' + tape;
                head++;
            }
            else if (tape.Length <= head + 13) tape += '=';

            state = int.Parse(next);
            if (state > codeGrid.ColumnCount)
                throw new Exception("Неподдерживаемое состояние");
        }

        private void ShowError(string message, char symbol, int state)
        {
            MessageBox.Show(
                $"Возникла ошибка выполнения:\n" +
                $"{message}. Символ \"{symbol}\", состояние {state}.",
                "Тьюринг",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            );
        }

        private void addState_Click(object sender, EventArgs e)
        {
            int last = codeGrid.ColumnCount++;
            DataGridViewColumn column = codeGrid.Columns[last];
            column.HeaderText = $"q{codeGrid.ColumnCount}";
            column.Width = 30;
        }

        private void decState_Click(object sender, EventArgs e)
        {
            if (codeGrid.ColumnCount > 1) codeGrid.ColumnCount--;
        }

        private void alphabetBox_Leave(object sender, EventArgs e)
        {
            if (alphabetChanged)
            {
                initRows();
                alphabetChanged = false;
            }

            symbols.DataSource = (alphabetBox.Text + '=').ToCharArray();
        }

        private void alphabetBox_TextChanged(object sender, EventArgs e)
        {
            alphabetChanged = true;
        }

        private void setme_Click(object sender, EventArgs e)
        {
            if (symbols.SelectedIndex == -1) return;

            setSymbol(
                ((string)symbols.SelectedItem)[0]
            );

            refreshTapeField();
        }

        private void setSymbol(char symbol)
        {
            char[] charTape = tape.ToCharArray();
            charTape[head] = symbol;
            tape = new string(charTape);
        }

        private void aboutMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Машина Тьюринга\n" +
                "© Dreipoe, 2019. Лицензия: MIT",
                "О программе",
                MessageBoxButtons.OK,
                MessageBoxIcon.Asterisk
            );
        }
    }
}
