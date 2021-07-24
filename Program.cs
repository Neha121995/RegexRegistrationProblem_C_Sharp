using System;

namespace RegexRegistrationProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter The First Name ::");
            String fname = Console.ReadLine();
            Console.WriteLine(ValidFirstName.validateFirstName(fname));
            Console.WriteLine();
        }
    }
}
