Console.WriteLine("How old are you?");
var userinputyears = int.Parse(Console.ReadLine());
if (userinputyears >= 18)
{
    Console.WriteLine("Available");
}
else
{
    Console.WriteLine("Not available");
}

