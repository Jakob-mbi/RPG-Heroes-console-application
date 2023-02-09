using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_Heroes_console_application.EquipmentItem
{
    internal class EquipmentException : Exception
    {
        public EquipmentException() :base() { }
        public EquipmentException(string message) : base(message) { }
    }
}
