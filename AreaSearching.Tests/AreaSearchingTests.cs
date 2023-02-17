namespace AreaSearching.Tests
{
    [TestClass]
    public class AreaSearchingTests
    {
        [TestMethod]
        public void GetArea_5_25return()
        {
            int radius = 5;
            double expected = 25;

            double actual = AreaSearching.Shared.GetArea(radius);

            Assert.AreEqual(expected, actual);
        
        }
        [TestMethod]
        public void GetArea_sides3and4and5_angles60and60and60_6return()
        {
            List<int> sides = new List<int> { 3, 4, 5 };
            List<int> angles = new List<int> { 60, 60, 60 };
            double expected = 6;

            double actual = AreaSearching.Shared.GetArea(sides, angles);

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void AppendFigure_Quadrangle3and4_12return()
        {
            List<int> sides = new List<int> { 3, 4, 3, 4};
            List<int> angles = new List<int> { 90, 90, 90, 90 };
            double expected = 12;

            QuadrangleTests testQuadrangle = new QuadrangleTests();
            AreaSearching.Shared.AppendFigure(testQuadrangle);
            double actual = AreaSearching.Shared.GetArea(sides, angles);

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void GetArea_sides2and2and2_angles50and50and50_ErrorReturn()
        {
            List<int> sides = new List<int> { 2, 2, 2 };
            List<int> angles = new List<int> { 50, 50, 50 };
            
            var checkException = Assert.ThrowsException<Exception>(() => AreaSearching.Shared.GetArea(sides, angles));

            Assert.AreEqual("No valid figures were found", checkException.Message);
        }
    }

    //Просто пример реализации (она плохая, но для примера работы AppendFigure сойдет)
    public class QuadrangleTests : Figure
    {
        public override bool IsThat(List<int>? sides = null, List<int>? angles = null, int? radius = null)
        {
            if (sides?.Count == 4 && angles?.Count == 4 && radius == null)
            {
                return true;
            }
            return false;
        }

        

        public override void CalculateArea(List<int>? sides = null, List<int>? angles = null, int? radius = null)
        {
            AreaValue = sides[0] * sides[1];
        }
    }
}