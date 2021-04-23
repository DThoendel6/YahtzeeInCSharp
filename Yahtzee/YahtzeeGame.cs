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
        int currentRoll;
        //public static string[] stringImageLocations = System.IO.Directory.GetFiles("..\\..\\images", "*.jpg", SearchOption.TopDirectoryOnly);
        List<Button> buttons = new List<Button>(5);
        //public Image[] diceImages = new Image[stringImageLocations.Length];
        public static Random rand = new Random();


        public frmYahtzeeGame()
        {
           
            InitializeComponent();
        }

  

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void SetDiceImage(int id)
        {
            /*
            if (Convert.ToInt32(pbxDie1.Tag) == 1)
            {
                pbxDie1.Image = Yahtzee.Properties.Resources.dice1;
            }
            else if(Convert.ToInt32(pbxDie2.Tag) == id)
            {
                pbxDie2.Image = Yahtzee.Properties.Resources.dice2;
            }
            else if (Convert.ToInt32(pbxDie3.Tag) == id)
            {
                pbxDie3.Image = Yahtzee.Properties.Resources.dice3;
            }
            else if (Convert.ToInt32(pbxDie4.Tag) == id)
            {
                pbxDie4.Image = Yahtzee.Properties.Resources.dice4;
            }
            else if (Convert.ToInt32(pbxDie5.Tag) == id)
            {
                pbxDie5.Image = Yahtzee.Properties.Resources.dice5;
            }
            */
            
        }

        private void frmYahtzeeGame_Load(object sender, EventArgs e)
        {
            Die die = new Die();
            buttons.Add(btnDie1);
            buttons.Add(btnDie2);
            buttons.Add(btnDie3);
            buttons.Add(btnDie4);
            buttons.Add(btnDie5);

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
    }
}
