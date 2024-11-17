namespace Vector;

public class Polar2DAdapter : IPolar2D, IVector
{
    private Vector2D srcVector;


    public Polar2DAdapter(Vector2D otherVector)
    {
        srcVector = otherVector;
    }
    public double abs()
    {
        return srcVector.abs();
    }

    public double cdot(IVector vector)
    {
        return srcVector.cdot(vector);
    }

    public double[] getComponents()
    {
        return srcVector.getComponents();
    }


    public double getAngle()
    {
        return Math.Atan(srcVector.X / srcVector.Y) * 180/Math.PI;
    }
}