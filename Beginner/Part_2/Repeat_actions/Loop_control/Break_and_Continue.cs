// Break - exit loops earlier
//Example from Microsoft

Console.WriteLine("Break example:");
for (int count = 0; count < 10; count++)
{
    if (count == 5)
    {
        break;
    }
    Console.WriteLine(count);
}

Console.WriteLine("Loop ended.\n");

// Continue - skip to next iteration

Console.WriteLine("Continue example:");
for (int count = 0; count < 6; count++)
{
    if (count % 2 == 0)
    {
        continue;
    }
    Console.WriteLine(count);
}
