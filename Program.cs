using System;

namespace RegexRegistrationProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter The Password ::");
            String password = Console.ReadLine();
            Console.WriteLine(ValidatePassword.validatePassword(password));
            Console.WriteLine();
        }
    }
}
