// Store a Fahrenheit temperature
//decimal fahrenheit = 94;
Console.Write("Enter the temperature in Fahrenheit: ");
string fahrenheitInput = Console.ReadLine() ?? "";
decimal fahrenheit = Convert.ToDecimal(fahrenheitInput);

// Convert it to Celsius
decimal celsius = (fahrenheit - 32) * 5/9;
decimal roundedValue = Math.Round(celsius, 1);

// Display the result
Console.WriteLine($"Fahrenheit: {fahrenheit}°F");
Console.WriteLine($"Celcius: {celsius}°C");
Console.WriteLine($"Celcius after rounded: {roundedValue}°C");

//Discover 1
//AI Prompt:
//In C#, how can I display a decimal value rounded to one decimal place, 
// like 34.4 instead of 34.44444444444444444444444444? Can you show me beginner friendly examples?
// Use Math.Round();