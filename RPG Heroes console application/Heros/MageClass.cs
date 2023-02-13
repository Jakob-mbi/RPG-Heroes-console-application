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
        protected override HeroAttribute HeroAttributes { get; set; }

        public MageClass(string name) : base(name)
        {
            HeroAttributes = new HeroAttribute(1, 1, 8);
            ValidWeaponTypes.Add(WeaponTypeEnum.Staffs);
            ValidWeaponTypes.Add(WeaponTypeEnum.Wands);
            ValidArmorTypes.Add(ArmorTypeEnum.Cloth);
        }

       
        public override void Damage()
        {
            throw new NotImplementedException();
        }

        public override void Display()
        {
            throw new NotImplementedException();
        }

        public override void LevelUp()
        {
            this.Level += 1;
            HeroAttributes.LevelUpAttribtues(1, 1, 5);
        }

       

    }
}
