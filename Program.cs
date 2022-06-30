using System;

namespace A2Q6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string which will be tested is str
            string str;

            //i is for loop; len is is the length of str; vowel is counter for vowel appearances
            int i, len, vowel;

            Console.Write("This program will count the number of vowels appearing in your word.\n");

            // take input of string from the user.
            Console.Write("\nInput the string : ");
            str = Console.ReadLine();

            //set vowel counter from 0; and determine the length of the string entered, which is used as the limit in our for loop
            vowel = 0;
            len = str.Length;

            for (i = 0; i < len; i++)
            {
                //each index in the string is compared with vowels (both lower and upper case); using OR.
                if (str[i] == 'a' || str[i] == 'e' || str[i] == 'i' || str[i] == 'o' || str[i] == 'u' || str[i] == 'A' || str[i] == 'E' || str[i] == 'I' || str[i] == 'O' || str[i] == 'U')
                {
                    vowel++;
                }
                else 
                {
                    //to go back to the start of the loop.
                    continue;
                }
            }
            Console.Write("\nThe total number of vowels in the string is : {0}\n", vowel);
        }
    }
}
