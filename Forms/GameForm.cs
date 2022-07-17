using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ArmyNS;
using BattleNS;
using GeneralNS;

namespace AndrewArnitaCharbelTabet_Project {
    public partial class GameForm : Form {

        ResultsForm resutlsForm = new ResultsForm();

        private static List<ArmyMember> listArmy1 = new List<ArmyMember>(IntroForm.NumbOfSoldiers + IntroForm.NumbOfVehicles); //first army list
        private static List<ArmyMember> listArmy2 = new List<ArmyMember>(IntroForm.NumbOfSoldiers + IntroForm.NumbOfVehicles); //second army list

        private Battle battle = new Battle(IntroForm.NumbOfBattles); 

        public static List<string> listBuilder = new List<string>(); //saving string builders in a list

        private General general1 = new General(IntroForm.nameOfGeneral1, listArmy1);
        private General general2 = new General(IntroForm.nameOfGeneral2, listArmy2);

        public GameForm() {
            InitializeComponent();
            FillBattleListBox(IntroForm.NumbOfBattles);
            FirstForm.gameCounter += 1; //increment the counter when a game is played
        }

        private void BtnAutomaticSimulation_Click(object sender, EventArgs e) {  //Simulate the battles automatically
            GameFormTimer.Start();
        }
        private void BtnStop_Click(object sender, EventArgs e) { //Stop the simulation
            if (BattlesListBox.Items.Count != IntroForm.NumbOfBattles)
                GameFormTimer.Stop();
            else
                MessageBox.Show("You cannot stop a war before it begins!", "Warning Generals!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        private void BtnEndgame_Click(object sender, EventArgs e) { //End the whole whenever you want and get the results
            if (BattlesListBox.Items.Count != IntroForm.NumbOfBattles) {
                BattlesListBox.Items.Clear();
                GameWinner();
                this.Hide();
                resutlsForm.ShowDialog();
                this.Close();
            }
            else
                MessageBox.Show("At least play one battle and show us who's better.", "Come on Generals!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }


        private void FillBattleListBox(int numOfBattles) {  //this will help us show how many battles the user will play in a list box
            for (int battle = 1; battle <= numOfBattles; battle++) {
                BattlesListBox.Items.Add($"Battle {battle}");
            }
        }

        private void BattlesListBox_Click(object sender, EventArgs e) { //play each round manually

            if (BattlesListBox.SelectedIndex != -1 && BattlesListBox.SelectedIndex == 0) { //Don't let the user press a round before the previous one is not yet played
                FillInfo(); 
                AllocateImage();
                RemoveArmyMember();
                battle.StartBattle(general1, general2);
                RemoveArmyMember();
                FillInfo();
                BattlesListBox.Items.RemoveAt(BattlesListBox.SelectedIndex); //Remove the selected list Item
                GameWinner();
            }
            else
                MessageBox.Show("The war is a sequence of battles!", "Warning Generals!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            if (BattlesListBox.Items.Count == 0) {
                GameWinner();
                this.Hide();
                resutlsForm.ShowDialog();
                this.Close();
            }
        }

        private void GameFormTimer_Tick(object sender, EventArgs e) {  //Automatic gameplay
            if (BattlesListBox.Items.Count != 0) {
                PlayGame();
            }
            else {
                GameFormTimer.Stop();
                GameWinner();
                this.Hide();
                resutlsForm.ShowDialog();
                this.Close();
            }
        }

        private void BtnFinishGame_Click(object sender, EventArgs e) {  //finish the game and generate results
            for (int i = 1; i <= IntroForm.NumbOfBattles; i++) {
                PlayGame();
            }
        }

        private void PlayGame() { //this function calls everything that the game needs to run
            FillInfo();
            AllocateImage();
            RemoveArmyMember();
            battle.StartBattle(general1, general2);
            RemoveArmyMember();
            FillInfo();
            BattlesListBox.Items.RemoveAt(0); //remove each battle played
            GameWinner();
        }

        private string TransferBattleNumber {
            get {
                return BattlesListBox.Items[ 0 ].ToString();
            }  //return the selected item in the listbox for displaying the battle numbers
        }

        private void GameForm_Load(object sender, EventArgs e) {
            //Creating the army array:
            general1.listOfArmyMembers = listArmy1;
            general2.listOfArmyMembers = listArmy2;

            general1.CreateArmyOfUnits();
            general2.CreateArmyOfUnits();
        }

        private void RemoveArmyMember() {  //when armymember has 0 life decrease the number

                if (battle.Unit1.armyMemberLife <= 0 && (battle.Unit1.ArmyMemberType == ArmyMember.EnumArmyMemberType.RifleSoldier
                    || battle.Unit1.ArmyMemberType == ArmyMember.EnumArmyMemberType.RPGSoldier
                    || battle.Unit1.ArmyMemberType == ArmyMember.EnumArmyMemberType.BazookaSoldier) && general1.NumberOfSoldiers > 0) {
                    general1.NumberOfSoldiers--;
                }
                else if (battle.Unit1.armyMemberLife <= 0  && (battle.Unit1.ArmyMemberType == ArmyMember.EnumArmyMemberType.ArmoredCar
                    || battle.Unit1.ArmyMemberType == ArmyMember.EnumArmyMemberType.BattleTank) && general1.NumberOfVehicles > 0) {
                    general1.NumberOfVehicles--;
                }

                if (battle.Unit2.armyMemberLife <= 0  && (battle.Unit2.ArmyMemberType == ArmyMember.EnumArmyMemberType.RifleSoldier 
                    || battle.Unit2.ArmyMemberType == ArmyMember.EnumArmyMemberType.RPGSoldier
                    || battle.Unit2.ArmyMemberType == ArmyMember.EnumArmyMemberType.BazookaSoldier) && general2.NumberOfSoldiers > 0) {
                    general2.NumberOfSoldiers--;
                }

                else if (battle.Unit2.armyMemberLife <= 0 && (battle.Unit2.ArmyMemberType == ArmyMember.EnumArmyMemberType.ArmoredCar 
                    || battle.Unit2.ArmyMemberType == ArmyMember.EnumArmyMemberType.BattleTank) && general2.NumberOfVehicles > 0) {
                    general2.NumberOfVehicles--;
                }  
        }

        private void GameWinner() {  //end game results
            if (BattlesListBox.Items.Count <= 0 
                || (general1.TotalLife <= 0 || (general1.NumberOfSoldiers == 0 && general1.NumberOfVehicles == 0))
                || (general2.TotalLife <= 0 || (general2.NumberOfSoldiers == 0 && general2.NumberOfVehicles == 0))) {

                if (general1.TotalLife > general2.TotalLife) {
                    BattlesListBox.Items.Clear();
                    GameFormTimer.Stop();
                    listBuilder.Add($"{general1.GeneralName } won the war");
                    listBuilder.Add($"{general2.GeneralName } lost the war");
                    AddToArmyList();
                    ArmyMember.AddToListOfBattles();
                    MessageBox.Show($"{general1.GeneralName } won the war!", "War Results!");
                    this.Hide();
                    resutlsForm.ShowDialog();
                    this.Close();
                }
                else if (general2.TotalLife > general1.TotalLife) {
                    BattlesListBox.Items.Clear();
                    GameFormTimer.Stop();
                    listBuilder.Add($"{general2.GeneralName } won the war");
                    listBuilder.Add($"{general1.GeneralName } lost the war");
                    AddToArmyList();
                    ArmyMember.AddToListOfBattles();
                    MessageBox.Show($"{general2.GeneralName } won the war!", "War Results!");
                    this.Hide();
                    resutlsForm.ShowDialog();
                    this.Close();
                }
                else {
                    BattlesListBox.Items.Clear(); //clear the list box to have 0 battles
                    GameFormTimer.Stop();
                    listBuilder.Add($"{general1.GeneralName } has tied with {general2.GeneralName }");
                    listBuilder.Add($"{general2.GeneralName } has tied with {general1.GeneralName }");
                    AddToArmyList();
                    ArmyMember.AddToListOfBattles();
                    MessageBox.Show($"This war has tied the Generals!", "War Results!");
                    this.Hide();
                    resutlsForm.ShowDialog();
                    this.Close();
                }
            }
        }

        private void AddToArmyList() {
            listBuilder.Add($", Total Life Points: {general1.TotalLife}, Total Ammunition: {general1.TotalAmmo}");
            listBuilder.Add($", Total Life Points: {general2.TotalLife}, Total Ammunition: {general2.TotalAmmo}\n");
        }

        private void FillInfo() { //Fill the Text info in the Game Form

            CheckArmyMemberLife();
            CheckTotalLife();
            CheckForGeneralLife();

            //Get the number of soldiers added by the user:
            SoldiersLeftText1.Text = $"{general1.NumberOfSoldiers}";
            SoldiersLeftText2.Text = $"{general2.NumberOfSoldiers}";

            //Get the number of vehicules added by the user:
            VehiculesLeftText1.Text = $"{general1.NumberOfVehicles}";
            VehiculesLeftText2.Text = $"{general2.NumberOfVehicles}";

            //Change the title dynamically
            BattleCounterText.Text = this.TransferBattleNumber;

            //Update the number of ammunition for each army member:
            ArmyMemberAmmunitionText1.Text = $"{battle.Unit1.armyMemberAmmunition}";
            ArmyMemberAmmunitionText2.Text = $"{battle.Unit2.armyMemberAmmunition}";
        }

        private void CheckForGeneralLife() { //change text color according to the general's TotalLife
            int totalLife = ((IntroForm.NumbOfSoldiers + IntroForm.NumbOfVehicles) * 100) / 2;
            //Get the generals names:
            if (general1.TotalLife <= totalLife) {
                GeneralText1.ForeColor = Color.Red;
                GeneralText1.Text = $"{general1.GeneralName}:";
            }
            if (general2.TotalLife <= totalLife) {
                GeneralText2.ForeColor = Color.Red;
                GeneralText2.Text = $"{general2.GeneralName}:";
            }
            else {
                GeneralText1.Text = $"{general1.GeneralName}:";
                GeneralText2.Text = $"{general2.GeneralName}:";
            }
        }

        private void CheckArmyMemberLife() { //can't have a value < 0 for the life of an armyMember
            if (battle.Unit1.armyMemberLife < 0) {
                //Update the number of life for each army member:
                ArmyMemberLifeText1.Text = $"{0}";
            }
            if (battle.Unit2.armyMemberLife < 0) {
                //Update the number of life for each army member:
                ArmyMemberLifeText2.Text = $"{0}";
            }
            else {
                //Update the number of life for each army member:
                ArmyMemberLifeText1.Text = $"{battle.Unit1.armyMemberLife}";
                ArmyMemberLifeText2.Text = $"{battle.Unit2.armyMemberLife}";
            }
        }

        private void CheckTotalLife() { //can't have a value < 0 for the total life of the army
            if (general1.TotalLife < 0) {
                //Update the number of life for each army member:
                TotalLifeGeneralText1.Text = $"{0}";
            }

            if (general2.TotalLife < 0) {
                //Update the number of life for each army member:
                TotalLifeGeneralText2.Text = $"{0}";
            }

            else {
                //Update the number of life for the whole army:
                TotalLifeGeneralText1.Text = $"{general1.TotalLife}";
                TotalLifeGeneralText2.Text = $"{general2.TotalLife}";
            }
        }

        public void AllocateImage() {
                //To set the images left and right:
          
                battle.Unit1 = listArmy1.ElementAt(general1.SelectArmyUnit(listArmy1));
                battle.Unit2 = listArmy2.ElementAt(general2.SelectArmyUnit(listArmy2));

                if (battle.Unit1.ArmyMemberType == ArmyMember.EnumArmyMemberType.RifleSoldier) {
                   if(battle.Unit1.armyMemberLife <= 50) {
                    GeneralImage1.Image = Properties.Resources.Rifle_Soldier_Inverted_Red;
                    GeneralImage1.SizeMode = PictureBoxSizeMode.StretchImage;
                    PlayerNameText1.Text = "Rifle Soldier";
                    PlayerNameText1.ForeColor = Color.Red;
                }
                   else {
                    GeneralImage1.Image = Properties.Resources.Rifle_Soldier_Inverted;
                    GeneralImage1.SizeMode = PictureBoxSizeMode.StretchImage;
                    PlayerNameText1.Text = "Rifle Soldier";
                    PlayerNameText1.ForeColor = Color.Blue;
                }

                }
                else if (battle.Unit1.ArmyMemberType == ArmyMember.EnumArmyMemberType.RPGSoldier) {
                if (battle.Unit1.armyMemberLife <= 50) {
                    GeneralImage1.Image = Properties.Resources.RPG_Soldier_Inverted_Red;
                    GeneralImage1.SizeMode = PictureBoxSizeMode.StretchImage;
                    PlayerNameText1.Text = "RPG Solider";
                    PlayerNameText1.ForeColor = Color.Red;
                }
                else {
                    GeneralImage1.Image = Properties.Resources.RPG_Soldier_Inverted;
                    GeneralImage1.SizeMode = PictureBoxSizeMode.StretchImage;
                    PlayerNameText1.Text = "RPG Soldier";
                    PlayerNameText1.ForeColor = Color.Blue;
                }
            }
                else if (battle.Unit1.ArmyMemberType == ArmyMember.EnumArmyMemberType.BazookaSoldier) {
                if (battle.Unit1.armyMemberLife <= 50) {
                    GeneralImage1.Image = Properties.Resources.Bazooka_Soldier_Inverted_Red;
                    GeneralImage1.SizeMode = PictureBoxSizeMode.StretchImage;
                    PlayerNameText1.Text = "Bazooka Soldier";
                    PlayerNameText1.ForeColor = Color.Red;
                }
                else {
                    GeneralImage1.Image = Properties.Resources.Bazooka_Soldier_Inverted;
                    GeneralImage1.SizeMode = PictureBoxSizeMode.StretchImage;
                    PlayerNameText1.Text = "Bazooka Soldier";
                    PlayerNameText1.ForeColor = Color.Blue;
                }
            }
                else if (battle.Unit1.ArmyMemberType == ArmyMember.EnumArmyMemberType.ArmoredCar) {
                if (battle.Unit1.armyMemberLife <= 50) {
                    GeneralImage1.Image = Properties.Resources.Armored_Car_Inverted_Red;
                    GeneralImage1.SizeMode = PictureBoxSizeMode.StretchImage;
                    PlayerNameText1.Text = "Armored Car";
                    PlayerNameText1.ForeColor = Color.Red;
                }
                else {
                    GeneralImage1.Image = Properties.Resources.Armored_Car_Inverted;
                    GeneralImage1.SizeMode = PictureBoxSizeMode.StretchImage;
                    PlayerNameText1.Text = "Armored Car";
                    PlayerNameText1.ForeColor = Color.Blue;
                }
            }
                else if (battle.Unit1.ArmyMemberType == ArmyMember.EnumArmyMemberType.BattleTank) {
                if (battle.Unit1.armyMemberLife <= 50) {
                    GeneralImage1.Image = Properties.Resources.Battle_Tank_Inverted_Red;
                    GeneralImage1.SizeMode = PictureBoxSizeMode.StretchImage;
                    PlayerNameText1.Text = "Battle Tank";
                    PlayerNameText1.ForeColor = Color.Red;
                }
                else {
                    GeneralImage1.Image = Properties.Resources.Battle_Tank_Inverted;
                    GeneralImage1.SizeMode = PictureBoxSizeMode.StretchImage;
                    PlayerNameText1.Text = "Battle Tank";
                    PlayerNameText1.ForeColor = Color.Blue;
                }
            }


                if (battle.Unit2.ArmyMemberType == ArmyMember.EnumArmyMemberType.RifleSoldier) {
                if (battle.Unit2.armyMemberLife <= 50) {
                    GeneralImage2.Image = Properties.Resources.Rifle_Soldier_Red;
                    GeneralImage2.SizeMode = PictureBoxSizeMode.StretchImage;
                    PlayerNameText2.Text = "Rifle Soldier";
                    PlayerNameText2.ForeColor = Color.Red;
                }
                else {
                    GeneralImage2.Image = Properties.Resources.Rifle_Soldier;
                    GeneralImage2.SizeMode = PictureBoxSizeMode.StretchImage;
                    PlayerNameText2.Text = "Rifle Soldier";
                    PlayerNameText2.ForeColor = Color.Blue;
                }
            }

                else if (battle.Unit2.ArmyMemberType == ArmyMember.EnumArmyMemberType.RPGSoldier) {
                if (battle.Unit2.armyMemberLife <= 50) {
                    GeneralImage2.Image = Properties.Resources.RPG_Soldier_Red;
                    GeneralImage2.SizeMode = PictureBoxSizeMode.StretchImage;
                    PlayerNameText2.Text = "RPG Soldier";
                    PlayerNameText2.ForeColor = Color.Red;
                }
                else {
                    GeneralImage2.Image = Properties.Resources.RPG_Soldier;
                    GeneralImage2.SizeMode = PictureBoxSizeMode.StretchImage;
                    PlayerNameText2.Text = "RPG Soldier";
                    PlayerNameText2.ForeColor = Color.Blue;
                }
            }
                else if (battle.Unit2.ArmyMemberType == ArmyMember.EnumArmyMemberType.BazookaSoldier) {
                if (battle.Unit2.armyMemberLife <= 50) {
                    GeneralImage2.Image = Properties.Resources.Bazooka_Soldier_Red;
                    GeneralImage2.SizeMode = PictureBoxSizeMode.StretchImage;
                    PlayerNameText2.Text = "Bazooka Soldier";
                    PlayerNameText2.ForeColor = Color.Red;
                }
                else {
                    GeneralImage2.Image = Properties.Resources.Bazooka_Soldier;
                    GeneralImage2.SizeMode = PictureBoxSizeMode.StretchImage;
                    PlayerNameText2.Text = "Bazooka Soldier";
                    PlayerNameText2.ForeColor = Color.Blue;
                }
            }
                else if (battle.Unit2.ArmyMemberType == ArmyMember.EnumArmyMemberType.ArmoredCar) {
                if (battle.Unit2.armyMemberLife <= 50) {
                    GeneralImage2.Image = Properties.Resources.Armored_Car_Red;
                    GeneralImage2.SizeMode = PictureBoxSizeMode.StretchImage;
                    PlayerNameText2.Text = "Armored Car";
                    PlayerNameText2.ForeColor = Color.Red;
                }
                else {
                    GeneralImage2.Image = Properties.Resources.Armored_Car;
                    GeneralImage2.SizeMode = PictureBoxSizeMode.StretchImage;
                    PlayerNameText2.Text = "Armored Car";
                    PlayerNameText2.ForeColor = Color.Blue;
                }
            }
                else if (battle.Unit2.ArmyMemberType == ArmyMember.EnumArmyMemberType.BattleTank) {
                if (battle.Unit2.armyMemberLife <= 50) {
                    GeneralImage2.Image = Properties.Resources.Battle_Tank_Red;
                    GeneralImage2.SizeMode = PictureBoxSizeMode.StretchImage;
                    PlayerNameText2.Text = "Battle Tank";
                    PlayerNameText2.ForeColor = Color.Red;
                }
                else {
                    GeneralImage2.Image = Properties.Resources.Battle_Tank;
                    GeneralImage2.SizeMode = PictureBoxSizeMode.StretchImage;
                    PlayerNameText2.Text = "Battle Tank";
                    PlayerNameText2.ForeColor = Color.Blue;
                }
            }
        }

        protected override void OnFormClosing(FormClosingEventArgs e) {  //Exit the entire app when button X is pressed (avoiding the app to run in the background)
            Environment.Exit(0);
        }

    }
}