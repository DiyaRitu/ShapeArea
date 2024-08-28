using System;

string answer;
float result;
Console.WriteLine("What shape would you like to find the area of? Please enter 'r' for rectangle or any other key for circle.");
#pragma warning disable CS8602 // Dereference of a possibly null reference.
answer = Console.ReadLine().ToLower(); // convert to lowercase for case-insensitive comparison
#pragma warning restore CS8602 // Dereference of a possibly null reference.

if (answer == "r")
{
    Console.WriteLine("Please enter the height of the rectangle.");
    if (float.TryParse(Console.ReadLine(), out float height))
    {
        Console.WriteLine("Please enter the width of the rectangle.");
        if (float.TryParse(Console.ReadLine(), out float width))
        {
            if (height < 0 || width < 0)
            {
                Console.WriteLine("Error: Height and width cannot be negative.");
                return;
            }
            result = height * width;
        }
        else
        {
            Console.WriteLine("Error: Invalid width input.");
            return;
        }
    }
    else
    {
        Console.WriteLine("Error: Invalid height input.");
        return;
    }
}
else
{
    Console.WriteLine("Please enter the radius of the circle.");
    if (float.TryParse(Console.ReadLine(), out float radius))
    {
        if (radius < 0)
        {
            Console.WriteLine("Error: Radius cannot be negative.");
            return;
        }
        result = (float)Math.PI * (radius * radius);
    }
    else
    {
        Console.WriteLine("Error: Invalid radius input.");
        return;
    }
}

Console.WriteLine($"The result is {result:F2}"); // display result with 2 decimal places
ConsoleKeyInfo consoleKeyInfo = Console.ReadKey();
