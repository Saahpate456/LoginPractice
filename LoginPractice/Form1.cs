using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginPractice
{
    public partial class Form1 : Form
    {
        string heroName;
        string difficulty;
        public Form1()
        {
            InitializeComponent();
        }

        private void easyButton_Click(object sender, EventArgs e)
        {
            easyButton.BackColor = Color.Black;
            mediumButton.BackColor = Color.Black;
            hardButton.BackColor = Color.Black;

            easyButton.BackColor = Color.Green;
            difficulty = "Easy";
        }

        private void mediumButton_Click(object sender, EventArgs e)
        {
            easyButton.BackColor = Color.Black;
            mediumButton.BackColor = Color.Black;
            hardButton.BackColor = Color.Black;

            mediumButton.BackColor = Color.Orange;
            difficulty = "Medium";
        }

        private void hardButton_Click(object sender, EventArgs e)
        {
            easyButton.BackColor = Color.Black;
            mediumButton.BackColor = Color.Black;
            hardButton.BackColor = Color.Black;

            hardButton.BackColor = Color.Red;
            difficulty = "Hard";
        }

        private void enterName_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void beginButton_Click(object sender, EventArgs e)
        {
            heroName = nameInput.Text;
            

            outputLabel.Text = $"Welcome {heroName}!";
            outputLabel.Text += $"\nBegin your journey. Go conquor the {difficulty} path!";
        }

    }
}
