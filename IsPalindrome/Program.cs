using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsPalindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            IsPalindrome("Was it a car or a cat I saw");
        }

        static void IsPalindrome(string input)
        {
            // Convert input to lowercase and remove whitespaces
            var inputToLowerWithNoWhiteSpace = input.ToLower().Replace(" ", "");

            // Convert input to array, reverse and convert back to string
            var arr = inputToLowerWithNoWhiteSpace.ToCharArray();
            Array.Reverse(arr);
            var reverseString = new string(arr);
             
            
            // Write out result
            if (inputToLowerWithNoWhiteSpace.Equals(reverseString))
            {
                Console.WriteLine("\"" + input + "\" is a palindrome.");
            }
            else
            {
                Console.WriteLine("\"" + input + "\" is NOT a palindrome");
            }
                
        }
    }

}
