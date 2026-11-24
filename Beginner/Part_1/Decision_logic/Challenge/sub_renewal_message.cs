// Generate a random number of days until expiration
Random days = new Random();
int expiration = days.Next(12);
int discount = 0;

// Display an expiration message based on the days remaining
// Discovery 2
// AI prompt
// In C#, how can I combine multiple comparisons into a single if condition using logical operators? 
// Can you show me beginner friendly examples?
// Can you rewrite the “5 days or less” rule so it explicitly checks both the lower and upper bounds 
// (for example, more than 1 day, but 5 or fewer)?

if(expiration == 0) 
{
    // Bonus: 
    // Once your basic version works, try adding a new rule that offers an extra discount (like 30%) 
    // when a subscription has already expired, to encourage the user to renew anyway.
    Console.WriteLine("Your subscription is expired");
    discount = 30;
}

else if(expiration == 1)
{
    Console.WriteLine("Your subscription expires within a day!");
    discount = 20;
}

else if(expiration >= 1 || expiration <= 5)
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
