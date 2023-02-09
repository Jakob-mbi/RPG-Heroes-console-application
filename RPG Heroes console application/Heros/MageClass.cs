using System;
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
            this.Name = name;
            this.HeroAttributes = new HeroAttribute(1,1,8);
            Eq

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
            HeroAttributes.LevelUpAttribtues(1, 1, 5);
        }

        public override void TotalAttributes()
        {
            throw new NotImplementedException();
        }
    }
}
