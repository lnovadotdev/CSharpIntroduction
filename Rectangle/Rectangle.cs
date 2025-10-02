// See https://aka.ms/new-console-template for more information
Console.Write("Enter the width of the rectangle: ");
float rectangleWidth = float.Parse(Console.ReadLine()!);
Console.Write("Enter the height of the rectangle: ");
float rectangleHeight = float.Parse(Console.ReadLine()!);
float rectangleArea = rectangleWidth * rectangleHeight;
float rectanglePerimeter = 2 * (rectangleWidth + rectangleHeight);
Console.WriteLine("The area of the rectangle is: " + rectangleArea);
Console.WriteLine("The perimeter of the rectangle is: " + rectanglePerimeter);
