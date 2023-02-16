using RPG_Heroes_console_application.Equipment.Armor;
using RPG_Heroes_console_application.Equipment;
using RPG_Heroes_console_application;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RPG_Heroes_console_application.HeroModels;

namespace RPG_Heros_console_application_Test.EquipmentTests.Armor
{
    public class TotalAttributesTest
    {
        Warrior hero = new Warrior("Jerry");

        [Fact]
        public void TotalAttributes_EquipNoArmor_ShouldReturnCorrectSum()
        {
            //Arrange
            int expected = 8;

            //act
            int actual = hero.TotalAttributes();
            //Assert
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void TotalAttributes_EquipOnePieceOfArmor_ShouldReturnCorrectSum()
        {
            //Arrange
            int expected = 9;
            ArmorModel equipment = new ArmorModel("Common Plate Chest", SlotEnum.Body, 1, ArmorTypesEnum.Plate, new Attributes(1, 0, 0));
            hero.EquipArmor(equipment);
            //act
            int actual = hero.TotalAttributes();
            //Assert
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void TotalAttributes_EquipTwoPieceOfArmor_ShouldReturnCorrectSum()
        {
            //Arrange
            int expected = 10;
            ArmorModel equipment = new ArmorModel("Common Plate Chest", SlotEnum.Body, 1, ArmorTypesEnum.Plate, new Attributes(1, 0, 0));
            ArmorModel equipment2 = new ArmorModel("Common Plate helmet", SlotEnum.Head, 1, ArmorTypesEnum.Plate, new Attributes(1, 0, 0));
            hero.EquipArmor(equipment);
            hero.EquipArmor(equipment2);
            //act
            int actual = hero.TotalAttributes();
            //Assert
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void TotalAttributes_ReplacedAPieceOfArmor_ShouldReturnCorrectSum()
        {
            //Arrange
            int[] expected = { 9, 10 };

            ArmorModel equipment = new ArmorModel("Common Plate Chest", SlotEnum.Body, 1, ArmorTypesEnum.Plate, new Attributes(1, 0, 0));
            ArmorModel equipment2 = new ArmorModel("Common Mail Chest", SlotEnum.Body, 1, ArmorTypesEnum.Mail, new Attributes(2, 0, 0));

            hero.EquipArmor(equipment);
            int withFirstPiece = hero.TotalAttributes();
            hero.EquipArmor(equipment2);
            int withSecondPiece = hero.TotalAttributes();

            //act
            int[] actual = {withFirstPiece,withSecondPiece};

            //Assert
            Assert.Equal(expected, actual);
        }
    }
}
