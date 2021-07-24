﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace RegexRegistrationProblem
{
    class ValidateEmail
    {
        public static string Regex_Email = "^[A-Z0-9a-z]{1,}([.#$^][A-Za-z0-9]+)*[@][A-Za-z]{2,}[.][A-Za-z]{2,3}([.][a-zA-Z]{2})?$";

        public static String validateEmail(string email)
        {
            if (Regex.IsMatch(email, Regex_Email) == true)
                return "Valid Email";
            else
                return "InValid Email";
        }
    }
}