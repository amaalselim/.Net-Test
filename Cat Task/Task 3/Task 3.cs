Console.Write("Enter length:");
double length = Convert.ToDouble(Console.ReadLine());
Console.Write("Enter Width:");
double width = Convert.ToDouble(Console.ReadLine());
Rectangle rec = new Rectangle(length,width);

Console.WriteLine($" Area Of Rectangle : {rec.CalculatingArea()}");


Console.Write("Enter Radius of Circle: ");
double Radius = Convert.ToDouble(Console.ReadLine());
Circle circle = new Circle(Radius);

Console.WriteLine($" Area Of Circle : {circle.CalculatingArea()}");


abstract class Shape
{
    abstract public double CalculatingArea();
}

class Rectangle : Shape
{
    public double  Width { get; set; }
    public double Length { get; set; }

    public Rectangle(double width, double length)
    {
        this.Width = width;
        this.Length = length;
    }
    public override double CalculatingArea()
    {
        return Width * Length;
    }

}
class Circle : Shape
{
    public double Radius { get; set; }
    public Circle(double radius)
    {
        Radius = radius;
    }

    public override double CalculatingArea()
    {
        return Math.PI * Radius * Radius;
    }
}