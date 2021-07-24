using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace RegexRegistrationProblem
{
    class ValidateMobileNumber
    {
        public static string Regex_MobileNumber = "(0|91)?[ ][6-9][0-9]{9}";

        public static String validateMobileNumber(string mobileNumber)
        {
            if (Regex.IsMatch(mobileNumber, Regex_MobileNumber) == true)
                return "Valid Mobile Number";
            else
                return "InValid Mobile Number";
        }
    }
}
