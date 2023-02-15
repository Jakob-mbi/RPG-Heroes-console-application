﻿using RPG_Heroes_console_application.HeroModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_Heros_console_application_Test.HeroModelTests.RogueClass
{
    public class RougeLevelingTests
    {
        Rogue hero = new Rogue("Jack");

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
            int expectedStrength = 3;
            int expectedDexterity = 10;
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