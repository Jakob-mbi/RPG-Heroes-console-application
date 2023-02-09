using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RPG_Heroes_console_application.EquipmentItem;

namespace RPG_Heroes_console_application.EquipmentItem
{
    internal abstract class EquipmentBaseClass
    {
        public string Name { get; set; }
        public int RequiredLevel { get; set; }
        public SlotEnum Slot { get; set; }

        public EquipmentBaseClass(string name, int requiredLevel, SlotEnum slot)
        {
            Name = name;
            RequiredLevel = requiredLevel;
            Slot = slot;
        }
    }
}
