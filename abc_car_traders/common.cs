using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace abc_car_traders
{
    internal class common
    {
        public bool IsValidEmail(string email)
        {
            // Regular expression pattern for email validation
            string pattern = @"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$";
            Regex regex = new Regex(pattern);

            // Check if the email matches the pattern
            return regex.IsMatch(email);
        }

        public bool ContainsOnlyLetters(string input)
        {
            // Regular expression pattern for only letters (alphabetic characters)
            string pattern = "^[a-zA-Z]+$";
            Regex regex = new Regex(pattern);

            // Check if the input string contains only letters
            return regex.IsMatch(input);
        }

        public bool ContainsOnlyNumbers(string input)
        {
            // Regular expression pattern for only numbers
            string pattern = "^[0-9]+$";
            Regex regex = new Regex(pattern);

            // Check if the input string contains only numbers
            return regex.IsMatch(input);
        }
    }
}
