using RPG_Heroes_console_application.Equipment.Armor;
using RPG_Heroes_console_application.Equipment;
using RPG_Heroes_console_application.HeroModels;
using RPG_Heroes_console_application;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RPG_Heroes_console_application.Equipment.Wepons;

namespace RPG_Heros_console_application_Test.HeroModelTests.RogueClass.HeroWeponTest
{
    public class EquipWeponTest
    {
        Rogue hero = new Rogue("Jerry");

        [Fact]
        public void EquipWepon_EquipInvalidWeponType_ShouldThrowInvalidWeponException()
        {
            //Arrange
            WeponModel equipment = new WeponModel("Common Axe", 1, WeaponTypesEnum.Axes, 2);
            // Act & Assert
            Assert.Throws<InvalidWeaponException>(() => hero.EquipWepon(equipment));
        }
        [Fact]
        public void EquipWepon_EquipWeponWithHigherRequiredLevel_ShouldThrowInvalidWeponException()
        {
            //Arrange
            WeponModel equipment = new WeponModel("Common Dagger", 2, WeaponTypesEnum.Daggers, 2);
            // Act & Assert
            Assert.Throws<InvalidWeaponException>(() => hero.EquipWepon(equipment));
        }
        [Fact]
        public void EquipWepon_EquipWepon_ShouldbeInEquipmentDictionary()
        {
            //Arrange
            WeponModel equipment = new WeponModel("Common Dagger", 1, WeaponTypesEnum.Daggers, 2);
            hero.EquipWepon(equipment);
            WeponModel expected = equipment;

            //act
            EquipmentBaseModel actual = hero.Equipment[SlotEnum.Wepon];
            //Assert
            Assert.Equal(expected, actual);
        }
    }
}
