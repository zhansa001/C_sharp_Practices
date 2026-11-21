// This is the dice game with the AI prompt
// Discovery 2: Letting the player choose how many rounds to play
// AI Prompt:
// In C#, how can I ask the player how many rounds they want to play and keep count of how many times a condition is true across those rounds? 
// Can you show me beginner friendly examples?

// Roll the dice
Random dice = new Random();

Console.Write("How many rounds do you want to play? ");

int rounds = Convert.ToInt32(Console.ReadLine());

if (rounds <= 0)
{
    Console.WriteLine("Please enter a positive whole number.");
    return;
}

int total_rolls = 0;
int total_points = 0;
int match2 = 0;
int match3 = 0;

for(int i = 1; i <= rounds; ++i)
{
    int roll = dice.Next(1, 21);
    int roll2 = dice.Next(1, 21);
    int roll3 = dice.Next(1, 21);
    total_rolls = roll + roll2 + roll3;

    Console.WriteLine($"\nRounds: {i}");
    Console.WriteLine($"Rolls: {roll} + {roll2} + {roll3} = {total_rolls}");

    if(roll == 20)
    {
        Console.WriteLine("You rolled a 20!");
    }

    if((roll == roll2) || (roll2 == roll3) || (roll == roll3))
    {

        if((roll == roll2) && (roll2 == roll3))
        {
            Console.WriteLine("You rolled triple! +6 points");
            total_rolls += 6;
            match3 += 1;
        }

        else
        {
            Console.WriteLine("You rolled double! +3 points");
            total_rolls += 3;
            match2 += 1;
        }

    }
    total_points += total_rolls;
}

Console.WriteLine($"\nTotal Triples: {match3}");
Console.WriteLine($"Total Doubles: {match2}");
Console.WriteLine($"Total: {total_points}");

