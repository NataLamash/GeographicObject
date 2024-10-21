using GeographicObject;

public class Program
{
    static void Main()
    {
        River river = new River
        {
            X = 12.34,
            Y = 56.78,
            Name = "Dnipro",
            Description = "One of the largest rivers in Europe",
            FlowSpeed = 50,
            Length = 2201
        };

        Mountain mountain = new Mountain
        {
            X = 9.87,
            Y = 65.43,
            Name = "Everest",
            Description = "The highest mountain in the world",
            HighestPoint = 8848
        };

        Console.WriteLine(river.GetInfo());
        Console.WriteLine(mountain.GetInfo());
    }
}
