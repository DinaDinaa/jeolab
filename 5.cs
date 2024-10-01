Console.WriteLine("Enter your password");
var userinput = (Console.ReadLine());
var rightpassword = ("secret123");
if (userinput == rightpassword)
{
    Console.WriteLine("Access Granted");
}
else
{
    Console.WriteLine("Incorrect password");
}
