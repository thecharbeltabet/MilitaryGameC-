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
    public partial class IntroForm : Form {
        public static int NumbOfBattles;

        public static int NumbOfSoldiers;

        public static int NumbOfVehicles;

        public static string nameOfGeneral1;
        public static string nameOfGeneral2;

        public IntroForm() {
            InitializeComponent();
        }

        private void BtnWar_Click(object sender, EventArgs e) { 

            //Text fields cannot be empty
            if (GeneralField1.Text == "" || GeneralField2.Text == "") {
                MessageBox.Show("Don't forget your names!","Attention Generals!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            //Fields cannot be empty
            if (BattlesField.Text == "" || SoldiersField.Text == "" || VehiculesField.Text == "")
                MessageBox.Show("Please don't leave empty fields for the battles!","Attention Generals!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            else if(IntroForm.NumbOfBattles == 0 || IntroForm.NumbOfSoldiers == 0 || IntroForm.NumbOfVehicles == 0)
                MessageBox.Show("The number 0 in a war is a bad sign!", "Be Careful Generals!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            else { 
                this.Hide(); //Hide the Intro Form
                GameForm gameForm = new GameForm(); //Instantiate the GameForm and sending values
                gameForm.ShowDialog();
                this.Close();
            }
            
        }

        //Saving the fields for later use

        private void GeneralField1_TextChanged(object sender, EventArgs e) {
             nameOfGeneral1 = GeneralField1.Text; //Saving the name of player 1
        }

        private void GeneralField2_TextChanged(object sender, EventArgs e) {
             nameOfGeneral2 = GeneralField2.Text; //Saving the name of player 2
        }

        //Saving the numbers of each text box
        public void RoundField_TextChanged(object sender, EventArgs e) {
            if (int.TryParse(BattlesField.Text, out _)) {
                NumbOfBattles = Convert.ToInt32(BattlesField.Text);
            }
        }

        public void SoldiersField_TextChanged(object sender, EventArgs e) {
            if (int.TryParse(SoldiersField.Text, out _)) {
                NumbOfSoldiers = Convert.ToInt32(SoldiersField.Text);
            }
        }

        public void VehiculesField_TextChanged(object sender, EventArgs e) {
            if (int.TryParse(VehiculesField.Text, out _)) {
                NumbOfVehicles = Convert.ToInt32(VehiculesField.Text);
            }
        }


        // Cannot place a number in the name fields
        private void GeneralField1_KeyPress(object sender, KeyPressEventArgs text) {
            if (!char.IsControl(text.KeyChar) && !char.IsLetter(text.KeyChar)) {  //Only characters
                text.Handled = true;
            }
           
        }

        private void GeneralField2_KeyPress(object sender, KeyPressEventArgs text) {
            if (!char.IsControl(text.KeyChar) && !char.IsLetter(text.KeyChar)) { //Only characters
                text.Handled = true;
            }
        }

        // Cannot place a character in the numeric fields
        private void RoundField_KeyPress(object sender, KeyPressEventArgs num) { 
            if (!char.IsControl(num.KeyChar) && !char.IsDigit(num.KeyChar)) { //Only Digits
                num.Handled = true;
            }
        }

        private void SoldiersField_KeyPress(object sender, KeyPressEventArgs num) {
            if (!char.IsControl(num.KeyChar) && !char.IsDigit(num.KeyChar)) { //Only Digits
                num.Handled = true;
            }
        }

        private void VehiculesField_KeyPress(object sender, KeyPressEventArgs num) {
            if (!char.IsControl(num.KeyChar) && !char.IsDigit(num.KeyChar)) { //Only Digits
                num.Handled = true;
            }
        }
    }
}
