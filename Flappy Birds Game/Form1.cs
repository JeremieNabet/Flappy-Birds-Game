using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Flappy_Birds_Game
{
    public partial class Form1 : Form
    {
        int pipeSpeed = 8;
        int gravity = 5;
        int score = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void gameTimerEvent(object sender, EventArgs e)
        {
            flappyBirds.Top += gravity;
            pipeBottom.Left -= pipeSpeed;
            pipeTop.Left -= pipeSpeed;
            scoreText.Text = "Score: " + score;

            if(pipeBottom.Left < -150)
            {
                pipeBottom.Left = 800;
                score++;
            }
            if(pipeTop.Left < -180)
            {
                pipeTop.Left = 830;
                score++;
            }
            if (flappyBirds.Bounds.IntersectsWith(pipeBottom.Bounds) || 
                flappyBirds.Bounds.IntersectsWith(pipeTop.Bounds) || 
                flappyBirds.Bounds.IntersectsWith(ground.Bounds))
            {
                endGame();
            }

            if(score > 5)
            {
                pipeSpeed = 10;
            }

            if (score > 8)
            {
                pipeSpeed = 12;
            }
            if (score > 15)
            {
                pipeSpeed = 15;
            }

            if (flappyBirds.Top < -25)
            {
                endGame();
            }
        }

        private void gamekeyisdown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Space)
            {
                gravity = -15;
            }

        }

        private void gamekeyisup(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = 15;
            }

        }
        private void endGame()
        {
            gameTimer.Stop();
            scoreText.Text += "   Game Over!!!";
            Form2 form2 = new Form2();
            form2.Show();
            
            
        }
    }
}
