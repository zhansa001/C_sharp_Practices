//Discovery 1
// AI prompt
// In C#, is there another way to write a long chain of if/else if statements?
// Can you show me a beginner friendly example using a switch statement?

// Generate a random number of days until expiration
Random days = new Random();
int expiration = days.Next(12);
int discount = 0;

// Display an expiration message based on the days remaining
switch(expiration)
{
    case 0:
        Console.WriteLine("Your subscription is expired");
        break;

    case 1:
        Console.WriteLine("Your subscription expires within a day!");
        discount = 20;
        break;

    case <= 5:
        Console.WriteLine($"Your subscription expires in {expiration}");
        discount = 10;
        break;

   case <= 10:
        Console.WriteLine("Your subscription expires soon! Renew now!");
        break;

    default:
        break;
}

// Display a discount message if a discount applies
if (discount > 0)
{
    Console.WriteLine($"Renew now and save {discount}%");
}
