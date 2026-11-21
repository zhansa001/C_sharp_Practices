// This is the combination of Boolean and if/else if/else statements/ nesting if statement
// Evaluates true or false
// bool data type stores true or false

// Comparison operators
// Operator	 Meaning	                Example	Result
// ==	     Equal to	                5 == 5	true
// !=	     Not equal to	            5 != 3	true
// >	     Greater than	            10 > 3	true
// <	     Less than	                3 < 10	true
// >=	     Greater than or equal to	5 >= 5	true
// <=	     Less than or equal to	    4 <= 3	false

// IF/if else/else statement
Console.Write("Enter a number: ");
string input = Console.ReadLine() ?? "";
double convertInput = Convert.ToDouble(input);

if(convertInput > 15) // if statments only run when Boolean is true
{
    Console.WriteLine($"{convertInput} is greater than 15");
}
else if (convertInput == 15) //Check additional conditions
{
    Console.WriteLine($"{convertInput} is equal to 15");
}
else // else statements are for if "IF" statements are false
{
    Console.WriteLine($"{convertInput} is less than 15");
}

// Nesting if statements
Console.WriteLine("\nCan I take my driver's test?");
Console.Write("\nEnter your age: ");
string answer = Console.ReadLine() ?? "";
int age = int.Parse(answer);

if(age >= 18)
{
    Console.Write("Do you have a permit (true/false): ");
    string answer2 = Console.ReadLine() ?? "";
    bool convertAnswer = bool.Parse(answer2);

    if(convertAnswer == true)
    {
        Console.WriteLine("\nYou can take your test");
        
    }

    else
    {
        Console.WriteLine("\nYou need to get a permit");
    }
}

else if(age >= 16)
{
    Console.Write("Do you have a permit (true/false): ");
    string answer2 = Console.ReadLine() ?? "";
    bool convertAnswer = bool.Parse(answer2);
    if(convertAnswer == true)
    {
        Console.Write("Did you take Driver's Ed (true/false): ");
        string answer3 = Console.ReadLine() ?? "";
        bool driver_ed = Convert.ToBoolean(answer3);

        if(driver_ed == true)
        {
            Console.WriteLine("\nYou can take your test");
        }

        else
        {
            Console.WriteLine("\nYou need to take your driver's ed in order to the test");
        }
    }

    else
    {
        Console.WriteLine("\nYou need to get your permit first");
    }
}

else
{
    Console.WriteLine("\nYou are not old enough for the test");
}