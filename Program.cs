using System;

namespace datatypesTest
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = -100;
            Console.WriteLine(num);
            int num1 = -128;
            Console.WriteLine(num1);
            int num2 = -3540;
            Console.WriteLine(num2);
            int num3 = 64876;
            Console.WriteLine(num3);
            long num4 = 2147483648L;
            Console.WriteLine(num4);
            long num5 = -1141583228L;
            Console.WriteLine(num5);
            long num6 = -1223372036854775808L;
            Console.WriteLine(num6);
            double num7 = 3.141592653589793238D;
            Console.WriteLine(num7);
            float num8 = 1.60217657F;
            Console.WriteLine(num8);
            double num9 = 7.8184261974584555216535342341D;
            Console.WriteLine(num9);
            string myString1 = "Software University";
            Console.WriteLine(myString1);
            char myChar1 = 'B';
            Console.WriteLine(myChar1);
            char myChar2 = 'y';
            Console.WriteLine(myChar2);
            char myChar3 = 'e';
            Console.WriteLine(myChar3);
            string mystring2 = "I love programming";
            Console.WriteLine(mystring2);

            Nullable<int> i = null;
            Console.WriteLine(i);
            i = i + 42;
            Console.WriteLine(i);
            i = 10;
            Console.WriteLine(i);
            i = i + 42;
            Console.WriteLine(i);


        }
    }
}
