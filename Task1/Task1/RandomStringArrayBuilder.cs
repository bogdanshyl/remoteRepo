using System;

namespace Task1
{
    class RandomStringArrayBuilder
    {
        public string[] RandomStringArray { get; set; }
        public string RandomString { get; set; }
        public char RandomChar { get; set; }

        public string[] RandomStringArrayMethod(int arrayLength, int minStringLength, int maxStringLength)
        {
            RandomStringArray = new string[arrayLength];
            for (int i = 0; i < RandomStringArray.Length; i++)
            {
                RandomStringArray[i] = RandomStringMethod(minStringLength, maxStringLength);
            }
            return RandomStringArray;
        }
        public string RandomStringMethod(int minStringLength, int maxStringLength)
        {
            RandomString = string.Empty;
            for (int i = 0; i < new Random().Next(minStringLength, maxStringLength); i++)
            {
                RandomString += RandomCharMethod();
                System.Threading.Thread.Sleep(10);
            }
            return RandomString;
        }
        public char RandomCharMethod()
        {
            //string engAlphabet = "abcdefghijklmnopqrstuvwxyz";
            //return RandomChar = engAlphabet[new Random().Next(0, 25)];
            return RandomChar = (char)('a' + new Random().Next(0, 25));
        }
        public void PrintValues(string[] array)
        {
            foreach (string str in array)
            {
                Console.WriteLine(str);
            }
        }
    }
}