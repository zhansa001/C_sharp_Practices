// "var" keyword is a C# shorthand that automatically determines 
// its data type based on the assigned value
var text = "John Doe";
var chars = 'a';
var whole_nums = 56;
var decimals = 5.6;
var bools = true;

//Can't be reassigned to another data type, will cause ERROR
// text = 'b';

Console.WriteLine(text);
Console.WriteLine(chars);
Console.WriteLine(whole_nums);
Console.WriteLine(decimals);
Console.WriteLine(bools);
