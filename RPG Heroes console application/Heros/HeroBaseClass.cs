using RPG_Heroes_console_application.EquipmentItem;
using RPG_Heroes_console_application.EquipmentItem.ArmorItem;
using RPG_Heroes_console_application.EquipmentItem.WeponsItem;
using System;
using System.Collections;
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
        protected abstract HeroAttribute HeroAttributes { get; set; }

        protected Dictionary <SlotEnum,EquipmentBaseClass?> Equipment { get; set; }

        protected  List<WeaponTypeEnum> ValidWeaponTypes { get; set; }
        protected  List<ArmorTypeEnum> ValidArmorTypes { get; set; }

        public HeroBaseClass(string name)
        {
            this.Name = name;
            ValidWeaponTypes = new List<WeaponTypeEnum>();
            ValidArmorTypes = new List<ArmorTypeEnum>();
            Equipment = new Dictionary<SlotEnum, EquipmentBaseClass?>();
            Equipment.Add(SlotEnum.Wepon, value: null);
            Equipment.Add(SlotEnum.Legs, value: null);
            Equipment.Add(SlotEnum.Head, value: null);
            Equipment.Add(SlotEnum.Body, value: null);
                    
        }

        public abstract void LevelUp();
        public void EquipArmor(ArmorItemTypeClass armor)
        {
            if (!ValidArmorTypes.Exists(validArmor => validArmor == armor.ArmorType))
            {
                throw new InvalidArmorException("You can not possess this armor type");
            }
            else if (armor.RequiredLevel > Level)
            {
                throw new InvalidArmorException("You are not at the requierd level for this armor");
            }
            else
            {
                Equipment[armor.Slot] = armor;
            }
  
        }
        public void EquipWepon(WeponsItemClass wepon)
        {
            if (!ValidWeaponTypes.Exists(validWepon => validWepon == wepon.WeponType))
            {
                throw new InvalidArmorException("You can not possess this armor type");
            }
            else if (wepon.RequiredLevel > Level)
            {
                throw new InvalidArmorException("You are not at the requierd level for this armor");
            }
            else
            {
                Equipment[wepon.Slot] = wepon;
            }

        }

        public abstract void Damage();
        public void TotalAttributes()
        {
            int totalAttribute = HeroAttributes.AttribtuesSum();


            foreach (KeyValuePair<SlotEnum, EquipmentBaseClass?> armor in Equipment)
            {
                if (armor.Value is ArmorItemTypeClass)
                {
                    ArmorItemTypeClass childClass = (ArmorItemTypeClass)armor.Value;
                    totalAttribute += childClass.ArmorAttribute;
                }
            }

        }
        public abstract void Display();

    }
}
