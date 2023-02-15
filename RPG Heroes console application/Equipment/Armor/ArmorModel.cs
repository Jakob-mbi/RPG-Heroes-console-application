using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RPG_Heroes_console_application.Equipment;
using RPG_Heroes_console_application.Equipment.Armor;

namespace RPG_Heroes_console_application.Equipment.Armor
{
    public class ArmorModel : EquipmentBaseClass
    {
        public Attributes ArmorAttribute { get; private set; }
        public ArmorTypesEnum ArmorType { get; private set; }

        public ArmorModel(string name, SlotEnum slot, int requiredLevel, ArmorTypesEnum armorType, Attributes armorAttribute) : base(name, requiredLevel, slot)
        {
            ArmorType = armorType;
            ArmorAttribute = armorAttribute;
        }

    }
}
