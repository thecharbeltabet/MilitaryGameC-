using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ArmyNS;
using GeneralNS;

namespace BattleNS {
    class Battle {

        public ArmyMember Unit1;
        public ArmyMember Unit2;

        public int BattleNumber; //already have it
        public bool hasAlreadyPlayed;

        public Battle(int battleNumber) {
            Unit1 = new ArmyMember();
            Unit2 = new ArmyMember();

            battleNumber = BattleNumber;
            hasAlreadyPlayed = false;
        }

        //Battle has started:
        public void StartBattle(General general1, General general2) {
            ArmyMember.BattleConfrontations(Unit1, Unit2, general1, general2);
            hasAlreadyPlayed = true;
        }
    }
}
