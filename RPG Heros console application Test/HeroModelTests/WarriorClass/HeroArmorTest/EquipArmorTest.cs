using RPG_Heroes_console_application.Equipment;
using RPG_Heroes_console_application;
using RPG_Heroes_console_application.Equipment.Armor;
using RPG_Heroes_console_application.HeroModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_Heros_console_application_Test.HeroModelTests.WarriorClass.HeroArmorTest
{
    public class EquipArmorTest
    {
        Warrior hero = new Warrior("Jerry");

        [Fact]
        public void EquipArmor_EquipInvalidArmorType_ShouldThrowInvalidArmorException()
        {
            //Arrange
            ArmorModel equipment = new ArmorModel("Common Plate Chest", SlotEnum.Body, 1, ArmorTypesEnum.Cloth, new Attributes(1, 0, 0));
            // Act & Assert
            Assert.Throws<InvalidArmorException>(() => hero.EquipArmor(equipment));
        }
        [Fact]
        public void EquipArmor_EquipArmorWithHigherRequiredLevel_ShouldThrowInvalidArmorException()
        {
            //Arrange
            ArmorModel equipment = new ArmorModel("Common Plate Chest", SlotEnum.Body, 2, ArmorTypesEnum.Cloth, new Attributes(1, 0, 0));
            // Act & Assert
            Assert.Throws<InvalidArmorException>(() => hero.EquipArmor(equipment));
        }
        [Fact]
        public void EquipArmor_EquipArmor_ShouldbeInEquipmentDictionary()
        {
            //Arrange
            ArmorModel equipmentl = new ArmorModel("Common Plate Chest", SlotEnum.Body, 1, ArmorTypesEnum.Mail, new Attributes(1, 0, 0));
            hero.EquipArmor(equipmentl);
            ArmorModel expected = equipmentl;

            //act
            EquipmentBaseModel actual = hero.Equipment[SlotEnum.Body];
            //Assert
            Assert.Equal(expected, actual);
        }
    }
}
