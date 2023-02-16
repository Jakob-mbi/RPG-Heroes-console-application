using RPG_Heroes_console_application;
using RPG_Heroes_console_application.Equipment;
using RPG_Heroes_console_application.Equipment.Armor;
using RPG_Heroes_console_application.Equipment.Wepons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Xunit.Abstractions;

namespace RPG_Heros_console_application_Test.CreateEquipmentTests
{
    public class ArmorCreationTests
    {
        ArmorModel equipment = new ArmorModel("Common Plate Chest",SlotEnum.Body,1,ArmorTypesEnum.Plate, new Attributes(1, 0, 0));
        [Fact]
        public void Name_GetName_ShouldReturnCorrectName()
        {
            //Arrange
            string expected = "Common Plate Chest";
            //act
            string actual = equipment.Name;
            //Assert
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void RequiredLevel_GetRequiredLevel_ShouldReturnCorrectRequiredLevel()
        {
            //Arrange
            int expected = 1;
            //act
            int actual = equipment.RequiredLevel;
            //Assert
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void Slot_GetSlot_ShouldReturnCorrectSlot()
        {
            //Arrange
            SlotEnum expected = SlotEnum.Body;
            //act
            SlotEnum actual = equipment.Slot;
            //Assert
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void Armortype_GetArmortype_ShouldReturnCorrectArmortype()
        {
            //Arrange
            ArmorTypesEnum expected = ArmorTypesEnum.Plate;
            //act
            ArmorTypesEnum actual = equipment.ArmorType;
            //Assert
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void ArmorAttribute_GetArmorAttributes_ShouldReturnCorrectArmorAttribute()
        {
            //Arrange
            int[] expected = {1,0,0};
            //act
            int[] actual = {equipment.ArmorAttribute.Strength,equipment.ArmorAttribute.Dexterity,equipment.ArmorAttribute.Intelligence};
            //Assert
            Assert.Equal(expected, actual);
        }

    }
}
