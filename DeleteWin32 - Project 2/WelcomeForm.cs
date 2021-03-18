using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeleteWin32___Project_2
{
    public partial class WelcomeForm : Form
    {
        public WelcomeForm()
        {
            InitializeComponent();
        }

        private void playButton_Click(object sender, EventArgs e)
        {
            if (nameTextBox.Text.Trim() == string.Empty)
            {
                errorLabel.Visible = true;
            }
            else
            {
                GameForm game = new GameForm(nameTextBox.Text);
                this.Hide();
                game.ShowDialog();
                this.Close();
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void NameTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                playButton.PerformClick();
            }
        }
    }
}
