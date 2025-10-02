// See https://aka.ms/new-console-template for more information
int highestInput = 0;
int number = 0;
int[] numbers = new int[10];
for (int i = 0; i < 10; i++)
{
    Console.Write("Enter an integer: ");
    number = int.Parse(Console.ReadLine()!);
    numbers[i] = number;
    if (i == 0 || number > highestInput)
    {
        highestInput = number;
    }
}
Console.WriteLine("The highest integer is: " + highestInput);
Console.Write("The integers you entered (in reverse order) are: ");
for (int i = 9; i >= 0; i--)
{
    Console.Write(numbers[i] + " ");
}
