using System;

namespace RegexRegistrationProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter The Last Name ::");
            String fname = Console.ReadLine();
            Console.WriteLine(ValidLastName.validateLastName(fname));
            Console.WriteLine();
        }
    }
}
