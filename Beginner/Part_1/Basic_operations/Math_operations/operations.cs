//Simple additions, subtractions, multiplication, and divisions are in Data_types.cs
//Modulusonly returns the reminders, and is good to check for odd and even numbers
int a = 7;
int b = 2;
Console.WriteLine(a % b);       //This shows 7 is an odd number
Console.WriteLine(b % a);       //This shows the remainder of 2/7 is 2

decimal c = 21m;
decimal d = 9m;
Console.WriteLine(c % d);       

//Order of Operations
int standard = 2 + 3 * 4;
int forced = (2 + 3) * 4 / 9; 
decimal mixed = 4.5m + 3.22m * 9.8m - 1.2m;

Console.WriteLine(standard);
Console.WriteLine(forced);
Console.WriteLine(mixed);

//Compound Assignment Operands
// Operator	  Meaning	            Example	Result (starting at 10)
// +=	      Add and assign	    x += 5	  15
// -=	      Subtract and assign	x -= 5	  5
// *=	      Multiply and assign	x *= 5	  50
// /=	      Divide and assign	    x /= 5	  2

Console.WriteLine("\nScore example: ");
int score = 50;
score = score + 10;    // Standard way: score is 60
Console.WriteLine(score);
score += 10;           // Shorthand: score is 70
Console.WriteLine(score);

//My example
Console.WriteLine("\nMy example: ");
decimal x = 9.99m;
x += 3m;
Console.WriteLine(x);
x -= 5.55m;
Console.WriteLine(x);
x *= 10m;
Console.WriteLine(x);
x /= 3.33m;
Console.WriteLine(x);

//Increment and Decrement
Console.WriteLine("\nIncrement and Decrement:");
int count = 10;
count++;                       
Console.WriteLine(count);     

count--;                      
Console.WriteLine(count);     

//Pre- and Post-
Console.WriteLine("\nPre- and Post-:\nIncrement:");
Console.WriteLine(count++); //Old value
Console.WriteLine(count); // 11

Console.WriteLine(++count); //Because I did pre-increment with the same variable, it is still 11
Console.WriteLine(count); //12

Console.WriteLine("\nDecrement:");
Console.WriteLine(count--); // 'a' is still 12
Console.WriteLine(count); // It should be 11
Console.WriteLine(--count); // a is now 10
Console.WriteLine(count); //10

//You can also store the results in a variable like this: int result = a + b