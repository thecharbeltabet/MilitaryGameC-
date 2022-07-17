using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GeneralNS;
using AndrewArnitaCharbelTabet_Project;

namespace ArmyNS {
    class ArmyMember{

        public int armyMemberLife;
        public int armyMemberAmmunition;

        public static int counter = 0;

        public static List<string> listOfBattles = new List<string>();

        public static StringBuilder stringBuilder = new StringBuilder();

        public EnumArmyMemberStatus ArmyMemberStatus;
        public EnumArmyMemberType ArmyMemberType;

        public ArmyMember() {  //Constructor
            armyMemberLife = 100;
            armyMemberAmmunition = 100;
            ArmyMemberStatus = EnumArmyMemberStatus.Active;
        }

        //general vs general results
        public static void BattleConfrontations(ArmyMember armyMember1, ArmyMember armyMember2, General general1, General general2 ) {
            if(armyMember1.ArmyMemberType == EnumArmyMemberType.RifleSoldier) {
                if(armyMember2.ArmyMemberType == EnumArmyMemberType.RifleSoldier) {
                    armyMember1.ReduceLife(50, general1);
                    armyMember1.ReduceAmmunition(1, general1);
                    armyMember2.ReduceLife(50, general2);
                    armyMember2.ReduceAmmunition(1, general2);
                }
                else if (armyMember2.ArmyMemberType == EnumArmyMemberType.RPGSoldier) {
                    armyMember1.ReduceAmmunition(1,general1);
                    armyMember2.ReduceLife(50, general2);
                }
                else if (armyMember2.ArmyMemberType == EnumArmyMemberType.BazookaSoldier) {
                    armyMember1.ReduceAmmunition(1, general1);
                    armyMember2.ReduceLife(50, general2);
                }
                
            }
            if(armyMember1.ArmyMemberType == EnumArmyMemberType.RPGSoldier) {
                if(armyMember2.ArmyMemberType == EnumArmyMemberType.RifleSoldier) {
                    armyMember1.ReduceLife(50, general1);
                    armyMember2.ReduceAmmunition(1,general2);
                }
                else if (armyMember2.ArmyMemberType == EnumArmyMemberType.ArmoredCar) {
                    armyMember1.ReduceAmmunition(1, general1);
                    armyMember2.ReduceLife(50, general2);
                }
                else if (armyMember2.ArmyMemberType == EnumArmyMemberType.BattleTank) {
                    armyMember1.ReduceAmmunition(1,general1);
                    armyMember2.ReduceLife(25, general2);
                }
                
            }
            if (armyMember1.ArmyMemberType == EnumArmyMemberType.BazookaSoldier) {
                if(armyMember2.ArmyMemberType == EnumArmyMemberType.RifleSoldier) {
                    armyMember1.ReduceLife(50, general1);
                    armyMember2.ReduceAmmunition(1,general2);
                }
                else if(armyMember2.ArmyMemberType == EnumArmyMemberType.ArmoredCar) {
                    armyMember1.ReduceAmmunition(1,general1);
                    armyMember2.ReduceLife(25, general2);
                }
                else if (armyMember2.ArmyMemberType == EnumArmyMemberType.BattleTank) {
                    armyMember1.ReduceAmmunition(1,general1);
                    armyMember2.ReduceLife(50, general2);
                }
                
            }
            if(armyMember1.ArmyMemberType == EnumArmyMemberType.ArmoredCar) {
                if(armyMember2.ArmyMemberType == EnumArmyMemberType.RPGSoldier) {
                    armyMember1.ReduceLife(50, general1);
                    armyMember2.ReduceAmmunition(1, general2);
                }
                else if (armyMember2.ArmyMemberType == EnumArmyMemberType.BazookaSoldier) {
                    armyMember1.ReduceLife(25, general1);
                    armyMember2.ReduceAmmunition(1, general2);
                }
                else if (armyMember2.ArmyMemberType == EnumArmyMemberType.BattleTank) {
                    armyMember1.ReduceLife(100, general1);
                    armyMember2.ReduceAmmunition(1,general2);
                }
                
            }
            if(armyMember1.ArmyMemberType == EnumArmyMemberType.BattleTank) {
                if(armyMember2.ArmyMemberType == EnumArmyMemberType.RPGSoldier) {
                    armyMember1.ReduceLife(25, general1);
                    armyMember2.ReduceAmmunition(1,general2);
                }
                else if(armyMember2.ArmyMemberType == EnumArmyMemberType.BazookaSoldier) {
                    armyMember1.ReduceLife(50, general1);
                    armyMember2.ReduceAmmunition(1,general2);
                }
                else if(armyMember2.ArmyMemberType == EnumArmyMemberType.ArmoredCar) {
                    armyMember1.ReduceAmmunition(1,general1);
                    armyMember2.ReduceLife(100, general2);
                }
                else if(armyMember2.ArmyMemberType == EnumArmyMemberType.BattleTank) {
                    armyMember1.ReduceLife(50, general1);
                    armyMember1.ReduceAmmunition(1,general1);
                    armyMember2.ReduceLife(50, general2);
                    armyMember2.ReduceAmmunition(1,general2);
                }
              
            }
            if (counter % 5 == 0 && IntroForm.NumbOfBattles >= 100) { //to visualize results better in the message box at the end
                stringBuilder.AppendLine();
            }
            else if (counter % 3 == 0)
                stringBuilder.AppendLine();

            counter++;
            stringBuilder.Append($"Round {counter}: {armyMember1.ArmyMemberType} vs {armyMember2.ArmyMemberType}  ");
            armyMember1.ArmyMemberStatusChanged();
            armyMember2.ArmyMemberStatusChanged();
            //MessageBox.Show($"{armyMember1.ArmyMemberType}: {armyMember1.armyMemberLife} vs {armyMember2.ArmyMemberType}: {armyMember2.armyMemberLife} ");
        }

        public static void AddToListOfBattles() { //saving each battle results of each game in a specific index using a stringbuilder so we can output it in the resultsForm
                listOfBattles.Add($"{stringBuilder}");
                stringBuilder.Clear();
        }

        //Status of each army member:
        private void ArmyMemberStatusChanged() {
            if (armyMemberAmmunition > 0 && armyMemberLife > 0)
                ArmyMemberStatus = EnumArmyMemberStatus.Active;

            else if (armyMemberAmmunition == 0 && armyMemberLife > 0)
                    ArmyMemberStatus = EnumArmyMemberStatus.Inactive;

            else if (armyMemberLife <= 0) {
                if (ArmyMemberType == EnumArmyMemberType.RifleSoldier || ArmyMemberType == EnumArmyMemberType.RPGSoldier
                    || ArmyMemberType == EnumArmyMemberType.BazookaSoldier) {
                    ArmyMemberStatus = EnumArmyMemberStatus.Deceased;
                }

                else if (ArmyMemberType == EnumArmyMemberType.ArmoredCar || ArmyMemberType == EnumArmyMemberType.BattleTank) {
                    ArmyMemberStatus = EnumArmyMemberStatus.Destroyed;
                }
            }
        }

        //Reduce Life of each member:
        private void ReduceLife(int reducedLife, General general) {
            if (reducedLife >= armyMemberLife) { //reduce the exact life without going below 0
                general.PlayerLifeDecreases(armyMemberLife);
                armyMemberLife = 0;
            }
            else { 
                general.PlayerLifeDecreases(reducedLife);
                armyMemberLife -= reducedLife;
            }

        }

        //Reduce ammo of each member:
        private void ReduceAmmunition(int ammo, General general) {
            if (armyMemberAmmunition > 0) {
                general.PlayerAmmoDecreases(ammo);
                armyMemberAmmunition -= ammo;
            }
        }

        public enum EnumArmyMemberStatus {
            Active,
            Inactive,
            Deceased,
            Destroyed,
        }

        public enum EnumArmyMemberType {
            RifleSoldier,
            RPGSoldier,
            BazookaSoldier,
            ArmoredCar,
            BattleTank,
        }
    }
}
