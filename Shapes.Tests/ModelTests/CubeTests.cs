using Microsoft.VisualStudio.TestTools.UnitTesting;
using Shapes.Models;

namespace Shapes.Tests
{
  [TestClass]
  public class CubeTests
  {

    [TestMethod]
    public void Cube_GetVolume_VolumeOfCube()
    {
      // Arrange
      Rectangle newRectangle = new Rectangle(4, 4);
      Cube newCube = new Cube(newRectangle);
      // Act
      int result = newCube.GetVolume();
      // Assert
      Assert.AreEqual(result, 64);

      //Notes:
      // In our arrange section, we create an instance of the Rectangle class and an instance of the Cube class.

      // To act, we call GetVolume() on the new instance of Cube.

      // Finally, we assert that the volume, as determined by the GetVolume() method, is 64.

      // The test will fail as expected, which means we're ready to add the necessary logic to GetVolume() which is currently (0) to make it pass.
    }

    [TestMethod]
    public void Cube_GetSurfaceArea_SurfaceAreaOfCube()
    {
      // Arrange
      Rectangle newRectangle = new Rectangle(4, 4);
      Cube newCube = new Cube(newRectangle);
      // Act
      int result = newCube.GetSurfaceArea();
      // Assert
      Assert.AreEqual(result, 96);
    }

  }  
}