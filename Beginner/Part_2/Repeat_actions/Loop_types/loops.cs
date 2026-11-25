// For loops
Console.Write("For loop example:\nEnter a number: ");
double num = Convert.ToDouble(Console.ReadLine());

Console.Write("Enter another number: ");
double num2 = Convert.ToDouble(Console.ReadLine());

double sum = 0;

for (int i = 0; i <= 5; i++)
{
    sum = num * (num2 + i);
    Console.WriteLine($"{sum}");
}

// While loop - continuses until rent is 0 or negative
Console.Write("\nWhile loop example:\nEnter rent: $");
decimal rent = Convert.ToDecimal(Console.ReadLine());

Console.Write("Enter amount to pay off each month: $");
decimal paidOff = Convert.ToDecimal(Console.ReadLine());

while(rent > 0) 
{
    Console.Write($"You paid ${paidOff}. You still have {rent - paidOff}\n");
    rent -= paidOff;
}

// Do-while loop using rent example - the loop stops when paid off is more than left over rent
Console.Write("\nDo-while loop example with rent:\nEnter rent: $");
decimal rent2 = Convert.ToDecimal(Console.ReadLine());

Console.Write("Enter amount to pay off each month: $");
decimal paidOff2 = Convert.ToDecimal(Console.ReadLine());

do
{
    Console.Write($"You paid ${paidOff2}. You still have {rent2 - paidOff2}\n");
    rent2 -= paidOff2;
}

while(paidOff2 <= rent2 );
