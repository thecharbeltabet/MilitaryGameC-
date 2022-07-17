using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ArmyNS;

namespace SoldierNS {
    class Soldier : ArmyMember {

        public Soldier(): base() { }
        public string NameOfSoldier { get; set; }
    }
}
