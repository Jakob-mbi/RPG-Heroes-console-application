using RPG_Heroes_console_application.Equipment.Armor;
using RPG_Heroes_console_application.Equipment;
using RPG_Heroes_console_application;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RPG_Heroes_console_application.HeroModels;

namespace RPG_Heros_console_application_Test.HeroModelTests.RangerClass.HeroArmorTest
{
    public class TotalAttributesTest
    {
        Ranger hero = new Ranger("Jerry");

        [Fact]
        public void TotalAttributes_EquipNoArmor_ShouldReturnCorrectSumOfAttribuets()
        {
            //Arrange
            Attributes e = new Attributes(1, 7, 1);        
            int[] expected = {e.Strength,e.Dexterity,e.Intelligence };
            //act
            int[] actual = { hero.TotalAttributes().Strength, hero.TotalAttributes().Dexterity, hero.TotalAttributes().Intelligence };
            //Assert
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void TotalAttributes_EquipOnePieceOfArmor_ShouldReturnCorrectSumOfAttribuets()
        {
            //Arrange
            Attributes e = new Attributes(2, 7, 1);
            int[] expected = { e.Strength, e.Dexterity, e.Intelligence };
            ArmorModel equipment = new ArmorModel("Common Mail Chest", SlotEnum.Body, 1, ArmorTypesEnum.Mail, new Attributes(1, 0, 0));
            hero.EquipArmor(equipment);
            //act
            int[] actual = { hero.TotalAttributes().Strength, hero.TotalAttributes().Dexterity, hero.TotalAttributes().Intelligence };
            //Assert
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void TotalAttributes_EquipTwoPieceOfArmor_ShouldReturnCorrectSumOfAttribuets()
        {
            //Arrange
            Attributes e = new Attributes(3, 7, 1);
            int[] expected = { e.Strength, e.Dexterity, e.Intelligence };
            ArmorModel equipment = new ArmorModel("Common Mail Chest", SlotEnum.Body, 1, ArmorTypesEnum.Mail, new Attributes(1, 0, 0));
            ArmorModel equipment2 = new ArmorModel("Common Mail Helmet", SlotEnum.Head, 1, ArmorTypesEnum.Mail, new Attributes(1, 0, 0));
            hero.EquipArmor(equipment);
            hero.EquipArmor(equipment2);
            //act
            int[] actual = { hero.TotalAttributes().Strength, hero.TotalAttributes().Dexterity, hero.TotalAttributes().Intelligence };
            //Assert
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void TotalAttributes_ReplacedAPieceOfArmor_ShouldReturnCorrectSumOfAttribuets()
        {
            //Arrange
            Attributes e1 = new Attributes(2, 7, 1);
            int[] Armor1 = { e1.Strength, e1.Dexterity, e1.Intelligence };
            Attributes e2 = new Attributes(3, 7, 1);
            int[] Armor2 = { e2.Strength, e2.Dexterity, e2.Intelligence };
            int[][] expected = { Armor1, Armor2 };

            ArmorModel equipment = new ArmorModel("Common Mail Chest", SlotEnum.Body, 1, ArmorTypesEnum.Mail, new Attributes(1, 0, 0));
            ArmorModel equipment2 = new ArmorModel("Super Mail Chest", SlotEnum.Body, 1, ArmorTypesEnum.Mail, new Attributes(2, 0, 0));

            hero.EquipArmor(equipment);
            int[] withFirstPiece = { hero.TotalAttributes().Strength, hero.TotalAttributes().Dexterity, hero.TotalAttributes().Intelligence };
            hero.EquipArmor(equipment2);
            int[] withSecondPiece = { hero.TotalAttributes().Strength, hero.TotalAttributes().Dexterity, hero.TotalAttributes().Intelligence };

            //act
            int[][] actual = { withFirstPiece, withSecondPiece };

            //Assert
            Assert.Equal(expected, actual);
        }
    }
}
