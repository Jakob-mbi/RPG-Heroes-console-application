using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_Heroes_console_application
{
    internal class LevelAttribtues
    {
        private int strength { get; set; }
        private int Dexterity { get; set; }
        private int Intelligence { get; set; }

        public LevelAttribtues(int strength, int dexterity, int intelligence)
        {
            this.strength = strength;
            Dexterity = dexterity;
            Intelligence = intelligence;
        }

        public void LevelUpAttribtues(int strength, int dexterity, int intelligence)
        {
            this.strength = strength;
            Dexterity = dexterity;
            Intelligence = intelligence;
        }
    }
}
