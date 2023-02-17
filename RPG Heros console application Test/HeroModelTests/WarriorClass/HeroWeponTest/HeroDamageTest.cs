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

namespace RPG_Heros_console_application_Test.HeroModelTests.WarriorClass.HeroWeponTest
{
    public class HeroDamageTest
    {

        Warrior hero = new Warrior("Jerry");

        [Fact]
        public void Damage_EquipNoWepon_ShouldReturnCorrectDamageSum()
        {
            //Arrange
            double expected = 1.05;

            //act
            double actual = hero.Damage();
            //Assert
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void Damage_EquipWepon_ShouldReturnCorrectDamageSum()
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
        [Fact]
        public void Damage_ReplaceWepon_ShouldReturnCorrectDamageSum()
        {
            //Arrange
            double[] expected = { 2.1, 3.1500000000000004 };
            WeponModel equipment = new WeponModel("Common Axe", 1, WeaponTypesEnum.Axes, 2, SlotEnum.Wepon);
            hero.EquipWepon(equipment);
            double first = hero.Damage();
            WeponModel equipment2 = new WeponModel("Super Axe", 1, WeaponTypesEnum.Axes, 3, SlotEnum.Wepon);
            hero.EquipWepon(equipment2);
            double second = hero.Damage();
            //act
            double[] actual = { first, second };
            //Assert
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void Damage_EquipWeponAndArmor_ShouldReturnCorrectDamageSum()
        {
            //Arrange
            double expected = 2.14;
            WeponModel equipment = new WeponModel("Common Axe", 1, WeaponTypesEnum.Axes, 2, SlotEnum.Wepon);
            ArmorModel equipment2 = new ArmorModel("Common Mail Chest", SlotEnum.Body, 1, ArmorTypesEnum.Mail, new Attributes(2, 0, 0));
            hero.EquipWepon(equipment);
            hero.EquipArmor(equipment2);
            //act
            double actual = hero.Damage();
            //Assert
            Assert.Equal(expected, actual);
        }
    }
}
