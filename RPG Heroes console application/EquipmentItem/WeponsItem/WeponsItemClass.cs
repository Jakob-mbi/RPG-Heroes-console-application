using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RPG_Heroes_console_application.EquipmentItem;
using RPG_Heroes_console_application.EquipmentItem.WeponsItem;


namespace RPG_Heroes_console_application.EquipmentItem.WeponsItem
{
    internal class WeponsItemClass : EquipmentBaseClass
    {
        public WeaponTypeEnum WeponType { get; private set; }
        public int WeaponDamage { get; private set; }

        public WeponsItemClass(string name, int requiredLevel, WeaponTypeEnum weponType, int weaponDamage, SlotEnum slot) : base(name, requiredLevel, slot)
        {
            WeponType = weponType;
            WeaponDamage = weaponDamage;
        }
    }
}
