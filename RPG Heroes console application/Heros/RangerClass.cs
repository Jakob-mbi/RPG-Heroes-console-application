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
        protected override HeroAttribute HeroAttributes { get; set; }

        public RangerClass(string name) : base(name)
        {
            this.HeroAttributes = new HeroAttribute(1, 7, 1);
            ValidWeaponTypes.Add(WeaponTypeEnum.Bows);
            ValidArmorTypes.Add(ArmorTypeEnum.Lether);
            ValidArmorTypes.Add(ArmorTypeEnum.Mail);
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
            HeroAttributes.LevelUpAttribtues(1, 5, 1);
        }

       

    }
}
