using System;

namespace Task1
{
    class PalindromeCheck
    {
        public bool PalindromeBool { get; set; }

        public bool PalindromeBoolMethod(string str)
        {
            char[] tempArray = str.ToCharArray();
            Array.Reverse(tempArray);
            return PalindromeBool = Equals(str, new string(tempArray));
        }
        public void PrintValues(string str)
        {
            Console.WriteLine($"{PalindromeBoolMethod(str)}:\t{str}");
        }
        public void PrintValues(string[] array)
        {
            foreach (string str in array)
            {
                Console.WriteLine($"{PalindromeBoolMethod(str)}:\t{str}");
            }
        }
    }
}
