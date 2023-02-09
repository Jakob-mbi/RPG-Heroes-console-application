using RPG_Heroes_console_application.EquipmentItem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_Heroes_console_application.Heros
{
    internal class RogueClass : HeroBaseClass
    {
        public RogueClass(string name) : base(name)
        {
            this.Name = name;
            this.HeroAttributes = new HeroAttribute(2, 6, 1);
        }

        public enum EquipmentTypeAllowd
        {
            Dagger,
            Sword,
            Lether,
            Mail
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
            HeroAttributes.LevelUpAttribtues(1, 4, 1);
        }

        public override void TotalAttributes()
        {
            throw new NotImplementedException();
        }

        public override void Equip(HeroBaseClass.EquipmentTypeAllowd Type, SlotEnum slot)
        {
            throw new NotImplementedException();
        }
    }
}
