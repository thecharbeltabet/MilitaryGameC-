using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleNS {
    class ArmoredCar : Vehicle {

        public ArmoredCar(): base() {
            NameOfVehicule = "Armored Car";
            ArmyMemberType = EnumArmyMemberType.ArmoredCar;
        }
    }
}
