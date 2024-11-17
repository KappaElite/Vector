namespace Vector;

public class Vector3DDecorator : IVector
{
    private IVector srcVector;
    private double[] components;

    private double Z
    {
        get;
    }

    public Vector3DDecorator(double x, double y, double z)
    {
        srcVector = new Vector2D(x, y);
        Z = z;
        components = srcVector.getComponents();
    }

    public double abs()
    {
        return Math.Sqrt(Math.Pow(components[0], 2) + Math.Pow(components[1], 2) + Math.Pow(Z,2));
    }

    
    public double[] getComponents()
    {
        double[] components3D = { components[0], components[1], Z };
        return components3D;
    }
    public double cdot(IVector vector)
    {
        double[] componentsOther = vector.getComponents();
        double result = 0;
        
        
        switch (componentsOther.Length)
        {
            case 3:
                
                result = components[0] * componentsOther[0] + components[1] * componentsOther[1] + Z * componentsOther[2];
                break;
            case 2:
                
                result = components[0] * componentsOther[0] + components[1] * componentsOther[1];
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
                x = components[1] * componentsOther[2] - Z * componentsOther[1];
                y = Z * componentsOther[0] - components[0] * componentsOther[2];
                z = components[0] * componentsOther[1] - components[1] * componentsOther[0];
                break;
            case 2:
                x =  - Z * componentsOther[1];
                y = Z * componentsOther[0];
                z = components[0] * componentsOther[1] - components[1] * componentsOther[0];
                break;
        }
            
                
       
        Vector3DDecorator newVector = new Vector3DDecorator(x, y, z);
        return newVector;

    }

    public IVector getSrcv()
    {
        return srcVector;
    }
}