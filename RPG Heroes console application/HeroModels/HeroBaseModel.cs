
using RPG_Heroes_console_application.Equipment;
using RPG_Heroes_console_application.Equipment.Armor;
using RPG_Heroes_console_application.Equipment.Wepons;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_Heroes_console_application.HeroModels
{
    public abstract class HeroBaseModel
    {
        public string Name { get; protected set; }

        public string ClassOfHero { get; protected set; }

        public int Level { get; protected set; } = 0;
        public Attributes HeroAttributes { get; protected set; } = new Attributes();

        public Dictionary <SlotEnum,EquipmentBaseClass?> Equipment { get; protected set; } = new Dictionary<SlotEnum, EquipmentBaseClass?>();

        public  List<WeaponTypesEnum> ValidWeaponTypes { get; protected set; } = new List<WeaponTypesEnum>();
        public  List<ArmorTypesEnum> ValidArmorTypes { get; protected set; } = new List<ArmorTypesEnum>();

        public HeroBaseModel(string name)
        {
            this.Name = name;
            Equipment.Add(SlotEnum.Wepon, value: null);
            Equipment.Add(SlotEnum.Legs, value: null);
            Equipment.Add(SlotEnum.Head, value: null);
            Equipment.Add(SlotEnum.Body, value: null);           
        }

        public abstract void LevelUp();
        public virtual void EquipArmor(ArmorModel armor)
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
        public virtual void EquipWepon(WeponModel wepon)
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
                if (armor.Value is ArmorModel)
                {
                    ArmorModel childClass = (ArmorModel)armor.Value;
                    totalAttribute += childClass.ArmorAttribute.AttribtuesSum();
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
