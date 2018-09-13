using System;

namespace Task1
{
    class DividedStringArrayBuilder
    {
        public string[] DividedStringArray { get; set; }

        public string[] DividedStringArrayMethod(string str)
        {
            int initialStringLenght = str.Length;
            int firstIndex = 0;
            DividedStringArray = new string[str.Length * str.Length];
            for (int i = 0; i < DividedStringArray.Length; i++)
            {
                DividedStringArray[i] = str.Substring(firstIndex, initialStringLenght - firstIndex);
                firstIndex++;
                if (firstIndex == initialStringLenght)
                {
                    firstIndex = 0;
                    DividedStringArray[i] = str.Substring(firstIndex, initialStringLenght);
                    initialStringLenght--;
                    if (initialStringLenght == firstIndex)
                    {
                        initialStringLenght = str.Length;
                    }
                }
            }
            return DividedStringArray;
        }
        public void PrintValues(string[] array)
        {
            foreach (string str in array)
            {
                Console.WriteLine($"{new PalindromeCheck().PalindromeBoolMethod(str)}:\t{str}");
            }
        }
    }
}
