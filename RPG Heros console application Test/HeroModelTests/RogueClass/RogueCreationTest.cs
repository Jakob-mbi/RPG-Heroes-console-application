using RPG_Heroes_console_application.HeroModels;

namespace RPG_Heros_console_application_Test.HeroModelTests.RogueClass
{
    public class RougeClassTest
    {
        Rogue hero = new Rogue("Jerry");
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
            var expectedClassOfHero = typeof(Rogue).ToString();
            //act
            var actual = hero.ClassOfHero;
            //Assert
            Assert.Equal(expectedClassOfHero, actual);
        }
        [Fact]
        public void HeroAttributes_GetAttributes_ShouldReturnCorrecttAttributesLevels()
        {
            //Arrange
            int expectedStrength = 2;
            int expectedDexterity = 6;
            int expectedIntelligence = 1;
            //act
            var actual = hero;
            //Assert
            Assert.Equal(expectedStrength, actual.HeroAttributes.Strength);
            Assert.Equal(expectedDexterity, actual.HeroAttributes.Dexterity);
            Assert.Equal(expectedIntelligence, actual.HeroAttributes.Intelligence);
        }
    }
}