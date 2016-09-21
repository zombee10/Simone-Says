//Programer John Monnin and Kayla Cole
//09.21.16
//VS C#
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace simon_Game
{
    public partial class frmSimon : Form
    {
        public frmSimon()//Starts up the form
        {
            InitializeComponent();
        }

        int onInList = 0;//List of the colors that are generated
        List<int> pattern = new List<int>();//Starts a new list for a chain
        Random rand = new Random();//Declares the random number generator seed
        bool playingBack = false;//If the pattern is playing back or not
     

        private void btnRed_Click(object sender, EventArgs e)//Tests to see if you clicked the correct button
        {
            testCorrect(0);
        }

        private void btnblue_Click(object sender, EventArgs e)
        {
            testCorrect(1);
        }

        private void btnGreen_Click(object sender, EventArgs e)
        {
            testCorrect(2);
        }

        private void btnYelow_Click(object sender, EventArgs e)
        {
            testCorrect(3);
        }

        void testCorrect(int color)//function that checks to see if the buttons are pressed in the corect order
        {
            if (playingBack)
                return;
            if (pattern[onInList] == color)//Checks to see if the color is on the list in the correct order
            {
                onInList++;//Updates the score and adds another color to the pattern
            }
            else
            {
                MessageBox.Show("You fail! Final Score: " + pattern.Count.ToString());//If you are incorrect on the pattern
                onInList = 0;//Resets the list to 0
                pattern = new List<int>();// Creates a new list
                new Thread(playback).Start();//Starts
            }
            if (onInList >= pattern.Count)//Adds another color to the pattern
            {
                pattern.Add(rand.Next(0, 4));//Adds Red, Green, Yellow, Blue
                onInList = 0;
                new Thread(playback).Start();
            }
            ScoreLabel.Text = ("Score: " + pattern.Count.ToString());//Changes the score
            PatternLabel.Text = ("Items within pattern: " + onInList.ToString());/// Adds the pattern to the chain
        }


        
        void playback()//Lights up the buttons
        {
            playingBack = true;
            foreach(int color in pattern)
            {
                switch(color)
                {
                    case 0:
                        btnRed.BackColor = Color.Red;
                        Thread.Sleep(200);
                        btnRed.BackColor = Color.Transparent;
                        break;
                    case 1:
                        btnblue.BackColor = Color.Blue;
                        Thread.Sleep(200);
                        btnblue.BackColor = Color.Transparent;
                        break;
                    case 2:
                        btnGreen.BackColor = Color.Green;
                        Thread.Sleep(200);
                        btnGreen.BackColor = Color.Transparent;
                        break;
                    case 3:
                        btnYelow.BackColor = Color.Yellow;
                        Thread.Sleep(200);
                        btnYelow.BackColor = Color.Transparent;
                        break;
                }
                Thread.Sleep(200);
            }
            playingBack = false;    
        }
        private void Form1_Load(object sender, EventArgs e)//Starts the seed
        {
            pattern.Add(rand.Next(0, 4));
            new Thread(playback).Start();
        }
    }
}
