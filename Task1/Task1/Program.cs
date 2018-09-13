using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            RandomStringArrayBuilder myRsab = new RandomStringArrayBuilder();
            //Console.WriteLine("input arrayLength:");
            int arrayLength = 10;//Int32.Parse(Console.ReadLine());
            //Console.WriteLine("input minStringLenght:");
            int minStringLength = 1;//Int32.Parse(Console.ReadLine());
            //Console.WriteLine("input maxStringLenght:");
            int maxStringLength = 20;//Int32.Parse(Console.ReadLine());
            string[] array = myRsab.RandomStringArrayMethod(arrayLength, minStringLength, maxStringLength);
            //myRsab.PrintValues(array);
            Console.WriteLine();

            PalindromeCheck myPc = new PalindromeCheck();
            //Console.WriteLine("enter string to check for palindrome:");
            string str = "ololo"; //Console.ReadLine();
            myPc.PrintValues(str);
            Console.WriteLine();
            myPc.PrintValues(array);
            Console.WriteLine();

            DividedStringArrayBuilder myDsab = new DividedStringArrayBuilder();
            //Console.WriteLine("enter string to divide:");
            string str2 = "lollipop"; //Console.ReadLine();
            string[] array2 = myDsab.DividedStringArrayMethod(str2);
            myDsab.PrintValues(array2);

            Console.ReadLine();
        }
    }
}
