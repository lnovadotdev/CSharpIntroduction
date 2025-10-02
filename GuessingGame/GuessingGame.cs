// See https://aka.ms/new-console-template for more information
int rand = new Random().Next(1, 101);
int guess;

do
{
    Console.Write("Enter a number between 1 and 100: ");
    guess = int.Parse(Console.ReadLine()!);
    if (guess < rand)
    {
        Console.WriteLine("Too low! Try again.");
    }
    else if (guess > rand)
    {
        Console.WriteLine("Too high! Try again.");
    }
    else
    {
        Console.WriteLine("Congratulations! You guessed the number!");
        break;
    }
} while (guess != rand);