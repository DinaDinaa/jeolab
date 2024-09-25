
var year = int.Parse(Console.ReadLine());

if (year % 4 == 0 && year % 100 == 0 && year % 400 == 0)
{
    Console.WriteLine("Leap year");
}
else
{
    Console.WriteLine("Year is not leap");
}

