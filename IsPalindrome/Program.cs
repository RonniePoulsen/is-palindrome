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

            var firstHalf = "";
            var secondHalf = "";
            
            // Check if input length is an even number
            if (inputToLowerWithNoWhiteSpace.Length % 2 == 0)
            {
                // Get first half of the original input
                firstHalf = inputToLowerWithNoWhiteSpace.Substring(0, inputToLowerWithNoWhiteSpace.Length / 2);

                // Convert input to an array and reverse
                var arr = inputToLowerWithNoWhiteSpace.ToCharArray();
                Array.Reverse(arr);
                var reverseString = new string(arr);

                // Get first half of the reversed string
                secondHalf = reverseString.Substring(0, reverseString.Length / 2);
            }
            else
            {
                // Get first half (-1 character) of the original input
                firstHalf = inputToLowerWithNoWhiteSpace.Substring(0, (inputToLowerWithNoWhiteSpace.Length / 2) - 1);

                // Convert input to an array and reverse
                var arr = inputToLowerWithNoWhiteSpace.ToCharArray();
                Array.Reverse(arr);
                var reverseString = new string(arr);

                // Get first half (-1 character) of the reversed string
                secondHalf = reverseString.Substring(0, (reverseString.Length / 2) - 1);
            }



            // Write out result
            if (firstHalf.Equals(secondHalf))
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
