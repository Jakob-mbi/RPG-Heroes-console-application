using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_Heroes_console_application.Equipments
{
    internal abstract class EquipmentBaseClass
    {
        public string Name { get; set; }
        public int RequiredLevel { get; set; }
        public SlotEnum Slot { get; set; }  
        
        public EquipmentBaseClass(string name,int requiredLevel, SlotEnum slot) 
        {
            this.Name = name;
            this.RequiredLevel = requiredLevel;
            this.Slot = slot;
        }
    }
}
