﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_Heroes_console_application.Heros
{
    internal abstract class HeroBaseClass
    {
        public string Name { get; set; }

        public int Level { get; set; } = 0;
        public HeroAttribute HeroAttributes { get; set; }

        public  string Equipment { get; set; }

        public string ValidWeaponTypes { get;  set; }

        public string ValidArmorTypes { get; set; }


        public HeroBaseClass(string name)
        {
            this.Name = name;
        }

        public abstract void LevelUp();
        public abstract void Equip();
        public abstract void Damage();
        public abstract void TotalAttributes();
        public abstract void Display();

    }
}