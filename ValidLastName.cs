using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace RegexRegistrationProblem
{
    class ValidLastName
    {
        public static string Regex_LName = "^[A-Z]{1}[A-Za-z]{2,}$";

        public static String validateLastName(string firstName)
        {
            if (Regex.IsMatch(firstName, Regex_LName) == true)
                return "Valid Last Name";
            else
                return "InValid Last Name";
        }
    }
}
