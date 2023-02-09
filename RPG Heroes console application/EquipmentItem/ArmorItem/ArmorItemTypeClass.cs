using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RPG_Heroes_console_application.EquipmentItem;
using RPG_Heroes_console_application.EquipmentItem.ArmorItem;

namespace RPG_Heroes_console_application.EquipmentItem.ArmorItem
{
    internal class ArmorItemTypeClass : EquipmentBaseClass
    {
        public int ArmorAttribute { get; set; }
        public ArmorTypeEnum ArmorType { get; set; }

        public ArmorItemTypeClass(string name, SlotEnum slot, int requiredLevel, ArmorTypeEnum armorType, int armorAttribute) : base(name, requiredLevel, slot)
        {
            Name = name;
            RequiredLevel = requiredLevel;
            Slot = slot;
            ArmorType = armorType;
            ArmorAttribute = armorAttribute;

        }

    }
}
