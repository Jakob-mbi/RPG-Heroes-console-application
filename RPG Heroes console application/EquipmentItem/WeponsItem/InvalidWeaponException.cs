using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_Heroes_console_application.EquipmentItem.WeponsItem
{
    internal class InvalidWeaponException :Exception
    {
         public InvalidWeaponException() { }
         public InvalidWeaponException(string message) : base(message) { }
    }
}
