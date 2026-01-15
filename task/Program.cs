using task;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Shape[] shapes = new Shape[5];
        shapes[0] = new Circle(4);
        shapes[1] = new Circle(6);
        shapes[2] = new Rectangle(12, 78);
        shapes[3] = new Rectangle(2, 5);
        shapes[4] = new Triangle(3, 4, 5);

        Shape maxAreaFig = shapes[0];
        double maxArea = shapes[0].CalculateArea();
        foreach (Shape shape in shapes)
        {
            if(shape.CalculateArea() > maxArea)
            {
                maxArea = shape.CalculateArea();
                maxAreaFig = shape;
            }
                
            shape.GetInfo();
            Console.WriteLine();
        }
        Console.WriteLine($"найбільша площа {maxArea:N2} у фігури {maxAreaFig.GetName()}");
    }
}