 //My Version
 // Collect the bill amount and tip percentage
 Console.Write("Enter bill amount: ");
string billInput = Console.ReadLine() ?? "";
decimal bill = Convert.ToDecimal(billInput);

Console.Write("Enter your tip percentage: ");
string tip_percentage_Input = Console.ReadLine() ?? "";
decimal tip_percentage = Convert.ToDecimal(tip_percentage_Input);

 // Display the entered values
Console.WriteLine($"\nBill: ${bill}\nTip Percentage: {tip_percentage}%");

 // Calculate the tip and total
decimal tip = bill * (tip_percentage / 100);
decimal total = bill + tip;

 // Display the results
 Console.WriteLine($"\nTip: ${tip}\nTotal: ${total}");