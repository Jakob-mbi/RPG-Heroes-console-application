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

namespace RPG_Heros_console_application_Test.HeroModelTests.RangerClass.HeroWeponTest
{
    public class HeroDamageTest
    {

        Ranger hero = new Ranger("Jerry");

        [Fact]
        public void Damage_EquipNoWepon_ShouldReturnCorrectDamageSum()
        {
            //Arrange
            double expected = 1.07;

            //act
            double actual = hero.Damage();
            //Assert
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void Damage_EquipWepon_ShouldReturnCorrectDamageSum()
        {
            //Arrange
            double expected = 2.14;
            WeponModel equipment = new WeponModel("Common Bow", 1, WeaponTypesEnum.Bows, 2, SlotEnum.Wepon);
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
            double[] expected = { 2.14, 3.21 };
            WeponModel equipment = new WeponModel("Common Bow", 1, WeaponTypesEnum.Bows, 2, SlotEnum.Wepon);
            hero.EquipWepon(equipment);
            double first = hero.Damage();
            WeponModel equipment2 = new WeponModel("Super Bow", 1, WeaponTypesEnum.Bows, 3, SlotEnum.Wepon);
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
            double expected = 2.18;
            WeponModel equipment = new WeponModel("Common Bow", 1, WeaponTypesEnum.Bows, 2, SlotEnum.Wepon);
            ArmorModel equipment2 = new ArmorModel("Common Mail Chest", SlotEnum.Body, 1, ArmorTypesEnum.Mail, new Attributes(0, 2, 0));
            hero.EquipWepon(equipment);
            hero.EquipArmor(equipment2);
            //act
            double actual = hero.Damage();
            //Assert
            Assert.Equal(expected, actual);
        }
    }
}
