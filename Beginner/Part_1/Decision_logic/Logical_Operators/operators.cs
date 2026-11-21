//I reused the driving test example
// Operator	    What it does	                    Example	          Result
// &&	        true only if both sides are true	true && false	  false
// &#124;&#124;	true if at least one side is true	true &#124;&#124; false	true
// !	        Flips a Boolean value	            !true	          false

Console.WriteLine("Can I take my driver's test?");
Console.Write("\nEnter your age: ");
string answer = Console.ReadLine() ?? "";
int age = int.Parse(answer);

if(age >= 16)
{
    Console.Write("Do you have a permit (true/false): ");
    string answer2 = Console.ReadLine() ?? "";
    bool convertAnswer = bool.Parse(answer2);

    if(age < 18 && convertAnswer == true)
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
            Console.WriteLine("\nYou need to take your driver's ed");
        }
    }

    if(convertAnswer != true)
    {
        Console.WriteLine("\nYou need to get a permit");
    }

    else if(convertAnswer == true && age >= 18)
    {
        Console.WriteLine("\nYou can take the test");
    }

}

else
{
    Console.WriteLine("\nYou are not old enough to take the test");
}