using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PurpleTest
{
    class Program
    {
        public static string NextPalindrome(string input)
        {
            int num = int.Parse(input);
            int output;
            int length = input.Length;
            int halfLength = length / 2;

            while (true)
            {
                output = ++num;

                if (isPalindrome(output))
                    break;          
            }
            return output.ToString();
        }

        public static string countLettersAndDigits(string input)
        {
            int lowerCase = 0;
            int upperCase = 0;
            int digit = 0 ;
            foreach(var c in input)
            {
                if (char.IsLower(c))
                    lowerCase++;
                else if (char.IsUpper(c))
                    upperCase++;
                else if (char.IsDigit(c))
                    digit++;
            }
            return String.Format("{0}:{1}:{2}", lowerCase, upperCase, digit);
        }

        public static string[] checkPalindrome(int length, int[] array)
        {
            string[] output = new string[length];

            for (int i = 0; i < length; i++)
            {
                if (isPalindrome(array[i]))
                    output[i] = "Palindrome".ToUpper();
                else
                    output[i] = "NOT";
            }
            return output;
            
        }

        public static int[] duplicateArray(int length, int[] array)
        {
            int count = 0;
            int[] temp = new int[length];
            for (int i = 0; i < length-1; i++)
            {
                for(int j = i+1; j < length; j++)
                {
                    if (array[i] == array[j] && array[i] != -1)
                    {
                        array[j] = -1;
                        temp[i] = array[i];
                        count++;
                    }
                }                 
            }
            int newLength = count;
            int[] output = new int[newLength];
            int index = 0;
            for (int i = 0; i < length; i++)
                if(temp[i] != 0)
                    output[index++] = array[i];
            if (count != 0)
                return output;
            else
                return new int[1] { -1 };

        }

        public static bool isPalindrome(int num)
        {
            string input = num.ToString();
            int length = input.Length;
            int halfLength = length / 2;


                var count = 0;
                for (count = 0; count < halfLength; count++)
                {
                    var first = input[count];
                    var last = input[length - 1 - count];
                    if (first != last)
                        break;
                }
            if (count == halfLength)
                return true;
            else
                return false;
        }

        static void Main()
        {
            Console.WriteLine(NextPalindrome("95188"));
            Console.WriteLine(countLettersAndDigits("HelloWorld42"));
            var output1 = checkPalindrome(6, new int[] { 1, 3, 5, 7, 9, 10 });
            foreach(var e in output1)
                Console.WriteLine(e);
            // Keep the console window open in debug mode.
            var output2 = duplicateArray(6, new int[] { 4, 4, 7,  11, 8, 9 });
            foreach (var e in output2)
                Console.WriteLine(e);
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
