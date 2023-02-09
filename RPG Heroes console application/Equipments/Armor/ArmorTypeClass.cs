using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_Heroes_console_application.Equipments.Armor
{
    internal class ArmorTypeClass : EquipmentBaseClass
    {
        public int ArmorAttribute { get; set; }
        public ArmorTypeEnum ArmorType { get; set; }

        public ArmorTypeClass(string name,SlotEnum slot int requiredLevel, ArmorTypeEnum armorType, int armorAttribute) : base(name, requiredLevel, slot)
        {
            this.Name = name;
            RequiredLevel = requiredLevel;
            Slot = slot;
            ArmorType = armorType;
            ArmorAttribute = armorAttribute;

        }

    }
}
