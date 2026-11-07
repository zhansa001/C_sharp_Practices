// Declare variables using an explicit type
string food = "pizza";
int slices_Eaten = 3;
bool _isHungry1 = false;

// Declare a variable using var
var fav_Color = "blue";

// Display the values of your variables
Console.WriteLine($"Favorite food: {food}");
Console.WriteLine($"Slices eaten: {slices_Eaten}");
Console.WriteLine($"Is hungry: {_isHungry1}");
Console.WriteLine($"Favorite color: {fav_Color}");

// Reassign a vari Console.WriteLine($"Slices eaten before dessert: {slicesEaten}");
slices_Eaten = 5;
Console.WriteLine($"Slices eaten after dessert: {slices_Eaten}");

//AI prompt
//In C#, what are the naming rules and conventions for variables? 
//C# variable names are "identifiers" following specific rules:
//  • They must start with a letter or an underscore (_), not a digit.
//  • Subsequent characters can include letters, digits, or underscores.
//  • Variable names cannot contain spaces or hyphens.
//  • Names are case-sensitive; for example, "score" and "Score" are considered different.
//  • Reserved keywords (e.g., "class") cannot be used directly unless prefixed with '@' (e.g., "@class"), 
//    though this practice is typically discouraged.

// Can you show me some valid and invalid examples? 
// Valid:
// int score = 10;
// string firstName = "Ada";
// int _count = 3;
// int item2 = 5;

//Invalid:
// int 2ndItem = 5;       // Starts with a digit
// string first name;     // Contains a space
// int item-count = 3;    // Contains a hyphen
// int class = 1;         // `class` is a reserved keyword

// After the AI responds: 
// Try renaming a few of your variables to follow the conventions the AI describes, 
// then run your program again to confirm it still works.