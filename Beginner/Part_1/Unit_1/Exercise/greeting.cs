 // Display a welcome message
Console.WriteLine("Welcome to the Greeting Exercise!");

 // Ask for the user's name
Console.WriteLine("What is your name?");
string name = Console.ReadLine() ?? "";

 // Display a personalized greeting
Console.WriteLine($"Hi {name}, nice to meet you!");

//AI prompt: In C#, how can I change a string input to all uppercase or all lowercase? 
// Can you show me examples?
//What AI gave me:

//string input = Console.ReadLine() ?? "";
// string uppercase = input.ToUpper();
// string lowercase = input.ToLower();
// Console.WriteLine($"Uppercase: {uppercase}");
// Console.WriteLine($"Lowercase: {lowercase}");

// After the AI responds: Look closely at the code examples it provides. 
// Try modifying your greeting program to display the user’s name in uppercase or lowercase.

string upper = name.ToUpper();
string lower = name.ToLower();

 // Display a personalized greeting
Console.WriteLine($"Hi {upper}, nice to meet you!");
Console.WriteLine($"Hi {lower}, nice to meet you!");

