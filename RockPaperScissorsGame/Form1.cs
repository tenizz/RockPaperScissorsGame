using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RockPaperScissorsGame
{
    public partial class Form1 : Form
    {
        public int pcMove;
        public string MoveTranslated;
        public int userScore = 0;
        public int pcScore = 0;
        public int winningScore = 1;

        public string MoveToWords(int move)
        {
            if (move == 1)
            {
                MoveTranslated = " Rock";
            }
            else if (move == 2)
            {
                MoveTranslated = " Paper";
            }
            else
            {
                MoveTranslated = " Scissors";
            }

            return MoveTranslated;
        }

        public void Game(int userMove)
        {
            Random rnd = new Random();
            pcMove = rnd.Next(1, 4);

            if (userMove == pcMove)
            {
                listBox1.Items.Add("Winning score is: " + winningScore);
                listBox1.Items.Add("Computer: " + pcMove + MoveToWords(pcMove));
                listBox1.Items.Add("You: " + userMove + MoveToWords(userMove));
                listBox1.Items.Add("Draw!");
                label2.Text = "Draw!";
            } else if ((userMove == 1 && pcMove == 3)
                || (userMove == 2 && pcMove == 1) 
                || (userMove == 3 && pcMove == 2)) 
            {
                listBox1.Items.Add("Winning score is: " + winningScore);
                listBox1.Items.Add("Computer: " + pcMove + MoveToWords(pcMove));
                listBox1.Items.Add("You: " + userMove + MoveToWords(userMove));
                listBox1.Items.Add("Win!");
                label2.Text = "Win!";
                userScore = userScore + 1;
            } else
            {
                listBox1.Items.Add("Winning score is: " + winningScore);
                listBox1.Items.Add("Computer: " + pcMove + MoveToWords(pcMove));
                listBox1.Items.Add("You: " + userMove + MoveToWords(userMove));
                listBox1.Items.Add("Loss!");
                label2.Text = "Loss!";
                pcScore = pcScore + 1;
            }

            textBox1.Text = "Score(You - Computer): " + userScore + " - " + pcScore;
            if (userScore >= winningScore)
            {
                MessageBox.Show("You won!\nYour score: " + userScore + "/" + pcScore);
                this.Close();
            } else if (pcScore >= winningScore)
            {
                MessageBox.Show("You lost!\nYour score: " + userScore + "/" + pcScore);
                this.Close();
            }
            
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Game(1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Game(2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Game(3);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            winningScore = Convert.ToInt32(numericUpDown1.Value);
            listBox1.Items.Add("Winning score is: " + winningScore);
        }
    }
}
