using RPG_Heroes_console_application.Equipment;
using RPG_Heroes_console_application.Equipment.Wepons;
using RPG_Heroes_console_application.HeroModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace RPG_Heros_console_application_Test.EquipmentTests.Wepon
{
    public class WeponCreationTest
    {
        WeponModel equipment = new WeponModel("Common Axe", 1, WeaponTypesEnum.Axes, 2, SlotEnum.Wepon);

        [Fact]
        public void Name_GetName_ShouldReturnCorrectName()
        {
            //Arrange
            string expected = "Common Axe";
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
            SlotEnum expected = SlotEnum.Wepon;
            //act
            SlotEnum actual = equipment.Slot;
            //Assert
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void Weapontype_GetWeapontype_ShouldReturnCorrectWeapontype()
        {
            //Arrange
            WeaponTypesEnum expected = WeaponTypesEnum.Axes;
            //act
            WeaponTypesEnum actual = equipment.WeponType;
            //Assert
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void WeaponDamage_GetWeaponDamage_ShouldReturnCorrectWeaponDamage()
        {
            //Arrange
            int expected = 2;
            //act
            int actual = equipment.WeaponDamage;
            //Assert
            Assert.Equal(expected, actual);
        }
    }
}
