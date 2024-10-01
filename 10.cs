Console.WriteLine("Write amount:");
var amount = decimal.Parse(Console.ReadLine());
Console.WriteLine($" amount is {amount} $");
var discount1 = amount - 0.1 * amount;
var discount2 = amount - 0.2 * amount;
if ( amount < 100 )
{
    Console.WriteLine("Without discount");
}
else if ( amount >= 100 & amount <= 500 )
{
    Console.WriteLine("Discount 10%");
    Console.WriteLine($"You have to pay {discount1} $");
}
else if (amount > 500 )
{
    Console.WriteLine("Discount 20%");
    Console.WriteLine($"You have to pay {discount2} $");
}




