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
    public class Mage : HeroBaseModel
    {
       

        public Mage(string name) : base(name)
        {
            HeroAttributes.InitialAttributes(1, 1, 8);          
            ValidWeaponTypes.Add(WeaponTypesEnum.Staffs);
            ValidWeaponTypes.Add(WeaponTypesEnum.Wands);
            ValidArmorTypes.Add(ArmorTypesEnum.Cloth);
        }

       
        public override double Damage()
        {
            double totalDamage = 0;
   
            if (Equipment[SlotEnum.Wepon] is WeponModel)
            {
                WeponModel wepon = (WeponModel)Equipment[SlotEnum.Wepon];
                totalDamage += wepon.WeaponDamage; 
            }
            else
            {
                totalDamage = 1;
            }
            totalDamage *= (1.0 + Convert.ToDouble(TotalAttributes().Intelligence) / 100.0);

            return totalDamage;
        }

        public override void LevelUp()
        {
            this.Level += 1;
            HeroAttributes.LevelUpAttribtues(1, 1, 5);
        }

       

    }
}
