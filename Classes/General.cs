using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ArmyNS;
using SoldierNS;
using VehicleNS;
using AndrewArnitaCharbelTabet_Project;

namespace GeneralNS {
    class General {
        public string GeneralName = "";

        public List<ArmyMember> listOfArmyMembers = new List<ArmyMember>(IntroForm.NumbOfSoldiers + IntroForm.NumbOfVehicles);

        public static Random randomUnit1 = new Random();
        public static Random randomUnit2 = new Random();
        public static Random randomUnit3 = new Random();

        public int NumberOfSoldiers;
        public int NumberOfVehicles;

        public int TotalLife;
        public int TotalAmmo;
        public General(string generalName, List<ArmyMember> listofArmyMembers) {
            listOfArmyMembers = listofArmyMembers;
            GeneralName = generalName;
            NumberOfSoldiers = 0;
            NumberOfVehicles = 0;
        }

        //Create the army from units:
        public void CreateArmyOfUnits() {
            listOfArmyMembers.Clear();

            StringBuilder stringBuilder = new StringBuilder();

            for (int i = 0; i < IntroForm.NumbOfSoldiers; i++) {

                int SoldierType = randomUnit1.Next(3);

                if (SoldierType == 0) {
                    RifleSoldier rifleSoldier = new RifleSoldier();
                    listOfArmyMembers.Add(rifleSoldier);
                    NumberOfSoldiers++;
                    stringBuilder.Append($"{listOfArmyMembers.ElementAt(i).ArmyMemberType}\n");
                }
                else if (SoldierType == 1) {
                    RPGSoldier rpgSoldier = new RPGSoldier();
                    listOfArmyMembers.Add(rpgSoldier);
                    NumberOfSoldiers++;
                    stringBuilder.Append($"{listOfArmyMembers.ElementAt(i).ArmyMemberType}\n");
                }
                else if (SoldierType == 2) {
                    BazookaSoldier bazookaSoldier = new BazookaSoldier();
                    listOfArmyMembers.Add(bazookaSoldier);
                    NumberOfSoldiers++;
                    stringBuilder.Append($"{listOfArmyMembers.ElementAt(i).ArmyMemberType}\n");
                }
            }

            for (int j = IntroForm.NumbOfSoldiers ; j < IntroForm.NumbOfVehicles + IntroForm.NumbOfSoldiers; j++) {

                int VehiculeType = randomUnit2.Next(2);

                if (VehiculeType == 0) {
                    ArmoredCar armoredCar = new ArmoredCar();
                    listOfArmyMembers.Add(armoredCar);
                    NumberOfVehicles++;
                    stringBuilder.Append($"{listOfArmyMembers.ElementAt(j).ArmyMemberType}\n");
                }
                else if (VehiculeType == 1) {
                    BattleTank battleTank = new BattleTank();
                    listOfArmyMembers.Add(battleTank);
                    NumberOfVehicles++;
                    stringBuilder.Append($"{listOfArmyMembers.ElementAt(j).ArmyMemberType}\n");
                }   
            }
            TotalLife = listOfArmyMembers.Count * 100;
            TotalAmmo = listOfArmyMembers.Count * 1000;
            MessageBox.Show(stringBuilder.ToString(),$"{GeneralName}'s Army:",MessageBoxButtons.OK,MessageBoxIcon.Information); //to see the array
        }

        //allocate a randomized player to each army:
        public int SelectArmyUnit(List<ArmyMember> listArmyMember) {
            while (true) {
                int selectedArmyMemberIndex = randomUnit3.Next(0, listArmyMember.Count);
                //MessageBox.Show($"{selectedArmyMemberIndex}");
                if (listArmyMember.ElementAt(selectedArmyMemberIndex).ArmyMemberStatus == ArmyMember.EnumArmyMemberStatus.Active)
                    return selectedArmyMemberIndex;
            }
        }

        //Decrease the player's life:
        public void PlayerLifeDecreases(int playerLifeLost) {
            TotalLife -= playerLifeLost;
        }

        public void PlayerAmmoDecreases(int playerAmmoLost) {
            TotalAmmo -= playerAmmoLost;
        }
    }
}
