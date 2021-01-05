using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Flappy_Bird
{
    public partial class Flappy_Bird : Form
    {
        int pipeSpeed = 8;
        int gravity = 15;
        public static int Score = 0;



        public Flappy_Bird()
        {
            InitializeComponent();
        }

        private void gameTimerEvent(object sender, EventArgs e)
        {

            flappyBird.Top += gravity;
            pipeBottom.Left -= pipeSpeed;
            pipeTop.Left -= pipeSpeed;
            scoreText.Text = "Score: " + Score;

            if(pipeBottom.Left< -150)
            {
                pipeBottom.Left = 800;
            }

            if (pipeTop.Left < -180)
            {
                pipeTop.Left = 950;
                Score++;

            }
            if(flappyBird.Bounds.IntersectsWith(pipeBottom.Bounds) ||
                 flappyBird.Bounds.IntersectsWith(pipeTop.Bounds) ||
                 flappyBird.Bounds.IntersectsWith(ground.Bounds) ||
                 (flappyBird.Top < -25) 
                 )
            {
                endGame();
            }

            if (Score>5)
            {
                pipeSpeed = 15;
            }
        }

        private void GameisDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Space)
            {

                gravity = -15;
            }
        }

        private void GameisUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {

                gravity = 15;
            }
        }
        
        private void endGame()
        {
            gameTimer.Stop();
            Form3 s = new Form3();
            s.Show();
        
        }

        private void Flappy_Bird_Load(object sender, EventArgs e)
        {
            
            
        }
    }
}
