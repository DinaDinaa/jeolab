Console.WriteLine("Write your score:");
var userscore = int.Parse(Console.ReadLine());
if (userscore >= 90 && userscore <= 100)
{
    Console.WriteLine("A");
}
else if (userscore >= 80 && userscore < 90)
{
    Console.WriteLine("B");
}
else if (userscore >= 70 & userscore < 80)
{
    Console.WriteLine("C");
}
else if (userscore >= 60 && userscore < 70)
{
    Console.WriteLine("D");
}
else if (userscore >= 0 && userscore < 60)
{
    Console.WriteLine("F");
}



