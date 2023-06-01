using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UdemyUnitTest.APP;

namespace UdemyUnitTest.Test
{
    public class CalculatorTest
    {
        [Fact]
        public void AddTest()
        {
            #region test 1 Equal, NotEqual
            /*
            // Arrange
            int a = 5;
            int b = 20;
            var calculator = new Calculator();

            // Act
            var total = calculator.Add(a, b);

            // Assert
            Assert.Equal<int>(25, total);
            Assert.NotEqual<int>(26, total);
            */
            #endregion

            #region test 2 Contains, DoesNotContain
            /*
            Assert.Contains("Kenan", "Kenan Idayatov");

            Assert.DoesNotContain("Kenan", "Revan Idayatov");

            var names = new List<string>()
            {
                "Kenan",
                "Revan",
                "Nihad"
            };

            Assert.Contains(names, x => x == "Kenan");
            */
            #endregion

            #region test 3 True, False
            /*
            Assert.True(5 > 2);
            Assert.False(5 < 2);
            */
            #endregion

            #region test 4 

            #endregion


        }
    }
}
