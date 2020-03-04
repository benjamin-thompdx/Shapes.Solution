namespace Shapes.Models
{
  public class Rectangle
  {
    public int Length { get; set; }
    public int Width { get; set; }

    public Rectangle(int sideLength, int sideWidth)
    {
      Length = sideLength;
      Width = sideWidth;
    }

    public int GetArea()
    {
      return Length * Width;
    }

    public bool IsSquare()
    {
      if(Length == Width)
      {
        return true;
      }
      else
      {
        return false;
      }
    }
  }
}

//Notes:
//This is a basic class with a constructor and two auto-implemented properties: Length and Width.
//It also contains two other methods:
//GetArea() multiplies the Length and Width properties to determine the area of the rectangle.
//IsSquare() compares Length and Width to determine if the Rectangle is also a square. It returns a bool.