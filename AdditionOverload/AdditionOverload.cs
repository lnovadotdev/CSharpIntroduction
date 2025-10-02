internal class AdditionOverload
{
    private static void Main(string[] args)
    {
        static int Add(int a, int b) => a + b;

        Console.Write("Enter the first integer: ");
        int firstInteger = int.Parse(Console.ReadLine()!);
        Console.Write("Enter the second integer: ");
        int secondInteger = int.Parse(Console.ReadLine()!);
        int sum = Add(firstInteger, secondInteger);
        Console.WriteLine("The sum of the two integers is: " + sum);
    }
}