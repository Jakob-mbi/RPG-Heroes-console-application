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
    internal class RangerClass : HeroBaseClass
    {
      

        public RangerClass(string name) : base(name)
        {
            ClassOfHero = typeof(RangerClass).ToString();
            HeroAttributes.InitialAttributes(1, 7, 1);
            ValidWeaponTypes.Add(WeaponTypeEnum.Bows);
            ValidArmorTypes.Add(ArmorTypeEnum.Lether);
            ValidArmorTypes.Add(ArmorTypeEnum.Mail);
        }

        

        public override int Damage()
        {
            int totalDamage = 0;

            if (Equipment[SlotEnum.Wepon] is WeponsItemClass)
            {
                WeponsItemClass? wepon = (WeponsItemClass?)Equipment[SlotEnum.Wepon];
                totalDamage += wepon.WeaponDamage;
                totalDamage *= (1 + HeroAttributes.Dexterity / 100);
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
            HeroAttributes.LevelUpAttribtues(1, 5, 1);
        }

       

    }
}
