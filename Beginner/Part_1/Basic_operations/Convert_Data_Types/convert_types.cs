// In C#, which is strongly typed, explicit type conversion is often necessary, particularly for user input, 
// as Console.ReadLine() returns a string regardless of the input type.
//
// Method	            Converts to	       Example	                  Result
// Convert.ToInt32()	int	               Convert.ToInt32("42")	   42
// Convert.ToDecimal()	decimal	           Convert.ToDecimal("19.99")  19.99m
// Convert.ToDouble()	double	           Convert.ToDouble("3.14")	   3.14
// Convert.ToString()	string	           Convert.ToString(42)	       "42"

Console.Write("Enter a number: ");
string input = Console.ReadLine() ?? "";
int num = Convert.ToInt32(input);
decimal dec = Convert.ToDecimal(input);
double double_int = Convert.ToDouble(input);

Console.WriteLine($"String: {input}");
Console.WriteLine($"Int: {num}");
Console.WriteLine($"Decimal: {dec}");
Console.WriteLine($"Double: {double_int}");

//Parse Method
Console.WriteLine("\nParse Method:");
num = int.Parse("30");
dec = decimal.Parse("99.99");
double_int = double.Parse("87.5");
Console.WriteLine($"String -> int: {num}");
Console.WriteLine($"String -> decimal: {dec}");
Console.WriteLine($"String -> double: {double_int}");

//Casting Method
//Example from Microsoft
Console.WriteLine("\nCasting Method:");
decimal price = 19.99m;
int wholePrice = (int)price;         // Casts to int: 19 (decimal dropped)
Console.WriteLine(wholePrice);       // Output: 19

//Decimal precision during division
Console.WriteLine("\nDecimal Precision during division:");
int a = 50;
int b = 26;
decimal result = (decimal)a / (decimal)b;
Console.WriteLine(result);
