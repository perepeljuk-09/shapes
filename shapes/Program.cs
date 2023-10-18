
using shapes.Interfaces;
using shapes.Models;

List<IShape> shapes = new List<IShape>()
{
    new Circle(13),
    new Triangle(5,3,4),
};

foreach (var shape in shapes)
{

    float square = shape.GetSquare();
    Console.WriteLine($"Square of {shape.GetType()} ===> " + square);

    if(shape is Triangle)
    {
        Triangle tr = (Triangle)shape;

        bool result = tr.CheckIsRectangular();
        Console.WriteLine("Is rectangular " + result);

    }
}