﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_Heroes_console_application.EquipmentItem.ArmorItem
{
    internal class InvalidArmorException : Exception
    {
        public InvalidArmorException() { }
        public InvalidArmorException(string message) : base(message) { }
    }
}
