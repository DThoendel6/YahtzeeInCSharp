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
        List<Die> dice = new List<Die>();
        public PictureBox[] dicePics = new PictureBox[5];
        int currentRoll;
        public static string[] stringImageLocations = System.IO.Directory.GetFiles("..\\..\\images", "*.jpg", SearchOption.TopDirectoryOnly);

        public Image[] diceImages = new Image[stringImageLocations.Length];
            

    public frmYahtzeeGame()
        {
            string path = "";
            string searchPattern = "";
            for (int i = 0; i < stringImageLocations.Length; i++)
            {
                diceImages[i] = Image.FromFile(stringImageLocations[i]);
            }
            dicePics[0] = pbxDie1;
            dicePics[1] = pbxDie2;
            dicePics[2] = pbxDie3;
            dicePics[3] = pbxDie4;
            dicePics[4] = pbxDie5;
           // pbxDie1.Tag.Equals(1);
            for (int i = 0; i <= 4; i++)
            {        //Add image and assign to die1, die2...
                Die d = new Die();
                d.DieId = i+1;
                d.Roll();
                d.Hold = false;
                currentRoll = d.DotCount;
                //dicePics[i].Image = diceImages[currentRoll-1];
                pbxDie1.Image = diceImages[3];

            }
            InitializeComponent();
        }

  

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void SetImage(int id)
        {
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
            
        }
    }
}
