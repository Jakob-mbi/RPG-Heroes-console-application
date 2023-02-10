using RPG_Heroes_console_application.EquipmentItem;
using RPG_Heroes_console_application.EquipmentItem.WeponsItem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_Heroes_console_application.Heros
{
    internal abstract class HeroBaseClass
    {
        protected string Name { get; set; }

        protected int Level { get; set; } = 0;
        protected HeroAttribute HeroAttributes { get; set; }

        protected Dictionary <SlotEnum,EquipmentBaseClass> Equipment { get; set; }

        protected string ValidWeaponTypes { get;  set; }

        protected string ValidArmorTypes { get; set; }

        protected enum EquipmentTypeAllowd { }

        public HeroBaseClass(string name)
        {
            this.Name = name;
            Equipment.Add(SlotEnum.Wepon, value: null);
            Equipment.Add(SlotEnum.Legs, value: null);
            Equipment.Add(SlotEnum.Head, value: null);
            Equipment.Add(SlotEnum.Body, value: null);
        }

        public abstract void LevelUp();
        public void Equip(EquipmentTypeAllowd Type, SlotEnum slot)
        {
            throw new NotImplementedException();

        }
        public abstract void Damage();
        public abstract void TotalAttributes();
        public abstract void Display();

    }
}
