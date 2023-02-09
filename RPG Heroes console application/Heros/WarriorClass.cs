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
            this.Name = name;
            this.HeroAttributes = new HeroAttribute(5, 2, 1);
        }

        public enum EquipmentTypeAllowdForWarrior
        {
            Axe,
            Hammer,
            sword,
            Mail,
            Plate
        }

        public override void Damage()
        {
            throw new NotImplementedException();
        }

        public override void Display()
        {
            throw new NotImplementedException();
        }

        public override void Equip()
        {
            throw new NotImplementedException();
        }

        public override void LevelUp()
        {
            this.Level += 1;
            HeroAttributes.LevelUpAttribtues(3, 2, 1);
        }

        public override void TotalAttributes()
        {
            throw new NotImplementedException();
        }
    }
}
