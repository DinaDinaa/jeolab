Console.WriteLine("Hours:");
var hours = int.Parse(Console.ReadLine());
Console.WriteLine("Minutes:");
var minutes = int.Parse(Console.ReadLine());

if (hours >= 0 && hours <= 23 && minutes >= 0 && minutes <= 59)
{
    Console.Write($"Time is: {hours}  : {minutes} ");
}
else
{
    Console.WriteLine("Error");
}
if (hours >= 5 && hours <= 11 && minutes >= 0 && minutes <= 59 )
{
    Console.WriteLine(" Good morning ");
}
else if (hours >= 12 && hours <= 16 && minutes >= 0 && minutes <= 59)
{
    Console.WriteLine(" Good afternoon ");
}
else if (hours >= 17 && hours <= 20 && minutes >= 0 && minutes <= 59)
{
    Console.WriteLine(" Good evening ");
}
else if (hours >= 21 && hours <= 4 && minutes >= 0 && minutes <= 59)
{
    Console.WriteLine(" Good night ");
}



