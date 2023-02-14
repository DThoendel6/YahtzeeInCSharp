using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Yahtzee.Model;
/*
 * Author: Dominic Thoendel
 * Program: Yahtzee
*/ 
namespace Yahtzee
{
    public partial class frmYahtzeeGame : Form
    {
        List<Die> dice = new List<Die>(5);
        List<Button> buttons = new List<Button>(5);
        public static Random rand = new Random();
        int rollCounter = 0;
        int totalScore = 0;
        int yahtzeeCounter = 0;
        int turns = 13;
        int yahtzeeTurn = 1;
        User player = new User();

        public frmYahtzeeGame()
        {

            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnLogout_Click(object sender, EventArgs e)
        {
            player = new User();
            ResetBoard();
            pnlRegistration.Visible = true;
            rdoLogin.Checked = true;
            rdoRegister.Checked = true;
            rdoLogin.Checked = true;
            txtUsername.Focus();

        }

        private void frmYahtzeeGame_Load(object sender, EventArgs e)
        {
            Die die = new Die();
            buttons.Add(btnDie1);
            buttons.Add(btnDie2);
            buttons.Add(btnDie3);
            buttons.Add(btnDie4);
            buttons.Add(btnDie5);
            btnRollAgain.Enabled = false;

            for (int id = 1; id < 6; id++)
            {
                die = new Die(id, id, false);
                die.Roll();
                dice.Add(die);
                buttons.ElementAt(die.DieId - 1).Text = "";//(die.DotCount).ToString();
                buttons.ElementAt(die.DieId - 1).Image = die.GetDieImage();
            }

        }


        private void btnNext_Click(object sender, EventArgs e)
        {
            
            ClearCheckBoxes();
            if (btnNext.Text == "&Play")
            {
                lblGoodLuck.Text = "Good Luck " + player.Username + "!";
                lblTheHighScore.Text = YahtzeeDA.getTheHighScore().ToString();
                lblYourHighScore.Text = player.UserHighScore.ToString();
                player.UserNumberOfGamesPlayed++;
                //change btn text
                ResetBoard();
                btnNext.Text = "&Next Round";
            }
            player.CanScore = true;
            rollCounter = 1;
            btnRollAgain.Enabled = true;
            btnNext.Enabled = false;
            //Fill dice
            RollDice();

        }

        private void RollDice()
        {
            foreach (Die d in dice)
            {
                d.Roll();
                buttons.ElementAt(d.DieId - 1).Image = d.GetDieImage(); 
            }
        }

        private void btnRollAgain_Click(object sender, EventArgs e)
        {
            if (rollCounter < 4)
            {
                rollCounter++;
                RollDice();
                if (rollCounter == 3)
                {
                    btnRollAgain.Enabled = false;
                    btnNext.Enabled = false;
                }
            }
        }
        /********************   **************************************/
        /********************  EVENT START  **************************************/

        private void chkDie1_CheckedChanged(object sender, EventArgs e)
        {
            if (dice.ElementAt(0).Hold == false)
                dice.ElementAt(0).Hold = true;
            else if (dice.ElementAt(0).Hold == true)
                dice.ElementAt(0).Hold = false;
        }
        private void chkDie2_CheckedChanged(object sender, EventArgs e)
        {
            if (dice.ElementAt(1).Hold == false)
                dice.ElementAt(1).Hold = true;
            else if (dice.ElementAt(1).Hold == true)
                dice.ElementAt(1).Hold = false;
        }
        private void chkDie3_CheckedChanged(object sender, EventArgs e)
        {
            if (dice.ElementAt(2).Hold == false)
                dice.ElementAt(2).Hold = true;
            else if (dice.ElementAt(2).Hold == true)
                dice.ElementAt(2).Hold = false;
        }
        private void chkDie4_CheckedChanged(object sender, EventArgs e)
        {
            if (dice.ElementAt(3).Hold == false)
                dice.ElementAt(3).Hold = true;
            else if (dice.ElementAt(3).Hold == true)
                dice.ElementAt(3).Hold = false;
        }
        private void chkDie5_CheckedChanged(object sender, EventArgs e)
        {
            if (dice.ElementAt(4).Hold == false)
                dice.ElementAt(4).Hold = true;
            else if (dice.ElementAt(4).Hold == true)
                dice.ElementAt(4).Hold = false;
        }
        /********************  TOOL TIP START **************************************/
        private void label8_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(label8, "Adds all of the dice together");
        }
        private void txtOnes_MouseHover(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            DoToolTip(textBox);

        }
        private void txtTwos_MouseHover(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            DoToolTip(textBox);
        }
        private void txtThrees_MouseHover(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            DoToolTip(textBox);
        }
        private void txtFours_MouseHover(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            DoToolTip(textBox);
        }
        private void txtFives_MouseHover(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            DoToolTip(textBox);
        }
        private void txtSixs_MouseHover(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            DoToolTip(textBox);
        }
        private void txtThreeOfKind_MouseHover(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            DoToolTip(textBox);
        }
        private void txtFourOfKind_MouseHover(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            DoToolTip(textBox);
        }
        private void txtFullHouse_MouseHover(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            DoToolTip(textBox);
        }
        private void txtSmallStraight_MouseHover(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            DoToolTip(textBox);
        }
        private void txtLargeStraight_MouseHover(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            DoToolTip(textBox);
        }
        private void txtChance_MouseHover(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            DoToolTip(textBox);
        }
        private void txtYahtzee_MouseHover(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            DoToolTip(textBox);
        }
        /********************  TOOL TIP END **************************************/
        /********************  TEXT BOX CLICK EVENT START **************************************/
        private void txtOnes_MouseClick(object sender, MouseEventArgs e)
        {
            if (player.CanScore)
            {
                TextBox textBox = (TextBox)sender;
                DoTextBoxStuff(textBox);
            }
        }
        private void txtTwos_MouseClick(object sender, MouseEventArgs e)
        {
            if (player.CanScore)
            {
                TextBox textBox = (TextBox)sender;
                DoTextBoxStuff(textBox);
            }
        }
        private void txtThrees_MouseClick(object sender, MouseEventArgs e)
        {
            if (player.CanScore)
            {
                TextBox textBox = (TextBox)sender;
                DoTextBoxStuff(textBox);
            }
        }
        private void txtFours_MouseClick(object sender, MouseEventArgs e)
        {
            if (player.CanScore)
            {
                TextBox textBox = (TextBox)sender;
                DoTextBoxStuff(textBox);
            }
        }
        private void txtFives_MouseClick(object sender, MouseEventArgs e)
        {
            if (player.CanScore)
            {
                TextBox textBox = (TextBox)sender;
                DoTextBoxStuff(textBox);
            }
        }
        private void txtSixs_MouseClick(object sender, MouseEventArgs e)
        {
            if (player.CanScore)
            {
                TextBox textBox = (TextBox)sender;
                DoTextBoxStuff(textBox);
            }
        }
        private void txtChance_MouseClick(object sender, MouseEventArgs e)
        {
            if (player.CanScore)
            {
                TextBox textBox = (TextBox)sender;
                DoTextBoxStuff(textBox);
            }
        }
        private void txtThreeOfKind_MouseClick(object sender, MouseEventArgs e)
        {
            if (player.CanScore)
            {
                TextBox textBox = (TextBox)sender;
                DoTextBoxStuff(textBox);
            }
        }
        private void txtFourOfKind_MouseClick(object sender, MouseEventArgs e)
        {
            if (player.CanScore)
            {
                TextBox textBox = (TextBox)sender;
                DoTextBoxStuff(textBox);
            }
        }
        private void txtFullHouse_MouseClick(object sender, MouseEventArgs e)
        {
            if (player.CanScore)
            {
                TextBox textBox = (TextBox)sender;
                DoTextBoxStuff(textBox);
            }
        }
        private void txtSmallStraight_MouseClick(object sender, MouseEventArgs e)
        {
            if (player.CanScore)
            {
                TextBox textBox = (TextBox)sender;
                DoTextBoxStuff(textBox);
            }
        }
        private void txtLargeStraight_MouseClick(object sender, MouseEventArgs e)
        {
            if (player.CanScore)
            {
                TextBox textBox = (TextBox)sender;
                DoTextBoxStuff(textBox);
            }
        }
        private void txtYahtzee_MouseClick(object sender, MouseEventArgs e)
        {
            if (player.CanScore)
            {
                TextBox textBox = (TextBox)sender;
                DoTextBoxStuff(textBox);
            }

        }
        /********************  TEXT BOX CLICK EVENT END **************************************/
        private void DoTextBoxStuff(TextBox textBox)
        {   //When a textbox is clicked, the score is entered and the textbox is disabled.
            //Unless the textbox is Yahtzee, then it is only disabled if you click it without a yahtzee.
            int score;
            int tempScore;
            score = CalculateScore.CalcScore(textBox.Tag.ToString(), dice, yahtzeeCounter);
            totalScore += score;
            lblTotalScore.Text = totalScore.ToString();
            if (textBox.Tag.ToString() == "yahtzee")
            {
                tempScore = score;

                if (tempScore == 0)
                {   //if you don't have a yahtzee, but you click it.
                    score = ((yahtzeeCounter - 1) * 100) + 50;
                    if (score == -50)//yahtzee was clicked with a false yahtzee and no previous yahtzees
                    {
                        score = 0;
                        turns -= yahtzeeTurn;
                        yahtzeeTurn -= yahtzeeTurn;
                        ClearCheckBoxes();
                    }
                    
                    //the box will be disabled, but the turn will not end
                    textBox.Enabled = false;
                }
                else
                {   //yahtzee is true
                    score = (yahtzeeCounter * 100) + 50;
                    yahtzeeCounter++;
                    ClearCheckBoxes();
                    turns -= yahtzeeTurn;
                    yahtzeeTurn -= yahtzeeTurn;

                }

            }
            else
            {   //any box that's not yahtzee
                ClearCheckBoxes();
                textBox.Enabled = false;
                turns--;

            }
            textBox.Text = score.ToString();
            lblTurns.Text = turns.ToString();
            btnNext.Text = "&Next Round";

            if (turns == 0)
            {   //game ends
                MessageBox.Show("Congratulations! \nYou scored " + totalScore.ToString() + " points!");
                if (totalScore > player.UserHighScore)
                {
                    player.UserHighScore = totalScore;
                    MessageBox.Show("Holy Moly! You got a new high score!");
                    lblYourHighScore.Text = player.UserHighScore.ToString();
                    Game.UpdateScores(player);
                }

                if(player.UserHighScore > YahtzeeDA.getTheHighScore())
                {
                    MessageBox.Show("Holy Moly! You got a new high score!");
                    lblTheHighScore.Text = player.UserHighScore.ToString();
                }

                btnNext.Text = "&Play";
            }
            btnNext.Focus();
        }
        private void ClearCheckBoxes()
        {
            chkDie1.Checked = false;
            chkDie2.Checked = false;
            chkDie3.Checked = false;
            chkDie4.Checked = false;
            chkDie5.Checked = false;
            player.CanScore = false;
            btnRollAgain.Enabled = false;
            btnNext.Enabled = true;
        }
        private void ResetBoard()
        {
            totalScore = 0;
            rollCounter = 0;
            yahtzeeCounter = 0;
            turns = 13;
            yahtzeeTurn = 1;
            player.CanScore = false;
            lblTotalScore.Text = 0.ToString();
            lblTurns.Text = turns.ToString();
            ClearCheckBoxes();
            player.CanScore = false;
            txtOnes.Text = "";
            txtOnes.Enabled = true;
            txtTwos.Text = "";
            txtTwos.Enabled = true;
            txtThrees.Text = "";
            txtThrees.Enabled = true;
            txtFours.Text = "";
            txtFours.Enabled = true;
            txtFives.Text = "";
            txtFives.Enabled = true;
            txtSixs.Text = "";
            txtSixs.Enabled = true;
            txtThreeOfKind.Text = "";
            txtThreeOfKind.Enabled = true;
            txtFourOfKind.Text = "";
            txtFourOfKind.Enabled = true;
            txtFullHouse.Text = "";
            txtFullHouse.Enabled = true;
            txtSmallStraight.Text = "";
            txtSmallStraight.Enabled = true;
            txtLargeStraight.Text = "";
            txtLargeStraight.Enabled = true;
            txtChance.Text = "";
            txtChance.Enabled = true;
            txtYahtzee.Text = "";
            txtYahtzee.Enabled = true;
            btnNext.Enabled = true;
            btnNext.Text = "&Play";
            btnRollAgain.Enabled = false;
        }
        private void DoToolTip(TextBox textBox)
        {
            int score;
            score = CalculateScore.CalcScore(textBox.Tag.ToString(), dice, yahtzeeCounter);
            toolTip1.SetToolTip(textBox, score.ToString());
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ResetBoard();
        }
        /////////////// START PANEL ////////////////////
        private void rdoRegister_CheckedChanged(object sender, EventArgs e)
        {
            lblConfirm.Visible = true;
            txtPasswordConfirm.Visible = true;
            lblPassConfirmWarning.Visible = true;
            ClearLoginBoxes();
        }

        private void rdoLogin_CheckedChanged(object sender, EventArgs e)
        {
            lblConfirm.Visible = false;
            txtPasswordConfirm.Visible = false;
            lblPassConfirmWarning.Visible = false;
            ClearLoginBoxes();
        }
        private void ClearLoginBoxes()
        {
            txtUsername.Text = "";
            txtPassword.Text = "";
            txtPasswordConfirm.Text = "";
        }
    
        private void btnSignIn_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            bool usernamePass = true;
            string password = txtPassword.Text;
            bool passwordPass = true;
            string passwordConfirm;
            if (rdoRegister.Checked)
            {

                    if (YahtzeeDA.CheckUsernameAvailability(username))//if the name is available...
                    {
                        usernamePass = true;
                        passwordConfirm = txtPasswordConfirm.Text;
                        //check password
                        if (password == passwordConfirm)
                        {   //if passwords match, check credentials
                            if (password == "")
                            {
                                lblPassWarning.Text = "Password must be 3-50 characters long,\nmust contain a lower and upper case letter,\n and must contain a number";
                                passwordPass = false;
                            }
                            else if (new Regex(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)[a-zA-Z\d]{3,}$").IsMatch(password) == false)
                            {
                                lblPassWarning.Text = "Password must be 3-50 characters long,\nmust contain a lower and upper case letter,\n and must contain a number";
                                passwordPass = false;
                            }
                        }
                        else
                        {   //if passwords don't match
                            lblPassConfirmWarning.Text = "Passwords do not match";
                            passwordPass = false;
                        }

                    }
                    else if (username == "")
                    {
                        lblUsernameWarning.Text = "Enter a username";
                        usernamePass = false;
                    }
                    else//username is taken
                    {
                        lblUsernameWarning.Text = "Username taken. try again";
                        usernamePass = false;
                    }

                    if (usernamePass && passwordPass)
                    {   //user registers, User = user, add user to DB
                        player = new User();
                        player.UserId = 1;
                        player.Username = username;
                        player.UserHighScore = 0;
                        player.UserNumberOfGamesPlayed = 0;
                        YahtzeeDA.AddPlayer(player, password);
                        //GAME START
                        pnlRegistration.Hide();
                    }
                    else
                    {
                        txtPassword.Text = "";
                        txtPasswordConfirm.Text = "";
                        txtPassword.Focus();
                    }
                
            }
            else if (rdoLogin.Checked)
            {
                passwordConfirm = password;
                if (!YahtzeeDA.CheckUsernameAvailability(username))//if the name is available...
                {
                    usernamePass = true;
                    passwordConfirm = txtPasswordConfirm.Text;
                    //check password
                    if (password == "")
                    {
                        lblPassWarning.Text = "Password must be 3-50 characters long,\nmust contain a lower and upper case letter,\n and must contain a number";
                        passwordPass = false;
                    }
                    else if (new Regex(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)[a-zA-Z\d]{3,}$").IsMatch(password) == false)
                    {
                        lblPassWarning.Text = "Password must be 3-50 characters long,\nmust contain a lower and upper case letter,\n and must contain a number";
                        passwordPass = false;
                    }
                    
                    if (passwordPass) { 
                        if (YahtzeeDA.CheckPassword(username, password))
                        {   //skips accessing the DB if the password doesn't even meet requirements
                            //User Signed In!
                            passwordPass = true;
                        }
                        else
                        {
                            lblPassWarning.Text = "Username or Password did not match";
                            passwordPass = false;
                        }
                    }
                }
                else//username is taken
                {
                    lblUsernameWarning.Text = "Username not found. try again";
                    passwordPass = false;
                }
                if (usernamePass && passwordPass)
                {   //user registers, User = user, add user to DB
                    player = new User();
                    player = YahtzeeDA.GetUser(username);
                    
                    //GAME START
                    pnlRegistration.Hide();
                    
                }
                else
                {
                    txtPassword.Text = "";
                    txtPassword.Focus();
                }
            }           
        }
        //////////////// END PANEL /////////////////////
    }
}
