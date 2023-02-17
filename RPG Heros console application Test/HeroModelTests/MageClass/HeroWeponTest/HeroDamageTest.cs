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

namespace RPG_Heros_console_application_Test.HeroModelTests.MageClass.HeroWeponTest
{
    public class HeroDamageTest
    {

        Mage hero = new Mage("Jerry");

        [Fact]
        public void Damage_EquipNoWepon_ShouldReturnCorrectDamageSum()
        {
            //Arrange
            double expected = 1.08;

            //act
            double actual = hero.Damage();
            //Assert
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void Damage_EquipWepon_ShouldReturnCorrectDamageSum()
        {
            //Arrange
            double expected = 2.16;
            WeponModel equipment = new WeponModel("Common staff", 1, WeaponTypesEnum.Staffs, 2);
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
            double[] expected = { 2.16,3.24 };
            WeponModel equipment = new WeponModel("Common staff", 1, WeaponTypesEnum.Staffs, 2);
            hero.EquipWepon(equipment);
            double first = hero.Damage();
            WeponModel equipment2 = new WeponModel("Super staff", 1, WeaponTypesEnum.Staffs, 3);
            hero.EquipWepon(equipment2);
            double second = hero.Damage();
            //act
            double[] actual = {first, second};
            //Assert
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void Damage_EquipWeponAndArmor_ShouldReturnCorrectDamageSum()
        {
            //Arrange
            double expected = 2.2;
            WeponModel equipment = new WeponModel("Common staff", 1, WeaponTypesEnum.Staffs, 2);
            ArmorModel equipment2 = new ArmorModel("Common cloth",SlotEnum.Body,1,ArmorTypesEnum.Cloth, new Attributes(0, 0, 2));
            hero.EquipWepon(equipment);
            hero.EquipArmor(equipment2);
            //act
            double actual = hero.Damage();
            //Assert
            Assert.Equal(expected, actual);
        }
    }
}
