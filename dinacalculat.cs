using System.ComponentModel.Design;

Console.WriteLine("number1");
var a = float.Parse(Console.ReadLine());
Console.WriteLine("number2");
var b = float.Parse(Console.ReadLine());
Console.WriteLine("choose operation");
var moqmedeba = Console.ReadLine();

//Console.WriteLine($"{a} + {b} = {a + b}")

if (moqmedeba == "+")
{
    Console.WriteLine( a+b );

}
else if (moqmedeba == "-")
{
    Console.WriteLine(a - b);
}
else if (moqmedeba == "*")
{
    Console.WriteLine(a * b);
}
else if (moqmedeba == "/" && b != 0)
{
    Console.WriteLine(a / b);
}
else if (moqmedeba == "/" && b == 0)
{
    Console.WriteLine("error");
}

