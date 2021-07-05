
namespace Yahtzee
{
    partial class frmYahtzeeGame
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.chkDie1 = new System.Windows.Forms.CheckBox();
            this.chkDie2 = new System.Windows.Forms.CheckBox();
            this.chkDie3 = new System.Windows.Forms.CheckBox();
            this.chkDie4 = new System.Windows.Forms.CheckBox();
            this.chkDie5 = new System.Windows.Forms.CheckBox();
            this.txtOnes = new System.Windows.Forms.TextBox();
            this.txtTwos = new System.Windows.Forms.TextBox();
            this.txtThrees = new System.Windows.Forms.TextBox();
            this.txtFours = new System.Windows.Forms.TextBox();
            this.txtFives = new System.Windows.Forms.TextBox();
            this.txtSixs = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtThreeOfKind = new System.Windows.Forms.TextBox();
            this.txtFourOfKind = new System.Windows.Forms.TextBox();
            this.txtFullHouse = new System.Windows.Forms.TextBox();
            this.txtSmallStraight = new System.Windows.Forms.TextBox();
            this.txtLargeStraight = new System.Windows.Forms.TextBox();
            this.txtChance = new System.Windows.Forms.TextBox();
            this.txtYahtzee = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.btnRollAgain = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnDie1 = new System.Windows.Forms.Button();
            this.btnDie2 = new System.Windows.Forms.Button();
            this.btnDie3 = new System.Windows.Forms.Button();
            this.btnDie4 = new System.Windows.Forms.Button();
            this.btnDie5 = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.label15 = new System.Windows.Forms.Label();
            this.lblTotalScore = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.lblTurns = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.lblTheHighScore = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.pnlRegistration = new System.Windows.Forms.Panel();
            this.lblPassConfirmWarning = new System.Windows.Forms.Label();
            this.lblPassWarning = new System.Windows.Forms.Label();
            this.lblUsernameWarning = new System.Windows.Forms.Label();
            this.txtPasswordConfirm = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblConfirm = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.rdoLogin = new System.Windows.Forms.RadioButton();
            this.rdoRegister = new System.Windows.Forms.RadioButton();
            this.btnSignIn = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.lblYourHighScore = new System.Windows.Forms.Label();
            this.lblGoodLuck = new System.Windows.Forms.Label();
            this.pnlRegistration.SuspendLayout();
            this.SuspendLayout();
            // 
            // chkDie1
            // 
            this.chkDie1.AutoSize = true;
            this.chkDie1.Location = new System.Drawing.Point(61, 154);
            this.chkDie1.Name = "chkDie1";
            this.chkDie1.Size = new System.Drawing.Size(57, 17);
            this.chkDie1.TabIndex = 5;
            this.chkDie1.Tag = "1";
            this.chkDie1.Text = "Hold &4";
            this.chkDie1.UseVisualStyleBackColor = true;
            this.chkDie1.CheckedChanged += new System.EventHandler(this.chkDie1_CheckedChanged);
            // 
            // chkDie2
            // 
            this.chkDie2.AutoSize = true;
            this.chkDie2.Location = new System.Drawing.Point(226, 154);
            this.chkDie2.Name = "chkDie2";
            this.chkDie2.Size = new System.Drawing.Size(57, 17);
            this.chkDie2.TabIndex = 6;
            this.chkDie2.Tag = "2";
            this.chkDie2.Text = "Hold &5";
            this.chkDie2.UseVisualStyleBackColor = true;
            this.chkDie2.CheckedChanged += new System.EventHandler(this.chkDie2_CheckedChanged);
            // 
            // chkDie3
            // 
            this.chkDie3.AutoSize = true;
            this.chkDie3.Location = new System.Drawing.Point(141, 271);
            this.chkDie3.Name = "chkDie3";
            this.chkDie3.Size = new System.Drawing.Size(57, 17);
            this.chkDie3.TabIndex = 7;
            this.chkDie3.Tag = "3";
            this.chkDie3.Text = "Hold &3";
            this.chkDie3.UseVisualStyleBackColor = true;
            this.chkDie3.CheckedChanged += new System.EventHandler(this.chkDie3_CheckedChanged);
            // 
            // chkDie4
            // 
            this.chkDie4.AutoSize = true;
            this.chkDie4.Location = new System.Drawing.Point(61, 387);
            this.chkDie4.Name = "chkDie4";
            this.chkDie4.Size = new System.Drawing.Size(60, 17);
            this.chkDie4.TabIndex = 8;
            this.chkDie4.Tag = "4";
            this.chkDie4.Text = "Hold &1 ";
            this.chkDie4.UseVisualStyleBackColor = true;
            this.chkDie4.CheckedChanged += new System.EventHandler(this.chkDie4_CheckedChanged);
            // 
            // chkDie5
            // 
            this.chkDie5.AutoSize = true;
            this.chkDie5.Location = new System.Drawing.Point(226, 387);
            this.chkDie5.Name = "chkDie5";
            this.chkDie5.Size = new System.Drawing.Size(57, 17);
            this.chkDie5.TabIndex = 9;
            this.chkDie5.Tag = "5";
            this.chkDie5.Text = "Hold &2";
            this.chkDie5.UseVisualStyleBackColor = true;
            this.chkDie5.CheckedChanged += new System.EventHandler(this.chkDie5_CheckedChanged);
            // 
            // txtOnes
            // 
            this.txtOnes.Location = new System.Drawing.Point(371, 38);
            this.txtOnes.Name = "txtOnes";
            this.txtOnes.Size = new System.Drawing.Size(55, 20);
            this.txtOnes.TabIndex = 10;
            this.txtOnes.Tag = "ones";
            this.txtOnes.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtOnes_MouseClick);
            this.txtOnes.MouseHover += new System.EventHandler(this.txtOnes_MouseHover);
            // 
            // txtTwos
            // 
            this.txtTwos.Location = new System.Drawing.Point(371, 79);
            this.txtTwos.Name = "txtTwos";
            this.txtTwos.Size = new System.Drawing.Size(55, 20);
            this.txtTwos.TabIndex = 11;
            this.txtTwos.Tag = "twos";
            this.txtTwos.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtTwos_MouseClick);
            this.txtTwos.MouseHover += new System.EventHandler(this.txtTwos_MouseHover);
            // 
            // txtThrees
            // 
            this.txtThrees.Location = new System.Drawing.Point(371, 126);
            this.txtThrees.Name = "txtThrees";
            this.txtThrees.Size = new System.Drawing.Size(55, 20);
            this.txtThrees.TabIndex = 12;
            this.txtThrees.Tag = "threes";
            this.txtThrees.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtThrees_MouseClick);
            this.txtThrees.MouseHover += new System.EventHandler(this.txtThrees_MouseHover);
            // 
            // txtFours
            // 
            this.txtFours.Location = new System.Drawing.Point(371, 168);
            this.txtFours.Name = "txtFours";
            this.txtFours.Size = new System.Drawing.Size(55, 20);
            this.txtFours.TabIndex = 13;
            this.txtFours.Tag = "fours";
            this.txtFours.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtFours_MouseClick);
            this.txtFours.MouseHover += new System.EventHandler(this.txtFours_MouseHover);
            // 
            // txtFives
            // 
            this.txtFives.Location = new System.Drawing.Point(371, 210);
            this.txtFives.Name = "txtFives";
            this.txtFives.Size = new System.Drawing.Size(55, 20);
            this.txtFives.TabIndex = 14;
            this.txtFives.Tag = "fives";
            this.txtFives.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtFives_MouseClick);
            this.txtFives.MouseHover += new System.EventHandler(this.txtFives_MouseHover);
            // 
            // txtSixs
            // 
            this.txtSixs.Location = new System.Drawing.Point(371, 253);
            this.txtSixs.Name = "txtSixs";
            this.txtSixs.Size = new System.Drawing.Size(55, 20);
            this.txtSixs.TabIndex = 15;
            this.txtSixs.Tag = "sixs";
            this.txtSixs.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtSixs_MouseClick);
            this.txtSixs.MouseHover += new System.EventHandler(this.txtSixs_MouseHover);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(432, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "1\'s";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(432, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "2\'s";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(432, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "3\'s";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(432, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "4\'s";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(432, 213);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(20, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "5\'s";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(432, 257);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(20, 13);
            this.label6.TabIndex = 21;
            this.label6.Text = "6\'s";
            // 
            // txtThreeOfKind
            // 
            this.txtThreeOfKind.Location = new System.Drawing.Point(482, 37);
            this.txtThreeOfKind.Name = "txtThreeOfKind";
            this.txtThreeOfKind.Size = new System.Drawing.Size(55, 20);
            this.txtThreeOfKind.TabIndex = 22;
            this.txtThreeOfKind.Tag = "threeOfAKind";
            this.txtThreeOfKind.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtThreeOfKind_MouseClick);
            this.txtThreeOfKind.MouseHover += new System.EventHandler(this.txtThreeOfKind_MouseHover);
            // 
            // txtFourOfKind
            // 
            this.txtFourOfKind.Location = new System.Drawing.Point(482, 79);
            this.txtFourOfKind.Name = "txtFourOfKind";
            this.txtFourOfKind.Size = new System.Drawing.Size(55, 20);
            this.txtFourOfKind.TabIndex = 23;
            this.txtFourOfKind.Tag = "fourOfAKind";
            this.txtFourOfKind.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtFourOfKind_MouseClick);
            this.txtFourOfKind.MouseHover += new System.EventHandler(this.txtFourOfKind_MouseHover);
            // 
            // txtFullHouse
            // 
            this.txtFullHouse.Location = new System.Drawing.Point(482, 127);
            this.txtFullHouse.Name = "txtFullHouse";
            this.txtFullHouse.Size = new System.Drawing.Size(55, 20);
            this.txtFullHouse.TabIndex = 24;
            this.txtFullHouse.Tag = "fullHouse";
            this.txtFullHouse.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtFullHouse_MouseClick);
            this.txtFullHouse.MouseHover += new System.EventHandler(this.txtFullHouse_MouseHover);
            // 
            // txtSmallStraight
            // 
            this.txtSmallStraight.Location = new System.Drawing.Point(482, 168);
            this.txtSmallStraight.Name = "txtSmallStraight";
            this.txtSmallStraight.Size = new System.Drawing.Size(55, 20);
            this.txtSmallStraight.TabIndex = 25;
            this.txtSmallStraight.Tag = "smallStraight";
            this.txtSmallStraight.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtSmallStraight_MouseClick);
            this.txtSmallStraight.MouseHover += new System.EventHandler(this.txtSmallStraight_MouseHover);
            // 
            // txtLargeStraight
            // 
            this.txtLargeStraight.Location = new System.Drawing.Point(482, 210);
            this.txtLargeStraight.Name = "txtLargeStraight";
            this.txtLargeStraight.Size = new System.Drawing.Size(55, 20);
            this.txtLargeStraight.TabIndex = 26;
            this.txtLargeStraight.Tag = "largeStraight";
            this.txtLargeStraight.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtLargeStraight_MouseClick);
            this.txtLargeStraight.MouseHover += new System.EventHandler(this.txtLargeStraight_MouseHover);
            // 
            // txtChance
            // 
            this.txtChance.Location = new System.Drawing.Point(482, 252);
            this.txtChance.Name = "txtChance";
            this.txtChance.Size = new System.Drawing.Size(55, 20);
            this.txtChance.TabIndex = 27;
            this.txtChance.Tag = "chance";
            this.txtChance.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtChance_MouseClick);
            this.txtChance.MouseHover += new System.EventHandler(this.txtChance_MouseHover);
            // 
            // txtYahtzee
            // 
            this.txtYahtzee.Location = new System.Drawing.Point(424, 302);
            this.txtYahtzee.Name = "txtYahtzee";
            this.txtYahtzee.Size = new System.Drawing.Size(60, 20);
            this.txtYahtzee.TabIndex = 28;
            this.txtYahtzee.Tag = "yahtzee";
            this.txtYahtzee.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtYahtzee_MouseClick);
            this.txtYahtzee.MouseHover += new System.EventHandler(this.txtYahtzee_MouseHover);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(490, 305);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 13);
            this.label7.TabIndex = 29;
            this.label7.Text = "YAHTZEE!";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(543, 257);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 13);
            this.label8.TabIndex = 30;
            this.label8.Text = "Chance";
            this.label8.MouseHover += new System.EventHandler(this.label8_MouseHover);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(543, 213);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 13);
            this.label9.TabIndex = 31;
            this.label9.Text = "Large Straight";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(543, 171);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(71, 13);
            this.label10.TabIndex = 32;
            this.label10.Text = "Small Straight";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(543, 129);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(57, 13);
            this.label11.TabIndex = 33;
            this.label11.Text = "Full House";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(543, 82);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(73, 13);
            this.label12.TabIndex = 34;
            this.label12.Text = "Four of a Kind";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(543, 40);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(80, 13);
            this.label13.TabIndex = 35;
            this.label13.Text = "Three of a Kind";
            // 
            // btnRollAgain
            // 
            this.btnRollAgain.Location = new System.Drawing.Point(80, 425);
            this.btnRollAgain.Name = "btnRollAgain";
            this.btnRollAgain.Size = new System.Drawing.Size(75, 23);
            this.btnRollAgain.TabIndex = 36;
            this.btnRollAgain.Text = "&Roll Again";
            this.btnRollAgain.UseVisualStyleBackColor = true;
            this.btnRollAgain.Click += new System.EventHandler(this.btnRollAgain_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(199, 425);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 23);
            this.btnNext.TabIndex = 37;
            this.btnNext.Text = "&Play";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Red;
            this.label14.Location = new System.Drawing.Point(13, 13);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(206, 39);
            this.label14.TabIndex = 38;
            this.label14.Text = "YAHTZEE!!!";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(251, 475);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 39;
            this.btnExit.Text = "&Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnDie1
            // 
            this.btnDie1.Enabled = false;
            this.btnDie1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDie1.Location = new System.Drawing.Point(61, 55);
            this.btnDie1.Name = "btnDie1";
            this.btnDie1.Size = new System.Drawing.Size(82, 87);
            this.btnDie1.TabIndex = 40;
            this.btnDie1.Tag = "1";
            this.btnDie1.Text = "1";
            this.btnDie1.UseVisualStyleBackColor = true;
            // 
            // btnDie2
            // 
            this.btnDie2.Enabled = false;
            this.btnDie2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnDie2.Location = new System.Drawing.Point(226, 55);
            this.btnDie2.Name = "btnDie2";
            this.btnDie2.Size = new System.Drawing.Size(82, 87);
            this.btnDie2.TabIndex = 41;
            this.btnDie2.Tag = "2";
            this.btnDie2.Text = "2";
            this.btnDie2.UseVisualStyleBackColor = true;
            // 
            // btnDie3
            // 
            this.btnDie3.Enabled = false;
            this.btnDie3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnDie3.Location = new System.Drawing.Point(141, 171);
            this.btnDie3.Name = "btnDie3";
            this.btnDie3.Size = new System.Drawing.Size(82, 87);
            this.btnDie3.TabIndex = 42;
            this.btnDie3.Tag = "3";
            this.btnDie3.Text = "3";
            this.btnDie3.UseVisualStyleBackColor = true;
            // 
            // btnDie4
            // 
            this.btnDie4.Enabled = false;
            this.btnDie4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnDie4.Location = new System.Drawing.Point(61, 293);
            this.btnDie4.Name = "btnDie4";
            this.btnDie4.Size = new System.Drawing.Size(82, 87);
            this.btnDie4.TabIndex = 43;
            this.btnDie4.Tag = "4";
            this.btnDie4.Text = "4";
            this.btnDie4.UseVisualStyleBackColor = true;
            // 
            // btnDie5
            // 
            this.btnDie5.Enabled = false;
            this.btnDie5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnDie5.Location = new System.Drawing.Point(226, 293);
            this.btnDie5.Name = "btnDie5";
            this.btnDie5.Size = new System.Drawing.Size(82, 87);
            this.btnDie5.TabIndex = 44;
            this.btnDie5.Tag = "5";
            this.btnDie5.Text = "5";
            this.btnDie5.UseVisualStyleBackColor = true;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(377, 367);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(89, 18);
            this.label15.TabIndex = 45;
            this.label15.Text = "Total Score:";
            // 
            // lblTotalScore
            // 
            this.lblTotalScore.AutoSize = true;
            this.lblTotalScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalScore.Location = new System.Drawing.Point(472, 367);
            this.lblTotalScore.Name = "lblTotalScore";
            this.lblTotalScore.Size = new System.Drawing.Size(16, 18);
            this.lblTotalScore.TabIndex = 46;
            this.lblTotalScore.Text = "0";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(389, 407);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(54, 13);
            this.label16.TabIndex = 47;
            this.label16.Text = "Turns left:";
            // 
            // lblTurns
            // 
            this.lblTurns.AutoSize = true;
            this.lblTurns.Location = new System.Drawing.Point(449, 407);
            this.lblTurns.Name = "lblTurns";
            this.lblTurns.Size = new System.Drawing.Size(19, 13);
            this.lblTurns.TabIndex = 48;
            this.lblTurns.Text = "13";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(358, 475);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(85, 13);
            this.label17.TabIndex = 49;
            this.label17.Text = "The High Score:";
            // 
            // lblTheHighScore
            // 
            this.lblTheHighScore.AutoSize = true;
            this.lblTheHighScore.Location = new System.Drawing.Point(449, 475);
            this.lblTheHighScore.Name = "lblTheHighScore";
            this.lblTheHighScore.Size = new System.Drawing.Size(13, 13);
            this.lblTheHighScore.TabIndex = 50;
            this.lblTheHighScore.Text = "0";
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(141, 475);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(75, 23);
            this.btnLogout.TabIndex = 56;
            this.btnLogout.Text = "LogOut";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(32, 475);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 51;
            this.btnReset.Text = "Reset Game";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // pnlRegistration
            // 
            this.pnlRegistration.Controls.Add(this.lblPassConfirmWarning);
            this.pnlRegistration.Controls.Add(this.lblPassWarning);
            this.pnlRegistration.Controls.Add(this.lblUsernameWarning);
            this.pnlRegistration.Controls.Add(this.txtPasswordConfirm);
            this.pnlRegistration.Controls.Add(this.txtPassword);
            this.pnlRegistration.Controls.Add(this.txtUsername);
            this.pnlRegistration.Controls.Add(this.lblConfirm);
            this.pnlRegistration.Controls.Add(this.label20);
            this.pnlRegistration.Controls.Add(this.label19);
            this.pnlRegistration.Controls.Add(this.rdoLogin);
            this.pnlRegistration.Controls.Add(this.rdoRegister);
            this.pnlRegistration.Controls.Add(this.btnSignIn);
            this.pnlRegistration.Controls.Add(this.label18);
            this.pnlRegistration.Location = new System.Drawing.Point(13, 12);
            this.pnlRegistration.Name = "pnlRegistration";
            this.pnlRegistration.Size = new System.Drawing.Size(623, 492);
            this.pnlRegistration.TabIndex = 52;
            // 
            // lblPassConfirmWarning
            // 
            this.lblPassConfirmWarning.AutoSize = true;
            this.lblPassConfirmWarning.ForeColor = System.Drawing.Color.Red;
            this.lblPassConfirmWarning.Location = new System.Drawing.Point(329, 289);
            this.lblPassConfirmWarning.Name = "lblPassConfirmWarning";
            this.lblPassConfirmWarning.Size = new System.Drawing.Size(11, 13);
            this.lblPassConfirmWarning.TabIndex = 12;
            this.lblPassConfirmWarning.Text = "*";
            // 
            // lblPassWarning
            // 
            this.lblPassWarning.AutoSize = true;
            this.lblPassWarning.ForeColor = System.Drawing.Color.Red;
            this.lblPassWarning.Location = new System.Drawing.Point(329, 231);
            this.lblPassWarning.Name = "lblPassWarning";
            this.lblPassWarning.Size = new System.Drawing.Size(11, 13);
            this.lblPassWarning.TabIndex = 11;
            this.lblPassWarning.Text = "*";
            // 
            // lblUsernameWarning
            // 
            this.lblUsernameWarning.AutoSize = true;
            this.lblUsernameWarning.ForeColor = System.Drawing.Color.Red;
            this.lblUsernameWarning.Location = new System.Drawing.Point(326, 179);
            this.lblUsernameWarning.Name = "lblUsernameWarning";
            this.lblUsernameWarning.Size = new System.Drawing.Size(11, 13);
            this.lblUsernameWarning.TabIndex = 10;
            this.lblUsernameWarning.Text = "*";
            // 
            // txtPasswordConfirm
            // 
            this.txtPasswordConfirm.Location = new System.Drawing.Point(220, 286);
            this.txtPasswordConfirm.Name = "txtPasswordConfirm";
            this.txtPasswordConfirm.PasswordChar = '*';
            this.txtPasswordConfirm.Size = new System.Drawing.Size(100, 20);
            this.txtPasswordConfirm.TabIndex = 9;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(220, 229);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(100, 20);
            this.txtPassword.TabIndex = 8;
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(220, 176);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(100, 20);
            this.txtUsername.TabIndex = 7;
            // 
            // lblConfirm
            // 
            this.lblConfirm.AutoSize = true;
            this.lblConfirm.Location = new System.Drawing.Point(120, 289);
            this.lblConfirm.Name = "lblConfirm";
            this.lblConfirm.Size = new System.Drawing.Size(94, 13);
            this.lblConfirm.TabIndex = 6;
            this.lblConfirm.Text = "Confirm Password:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(158, 232);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(56, 13);
            this.label20.TabIndex = 5;
            this.label20.Text = "Password:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(156, 179);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(58, 13);
            this.label19.TabIndex = 4;
            this.label19.Text = "Username:";
            // 
            // rdoLogin
            // 
            this.rdoLogin.AutoSize = true;
            this.rdoLogin.Location = new System.Drawing.Point(318, 97);
            this.rdoLogin.Name = "rdoLogin";
            this.rdoLogin.Size = new System.Drawing.Size(79, 17);
            this.rdoLogin.TabIndex = 3;
            this.rdoLogin.Text = "Log-in User";
            this.rdoLogin.UseVisualStyleBackColor = true;
            this.rdoLogin.CheckedChanged += new System.EventHandler(this.rdoLogin_CheckedChanged);
            // 
            // rdoRegister
            // 
            this.rdoRegister.AutoSize = true;
            this.rdoRegister.Checked = true;
            this.rdoRegister.Location = new System.Drawing.Point(156, 97);
            this.rdoRegister.Name = "rdoRegister";
            this.rdoRegister.Size = new System.Drawing.Size(89, 17);
            this.rdoRegister.TabIndex = 2;
            this.rdoRegister.TabStop = true;
            this.rdoRegister.Text = "Register User";
            this.rdoRegister.UseVisualStyleBackColor = true;
            this.rdoRegister.CheckedChanged += new System.EventHandler(this.rdoRegister_CheckedChanged);
            // 
            // btnSignIn
            // 
            this.btnSignIn.Location = new System.Drawing.Point(256, 407);
            this.btnSignIn.Name = "btnSignIn";
            this.btnSignIn.Size = new System.Drawing.Size(75, 23);
            this.btnSignIn.TabIndex = 1;
            this.btnSignIn.Text = "&Sign in";
            this.btnSignIn.UseVisualStyleBackColor = true;
            this.btnSignIn.Click += new System.EventHandler(this.btnSignIn_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.Red;
            this.label18.Location = new System.Drawing.Point(175, 25);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(217, 25);
            this.label18.TabIndex = 0;
            this.label18.Text = "Welcome to Yahtzee!";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(355, 445);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(91, 13);
            this.label21.TabIndex = 53;
            this.label21.Text = "Your High Score: ";
            // 
            // lblYourHighScore
            // 
            this.lblYourHighScore.AutoSize = true;
            this.lblYourHighScore.Location = new System.Drawing.Point(449, 445);
            this.lblYourHighScore.Name = "lblYourHighScore";
            this.lblYourHighScore.Size = new System.Drawing.Size(13, 13);
            this.lblYourHighScore.TabIndex = 54;
            this.lblYourHighScore.Text = "0";
            // 
            // lblGoodLuck
            // 
            this.lblGoodLuck.AutoSize = true;
            this.lblGoodLuck.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGoodLuck.Location = new System.Drawing.Point(225, 9);
            this.lblGoodLuck.Name = "lblGoodLuck";
            this.lblGoodLuck.Size = new System.Drawing.Size(164, 18);
            this.lblGoodLuck.TabIndex = 55;
            this.lblGoodLuck.Text = "Good Luck, Press Play!";
            // 
            // frmYahtzeeGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 517);
            this.Controls.Add(this.pnlRegistration);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.lblGoodLuck);
            this.Controls.Add(this.lblYourHighScore);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.lblTheHighScore);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.lblTurns);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.lblTotalScore);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.btnDie5);
            this.Controls.Add(this.btnDie4);
            this.Controls.Add(this.btnDie3);
            this.Controls.Add(this.btnDie2);
            this.Controls.Add(this.btnDie1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnRollAgain);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtYahtzee);
            this.Controls.Add(this.txtChance);
            this.Controls.Add(this.txtLargeStraight);
            this.Controls.Add(this.txtSmallStraight);
            this.Controls.Add(this.txtFullHouse);
            this.Controls.Add(this.txtFourOfKind);
            this.Controls.Add(this.txtThreeOfKind);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSixs);
            this.Controls.Add(this.txtFives);
            this.Controls.Add(this.txtFours);
            this.Controls.Add(this.txtThrees);
            this.Controls.Add(this.txtTwos);
            this.Controls.Add(this.txtOnes);
            this.Controls.Add(this.chkDie5);
            this.Controls.Add(this.chkDie4);
            this.Controls.Add(this.chkDie3);
            this.Controls.Add(this.chkDie2);
            this.Controls.Add(this.chkDie1);
            this.Name = "frmYahtzeeGame";
            this.Text = "Yahtzee!!!";
            this.Load += new System.EventHandler(this.frmYahtzeeGame_Load);
            this.pnlRegistration.ResumeLayout(false);
            this.pnlRegistration.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.CheckBox chkDie1;
        private System.Windows.Forms.CheckBox chkDie2;
        private System.Windows.Forms.CheckBox chkDie3;
        private System.Windows.Forms.CheckBox chkDie4;
        private System.Windows.Forms.CheckBox chkDie5;
        private System.Windows.Forms.TextBox txtOnes;
        private System.Windows.Forms.TextBox txtTwos;
        private System.Windows.Forms.TextBox txtThrees;
        private System.Windows.Forms.TextBox txtFours;
        private System.Windows.Forms.TextBox txtFives;
        private System.Windows.Forms.TextBox txtSixs;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtThreeOfKind;
        private System.Windows.Forms.TextBox txtFourOfKind;
        private System.Windows.Forms.TextBox txtFullHouse;
        private System.Windows.Forms.TextBox txtSmallStraight;
        private System.Windows.Forms.TextBox txtLargeStraight;
        private System.Windows.Forms.TextBox txtChance;
        private System.Windows.Forms.TextBox txtYahtzee;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnRollAgain;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnDie1;
        private System.Windows.Forms.Button btnDie2;
        private System.Windows.Forms.Button btnDie3;
        private System.Windows.Forms.Button btnDie4;
        private System.Windows.Forms.Button btnDie5;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label lblTotalScore;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label lblTurns;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label lblTheHighScore;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Panel pnlRegistration;
        private System.Windows.Forms.Button btnSignIn;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtPasswordConfirm;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblConfirm;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.RadioButton rdoLogin;
        private System.Windows.Forms.RadioButton rdoRegister;
        private System.Windows.Forms.Label lblPassConfirmWarning;
        private System.Windows.Forms.Label lblPassWarning;
        private System.Windows.Forms.Label lblUsernameWarning;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label lblYourHighScore;
        private System.Windows.Forms.Label lblGoodLuck;
        private System.Windows.Forms.Button btnLogout;
    }
}

