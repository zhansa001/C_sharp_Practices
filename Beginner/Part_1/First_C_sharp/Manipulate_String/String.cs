//Concatenation
string one = "Hello";
string two = "World!";
//string three = one + " " + two;

Console.WriteLine(one + " " + two);
//then put "three" in ^ works too

//String interpolation
string name = "John Doe";
Console.WriteLine($"Hello, {name}!");

//Can be combined with Console.ReadLine()
Console.WriteLine("What is your name?");
string input = Console.ReadLine() ?? ""; //?? "" help remove null warnings
Console.WriteLine($"Hi {input}! I am John!");

//Common String Methods: Uppercase, Lowercase and Length
Console.Write("Enter text: ");
string text = Console.ReadLine() ?? "";
string upper = $"Upper: {text.ToUpper()}";
string lower = $"Lower: {text.ToLower()}";
string length = $"Length: {text.Length}";
Console.WriteLine($"Uppercase: {upper}\nLowercase: {lower}\nLength: {length}");

//Replace
Console.Write("Enter cat: ");
string text2 = Console.ReadLine() ?? "";
string replace = text2.Replace("c", "b");
Console.WriteLine($"{replace}");