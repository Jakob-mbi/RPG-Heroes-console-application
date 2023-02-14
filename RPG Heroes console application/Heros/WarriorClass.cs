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
    internal class WarriorClass : HeroBaseClass
    {


      

        public WarriorClass(string name) : base(name)
        {
            ClassOfHero = typeof(WarriorClass).ToString();
            HeroAttributes.InitialAttributes(5, 2, 1);
            ValidWeaponTypes.Add(WeaponTypeEnum.Axes);
            ValidWeaponTypes.Add(WeaponTypeEnum.Hammers);
            ValidWeaponTypes.Add(WeaponTypeEnum.Swords);
            ValidArmorTypes.Add(ArmorTypeEnum.Mail);
            ValidArmorTypes.Add(ArmorTypeEnum.Lether);
        }

        

        public override int Damage()
        {
            int totalDamage = 0;

            if (Equipment[SlotEnum.Wepon] is WeponsItemClass)
            {
                WeponsItemClass? wepon = (WeponsItemClass?)Equipment[SlotEnum.Wepon];
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
