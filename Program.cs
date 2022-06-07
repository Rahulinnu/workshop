using System;

namespace workshop
{
    class MainClass
    {
        public static void Main(string[] args)
        {

            Console.WriteLine("Enter first word: ");
            string str1 = Console.ReadLine();
            Console.WriteLine("Enter second word: ");
            string str2 = Console.ReadLine();

            str1 = str1.ToLower();
            str2 = str2.ToLower();

            if (str1.Length != str2.Length)
            {
                Console.WriteLine("Both the strings are not anagram");
            }

            else
            {

                char[] string1 = str1.ToCharArray();
                char[] string2 = str2.ToCharArray();

                Array.Sort(string1);
                Array.Sort(string2);

                if (string1.ToString().Equals(string2.ToString()))
                {
                    Console.WriteLine("Both the strings are anagram");
                }
                else
                {
                    Console.WriteLine("Both the strings are not anagram");
                }
            }
        }
    }
}

