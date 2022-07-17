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
    public partial class ResultsForm : Form {
        public ResultsForm() {
            InitializeComponent();
        }

        private void ResultsForm_Load_1(object sender, EventArgs e) { //Display the game number
            for (int i = 0; i < FirstForm.gameCounter; i++) { 
                ResultsListBox.Items.Add($"Game {i + 1}: {GameForm.listBuilder.ElementAt(i * 4)}"); //up by 4 each time to sleect the new element in GameForm at a specific index of the list
            }
        }

        private void BtnExitGame_Click(object sender, EventArgs e) { //Exit the whole Game
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to exit the game?", "Warning!", MessageBoxButtons.YesNo,MessageBoxIcon.Exclamation);

            if(dialogResult == DialogResult.Yes)
                Application.Exit();

        }

        //private void BtnTryAgain_Click(object sender, EventArgs e) {  //can restart the same game with same army but different results (as an extra feature)
        //    ArmyMember.counter = 0; //null the counter for a new games
        //    this.Hide();
        //    GameForm gameForm = new GameForm(); //Instantiate the GameForm and sending values
        //    gameForm.ShowDialog();
        //    this.Close();
        //}

        private void BtnNewGame_Click(object sender, EventArgs e) {
            ArmyMember.counter = 0; //null the counter for a new game
            this.Hide();
            IntroForm introForm = new IntroForm(); //Instantiate the IntroForm and sending values
            introForm.ShowDialog();
            this.Close();
        }

        private void ResultsListBox_DoubleClick(object sender, EventArgs e) {
            if (ResultsListBox.SelectedIndex != -1) { //On double click display the results of each game
                    MessageBox.Show($"Game {ResultsListBox.SelectedIndex + 1}:\n\n" // 0 1 2 3 at a selected index make it * 4 so we get the 4 new added strings and choose accordingly 
                    + $"{GameForm.listBuilder.ElementAt((ResultsListBox.SelectedIndex * 4))} {GameForm.listBuilder.ElementAt((ResultsListBox.SelectedIndex * 4) + 2)}\n" //player 1 Total...
                    + $"{GameForm.listBuilder.ElementAt((ResultsListBox.SelectedIndex * 4) + 1)} {GameForm.listBuilder.ElementAt((ResultsListBox.SelectedIndex * 4) + 3)}\n" //player 2 Total...
                    + $"{ArmyMember.listOfBattles.ElementAt(ResultsListBox.SelectedIndex)}", "These are your results Generals!"); //return the sb of every selected index of the list 
            }
        }
    }
}
