using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_Heroes_console_application.Equipments.Wepons
{
    internal class WeponsClass : EquipmentBaseClass
    {
        public WeponTypeEnum WeponType { get; set; }

        public WeponsClass(string name, int requiredLevel, SlotEnum slot) : base(name, requiredLevel, slot)
        {
            this.Name = name;
            RequiredLevel= requiredLevel;
            Slot= slot;
        }
    }
}
