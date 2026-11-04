 // Ask for the user's name
Console.WriteLine("What is your name?");
string name = Console.ReadLine() ?? "";

 // Ask for the user's age
Console.WriteLine("How old are you?");
string age = Console.ReadLine() ?? "";

 // Display a personalized message that includes both pieces of information
Console.WriteLine($"Hi {name}! You are {age} years old."); 

//AI Prompt 1:
//In C#, how can I print a line of 20 dashes in a row without typing them all out? Can you show me an example?
Console.WriteLine(new string('-', 20));

//AI Prompt 2:
//In C#, how can I display a message that spans multiple lines using a single Console.WriteLine() statement? 
// Can you show me examples?
// Use '\n'
Console.WriteLine($"Hi {name}!\nYou are {age} years old."); 
