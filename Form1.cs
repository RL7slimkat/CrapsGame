using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/*author: RLisasi
 * channel: RL7_slimkat video: Craps game demo C# project
https://youtu.be/ydbEABJJNY4
 */
namespace CrapsGame
{
    public partial class Form1 : Form
    {
        //properties
        bool attempt1Exe = true;
        int attemptX = 0;
        int result1 = 0;
        int result2 = 0;
        int sum = 0;
        Random rnd = new Random();

        //String properties
        String youLose = "You Lose. Play again?";
        String youWin = "You Win, Play again?";
        String youDraw = "You drew";
        String youExit = "Click OK to quit, or cancel to return to the current game";
        String youHelp = "How the game works: The user rolls 2 dice.  If the dice lands on 7 or 11. The user wins.  If the dice land on 2, 3 or 12, the user loses.  If any other number comes up, like 9, that number becomes the point.  The user will next roll as many times as necessary to either hit their point(9), they win, or they hit a 7, they lose.  If any other number comes up, like a 5, the user rolls again….until they hit their point or a 7. ";
        String help = "HELP";
        String exit = "QUIT?";

        //attach images to image objects
        Bitmap LeftDice1 = Properties.Resources.leftDice1;
        Bitmap LeftDice2 = Properties.Resources.leftDice2;
        Bitmap LeftDice3 = Properties.Resources.leftDice3;
        Bitmap LeftDice4 = Properties.Resources.leftDice4;
        Bitmap LeftDice5 = Properties.Resources.leftDice5;
        Bitmap LeftDice6 = Properties.Resources.leftDice6;

        Bitmap RightDice1 = Properties.Resources.rightDice1;
        Bitmap RightDice2 = Properties.Resources.rightDice2;
        Bitmap RightDice3 = Properties.Resources.rightDice3;
        Bitmap RightDice4 = Properties.Resources.rightDice4;
        Bitmap RightDice5 = Properties.Resources.rightDice5;
        Bitmap RightDice6 = Properties.Resources.rightDice6;

        public Form1()
        {
            InitializeComponent();
            setNull();
        }

        public void PlayGame()
        {
            //generate a random number
            GetRandom();
            //if its their first attempt call the method that applies the rules of the first roll
            if (attempt1Exe)
            {
                Roll1();
            }
            else
            {
                //after the first attempt keep rolling with rules for the second roll
                RollX();
            }

            handGif.Enabled = true;
            handGif.Visible = true;
            //timers for animations
            if (dicePickupTimer.Enabled == false && handTimer.Enabled == false && diceThrowTimer.Enabled == false)
            {
                dicePickupTimer.Enabled = true;
                handTimer.Enabled = true;
                diceThrowTimer.Enabled = true;
                //this code prevents timers from being set off unintentionally
            }
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            //set things off with  BUTTON CLICK
            PlayGame();
            btnPlay.Enabled = false;
        }


        private int getX()
        {
            //get stored attempt
            return attemptX;
        }
        //ROLL  XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX
        public void RollX()
        {
            //roll x is any roll after roll1
            getX();
            //x is the first attempt
            int x = attemptX;
            Console.WriteLine("This is the value stored in x: " + x);
            //the stored value equals the new roll they win
            if (sum == x)
            {
                DisplayW();
            }
            //if they roll 7 after roll1 they lose
            if (sum == 7)
            {
                DisplayL();
            }
            //keep drawing if they neither win nor lose
            if (sum != x && sum != 7 && sum != 0)
            {
                DisplayD();

            }

        }//END ROLL XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX

        private void btnRestart_Click(object sender, EventArgs e)
        {
            //restart
            setNull();
        }
        //SET NULL***************************************************************************
        private void setNull()
        {
            //set everything to zero
            attempt1Exe = true;
            attemptX = 0;
            result1 = 0;
            result2 = 0;
            sum = 0;
            //reset all gui controls
            handGif.Enabled = false;
            dicePickupTimer.Enabled = false;
            handTimer.Enabled = false;
            diceThrowTimer.Enabled = false;
            diceBox1.Visible = false;
            diceBox2.Visible = false;
            lblResult.Text = null;
            btnPlay.Enabled = true;
            lammerBox10.Visible = false;
            lammerBox0.Visible = true;
            chipsBox1.Visible = false;
            chipsBox2.Visible = false;
           
        }
        //END SET NULL---------------------------------------------------------------------

        //MESSAGEBOX W & L**************************************************************
        private void DisplayMsgBox(String message, String titleM)
        {
            // exit confirmation prompt
            DialogResult confirmExit = MessageBox.Show($"{message}",
                titleM, MessageBoxButtons.YesNo);

            if (confirmExit == DialogResult.Yes)
            {
                //close the message box
                //setNull();
                btnPlay.Enabled = true;
                //set everything to zero
                attempt1Exe = true;
                //automatically roll the dice foe the user if they choose to play again
               attemptX = GetRandom();  
            }
            else
            {
                this.Close();
            }
        }
        //END MSGBOX-----------------------------------------------------------------

        //DISPLAYS AND RANDOM********************************************************
        public int GetRandom()
        {
            //generate random dice
            result1 = rnd.Next(1, 7);
            result2 = rnd.Next(1, 7);
            //store both dice results in sum
            sum = (result1 + result2);
            return sum;
        }

        public void Display()
        {
            //display to console
            Console.WriteLine($"You rolled {sum}");
        }
        //what happens when you lose
        private void DisplayL()
        {   
            //enable timers
            chipsOffTimer.Enabled = true;
            chipsBox2.Visible = true;
            //show sum
            lblResult.Text = $"{sum}";
            Console.WriteLine($"Sorry, {youLose} {sum}");
            //show message to user
            DisplayMsgBox(youLose, youLose);
            attempt1Exe = true;
        }

        private void DisplayW()
        {   
            //enable timers
            chipsOffTimer.Enabled = true;
            chipsBox1.Visible = true;
            //set lbl result to dice roll
            lblResult.Text = $"Congrats, {youWin} {sum}";
            Console.WriteLine($"Congrats, {youWin} {sum}");
            //show message to user
            DisplayMsgBox(youWin, youWin);

        }
        private void DisplayD()
        {
            //lblResult.Text = $"{youDraw} {sum}, roll again.";
            Console.WriteLine($"{youDraw} {sum}, roll again.");
        }
        //END DISPLAYS------------------------------------------------

        //TIMERS**********************************************************************
        private void handTimer_Tick(object sender, EventArgs e)
        {
            //all the gui for when the dice rolls
            handGif.Enabled = false;
            handGif.Visible = false;
            handTimer.Enabled = false;

        }

        private void diceThrowTimer_Tick(object sender, EventArgs e)
        {
            //all the gui for when the dice images are meant to come out
            setDiceImg();
            diceThrowTimer.Enabled = false;
            diceBox1.Visible = true;
            diceBox2.Visible = true;
            lblResult.Text = $"You rolled {sum}, roll again...";
            lblPoint.Text = attemptX.ToString();
            setLammer();
            lammerBox10.Visible = true;
            lammerBox0.Visible = false;
        }

        private void dicePickupTimer_Tick(object sender, EventArgs e)
        {
            //all the gui for when the dice images dissappear
            diceBox1.Visible = false;
            diceBox2.Visible = false;
            dicePickupTimer.Enabled = false;
            btnPlay.Enabled = true;
        }
        //END TIMERS--------------------------------------------------------------------

        //MISC BUTTONS***************************************************************
        private void btnHelp_Click(object sender, EventArgs e)
        {
            // help prompt 
            DialogResult confirmHelp = MessageBox.Show(youHelp,
                help, MessageBoxButtons.OK);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //DisplayUtilityBox(youExit, exit);
            // exit confirmation prompt
            DialogResult confirmExit = MessageBox.Show($"{youExit}",
                exit, MessageBoxButtons.YesNo);

            if (confirmExit == DialogResult.Yes)
            {
                //Exit
                this.Close();
            }
            else
            {
                //nothing
                btnPlay.Enabled = true;
            }
        }
        //END MISC--------------------------------------------------------------------

        //ROL1********************************************************
        public void Roll1()
        {
            switch (sum)
            {
                case 0:
                    {
                        //null
                        Console.WriteLine("Case is 0");
                        break;
                    }
                case 2:
                case 3:
                case 12:
                    {
                        //if they roll 12 on roll1 they lose
                        DisplayL();
                        break;
                    }
                case 7:
                case 11:
                    {
                        //if they roll 11 they win
                        DisplayW();
                        break;
                    }
                case 4:
                case 5:
                case 6:
                case 8:
                case 9:
                case 10:
                    {
                        //if they draw store their result in attemptX
                        DisplayD();
                        attemptX = sum;
                        break;
                    }
            }
            attempt1Exe = false;

        }//END ROLL1------------------------------------------------------------

        //SET DICE IMG********************************************************
        public void setDiceImg()
        {
            switch (result1)
            {
                case 1:
                    diceBox1.Image = LeftDice1;
                    break;
                case 2:
                    diceBox1.Image = LeftDice2;
                    break;
                case 3:
                    diceBox1.Image = LeftDice3;
                    break;
                case 4:
                    diceBox1.Image = LeftDice4;
                    break;
                case 5:
                    diceBox1.Image = LeftDice5;
                    break;
                case 6:
                    diceBox1.Image = LeftDice6;
                    break;
                default:
                    diceBox1.Image = null;
                    break;
            }

            switch (result2)
            {
                case 1:
                    diceBox2.Image = RightDice1;
                    break;
                case 2:
                    diceBox2.Image = RightDice2;
                    break;
                case 3:
                    diceBox2.Image = RightDice3;
                    break;
                case 4:
                    diceBox2.Image = RightDice4;
                    break;
                case 5:
                    diceBox2.Image = RightDice5;
                    break;
                case 6:
                    diceBox2.Image = RightDice6;
                    break;
                default:
                    diceBox2.Image = null;
                    break;
            }
        }//END SETDICEIMG-----------------------------------------------------

        //SET LAMMER*********************************************************
        public void setLammer()
        {
            switch (attemptX)
            {
                //lammer is the on/off button
                //move the lammer according to what number is drawn
                case 4:
                    lammerBox10.Location = new Point(203, 146);
                    break;
                case 5:
                    lammerBox10.Location = new Point(281, 146);
                    break;
                case 6:
                    lammerBox10.Location = new Point(360, 146);
                    break;
                case 8:
                    lammerBox10.Location = new Point(439, 146);
                    break;
                case 9:
                    lammerBox10.Location = new Point(518, 146);
                    break;
                case 10:
                    lammerBox10.Location = new Point(600, 146);
                    break;
                default:
                    //lammerBox10.Location = new Point(664, 12);
                    lammerBox0.Visible = true;
                    lammerBox10.Location = new Point(816, 489);
                    break;
            }
        }

        private void chipsOffTimer_Tick(object sender, EventArgs e)
        {
            //if user wins/loses they get chips animation
            chipsBox1.Visible = false;
            chipsBox2.Visible = false;
            chipsBox2.Enabled = false;
            chipsBox1.Enabled = false;
        }
    }
}
