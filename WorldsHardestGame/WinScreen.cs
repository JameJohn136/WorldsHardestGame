using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WorldsHardestGame
{
    public partial class WinScreen : UserControl
    {
        public static int deaths;
        public WinScreen()
        {
            InitializeComponent();
            DisplayInfo();
        }

        private void DisplayInfo()
        {
            deathLabel.Text = $"Deaths: {deaths}";
        }

        private void retryButton_Click(object sender, EventArgs e)
        {
            Form1.ChangeScreen(this, new GameScreen());
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
