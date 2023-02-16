using RPG_Heroes_console_application.Equipment.Armor;
using RPG_Heroes_console_application.Equipment;
using RPG_Heroes_console_application;
using RPG_Heroes_console_application.HeroModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RPG_Heroes_console_application.Equipment.Wepons;

namespace RPG_Heros_console_application_Test.EquipmentTests.Wepon
{
     public class HeroDamageTest
     {

        Warrior hero = new Warrior("Jerry");

        [Fact]
        public void Damage_EquipNoWepon_ShouldReturnCorrectSum()
        {
            //Arrange
            double expected = 1.05;

            //act
            double actual = hero.Damage();
            //Assert
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void Damage_EquipWepon_ShouldReturnCorrectSum()
        {
            //Arrange
            double expected = 2.1;
            WeponModel equipment = new WeponModel("Common Axe", 1, WeaponTypesEnum.Axes, 2, SlotEnum.Wepon);
            hero.EquipWepon(equipment);
            //act
            double actual = hero.Damage();
            //Assert
            Assert.Equal(expected, actual);
        }
    }
}
