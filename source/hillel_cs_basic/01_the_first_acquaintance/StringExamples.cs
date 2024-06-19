using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _01_the_first_acquaintance
{
    public class Range
    {
        public int MyProperty1 { get; set; }
        public int MyProperty2 { get; set; }
        public int MyProperty3 { get; set; }
    }

    public class StringExamples
    {
        // .Net -> System.Int32  ---- Common Types System
        // C#   -> int (abbr)
        // VB   -> Integer (abbr)

        //float f = 0f;
        //System.Single s = 0f;

        public void FunWithString()
        {
            //int? i = null; 
            //string nullString = null;

            //string strEmpty = string.Empty;
            //string path = "C:\\Windows\\System32"; // @ - at serhii@gmail.com
            //string path2 = @"SELECT *
            //                 FROM Employee
            //                 WHERE id = 5"; // SQL-Queries

            //int a = 9; int b = 10;

            //string plus = string.Format("{0} + {1} = {2}", a, b, a + b); // data | view

            //string interpolation = $"{a} + {b} = {a + b}"; // data | view

            //Console.WriteLine(interpolation);

            //string str = "Hello"; // 25 mb
            //string anotherString = str; // + 25 mb

            //Console.WriteLine(ReferenceEquals(str, anotherString)); //  

            //string answer = Console.ReadLine();

            //Console.WriteLine(ReferenceEquals(str, answer)); // ==, equels => true 

            ////string answer = Console.ReadLine();

            ////Console.WriteLine(answer.GetHashCode()); // Unique Id based on value

            ////int a = 9; int b = 9; // 9 9
            ////bool c = a == b;



            // Обробка strings

            //string str1 = "Нello";
            //string str2 = "hello";

            //char H = 'Н';
            //char h = ' ';

            //Console.WriteLine($"{(int)H}    {(int)h}");

            //Console.WriteLine(str1 == str2);
            //Console.WriteLine(str1.Equals(str2));
            //Console.WriteLine(string.Compare(str1, str2)); // -1  0  1 // cp-1251 Coder

            //string str = "Hello World";
            //int a = 1;
            //string str1 = ", World";
            //string result = str + str1 + "!"; // string.Concat(str, str1, "!");

            //Console.WriteLine(result);

            //char[] arr = new char[str.Length];
            //str.CopyTo(2, arr, 0, 3);

            //string answer = string.Format("String contains {0} and {1}", str, a);
            //string answer = $"{str} {a}"; // strings interpolation 

            //Console.WriteLine(str.IndexOf('l'));
            //Console.WriteLine(str.LastIndexOf('l'));

            //Console.WriteLine(str.IndexOf("lo"));

            //char[] chars = str.ToCharArray();

            //string str1 = string.Join("\"", chars); // *.csv data1;data2;data 3;
            //string str1 = "data1;data2;data 3"; // *.csv data1;data2;data 3;

            //string[] chars = str1.Split(';');

            //str = str.Insert(5, ","); 

            //Console.WriteLine(str);

            //string str = " Hello, World! ";

            //str = str.Trim();
            //Console.WriteLine(str);

            //str = str.Replace(", ", "_");

            //string substr = str.Substring(6);

            //Console.WriteLine(substr);

            //string firstName = Console.ReadLine();//" aRtemenko"; // From user 
            //firstName = firstName.Trim(); // aRtemenko
            //string firstLetter = firstName.Substring(0, 1).ToUpper(); // A
            //string tailName = firstName.Substring(1).ToLower(); // rtemenko
            //string correctName = string.Concat(firstLetter, tailName);

            //Console.WriteLine(correctName);

            // Record to DB

            //string str = "Hello"; // ~4 Gb memory 
            //string str1 = str; 
            //Console.WriteLine(ReferenceEquals(str, str1)); // True
            //Console.WriteLine(str == str1); // True

            //string str2 = string.Intern(Console.ReadLine());
            //Console.WriteLine(ReferenceEquals(str, str2)); // True

            //for (int i = 0; i < str.Length; i++)
            //{
            //    //str[0] = ' '; // ReadOnly
            //}

            // Garbage Collector collect bad referances

            // StringBuilder
            //string myStr = "Hello, World!"; // lenght + lenght / 2

            //////for (int i = 0; i < myStr.Length; i++)
            //////{
            //////    myStr[i] = 'a'; // Error
            //////}

            //StringBuilder sb = new StringBuilder(myStr);

            //for (int i = 0; i < myStr.Length / 2; i++)
            //{
            //    var c = sb[i];
            //    sb[i] = sb[myStr.Length - i - 1];
            //    sb[myStr.Length - i - 1] = c;
            //}

            //Console.WriteLine(sb);



            //for (int i = 0; i < sb.Length; i++) 
            //{
            //    sb[i] = 'a';
            //}

            //Console.WriteLine(sb);

            // string - read, 
            // StringBuilder - update 

            //string firstName = " aRtemenko"; // From user 
            //firstName = firstName.Trim(); // aRtemenko
            //string firstLetter = firstName.Substring(0, 1).ToUpper(); // A
            //string tailName = firstName.Substring(1).ToLower(); // rtemenko
            //string correctName = string.Concat(firstLetter, tailName);


            //int v = 15; // HEX DEC BIN OCT
            // DEC
            // 0 - 9
            
            // BIN
            // 0, 1
            
            // OCT
            // 0 - 7

            // HEX
            // 0 - 9, A - F

            // DEC -> BIN < DEC -> HEX -> BIN

            //double d1 = Math.Round(v);
            //double d2 = Math.Ceiling(v); 
            //double d3 = Math.Floor(v);
            //Console.WriteLine(d3);
            //Console.WriteLine($"{v:X}"); 
            //Console.WriteLine($"{v}");

            //DateTime dt = DateTime.Now;

            //Console.WriteLine($"{dt:M}");
        }

        // Method Signature
        // return_type Name([optional] params)
        public void ReturnVoid0Args()
        {
            int i = 0;
            Console.WriteLine($"From ReturnVoid0Args method - {i}");
        }

        public void ReturnVoid1Args(int arg)
        {
            Console.WriteLine($"From ReturnVoid1Args method - {arg}");
        }
        public void ReturnVoidManyArgs(int arg1, int arg2)
        {
            Console.WriteLine($"From ReturnVoid1Args method - {arg1 + arg2}");
        }

        public void ReturnVoidArrArgs(int[] args)
        {
            Console.WriteLine($"From ReturnVoid1Args method -");
            int sum = 0;
            for (int i = 0; i < args.Length; i++)
            {
                sum += args[i];
            }

            Console.WriteLine(sum);
        }

        public void ReturnVoidManyNamedArgs(int arg1, int arg2)
        {
            Console.WriteLine($"From ReturnVoid1Args method - {arg1 + arg2}");
        }

        //public void ReturnVoidManyNamedArgs(int arg1, int arg2)
        //{
        //    //
        //}

        public void ReturnVoidManyWithDefaultValueArgs(int arg1, int arg2, int arg3 = 8)
        {
            int sum = arg1 + arg2 + arg3;

            Console.WriteLine(sum);
        }

        public Range ReturnValue(int[] ints)
        {
            Range range = new Range();
            range.MyProperty1 = ints[0];
            range.MyProperty2 = ints[1];
            range.MyProperty3 = ints[2];
            int sum = ints.Sum();
            return range;
        }

        public (int a, int b, int c) ReturnTuples(int[] ints) // Кортежі
        {
            //Range range = new Range();
            //range.MyProperty1 = ints[0];
            //range.MyProperty2 = ints[1];
            //range.MyProperty3 = ints[2];
            //int sum = ints.Sum();
            return (ints[0], ints[1], ints[2]);
        }


        public void Sum(int a, int b)
        {
            Console.WriteLine(a + b);
        }
        public int Sum(int a)
        {
            Console.WriteLine();
            return a;
        }
        public void Sum(decimal a, decimal b)
        {
            Console.WriteLine(a + b);
        }
    }
}
