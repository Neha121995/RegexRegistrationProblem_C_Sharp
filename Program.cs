using System;

namespace RegexRegistrationProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter The Email Id ::");
            String email = Console.ReadLine();
            Console.WriteLine(ValidateEmail.validateEmail(email));
            Console.WriteLine();
        }
    }
}
