## **Vector Manipulation with Adapter and Decorator Patterns**
This C# project demonstrates the use of the Adapter and Decorator design patterns to work with two or three-dimensional vectors in Cartesian and polar coordinate systems. The project includes examples of both patterns for flexibility in handling vector operations, including scalar and cross products.
### **Design Patterns**
#### **Adapter**
The Adapter pattern is used to allow polar coordinate-based vector representation to interact seamlessly with Cartesian coordinates. A Polar2DAdapter class implements both Cartesian and polar methods, converting between systems when necessary.
#### **Decorator**
The Decorator pattern is used to extend vector functionality, particularly for the cross product, which requires a third dimension. The Vector3DDecorator class enables two-dimensional vectors to perform three-dimensional operations without changing the base Vector2D class.
### **Features**
##### Vector Creation: Supports creating vectors with either Cartesian or polar coordinates.
##### Coordinate Conversion: Converts vectors between Cartesian and polar coordinate systems.
##### Dot Product: Calculates the scalar product between two vectors.
##### Cross Product: Extends vectors to a third dimension for cross-product calculations.

