using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace RegexRegistrationProblem
{
    class ValidFirstName
    {
        public static string Regex_FName = "^[A-Z]{1}[A-Za-z]{2,}$";

        public static String validateFirstName(string firstName)
        {
            if (Regex.IsMatch(firstName, Regex_FName) == true)
                return "Valid First Name";
            else
                return "InValid First Name";
        }
    }
}
