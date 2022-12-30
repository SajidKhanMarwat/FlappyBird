using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlappyBird
{
    public partial class FPBird : Form
    {
        int pipeSpeed = 8;
        int gravity = 7;
        int score = 0;

        int gamePause = 0;

        public FPBird()
        {
            InitializeComponent();

            //this.MaximumSize = new System.Drawing.Size(300, 500);

            this.MaximizeBox = false;
            lblPause.Hide();

            // Making player (picturebox) transparent
            //_player.BackColor = Color.Transparent;

            

            //KeyEventArgs e = new KeyEventArgs(Keys.Space);
            //if (e.KeyCode == Keys.Space)
            //{
            //    lblInitial.Hide();
            //    gameTimer.Start();
            //    GameCode();
            //}
        }

        private void lblExit_Click(object sender, EventArgs e)
        {

            //MessageBox Before Closing Application

            DialogResult = MessageBox.Show("Are you sure to exit?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (DialogResult == DialogResult.Yes)
            {
                Application.Exit();
            }            
        }

        private void player_Click(object sender, EventArgs e)
        {

        }

        private void GameTimerEvent(object sender, EventArgs e)
        {
            GameCode();

            if (score > 5)
            {
                gameTimer.Interval = 20;
            }
            if(score > 10)
            {
                gameTimer.Interval = 10;
            }
            if (score > 20)
            {
                gameTimer.Interval = 5;
            }
        }

        private void GameKeyIsDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = -8;
            }

            if (e.KeyCode == Keys.Alt && e.KeyCode == Keys.F4)
            {
                Application.Exit();
            }

            if (e.KeyCode == Keys.Escape)
            {
                lblPause.Show();
                gameTimer.Stop();

            }

        }

        private void GameKeyIsUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = 5;
            }
        }
        public void GameCode()
        {
            _Player.Top += gravity;

            pipeBottom.Left -= pipeSpeed;
            pipeTop.Left -= pipeSpeed;

            _Score.Text = Convert.ToString(score);
            if (pipeBottom.Left < -50 && pipeTop.Left < -50)
            {
                _Score.Text = Convert.ToString(score++);
                pipeBottom.Left = 570;
                pipeTop.Left = 570;
            }

            if (_Player.Bounds.IntersectsWith(pipeBottom.Bounds)
                || _Player.Bounds.IntersectsWith(pipeTop.Bounds)
                || _Player.Bounds.IntersectsWith(ground.Bounds)
                )
            {
                EndGame();
            }
        }

       public void EndGame()
        {
            gameTimer.Stop();
            label1.Hide();
            _Score.Text = null;
            _Score.Text += " Game Over";


            Close close = new Close();

            //this.Hide();

            

            close.Show();


            //if (DialogResult.Yes == MessageBox.Show("Want to start the Game Again?", "Game Over", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            //{
            //    FPBird newGame = new FPBird();
            //    this.Hide();
                
            //    newGame.Show();

            //    //InitializeComponent();
            //}
            //else
            //{
            //    Application.Exit();
            //}
        }

        private void label2_Click(object sender, EventArgs e)
        {

            gameTimer.Stop();
            if ( DialogResult.Yes == MessageBox.Show("Are you sure you want to exit?", "Close", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation))
            {
                Application.Exit();
            }
            else
            {
                gameTimer.Start();
            }
                         
        }

        //private void Alt_F4ButtonPress(object sender, KeyPressEventArgs e)
        //{
        //    if (e.KeyCode == Keys.Alt && e.KeyChar == Keys.F4)
        //    {

        //    }
        //}
    }
}
