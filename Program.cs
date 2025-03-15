
//Challenge: "Guess the Number" Game
Console.WriteLine("Computer: I am thinking of a number between 1 to 100. You have 5 chances to guess it right.");

Random rdm = new Random();

int computerNumber = rdm.Next(1, 101);
int chances = 5;
while (true)
{
    Console.Write("Enter the guessed number here: ");
    string input = Console.ReadLine();
     
    if (int.TryParse(input, out int integerInput))
    {
        if (integerInput < 0 || integerInput > 100)
        {
            Console.WriteLine("Number must be between 1 to 100. Please an integer again.");
        }
        else if (computerNumber == integerInput)
        {
            Console.WriteLine($"You guessed it right! The number is {computerNumber}");
            break;
        }
        else if (integerInput > computerNumber)
        {
            chances--;
            Console.WriteLine($"{integerInput} is too big. Try again. You have {chances} chances left");
        }
        else
        {
            chances--;
            Console.WriteLine($"{integerInput} is too small. Try again. You have {chances} chances left");
        }

        if (chances == 0)
        {
            Console.WriteLine($"Game is over. You lose. The answer is {computerNumber}");
            break;
        }
    }
    else
    {
        Console.WriteLine("Please enter an integer.");
    }
    
}

