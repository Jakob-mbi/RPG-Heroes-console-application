using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RPG_Heroes_console_application.Equipment;
using RPG_Heroes_console_application.Equipment.Wepons;


namespace RPG_Heroes_console_application.Equipment.Wepons
{
    public class WeponModel : EquipmentBaseModel
    {
        public WeaponTypesEnum WeponType { get; private set; }
        public int WeaponDamage { get; private set; }

        public WeponModel(string name, int requiredLevel, WeaponTypesEnum weponType, int weaponDamage, SlotEnum slot = SlotEnum.Wepon) : base(name, requiredLevel, slot)
        {
            WeponType = weponType;
            WeaponDamage = weaponDamage;
        }
    }
}
