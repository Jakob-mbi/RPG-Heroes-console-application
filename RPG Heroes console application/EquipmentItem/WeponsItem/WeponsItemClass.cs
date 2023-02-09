using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RPG_Heroes_console_application.Equipment.EquipmentItem;
using RPG_Heroes_console_application.Equipments;

namespace RPG_Heroes_console_application.EquipmentItem.WeponsItem
{
    internal class WeponsItemClass : EquipmentBaseClass
    {
        public WeaponTypeEnum WeponType { get; set; }
        public int WeaponDamage { get; set; }

        public WeponsItemClass(string name, int requiredLevel, WeponTypeEnum weponType, int weaponDamage) : base(name, requiredLevel, slot)
        {
            Name = name;
            RequiredLevel = requiredLevel;
            Slot = SlotEnum.Wepon
            WeponType = weponType;
            WeaponDamage = weaponDamage;
        }
    }
}
