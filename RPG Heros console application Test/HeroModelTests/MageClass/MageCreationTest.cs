using Newtonsoft.Json.Linq;
using RPG_Heroes_console_application.HeroModels;

namespace RPG_Heros_console_application_Test.HeroModelTests.MageClass
{
    public class MageCreationTest
    {
        
        Mage hero = new Mage("Jerry");

        [Fact]
        public void Name_GetName_ShouldReturnCorrectName()
        {
            //Arrange
            string expectedName = "Jerry";
            //act
            string actual = hero.Name;
            //Assert
            Assert.Equal(expectedName, actual);
        }

        [Fact]
        public void Level_GetLevel_ShouldReturnCorrectLevel()
        {
            //Arrange
            int expectedLevel = 0;
            //act
            int actual = hero.Level;
            //Assert
            Assert.Equal(expectedLevel, actual);
        }
        [Fact]
        public void ClassOfHero_GetClassOfHero_ShouldReturnCorrecttClassOfHero()
        {
            //Arrange
            var expectedClassOfHero = typeof(Mage).ToString();
            //act
            var actual = hero.ClassOfHero;
            //Assert
            Assert.Equal(expectedClassOfHero, actual);
        }
        [Fact]
        public void HeroAttributes_GetAttributes_ShouldReturnCorrecttAttributesLevels()
        {
            //Arrange
            int expectedStrength = 1;
            int expectedDexterity = 1;
            int expectedIntelligence = 8;
            //act
            var actual = hero;
            //Assert
            Assert.Equal(expectedStrength, actual.HeroAttributes.Strength);
            Assert.Equal(expectedDexterity, actual.HeroAttributes.Dexterity);
            Assert.Equal(expectedIntelligence, actual.HeroAttributes.Intelligence);
        }
    }
}