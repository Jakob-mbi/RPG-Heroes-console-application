
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

        public int Level { get; protected set; } = 1;
        public Attributes HeroAttributes { get; protected set; } = new Attributes();

        public Dictionary <SlotEnum,EquipmentBaseModel?> Equipment { get; protected set; } = new Dictionary<SlotEnum, EquipmentBaseModel?>();

        public  List<WeaponTypesEnum> ValidWeaponTypes { get; protected set; } = new List<WeaponTypesEnum>();
        public  List<ArmorTypesEnum> ValidArmorTypes { get; protected set; } = new List<ArmorTypesEnum>();

        public HeroBaseModel(string name)
        {
            this.Name = name;
            this.ClassOfHero = this.GetType().Name;
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
                throw new InvalidWeaponException("You can not possess this Wepon type");
            }
            else if (wepon.RequiredLevel > Level)
            {
                throw new InvalidWeaponException("You are not at the requierd level for this Wepon");
            }
            else
            {
                Equipment[wepon.Slot] = wepon;
            }

        }

        public abstract double Damage();
        public virtual Attributes TotalAttributes()
        {
            Attributes total = new Attributes(HeroAttributes.Strength,HeroAttributes.Dexterity,HeroAttributes.Intelligence);


            foreach (KeyValuePair<SlotEnum, EquipmentBaseModel?> armor in Equipment)
            {
                if (armor.Value is ArmorModel)
                {
                    ArmorModel childClass = (ArmorModel)armor.Value;
                    total.LevelUpAttribtues(childClass.ArmorAttribute.Strength,childClass.ArmorAttribute.Dexterity,childClass.ArmorAttribute.Intelligence);
                }
            }
            return total;
        }
        public virtual string Display()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(Name);
            sb.AppendLine($"{ClassOfHero}");
            sb.AppendLine($"Strength:{TotalAttributes().Strength}");
            sb.AppendLine($"Dexterity:{TotalAttributes().Dexterity}");
            sb.AppendLine($"Inteligence:{TotalAttributes().Intelligence}");
            sb.AppendLine($"Total damage:{Damage()}");
            

            return sb.ToString();
        }

    }
}
