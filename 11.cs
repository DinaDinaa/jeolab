Console.WriteLine("Write your country:");
var country = Console.ReadLine();
Console.WriteLine("How old are you?");
var age = int.Parse(Console.ReadLine());
var country1 = ("USA");
if ( country == country1 && age >= 21 )
{
    Console.WriteLine("Access");
}
else if ( age >= 18 )
{
    Console.WriteLine("Access");
}
else
{
    Console.WriteLine("Without access");
}





