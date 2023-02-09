using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_Heroes_console_application.Equipments.Wepons
{
    internal class WeponsClass : EquipmentBaseClass
    {
        public WeaponTypeEnum WeponType { get; set; }
        public int WeaponDamage { get; set; }

        public WeponsClass(string name, int requiredLevel, WeponTypeEnum weponType,int weaponDamage) : base(name, requiredLevel, slot)
        {
            this.Name = name;
            RequiredLevel = requiredLevel;
            Slot = SlotEnum.Wepon
            WeponType = weponType;
            WeaponDamage = weaponDamage;
        }
    }
}
