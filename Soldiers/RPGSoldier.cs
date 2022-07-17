using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ArmyNS;
using BattleNS;
namespace SoldierNS {
    class RPGSoldier : Soldier {
        public RPGSoldier(): base() {
            NameOfSoldier = "RPG Soldier";
            ArmyMemberType = EnumArmyMemberType.RPGSoldier;
        }
    }
}