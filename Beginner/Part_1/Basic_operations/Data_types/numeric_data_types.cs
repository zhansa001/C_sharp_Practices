// Type Name	C# Keyword	Description	                                Example
// Integer	    int	        Whole numbers (positive or negative)	    42, -7, 1000
// Decimal	    decimal	    Precise decimal numbers, great for money	19.99m, 3.14m
// Double	    double	    Larger decimal numbers	                    3.14, 2.71828

int whole = 50;
decimal money = 164.12m;
double pi = 3.14159265359;

Console.WriteLine("Simple Outputs:");
Console.WriteLine(whole);
Console.WriteLine(money);
Console.WriteLine(pi);

//Example of some basic math operations
Console.WriteLine("\nExample of Operations: ");
Console.WriteLine("Additions and Subtractions: ");
Console.WriteLine(money + whole);
Console.WriteLine(pi + whole);
Console.WriteLine(money - whole);
Console.WriteLine(pi - whole);
// Console.WriteLine(pi + money); Operators cannot be applied to operands of type 'double' and 'decimal'

Console.WriteLine("\nMultiplications and Divisions: ");
Console.WriteLine(money / whole);
Console.WriteLine(pi / whole);
Console.WriteLine(money * whole);
Console.WriteLine(pi * whole);