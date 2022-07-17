using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleNS {
    class BattleTank : Vehicle {

        public BattleTank(): base() {
            NameOfVehicule = "Battle Tank";
            ArmyMemberType = EnumArmyMemberType.BattleTank;
        }
    }
}