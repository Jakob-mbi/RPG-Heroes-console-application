using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_Heroes_console_application.Heros
{
    internal interface Ihero
    {
        string name { get; set; }

        int level { get; set; }
        int LevelAttribtues { get; set; }

        string Equipment { get; set; }

        string ValidWeaponTypes { get; set; }

        string ValidArmorTypes { get; set; }

        public void LevelUp();
        public void Equip();
        public void Damage();
        public void TotalAttributes();
        public void Display();

    }
}
