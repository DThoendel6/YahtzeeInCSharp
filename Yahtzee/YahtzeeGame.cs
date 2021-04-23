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
        //public PictureBox[] dicePics = new PictureBox[5];
        //public static string[] stringImageLocations = System.IO.Directory.GetFiles("..\\..\\images", "*.jpg", SearchOption.TopDirectoryOnly);
        List<Button> buttons = new List<Button>(5);
        //public Image[] diceImages = new Image[stringImageLocations.Length];
        public static Random rand = new Random();
        int rollCounter = 0;
        [System.ComponentModel.Browsable(true)]
        public event System.Windows.Forms.MouseEventHandler MouseClick;


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
                buttons.ElementAt(die.DieId-1).Text = (die.DotCount).ToString();
              
            }

        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (btnNext.Text == "Play")
            {
                //change btn text
                btnNext.Text = "Next Round";
            }
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
                buttons.ElementAt(d.DieId-1).Text = (d.DotCount).ToString();
            }
        }

        private void chkDie1_CheckedChanged(object sender, EventArgs e)
        {
            if(dice.ElementAt(0).Hold == false)
                dice.ElementAt(0).Hold = true;
            else if(dice.ElementAt(0).Hold == true)
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
                if(rollCounter == 3)
                {
                    btnRollAgain.Enabled = false;
                    btnNext.Enabled = true;
                }
            }
        }

        private void txtOnes_MouseClick(object sender, MouseEventArgs e)
        {
            int score;
            score = calcScore("ones");
            txtOnes.Text = score.ToString();
            txtOnes.Enabled = false;
        }

        private int calcScore(string type)
        {
            int score = 0;
            int searchCriteria;
            int[] numbers = new int[5];
            int i = 0;
            foreach(Die d in dice)
            {
                if(type == "ones")
                {
                    if (d.DotCount == 1)
                    {
                        score += 1;
                    }
                }else if(type == "twos")
                {
                    if (d.DotCount == 2)
                    {
                        score += 2;
                    }
                }else if (type == "threes")
                {
                    if (d.DotCount == 3)
                    {
                        score += 3;
                    }
                }else if (type == "fours")
                {
                    if (d.DotCount == 4)
                    {
                        score += 4;
                    }
                }else if (type == "fives")
                {
                    if (d.DotCount == 5)
                    {
                        score += 5;
                    }
                }else if (type == "sixs")
                {
                    if (d.DotCount == 6)
                    {
                        score += 6;
                    }
                }else if (type == "chance")
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
                                }
                            }
                        }
                    }catch (IndexOutOfRangeException e)
                    {

                    }
                }
            }

            return score;
        }

        private void txtOnes_MouseHover(object sender, EventArgs e)
        {
            int score;
            score = calcScore("ones");
            toolTip1.SetToolTip(txtOnes, score.ToString());
        }

        private void txtTwos_MouseClick(object sender, MouseEventArgs e)
        {
            int score;
            score = calcScore("twos");
            txtTwos.Text = score.ToString();
            txtTwos.Enabled = false;
        }

        private void txtThrees_MouseClick(object sender, MouseEventArgs e)
        {
            int score;
            score = calcScore("threes");
            txtThrees.Text = score.ToString();
            txtThrees.Enabled = false;
        }

        private void txtFours_MouseClick(object sender, MouseEventArgs e)
        {
            int score;
            score = calcScore("fours");
            txtFours.Text = score.ToString();
            txtFours.Enabled = false;
        }

        private void txtFives_MouseClick(object sender, MouseEventArgs e)
        {
            int score;
            score = calcScore("fives");
            txtFives.Text = score.ToString();
            txtFives.Enabled = false;
        }

        private void txtSixs_MouseClick(object sender, MouseEventArgs e)
        {
            int score;
            score = calcScore("sixs");
            txtSixs.Text = score.ToString();
            txtSixs.Enabled = false;
        }

        private void txtChance_MouseClick(object sender, MouseEventArgs e)
        {
            int score;
            score = calcScore("chance");
            txtChance.Text = score.ToString();
            txtChance.Enabled = false;
        }

        private void txtThreeOfKind_MouseClick(object sender, MouseEventArgs e)
        {
            int score;
            score = calcScore("threeOfAKind");
            txtTwos.Text = score.ToString();
            txtTwos.Enabled = false;
        }

        private void txtFourOfKind_MouseClick(object sender, MouseEventArgs e)
        {
            int score;
            score = calcScore("fourOfAKind");
            txtThreeOfKind.Text = score.ToString();
            txtFourOfKind.Enabled = false;
        }
    }
}
