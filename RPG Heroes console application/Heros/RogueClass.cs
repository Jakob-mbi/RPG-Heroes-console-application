﻿using RPG_Heroes_console_application.EquipmentItem;
using RPG_Heroes_console_application.EquipmentItem.ArmorItem;
using RPG_Heroes_console_application.EquipmentItem.WeponsItem;
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
            Equipment.Add(SlotEnum.Wepon, value: null);
            Equipment.Add(SlotEnum.Legs, value: null);
            Equipment.Add(SlotEnum.Head, value: null);
            Equipment.Add(SlotEnum.Body, value: null);
            this.HeroAttributes = new HeroAttribute(2, 6, 1);
            ValidWeaponTypes.Add(WeaponTypeEnum.Daggers);
            ValidWeaponTypes.Add(WeaponTypeEnum.Swords);
            ValidArmorTypes.Add(ArmorTypeEnum.Mail);
            ValidArmorTypes.Add(ArmorTypeEnum.Lether);
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

    }
}
