using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введiть логiн: ");
        string login = Console.ReadLine();

        if (Valid(login))
        {
            Console.WriteLine("Логiн пiдходить.");
        }
        else
        {
            Console.WriteLine("Логiн не пiдходить.");
        }
    }

    static bool Valid(string login)
    {
        Regex myReg = new Regex(@"^[a-zA-Z][a-zA-Z0-9]{1,9}$");

        if (myReg.IsMatch(login))
        {
            return true;
        }

        return false;   
    }
}
