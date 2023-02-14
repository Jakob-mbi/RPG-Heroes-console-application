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
    internal class MageClass : HeroBaseClass
    {
       

        public MageClass(string name) : base(name)
        {
            ClassOfHero = typeof(MageClass).ToString();
            HeroAttributes.InitialAttributes(1, 1, 8);          
            ValidWeaponTypes.Add(WeaponTypeEnum.Staffs);
            ValidWeaponTypes.Add(WeaponTypeEnum.Wands);
            ValidArmorTypes.Add(ArmorTypeEnum.Cloth);
        }

       
        public override int Damage()
        {
            int totalDamage = 0;
   
            if (Equipment[SlotEnum.Wepon] is WeponsItemClass)
            {
                WeponsItemClass? wepon = (WeponsItemClass?) Equipment[SlotEnum.Wepon];
                totalDamage += wepon.WeaponDamage;
                totalDamage *= (1 + HeroAttributes.Intelligence / 100); 
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
            HeroAttributes.LevelUpAttribtues(1, 1, 5);
        }

       

    }
}
