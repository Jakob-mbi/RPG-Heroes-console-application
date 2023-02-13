using RPG_Heroes_console_application.EquipmentItem;
using RPG_Heroes_console_application.EquipmentItem.ArmorItem;
using RPG_Heroes_console_application.EquipmentItem.WeponsItem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_Heroes_console_application.Heros
{
    internal abstract class HeroBaseClass
    {
        protected string Name { get; set; }

        protected int Level { get; set; } = 0;
        protected HeroAttribute HeroAttributes { get; set; }

        protected Dictionary <SlotEnum,EquipmentBaseClass?> Equipment { get; set; }

        protected  List<WeaponTypeEnum> ValidWeaponTypes { get; set; }
        protected  List<ArmorTypeEnum> ValidArmorTypes { get; set; }

        public HeroBaseClass(string name)
        {
            this.Name = name;
        }

        public abstract void LevelUp();
        public void EquipArmor(ArmorItemTypeClass armor)
        {
            if (!ValidArmorTypes.Exists(validArmor => validArmor == armor.ArmorType))
            {
                throw new InvalidArmorException("You can not possess this armor type");
            }
            if (armor.RequiredLevel > Level)
            {
                throw new InvalidArmorException("You are not at the requierd level for this armor");
            }
           
        }
        public void EquipWepon(WeponsItemClass wepon)
        {
            if (!ValidWeaponTypes.Exists(validWepon => validWepon == wepon.WeponType))
            {
                throw new InvalidArmorException("You can not possess this armor type");
            }
            if (wepon.RequiredLevel > Level)
            {
                throw new InvalidArmorException("You are not at the requierd level for this armor");
            }
        }

        public abstract void Damage();
        public abstract void TotalAttributes();
        public abstract void Display();

    }
}
