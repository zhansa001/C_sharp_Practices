// Generate a random number of days until expiration
Random days = new Random();
int expiration = days.Next(12);
int discount = 0;

// Display an expiration message based on the days remaining
if(expiration == 0) 
{
    Console.WriteLine("Your subscription is expired");
}

else if(expiration == 1)
{
    Console.WriteLine("Your subscription expires within a day!");
    discount = 20;
}

else if(expiration <= 5)
{
    Console.WriteLine($"Your subscription expires in {expiration}");
    discount = 10;
}

else if(expiration <= 10)
{
    Console.WriteLine("Your subscription expires soon! Renew now!");
}

// Display a discount message if a discount applies
if (discount > 0)
{
    Console.WriteLine($"Renew now and save {discount}%");
}
