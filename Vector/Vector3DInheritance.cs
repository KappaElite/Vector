namespace Vector;

public class Vector3DInheritance: Vector2D
{
    private double Z
    {
        get;
    }

    public Vector3DInheritance(double x, double y, double z): base(x,y)
    {
        Z = z;
    }
    
    
    public override double abs()
    {
        return Math.Sqrt(Math.Pow(X, 2) + Math.Pow(Y, 2) + Math.Pow(Z,2));
    }

    
    public override double[] getComponents()
    {
        double[] components3D = { X, Y, Z };
        return components3D;
    }
    public override double cdot(IVector vector)
    {
        double[] componentsOther = vector.getComponents();
        double result = 0;

        switch (componentsOther.Length)
        {
            case 3:
                result = X * componentsOther[0] + Y * componentsOther[1] + Z * componentsOther[2];
                break;
            case 2:
                result = X * componentsOther[0] + Y * componentsOther[1];
                break;
                
        }

        return result;
    }

    public Vector3DDecorator cross(IVector vector)
    {
        double[] componentsOther = vector.getComponents();
        double x = 0 , y = 0 , z = 0;

        switch (componentsOther.Length)
        {
            case 3:
                x = Y * componentsOther[2] - Z * componentsOther[1];
                y = Z * componentsOther[0] - X * componentsOther[2];
                z = X * componentsOther[1] - Y * componentsOther[0];
                break;
            case 2:
                x =  - Z * componentsOther[1];
                y = Z * componentsOther[0];
                z = X * componentsOther[1] - Y * componentsOther[0];
                break;
        }
            
                
       
        Vector3DDecorator newVector = new Vector3DDecorator(x, y, z);
        return newVector;

    }

    public IVector getSrcv()
    {
        IVector newVector = new Vector2D(X, Y);
        return newVector;
    }
}