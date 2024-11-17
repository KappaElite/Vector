namespace Vector;

public class Polar2DInheritance : Vector2D
{
    public Polar2DInheritance(double x, double y) : base(x, y)
    {
        
    }

    public double getAngle()
    {
        return Math.Atan(X / Y) * 180/Math.PI;
    }
}