using System;

class TwoDShape
{
    double pri_size;
    

    public TwoDShape()
    {
        Size = 0.0;
        name = "null";
    }

    public TwoDShape(double x, string n)
    {
        Size = x;
        name = n;
    }

    public TwoDShape(TwoDShape ob)
    {
        Size = ob.Size;
        name = ob.name;
    }

    public double Size
    {
        get { return pri_size; }
        set { pri_size = value < 0 ? -value : value; }
    }

    public string name { get; set; }


    public virtual double Area()
    {
        return 0.0;
    }
}

class Triangle : TwoDShape
{
    string Style;
    //Значення висоти трикутника
    double Height= 54;
    public Triangle()
    {
        Style = "null";
    }
    public Triangle(string s, double x) :
        base(x, "triangle")
    {
        Style = s;
    }
    public Triangle(double x) : base(x, "triangle")
    {
        Style = "equilateral";
    }
    public override double Area()
    {
        return (Size * (Height/2));
    }
    public void ShowStyle()
    {
        Console.WriteLine("triangle " + Style);
    }
}

class Rectangle : TwoDShape
{

    public Rectangle(double x, double y) :
        base(Math.Sqrt(x * y), "rectangle")
    { }

    public Rectangle(Rectangle ob) : base(ob) { }

    public override double Area()
    {
        return Size * Size;
    }
}

class Circle : TwoDShape
{

    public Circle(double x) :
        base(x, "circle")
    { }

    public Circle(Circle ob) : base(ob) { }

    public override double Area()
    {
        return Math.PI * (Size * Size);
    }

}

class Square : TwoDShape
{
    public Square(double x) :
        base(x, "square")
    { }

    public Square(Square ob) : base(ob) { }

    public override double Area()
    {
        return Math.Pow(Size, 2);
    }

}

class DynShapes
{
    public static int CompareShapes(TwoDShape left, TwoDShape right)
    {
        return left.Area().CompareTo(right.Area());
    }

    static void Main()
    {
        TwoDShape[] shapes = new TwoDShape[5];

        shapes[0] = new Triangle(12.0);// Рядок №45 вказати значення висоти
        shapes[1] = new Rectangle(20.0, 7.0);//1-ше знечення висоти,2-ге значення щирини
        shapes[2] = new Circle(2.0);//значення радіуса
        shapes[3] = new Square(9.0);//значення сторони
        shapes[4] = new TwoDShape(5, "general form");

        for (int i = 0; i < shapes.Length; i++)
        {
            Array.Sort(shapes, new Comparison<TwoDShape>(CompareShapes));
            Console.WriteLine("Object - " + shapes[i].name);
            Console.WriteLine("The area is -  " + shapes[i].Area());
            Console.WriteLine();
        }
    }
}