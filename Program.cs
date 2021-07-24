using System;

namespace RegexRegistrationProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter The Mobile Number ::");
            String mobileNumber = Console.ReadLine();
            Console.WriteLine(ValidateMobileNumber.validateMobileNumber(mobileNumber));
            Console.WriteLine();
        }
    }
}
