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

        protected string ClassOfHero { get; set; }

        protected int Level { get; set; } = 0;
        protected HeroAttribute HeroAttributes { get; set; } = new HeroAttribute();

        protected Dictionary <SlotEnum,EquipmentBaseClass?> Equipment { get; set; } = new Dictionary<SlotEnum, EquipmentBaseClass?>();

        protected  List<WeaponTypeEnum> ValidWeaponTypes { get; set; } = new List<WeaponTypeEnum>();
        protected  List<ArmorTypeEnum> ValidArmorTypes { get; set; } = new List<ArmorTypeEnum>();

        public HeroBaseClass(string name)
        {
            this.Name = name;
            Equipment.Add(SlotEnum.Wepon, value: null);
            Equipment.Add(SlotEnum.Legs, value: null);
            Equipment.Add(SlotEnum.Head, value: null);
            Equipment.Add(SlotEnum.Body, value: null);           
        }

        public abstract void LevelUp();
        public virtual void EquipArmor(ArmorItemTypeClass armor)
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
        public virtual void EquipWepon(WeponsItemClass wepon)
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

        public abstract int Damage();
        public virtual void TotalAttributes()
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
        public virtual string Display()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(Name);
            sb.AppendLine($"{ClassOfHero}");
            sb.AppendLine($"Strength:{HeroAttributes.Strength}");
            sb.AppendLine($"Dexterity:{HeroAttributes.Dexterity}");
            sb.AppendLine($"Inteligence:{HeroAttributes.Intelligence}");
            sb.AppendLine($"Total damage:{Damage()}");
            

            return sb.ToString();
        }

    }
}
