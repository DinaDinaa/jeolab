Console.WriteLine("Write your number");
var number1 = double.Parse(Console.ReadLine());
var number2 = double.Parse(Console.ReadLine());
var number3 = double.Parse(Console.ReadLine());
if (number1 > number2 && number2 > number3)
{
    Console.WriteLine($"{number1} is max");
}
else if (number2 > number1 && number1 > number3)
{
    Console.WriteLine($"{number2} is max");
}
else if (number3 > number2 && number2 > number1)
{
    Console.WriteLine($"{number3} is max");
}



