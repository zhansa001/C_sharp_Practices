// Roll the dice
Random dice = new Random();

int roll = dice.Next(1, 21);
int roll2 = dice.Next(1, 21);
int roll3 = dice.Next(1, 21);

int total = roll + roll2 + roll3;

// Display the roll and total
Console.WriteLine($"First roll: {roll}\nSecond Roll: {roll2}\nThird Roll: {roll3}\nTotal: {total}");

// Award a bonus for doubles or triples
if((roll == roll2) || (roll2 == roll3) || (roll == roll3))
{
    if((roll == roll2) && (roll2 == roll3))
    {
        Console.WriteLine("\nYou rolled triple! +6 points");
        total += 6;
    }

    else
    {
        Console.WriteLine("\nYou rolled double! +3 points");
        total += 3;
    }

}

else
{
    Console.WriteLine("\nYou didn't roll any matches! +0 points");
}

Console.WriteLine($"\nTotal after bonus: {total}");

// Display the final result
 if (total >= 25)
 {
     Console.WriteLine("\nYou win a new car!");
 }
 else if (total >= 18)
 {
     Console.WriteLine("\nYou win a new laptop!");
 }
 else if (total == 12)
 {
     Console.WriteLine("\nYou win a trip for two!");
 }
 else
 {
     Console.WriteLine("\nYou win a kitten!");
 }

 // Discovery 1: Rolling a different kind of die
 // AI Prompt:
 // In C#, how does the Random.Next() method decide which numbers it can return? Can you show me how to simulate rolling a 20-sided die?
 // Random.Next(minValue, maxValue), change the maxValue to 20 
 // Changes: The total will increase so the points for the prizes also needs to be increased.
 // Also in programming languages, it starts counting from 0. Thus, the maxValue needs to be 21.

// Discovery 2: Letting the player choose how many rounds to play
// AI Prompt:
// In C#, how can I ask the player how many rounds they want to play and keep count of how many times a condition is true across those rounds? 
// Can you show me beginner friendly examples?

// Console.Write("How many rounds do you want to play? ");

// if (!int.TryParse(Console.ReadLine(), out int rounds) || rounds <= 0)
// {
//     Console.WriteLine("Please enter a positive whole number.");
//     return;
// }

// Random random = new Random();
// int qualifyingRolls = 0;

// for (int round = 1; round <= rounds; round++)
// {
//     int roll = random.Next(1, 21); // A number from 1 to 20

//     // Check the condition for this round
//     if (roll >= 15)
//     {
//         qualifyingRolls++; // Add 1 when the condition is true
//     }

//     Console.WriteLine($"Round {round}: rolled {roll}");
// }

// Console.WriteLine($"You rolled 15 or higher {qualifyingRolls} time(s).");

