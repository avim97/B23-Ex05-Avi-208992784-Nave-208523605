using System;
using System.Windows.Forms;

namespace Ex05.ReverseTicTacToeUI.Forms
{
    public partial class FormGameSettings : Form
    {
        public FormGameSettings()
        {
            InitializeComponent();
        }

        public int BoardSize => (int)numericUpDownRows.Value;
        public string FirstPlayerName => textBoxPlayer1Name.Text;
        public string SecondPlayerName => textBoxPlayer2Name.Text;
        public bool IsAiMatch => !checkBoxPlayer2.Checked;

        private void checkBoxPlayer2_CheckStateChanged(object sender, EventArgs e)
        {
            textBoxPlayer2Name.Enabled = checkBoxPlayer2.Checked;
        }

        private void textBoxPlayer2Name_EnabledChanged(object sender, EventArgs e)
        {
            if (textBoxPlayer2Name.Enabled)
            {
                textBoxPlayer2Name.Text = string.Empty;
            }
            else
            {
                const string k_ComputerPlayerName = "[Computer]";
                textBoxPlayer2Name.Text = k_ComputerPlayerName;
            }
        }

        private void numericUpDownRows_ValueChanged(object sender, EventArgs e)
        {
            numericUpDownCols.Value = numericUpDownRows.Value;
        }

        private void numericUpDownCols_ValueChanged(object sender, EventArgs e)
        {
            numericUpDownRows.Value = numericUpDownCols.Value;
        }

        private void buttonStartGame_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Yes;
            Close();
        }
    }
}