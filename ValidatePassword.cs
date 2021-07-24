using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace RegexRegistrationProblem
{
    class ValidatePassword
    {
        public static string Regex_Password = "^[A-Z][A-Za-z0-9]{7,}$";

        public static String validatePassword(string password)
        {
            if (Regex.IsMatch(password, Regex_Password) == true)
                return "Valid Password";
            else
                return "InValid Password";
        }
    }
}
