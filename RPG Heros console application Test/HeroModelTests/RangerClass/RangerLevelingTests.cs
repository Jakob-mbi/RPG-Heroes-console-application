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
            int expectedLevel = 1;
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
            int expectedStrength = 2;
            int expectedDexterity = 12;
            int expectedIntelligence = 2;
            hero.LevelUp();
            //act 
            var actual = hero;
            //Assert
            //Assert
            Assert.Equal(expectedStrength, actual.HeroAttributes.Strength);
            Assert.Equal(expectedDexterity, actual.HeroAttributes.Dexterity);
            Assert.Equal(expectedIntelligence, actual.HeroAttributes.Intelligence);
        }
    }
}
