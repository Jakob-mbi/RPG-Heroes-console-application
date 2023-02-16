using RPG_Heroes_console_application.HeroModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_Heros_console_application_Test.HeroModelTests.WarriorClass
{
    public class WarriorAttribteTest
    {
        Warrior hero = new Warrior("Jerry");

        [Fact]
        public void HeroAttributes_GetStrength_ShouldReturnCorrecttStrengthLevel()
        {
            //Arrange
            int expectedStrength = 5;

            //act
            var actual = hero;
            //Assert
            Assert.Equal(expectedStrength, actual.HeroAttributes.Strength);
        }
        [Fact]
        public void HeroAttributes_GetDexterity_ShouldReturnCorrecttDexterityLevel()
        {
            //Arrange
            int expectedDexterity = 2;
            //act
            var actual = hero;
            //Assert
            Assert.Equal(expectedDexterity, actual.HeroAttributes.Dexterity);
        }
        [Fact]
        public void HeroAttributes_GetIntelligence_ShouldReturnCorrecttIntelligenceLevel()
        {
            //Arrange
            int expectedIntelligence = 1;
            //act
            var actual = hero;
            //Assert
            Assert.Equal(expectedIntelligence, actual.HeroAttributes.Intelligence);
        }
    }
}
