namespace Triangle
{
  public class TriangleTracker
  {
    public bool IsTriangle(int side1, int side2, int side3)
    {
      if ((side1+side2>side3)&&(side2+side3>side1)&&(side1+side3>side2))
      {
        return true;
      }
      else
      {
        return false;
      }
    }
    public bool IsTriangleEquilateral(int side1, int side2, int side3)
    {
      if ((side1 == side2 && side2 ==side3))
      {
        return true;
      }
      else 
      {
        return false;
      }
    }
    public bool IsTriangleIsosceles(int side1, int side2, int side3)
    {
      return ((side1 == side2)||(side2 == side3)||(side1==side3));
    }
  }
}
