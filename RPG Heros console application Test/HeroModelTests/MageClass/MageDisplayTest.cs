using RPG_Heroes_console_application.HeroModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace RPG_Heros_console_application_Test.HeroModelTests.MageClass
{
    public class MageDisplayTest
    {
        Mage hero = new Mage("Jerry");

        [Fact]
        public void Display_GetDisplayString_ShouldReturnCorrecttDisplayString()
        {
            //Arrange
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(hero.Name);
            sb.AppendLine($"{hero.ClassOfHero}");
            sb.AppendLine($"Strength:{hero.TotalAttributes().Strength}");
            sb.AppendLine($"Dexterity:{hero.TotalAttributes().Dexterity}");
            sb.AppendLine($"Inteligence:{hero.TotalAttributes().Intelligence}");
            sb.AppendLine($"Total damage:{hero.Damage()}");

            string expected = sb.ToString();

            //act
            string actual = hero.Display();
            //Assert
            Assert.Equal(expected,actual);
        }
    }
}
