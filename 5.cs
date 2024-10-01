Console.WriteLine("Enter your password");
var userinput = (Console.ReadLine());
const rightpassword = ("secret123");
if (userinput == rightpassword)
{
    Console.WriteLine("Access Granted");
}
else
{
    Console.WriteLine("Incorrect password");
}
