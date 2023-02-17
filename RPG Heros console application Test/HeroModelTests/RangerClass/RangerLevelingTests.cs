using RPG_Heroes_console_application.HeroModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_Heros_console_application_Test.HeroModelTests.RangerClass
{
    public class RangerLevelingTests
    {
        Ranger hero = new Ranger("Jack");

        [Fact]
        public void LevelUp_IncreseLevel_ShouldReturnCorrectlyIncrementedLevel()
        {
            //Arrange
            int expectedLevel = 2;
            hero.LevelUp();
            //act 
            int actual = hero.Level;
            //Assert
            Assert.Equal(expectedLevel, actual);
        }
        [Fact]
        public void LevelUp_IncreseHeroAttributes_ShouldReturnCorrectlyIncrementedAttributes()
        {
            //Arrange
            int[] expected = { 2, 12, 2 };
            hero.LevelUp();
            //act 
            int[] actual = { hero.HeroAttributes.Strength, hero.HeroAttributes.Dexterity, hero.HeroAttributes.Intelligence };
            //Assert
            Assert.Equal(expected, actual);
        }
    }
}
