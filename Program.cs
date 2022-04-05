using System;
using System.Collections.Generic;

namespace Delegate
{
    class Program
    {
        delegate bool Check(int num);
        // delegate void Write<T, U>(T str1, U str2);
        //delegate C Write<in T, in U, out C>(T str1, U str2);
        // delegate int Topla(int num1, int num2);

        static void Main(string[] args)
        {
            // delegate arashdirma =   https://www.youtube.com/watch?v=8khRhtRgdqw
            // delegate arashdirma =   https://www.youtube.com/watch?v=mYKds3_RboY
            // delegate arashdirma = https://www.yusufsezer.com.tr/csharp-delegate/#:~:text=C%23%20programlama%20dilinde%20tan%C4%B1mlanan%20ve,pointer%20veya%20fonksiyon%20g%C3%B6stericilerine%20benzemektedir.





            // Console.WriteLine(Sum(new int[] { 2, 4, 5, 6, 9 }, n => n % 2 == 0));
            // Console.WriteLine(Sum(new int[] { 2, 4, 5, 6, 9 }, CheckIsEven(4)));
            //Console.WriteLine(IsBigTwo(new int[] {2,3,4,6,9 }));


            //StringBuilder stringBuilder = new StringBuilder();
            //StringBuilder stringBuilder1 = new StringBuilder();
            // Write write = Test;
            //write += TestUpper;
            //write += TestLength;
            // write += delegate (string m)
            //{
            //     Console.WriteLine(m.ToLower());
            // };
            // write -= TestLength;
            // write .Invoke("Lorem");
            // write ("Lorem");
            //Topla topla = Summer;
            //topla += delegate (int b, int z)
            //{
            //    return b + z;
            //};
            //topla += (n, m) =>
            //{
            //    Console.WriteLine("topla");
            //    return n - m;
            //};
            //Console.WriteLine(topla(5, 6));

            //Action<int, int> test = (n, m) => Console.WriteLine(n+m);
            //Predicate<string> tes2 = m => m.Length > 5;
            //Func<int,int ,string> test3 = (n, m) => "test";


            List<int> numbers = new List<int>();
            numbers.Add(7);
            numbers.Add(3);
            numbers.Add(5);
            numbers.Add(4);
            numbers.Add(14);
          int num = numbers.Find(n => n > 2);
            Console.WriteLine(num);
          List<int> nums=  numbers.FindAll(n => n > 2);
            foreach (var item in nums)
            {
                Console.WriteLine(item);
            }


        }
        //static int Summer(int n, int m)
        //{
        //    return n + m;
        //}
        //static void Test(string word1)
        //{
        //    Console.WriteLine(word1);
        //}
        //static void TestUpper(string word1)
        //{
        //    Console.WriteLine(word1.ToUpper());
        //}
        //static void TestLength(string word1)
        //{
        //    Console.WriteLine(word1.ToUpper());
        //}
        //static bool CheckIsOdd(int num)
        //{
        //    return num % 2 == 1;
        //}

        //static bool CheckIsEven(int num)
        //{
        //    return num % 2 == 0;
        //}
        //static bool CheckBigTwo(int num)
        //{
        //    return num > 2;
        //}
        static int Sum(int[] arr, Predicate<int> func)
        {
            int result = 0;
            foreach (var item in arr)
            {
                if (func(item))
                {
                    result += item;
                }

            }
            return result;
        }
    }
}
