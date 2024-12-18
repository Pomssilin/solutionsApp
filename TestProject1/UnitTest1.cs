using System;
using System.IO;
using Simple;

namespace TestProject1
{
    public class UnitTest
    {
        [Test]
        public void Calculer1()
        {
            // Arrange
            double a = 1;
            double b = -3;
            double c = 2; // Delta = 1, solutions: x1 = 2, x2 = 1
            string expectedOutput = $"L'�quation a deux solutions r�elles : x1 = 2, x2 = 1{Environment.NewLine}";

            using (StringWriter sw = new StringWriter())
            {
                Console.SetOut(sw);

                // Act
                Simple.Program.calculer(a, b, c);

                // Assert
                string result = sw.ToString();
                Assert.AreEqual(expectedOutput, result);
            }
        }

        [Test]
        public void Calculer2()
        {
            // Arrange
            double a = 1;
            double b = 2;
            double c = 1; // Delta = 0, solution unique: x = -1
            string expectedOutput = $"L'�quation a une solution unique : x = -1{Environment.NewLine}";

            using (StringWriter sw = new StringWriter())
            {
                Console.SetOut(sw);

                // Act
                Simple.Program.calculer(a, b, c);

                // Assert
                string result = sw.ToString();
                Assert.AreEqual(expectedOutput, result);
            }
        }

        [Test]
        public void Calculer3()
        {
            // Arrange
            double a = 1;
            double b = 1;
            double c = 1; // Delta = -3, pas de solutions r�elles
            string expectedOutput = $"L'�quation n'a pas de solution r�elle (discriminant n�gatif).{Environment.NewLine}";

            using (StringWriter sw = new StringWriter())
            {
                Console.SetOut(sw);

                // Act
                Simple.Program.calculer(a, b, c);

                // Assert
                string result = sw.ToString();
                Assert.AreEqual(expectedOutput, result);
            }
        }
    }
}
