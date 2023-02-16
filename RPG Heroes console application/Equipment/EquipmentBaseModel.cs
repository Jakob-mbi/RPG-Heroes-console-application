using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RPG_Heroes_console_application.Equipment;

namespace RPG_Heroes_console_application.Equipment
{
    public abstract class EquipmentBaseModel
    {
        public  string Name { get; protected set; }
        public int RequiredLevel { get; protected set; }
        public SlotEnum Slot { get; protected set; }

        public EquipmentBaseModel(string name, int requiredLevel, SlotEnum slot)
        {
            Name = name;
            RequiredLevel = requiredLevel;
            Slot = slot;
        }
    }
}
