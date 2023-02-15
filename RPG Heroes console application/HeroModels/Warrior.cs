using RPG_Heroes_console_application.Equipment;
using RPG_Heroes_console_application.Equipment.Armor;
using RPG_Heroes_console_application.Equipment.Wepons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_Heroes_console_application.HeroModels
{
    public class Warrior : HeroBaseModel
    {


      

        public Warrior(string name) : base(name)
        {
            ClassOfHero = typeof(Warrior).ToString();
            HeroAttributes.InitialAttributes(5, 2, 1);
            ValidWeaponTypes.Add(WeaponTypesEnum.Axes);
            ValidWeaponTypes.Add(WeaponTypesEnum.Hammers);
            ValidWeaponTypes.Add(WeaponTypesEnum.Swords);
            ValidArmorTypes.Add(ArmorTypesEnum.Mail);
            ValidArmorTypes.Add(ArmorTypesEnum.Lether);
        }

        

        public override int Damage()
        {
            int totalDamage = 0;

            if (Equipment[SlotEnum.Wepon] is WeponModel)
            {
                WeponModel? wepon = (WeponModel?)Equipment[SlotEnum.Wepon];
                totalDamage += wepon.WeaponDamage;
                totalDamage *= (1 + HeroAttributes.Strength / 100);
            }
            else
            {
                totalDamage = 1;
            }
            return totalDamage;
        }

        public override void LevelUp()
        {
            this.Level += 1;
            HeroAttributes.LevelUpAttribtues(3, 2, 1);
        }

        

    }
}
