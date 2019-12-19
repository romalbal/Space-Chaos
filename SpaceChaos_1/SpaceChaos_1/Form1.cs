using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpaceChaos_1
{
    public partial class frmSpaceChaos : Form
    {
        //global variables
        
        //This creates bool variables to detect if the corresponding direction key is pressed and activated (true or false)
        bool Left;
        bool Right;
        bool Up;
        bool Down;
        bool Enter;

        //create variables for speed of meteors falling down
        int Speed1 = 2;
        int Speed2 = 5;
        int Speed3 = 4;  
        int Speed4 = 8;
        int Speed5 = 1;

        //create variable that sets speed of SpaceShip which the user controls
        int PlayerSpeed = 6;

        //create variable that generates random x value
        Random RandomXValue;
        
        //create variables, used to increase score as the game is still being played
        int Seconds = 0;
        int Ms = 0;

        //create variable for speed of Power Up falling down
        int SpeedPowerUp = 4;


        public frmSpaceChaos()
        {
            InitializeComponent();
        }

        private void tmrGame_Tick(object sender, EventArgs e)
        {

            //Moves space ship left 
            if (Left)
            {
                picSpaceShip.Left -= PlayerSpeed;
                
                //if spaceship touches left part of screen, it automatically comes out of the right side of the screen
                if (picSpaceShip.Left <= -5)
                {
                    picSpaceShip.Left = 665;
                }
            //moves space ship right
            }
            else if (Right)
            {
                picSpaceShip.Left += PlayerSpeed;

                //if space ship touches right side of screen, it automatically comes out of the left side of the screen
                if (picSpaceShip.Left >= 665)
                {
                    picSpaceShip.Left = -5;
                }
            }
            //moes space ship up
            else if (Up)
            {
                picSpaceShip.Top -= PlayerSpeed;

                //space ship cannot exceed top of the screen
                if (picSpaceShip.Top < 25)
                {
                    picSpaceShip.Top = 25;
                }
            }
            //moves space ship down
            else if (Down)
            {
                picSpaceShip.Top += PlayerSpeed;

                //space ship cannot go lower than the screen
                if (picSpaceShip.Top >= 395)
                {
                    picSpaceShip.Top = 395;
                }
            }


            //This makes meteors and powerups fall at their respective speeds set at the top
            picMeteor1.Top += Speed1;
            picMeteor2.Top += Speed2;
            picMeteor3.Top += Speed3;
            picMeteor4.Top += Speed4;
            picMeteor5.Top += Speed5;
            picPowerUp.Top += SpeedPowerUp;
            

            //This creates a random x value for the obstacles / power ups to spawn at
            RandomXValue = new Random();
            int XLocation = RandomXValue.Next(1, 650);

            //bring meteor1 back to the top, at random x location, if it hits the bottom of the screen (while increasing speed by 1)
            if (picMeteor1.Top > 448)
            {
                picMeteor1.Top = 25;
                picMeteor1.Left = XLocation;
                Speed1 = Speed1 + 1;

                //max speed will be 12, cannot exceed that
                if (Speed1 >= 12)
                {
                    Speed1 = 12;
                }
            }

            //bring meteor2 back to the top, at random x location, if it hits the bottom of the screen (while increasing speed by 1)
            if (picMeteor2.Top > 448)
            {
                picMeteor2.Top = 25;
                Speed2 = Speed2 + 1;
                picMeteor2.Left = XLocation;

                //max speed will be 12, cannot exceed that
                if (Speed2 >= 12)
                {
                    Speed2 = 12;
                }
            }

            //bring meteor3 back to the top, at random x location, if it hits the bottom of the screen (while increasing speed by 1)
            if (picMeteor3.Top > 448)
            {
                picMeteor3.Top = 25;
                Speed3 = Speed3 + 1;
                picMeteor3.Left = XLocation;

                //max speed will be 12, cannot exceed that
                if (Speed3 >= 12)
                {
                    Speed3 = 12;
                }
            }

            //bring meteor4 back to the top, at random x location, if it hits the bottom of the screen (while increasing speed by 1)
            if (picMeteor4.Top > 448)
            {
                picMeteor4.Top = 25;
                Speed4 = Speed4 + 1;
                picMeteor4.Left = XLocation;

                //max speed will be 12, cannot exceed that
                if (Speed4 >= 12)
                {
                    Speed4 = 12;
                }
            }

            //bring meteor5 back to the top, at random x location, if it hits the bottom of the screen (while increasing speed by 1)
            if (picMeteor5.Top > 448)
            {
                picMeteor5.Top = 25;
                Speed5 = Speed5 + 1;
                picMeteor5.Left = XLocation;

                //max speed will be 12, cannot exceed that
                if (Speed5 >= 12)
                {
                    Speed5 = 12;
                }
            }
            
            //make power up spawn every interval of 30, in regards to score
            if (Seconds % 30 == 0 && Seconds != 0)
            {
                picPowerUp.Visible = true;
                
                if (picPowerUp.Top >= 450)
                {
                    picPowerUp.Top = 25;
                }
            }

            //if spaceship touches powerup, multiply the score by 2 
            foreach (Control Z in this.Controls)
            {
                if (Z is PictureBox && Z.Tag == "PowerUp")
                {
                    if (((PictureBox)Z).Bounds.IntersectsWith(picSpaceShip.Bounds) && Z.Visible == true)
                    {  
                        Z.Visible = false;
                        Seconds = Seconds * 2;  
                    }
                }
            }

            //end game if meteor hits spaceship
            foreach (Control X in this.Controls)
            {
                if (X is PictureBox && X.Tag == "Obstacle")
                {
                    if (((PictureBox)X).Bounds.IntersectsWith(picSpaceShip.Bounds))
                    {
                        Gameover();
                    }
                }
            }

            //code to increase score as the game is being played, and display it
            lblGameScore.Text = "Score: " + Seconds;
            Ms++;
            if (Ms >= 10)
            {
                Seconds++;
                Ms = 0;
            }
        }
        
        //Gameover method to end game if meteor hits space ship
        private void Gameover()
        {
            tmrGame.Stop();

            lblGameOver.Visible = true;
            lblGameOver.Text = "Game Over!";

            lblPlayAgain.Visible = true;

            lblFinalScore.Visible = true;
            lblFinalScore.Text = "Final Score: " + Seconds;
            lblFinalScore.Left = (ClientSize.Width - lblFinalScore.Width) / 2;
        }

        private void StartGame()
        {
            //set all values of variables and locations / visibility of objects to default

            picPowerUp.Visible = false;
            picPowerUp.Top = 25;
            
            lblPlayAgain.Visible = false;
            lblGameOver.Visible = false;
            lblFinalScore.Visible = false;

            Speed1 = 2;
            Speed2 = 5;
            Speed3 = 4;
            Speed4 = 8;
            Speed5 = 1;
            
            Seconds = 0;
            Ms = 0;

            picMeteor1.Top = 25;
            picMeteor2.Top = 25;
            picMeteor3.Top = 25;
            picMeteor4.Top = 25;
            picMeteor5.Top = 25;

            picMeteor1.Left = RandomXValue.Next(1, 650);
            picMeteor2.Left = RandomXValue.Next(1, 650);
            picMeteor3.Left = RandomXValue.Next(1, 650);
            picMeteor4.Left = RandomXValue.Next(1, 650);
            picMeteor5.Left = RandomXValue.Next(1, 650);

            picSpaceShip.Left = (ClientSize.Width - picSpaceShip.Width) / 2;
            picSpaceShip.Top = 395;
        }

        //enable the spaceship to move once an appropriate key is clicked, since the bool expression will be set to true for that corresponding direction
        private void KeyisDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                Left = true;
            }
            if (e.KeyCode == Keys.Right)
            {
                Right = true;
            }
            if (e.KeyCode == Keys.Up)
            {
                Up = true;
            }
            if (e.KeyCode == Keys.Down)
            {
                Down = true;
            }
            if (e.KeyCode == Keys.Enter)
            {
                Enter = true;

            }

            if (Enter)
            {
                StartGame();
                tmrGame.Enabled = true;
            }
        }

        //do not allow user to move spaceship if key is no longer pressed
        private void KeyisUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                Left = false; 
            }
            if (e.KeyCode == Keys.Right)
            {
                Right = false;
            }
            if (e.KeyCode == Keys.Up)
            {
                Up = false;
            }
            if (e.KeyCode == Keys.Down)
            {
                Down = false;
            }
           if (e.KeyCode == Keys.Enter)
           {
               Enter = false;
           }
        }

        //restart game if user clicks restart menu button
        private void mnuFileRestart_Click(object sender, EventArgs e)
        {
            StartGame();
            tmrGame.Enabled = true;
        }

        //close game if exit is clicked
        private void mnuFileExit_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        //show rules of the game in messagebox if rules menu option is clicked
        private void mnuRules_Click(object sender, EventArgs e)
        {
            MessageBox.Show("These are the rules");
        }

        private void frmSpaceChaos_Load(object sender, EventArgs e)
        {
            
        }

        private void picMeteor4_Click(object sender, EventArgs e)
        {

        }

        private void picMeteor1_Click(object sender, EventArgs e)
        {

        }

        private void lblGameScore_Click(object sender, EventArgs e)
        {

        }
        private void SlowDown()
        {
            
        }

        private void mnuFile_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }


    }
}
