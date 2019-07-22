using Microsoft.VisualStudio.TestTools.UnitTesting;
using Triangle;

namespace Triangle.Tests
{
  [TestClass]
  public class TriangleTest
  {
    [TestMethod]
    public void IsTriangle_CheckSidesAreTriangle_True()
    {
      TriangleTracker testTriangleTracker = new TriangleTracker();
      Assert.AreEqual(true, testTriangleTracker.IsTriangle(3, 3, 3));
    }

    [TestMethod]
    public void IsTriangle_SidesAreNotTriangle_False()
    {
      TriangleTracker testTriangleTracker = new TriangleTracker();
      Assert.AreEqual(false, testTriangleTracker.IsTriangle(1, 1, 5));
    }

    [TestMethod]
    public void IsTriangleEquilateral_CheckSidesAreEquilateral_True()
    {
      TriangleTracker testTriangleTracker = new TriangleTracker();
      Assert.AreEqual(true, testTriangleTracker.IsTriangleEquilateral(3, 3, 3));
    }

    [TestMethod]
    public void IsTriangleEquilateral_CheckSidesAreEquilateral_False()
    {
      TriangleTracker testTriangleTracker = new TriangleTracker();
      Assert.AreEqual(false, testTriangleTracker.IsTriangleEquilateral(3, 2, 1));
    }
    [TestMethod]
    public void IsTriangleIsosceles_CheckSidesAreIsosceles_True()
    {
      TriangleTracker testTriangleTracker = new TriangleTracker();
      Assert.AreEqual(true, testTriangleTracker.IsTriangleIsosceles(3, 3, 5));
    }

    [TestMethod]
    public void IsTriangleIsosceles_CheckSidesAreIsosceles_False()
    {
      TriangleTracker testTriangleTracker = new TriangleTracker();
      Assert.AreEqual(false, testTriangleTracker.IsTriangleIsosceles(1, 2, 3));
    }
  }
}