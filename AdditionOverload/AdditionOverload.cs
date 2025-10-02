internal class AdditionOverload
{
    static int Add(int a, int b) => a + b;
    static float Add(float a, float b) => a + b;
    public static void Main(string[] args)
    {
        Console.Write("Enter the first number: ");
        float firstNumber = float.Parse(Console.ReadLine()!);
        Console.Write("Enter the second number: ");
        float secondNumber = float.Parse(Console.ReadLine()!);
        float sum = Add(firstNumber, secondNumber);
        Console.WriteLine("The sum of the two numbers is: " + sum);
    }
}