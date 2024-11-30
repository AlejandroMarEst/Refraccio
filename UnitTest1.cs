using Microsoft.VisualStudio.TestPlatform.TestHost;
using Refracció;
namespace Test_Refacció
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestArea()
        {
            double width = 5;
            double height = 10;
            double expected = 50;

            double actual = Refracció.CalculateRectangleArea(width, height);

            Assert.Equals(expected, actual);
        }
        public void TestCircumferencia()
        {
            double width = 5;
            double height = 10;
            double expected = 50;

            double actual = Refracció.CalculateCircleCircumferencia(width, height);

            Assert.Equals(expected, actual);
        }
    }
}