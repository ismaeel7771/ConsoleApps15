using ConsoleAppProject.App01;

namespace ConsoleApp.Tests
{
    [TestClass]
    public class TestDistanceConverter
    {
        [TestMethod]
        public void TestMilesToFeet()
        {
            DistanceConverter converter = new DistanceConverter();
              
                
                converter.FromUnit = DistanceConverter.MILES;
            converter.ToUnit = DistanceConverter.FEET;



            converter.FromDistance = 1.0;
            converter.CalculateDistance();

            double expectedDistance = 5280;

            Assert.AreEqual(expectedDistance, converter.ToDistance);
        }
      
        [TestMethod]
        public void TestFeetToMiles()
        {
            DistanceConverter converter = new DistanceConverter();

            converter.FromUnit = DistanceConverter.FEET;
            converter.ToUnit = DistanceConverter.MILES;

            converter.FromDistance = 5280;
            converter.CalculateDistance();

            double expectedDistance = 1.0;
            Assert.AreEqual(expectedDistance, converter.ToDistance);
        }
       
        [TestMethod]
        public void TestMilesToMetres()
        {
            DistanceConverter converter = new DistanceConverter();

            converter.FromUnit = DistanceConverter.MILES;
            converter.ToUnit = DistanceConverter.METRES;

            converter.FromDistance = 1.0;
            converter.CalculateDistance();

            double expectedDistance = 1609.34;
            Assert.AreEqual(expectedDistance, converter.ToDistance, 0.01); // Allowing a small tolerance due to potential floating-point precision issues
        }


        [TestMethod]
        public void TestMetresToMiles()
        {
            DistanceConverter converter = new DistanceConverter();

            converter.FromUnit = DistanceConverter.METRES;
            converter.ToUnit = DistanceConverter.MILES;

            converter.FromDistance = 1609.34;
            converter.CalculateDistance();

            double expectedDistance = 1.0;
            Assert.AreEqual(expectedDistance, converter.ToDistance, 0.01);
        }


        [TestMethod]
        public void TestMetresToFeet()
        {
            DistanceConverter converter = new DistanceConverter();

            converter.FromUnit = DistanceConverter.METRES;
            converter.ToUnit = DistanceConverter.FEET;

            converter.FromDistance = 1.0;
            converter.CalculateDistance();

            double expectedDistance = 3.28084;
            Assert.AreEqual(expectedDistance, converter.ToDistance, 0.01);
        }

       

        [TestMethod]
        public void TestFeetToMetres()
        {
            DistanceConverter converter = new DistanceConverter();

            converter.FromUnit = DistanceConverter.FEET;
            converter.ToUnit = DistanceConverter.METRES;

            converter.FromDistance = 3.28084;
            converter.CalculateDistance();

            double expectedDistance = 1.0;
            Assert.AreEqual(expectedDistance, converter.ToDistance, 0.01);
        }

       

    }
}
    