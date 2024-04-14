Console.Write("Enter length of Rectangle:");
double length = Convert.ToDouble(Console.ReadLine());
Console.Write("Enter Width of Rectangle:");
double width = Convert.ToDouble(Console.ReadLine());

Rectangle rectangle = new Rectangle();
Console.WriteLine($"Perimeter Of Rectangle: {rectangle.PerimeterRectangle(width, length)}");
Console.WriteLine("---------------------------------------------");
Console.WriteLine($" Area Of Rectangle: {rectangle.ArearRectangle(width, length)}");

class Rectangle
{
    public double length { get; set; }
    public double width { get; set; }

    public double PerimeterRectangle(double width, double length)
    {
        this.width = width;
        this.length = length;
        return (length + width) * 2;
    }
    public double ArearRectangle(double width, double length)
    {
        this.width = width;
        this.length = length;
        return length * width;
    }
}