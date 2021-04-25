using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
        bool canScore = false;
        int highScore = 0;

        public frmYahtzeeGame()
        {

            InitializeComponent();
        }



        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
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
                buttons.ElementAt(die.DieId - 1).Text = (die.DotCount).ToString();

            }

        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            ClearCheckBoxes();
            if (btnNext.Text == "Play")
            {
                //change btn text
                ResetBoard();
                btnNext.Text = "Next Round";
            }
            canScore = true;
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
                buttons.ElementAt(d.DieId - 1).Text = (d.DotCount).ToString();
            }
        }

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

        private void btnRollAgain_Click(object sender, EventArgs e)
        {
            if (rollCounter < 4)
            {
                rollCounter++;
                RollDice();
                if (rollCounter == 3)
                {
                    btnRollAgain.Enabled = false;
                    btnNext.Enabled = true;
                }
            }
        }
        /********************  CALC SCORE START **************************************/
        private int CalcScore(string type)
        {
            int score = 0;
            int searchCriteria;
            int[] numbers = new int[5];
            int fullHouseMatch3;
            int i = 0;
            foreach (Die d in dice)
            {
                if (type == "ones")
                {
                    if (d.DotCount == 1)
                    {
                        score += 1;
                    }
                } else if (type == "twos")
                {
                    if (d.DotCount == 2)
                    {
                        score += 2;
                    }
                } else if (type == "threes")
                {
                    if (d.DotCount == 3)
                    {
                        score += 3;
                    }
                } else if (type == "fours")
                {
                    if (d.DotCount == 4)
                    {
                        score += 4;
                    }
                } else if (type == "fives")
                {
                    if (d.DotCount == 5)
                    {
                        score += 5;
                    }
                } else if (type == "sixs")
                {
                    if (d.DotCount == 6)
                    {
                        score += 6;
                    }
                } else if (type == "chance")
                {
                    score += d.DotCount;
                }
                numbers[i] = d.DotCount;
                i++;
            }
            //search through array to find repeating numbers. Factor score for variable answers
            Array.Sort(numbers);
            
            if (score == 0)
            {
                for (int n = 0; n < 5; n++)
                {
                    searchCriteria = numbers[n];
                    try
                    {
                        if (numbers[n + 1] == searchCriteria)
                        {   //if the first 2 numbers in the sorted array are equal, it will check the 3rd number
                            //if 3 numbers are equal to each other, that fits the criteria for the rest
                            //of the score boxes until 4-of-a-kind or yahtzee.

                            if (numbers[n + 2] == searchCriteria)
                            {   //if you've made it this far, you found your 3-of-a-kind!
                                if (type == "threeOfAKind")
                                {
                                    foreach (Die d in dice)
                                    {
                                        score += d.DotCount;
                                    }
                                    return score;
                                }
                                if (type == "fullHouse")
                                {
                                    fullHouseMatch3 = searchCriteria;//example if there are 3 4's, will search 
                                    for(int b = 0; b < 5; b++)      //through the array again for 2 of the same number that is not 4.
                                    {
                                        if (numbers[b] != fullHouseMatch3)
                                        {
                                            if (numbers[b + 1] == numbers[b])
                                            {   //Full House!
                                                return 25;
                                            }
                                        }

                                    }

                                }
                                if (numbers[n + 3] == searchCriteria)
                                {   //4-of-a-kind
                                    if (type == "fourOfAKind")
                                    {
                                        foreach (Die d in dice)
                                        {
                                            score += d.DotCount;
                                        }
                                        return score;
                                    }
                                    if (numbers[n + 4] == searchCriteria)
                                    {   //YAHTZEE!
                                        if (type == "yahtzee")
                                        {
                                            if (yahtzeeCounter > 0)
                                            {
                                                score = 100;
                                            } else if (yahtzeeCounter == 0)
                                            {
                                                score = 50;
                                            }
                                        }
                                        return score;
                                    }
                                }
                            }
                        }
                        else if(numbers[n + 1] == searchCriteria+1)//works 11234. 
                        {
                            if(numbers[n+2]== searchCriteria + 2)//breaks 12234
                            {
                                if (numbers[n + 3] == searchCriteria + 3)//doesn't work for 12334.
                                {   //small straight
                                    if (type == "smallStraight")
                                    {
                                        return 30;
                                    }

                                    if (numbers[n + 4] == searchCriteria + 4)
                                    {   //large straight
                                        if (type == "largeStraight")
                                        {
                                            return 40;
                                        }
                                    }
                                }
                                else if (numbers[n + 3] == searchCriteria + 2)//passes 12334
                                {
                                    if (numbers[n + 4] == searchCriteria + 3)
                                    {
                                        if (type == "smallStraight")
                                        {
                                            return 30;
                                        }
                                    }
                                }
                            }
                            else if (numbers[n + 3] == searchCriteria + 2)//passes 12234
                            {
                                if (numbers[n + 4] == searchCriteria + 3)//12234
                                {
                                    if (type == "smallStraight")
                                    {
                                        return 30;
                                    }
                                }
                            }
                        }
                    } catch (IndexOutOfRangeException e)
                    {

                    }
                }
            }

            return score;
        }
        /********************  CALC SCORE END **************************************/
        /********************  TOOL TIP START **************************************/
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
            if (canScore)
            {
                TextBox textBox = (TextBox)sender;
                DoTextBoxStuff(textBox);
            }
        }

        private void txtTwos_MouseClick(object sender, MouseEventArgs e)
        {
            if (canScore)
            {
                TextBox textBox = (TextBox)sender;
                DoTextBoxStuff(textBox);
            }
        }

        private void txtThrees_MouseClick(object sender, MouseEventArgs e)
        {
            if (canScore)
            {
                TextBox textBox = (TextBox)sender;
                DoTextBoxStuff(textBox);
            }
        }

        private void txtFours_MouseClick(object sender, MouseEventArgs e)
        {
            if (canScore)
            {
                TextBox textBox = (TextBox)sender;
                DoTextBoxStuff(textBox);
            }
        }

        private void txtFives_MouseClick(object sender, MouseEventArgs e)
        {
            if (canScore)
            {
                TextBox textBox = (TextBox)sender;
                DoTextBoxStuff(textBox);
            }
        }

        private void txtSixs_MouseClick(object sender, MouseEventArgs e)
        {
            if (canScore)
            {
                TextBox textBox = (TextBox)sender;
                DoTextBoxStuff(textBox);
            }
        }

        private void txtChance_MouseClick(object sender, MouseEventArgs e)
        {
            if (canScore)
            {
                TextBox textBox = (TextBox)sender;
                DoTextBoxStuff(textBox);
            }
        }

        private void txtThreeOfKind_MouseClick(object sender, MouseEventArgs e)
        {
            if (canScore)
            {
                TextBox textBox = (TextBox)sender;
                DoTextBoxStuff(textBox);
            }
        }

        private void txtFourOfKind_MouseClick(object sender, MouseEventArgs e)
        {
            if (canScore)
            {
                TextBox textBox = (TextBox)sender;
                DoTextBoxStuff(textBox);
            }
        }

        private void txtFullHouse_MouseClick(object sender, MouseEventArgs e)
        {
            if (canScore)
            {
                TextBox textBox = (TextBox)sender;
                DoTextBoxStuff(textBox);
            }
        }
        private void txtSmallStraight_MouseClick(object sender, MouseEventArgs e)
        {
            if (canScore)
            {
                TextBox textBox = (TextBox)sender;
                DoTextBoxStuff(textBox);
            }
        }

        private void txtLargeStraight_MouseClick(object sender, MouseEventArgs e)
        {
            if (canScore)
            {
                TextBox textBox = (TextBox)sender;
                DoTextBoxStuff(textBox);
            }
        }

        private void txtYahtzee_MouseClick(object sender, MouseEventArgs e)
        {
            if (canScore)
            {
                TextBox textBox = (TextBox)sender;
                DoTextBoxStuff(textBox);
            }

        }
        /********************  TEXT BOX CLICK EVENT END **************************************/
        private void DoTextBoxStuff(TextBox textBox)
        {
            int score;
            int tempScore;
            score = CalcScore(textBox.Tag.ToString());
            totalScore += score;
            lblTotalScore.Text = totalScore.ToString();
            if (textBox.Tag.ToString() == "yahtzee")
            {
                tempScore = score;
                
                if(tempScore == 0)
                {   //if you don't have a yahtzee, but you click it.
                    score = ((yahtzeeCounter-1) * 100) + 50;
                    if(score== -50)//yahtzee was clicked with a false yahtzee and no previous yahtzees
                    {
                        score = 0;
                        turns -= yahtzeeTurn;
                        yahtzeeTurn -= yahtzeeTurn;
                        ClearCheckBoxes();

                    }
                    else //the box will be disabled, but the turn will not end
                    {

                    }

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
            btnNext.Text = "Next Round";
            
            if (turns == 0)
            {   //game ends
                MessageBox.Show("Congratulations! \nYou scored " + totalScore.ToString() + " points!");
                if (totalScore > highScore)
                {
                    highScore = totalScore;
                    MessageBox.Show("Holy Mackeral! You got the high score!");
                    lblHighScore.Text = highScore.ToString();
                }

                btnNext.Text = "Play";
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
            canScore = false;
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
            canScore = false;
            lblTotalScore.Text = 0.ToString();
            lblTurns.Text = turns.ToString();
            ClearCheckBoxes();
            canScore = false;
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
            btnNext.Text = "Play";
            btnRollAgain.Enabled = false;
        }
        private void DoToolTip(TextBox textBox)
        {
            int score;
            score = CalcScore(textBox.Tag.ToString());
            toolTip1.SetToolTip(textBox, score.ToString());
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ResetBoard();
        }
    }
}
