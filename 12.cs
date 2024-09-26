Console.WriteLine("How old are you?");
var age = int.Parse(Console.ReadLine());
var answer = ("yes");
if (age >= 18)
{
    Console.WriteLine("Your salary per year:");
    var salary = int.Parse(Console.ReadLine());
    
    if (salary >= 25000 && age >= 18)
    {
        Console.WriteLine("Congratulations!");
    }
    else if (salary < 25000 && age >= 18)
    {
        Console.WriteLine("Do you have co-borrower?");
        var useranswer = Console.ReadLine();
        if (useranswer == answer)
        {
            Console.WriteLine("Congratulations!");
        }
        else
        {
            Console.WriteLine("Without access");

        }
    }
    else
    {
        Console.WriteLine("Without access");
    }
    }
    else
    {
        Console.WriteLine("Without access");
    }







