Console.WriteLine("Write your number");
var usernumber = int.Parse(Console.ReadLine());

if (usernumber == 0)
{
    Console.WriteLine("Your number is 0");
}
else if (usernumber % 2 == 0)
{
    Console.WriteLine("Your number is even");
}
else if (usernumber % 2 == 1)
{
    Console.WriteLine("Your number is odd");
}
