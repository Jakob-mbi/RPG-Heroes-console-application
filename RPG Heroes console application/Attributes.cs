using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_Heroes_console_application
{
    public class Attributes
    {
        public int Strength { get; private set; }
        public int Dexterity { get; private set; }
        public int Intelligence { get; private set; }
    
        public Attributes() { }
        public Attributes(int strength,int dexterity,int intelligence) 
        { 
            Strength = strength;
            Dexterity = dexterity;
            Intelligence = intelligence;
        }  
        public void LevelUpAttribtues(int strength, int dexterity, int intelligence)
        {
            this.Strength += strength;
            Dexterity += dexterity;
            Intelligence += intelligence;
        }
        public int AttribtuesSum()
        {
            int sum = Strength+Dexterity+Intelligence;

            return sum;
        }
        public void InitialAttributes(int strength, int dexterity, int intelligence)
        {
            this.Strength = strength;
            Dexterity = dexterity;
            Intelligence = intelligence;
        }


    }
}
