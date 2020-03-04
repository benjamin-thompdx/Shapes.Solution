namespace Shapes.Models
{
  public class Cube
  {
    public Rectangle Face { get; set; }

    public Cube (Rectangle side)
    {
      Face = side;
    }

    //GetVolume Before: To test for fail
    // public int GetVolume()
    // {
    //   return 0;
    // }

    //GetVolume After: To test for pass
    public int GetVolume()
    {
      int length = Face.Length;
      return length * length * length;

      // Face is the our auto-implemented property that is itself a Rectangle object. We'll use it to get the volume of our Cube.
    }

    //GetSurfaceArea Before: To test for fail
    // public int GetSurfaceArea()
    // {
    //   return 0;
    // }
    
    //GetSurfaceArea After: To test for pass
    public int GetSurfaceArea()
    {
      int length = Face.Length;
      return (length * length) * 6;
    }

  }
}