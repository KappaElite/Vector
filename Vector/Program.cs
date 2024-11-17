using Vector;


Polar2DAdapter vector2DAdapter = new Polar2DAdapter(new Vector2D(2, 3));
Vector3DDecorator vector3DDecorator = new Vector3DDecorator(3, 7, 13);
Vector3DInheritance vector3DInheritance = new Vector3DInheritance(16, 12, 7);

Console.WriteLine("Współrzędne w układzie kartezjańskim");
Console.WriteLine($"Adapter: {{ {string.Join(", ", vector2DAdapter.getComponents())} }}");
Console.WriteLine($"Decorator: {{ {string.Join(", ", vector3DDecorator.getComponents())} }}");
Console.WriteLine($"Vector 3D dziedziczenie: {{ {string.Join(", ", vector3DInheritance.getComponents())} }}");
Console.WriteLine("");
Console.WriteLine("Współrzędne biegunowe Adapter");
Console.WriteLine($"Długość wektora: {vector2DAdapter.abs()}");
Console.WriteLine($"Kąt wektora w stopniach: {vector2DAdapter.getAngle()}");
Console.WriteLine("");
Console.WriteLine("Iloczyn skalarny");
Console.WriteLine($"Wektor 3D Dekorator z Wektorem 3D Dziedziczenie: {vector3DDecorator.cdot(vector3DInheritance)}");
Console.WriteLine($"Wektor 2D Adapter z Wektorem 2D Adapter: {vector2DAdapter.cdot(vector2DAdapter)}");
Console.WriteLine($"Wektor 3D Dekorator z Wektorem 2D Adapter: {vector3DDecorator.cdot(vector2DAdapter)}");
Console.WriteLine($"Wektor 3D Dziedziczenie z Wektorem 2D Adapter: {vector3DInheritance.cdot(vector2DAdapter)}");
Console.WriteLine($"Wektor 3D Dziedziczenie z Wektorem 3D Dekorator: {vector3DInheritance.cdot(vector3DDecorator)}");
Console.WriteLine("");
Console.WriteLine("Iloczyn wektorowy");
Console.WriteLine($"Wektor 3D Dekorator z Wektorem 3D Dziedziczenie: {{ {string.Join(", ", vector3DDecorator.cross(vector3DInheritance).getComponents())} }}");
Console.WriteLine($"Wektor 3D Dziedziczenie z Wektorem 3D Dekorator: {{ {string.Join(", ", vector3DInheritance.cross(vector3DDecorator).getComponents())} }}");
Console.WriteLine($"Wektor 3D Dekorator z Wektorem 3D Dekorator: {{ {string.Join(", ", vector3DInheritance.cross(vector3DInheritance).getComponents())} }}");
Console.WriteLine($"Wektor 3D Dekorator z Wektorem 2D Adapter: {{ {string.Join(", ", vector3DDecorator.cross(vector2DAdapter).getComponents())} }}");
Console.WriteLine($"Wektor 3D Dziedziczenie z Wektorem 2D Adapter: {{ {string.Join(", ", vector3DInheritance.cross(vector2DAdapter).getComponents())} }}");