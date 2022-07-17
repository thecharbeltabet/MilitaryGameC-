using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoldierNS {
    class RifleSoldier : Soldier {

        public RifleSoldier() : base(){
            NameOfSoldier = "Rifle Soldier";
            ArmyMemberType = EnumArmyMemberType.RifleSoldier;
        }
    }
}
