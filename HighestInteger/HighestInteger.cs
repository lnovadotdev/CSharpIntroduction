// See https://aka.ms/new-console-template for more information
int highestInput = 0;
int number = 0;
for (int i = 0; i < 10; i++)
{
    Console.Write("Enter an integer: ");
    number = int.Parse(Console.ReadLine()!);
    if (i == 0 || number > highestInput)
    {
        highestInput = number;
    }
}
Console.WriteLine("The highest integer is: " + highestInput);