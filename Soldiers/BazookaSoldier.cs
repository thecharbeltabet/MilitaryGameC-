using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoldierNS {
    class BazookaSoldier : Soldier {

        public BazookaSoldier(): base() {
            NameOfSoldier = "Bazooka Soldier";
            ArmyMemberType = EnumArmyMemberType.BazookaSoldier;
        }
    }
}
