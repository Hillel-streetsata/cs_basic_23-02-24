﻿using System.Data.SqlTypes;
using System.Security.Cryptography;
using System.Text;

namespace _01_the_first_acquaintance
{

#pragma warning disable S1118 // Utility classes should not have public constructors
    internal class Program
#pragma warning restore S1118 // Utility classes should not have public constructors
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;

            // artemenko_hw_5

            // fgfgf

            // / % Convert.To...
            //string str = "123456";

            //foreach (char arg in str) 
            //{
            //    if (char.IsDigit(arg))
            //    {

            //    }
            //}

            // "123457845454"



            // F5 - build (compile)
            // Ctrl + Space - Intellesence 
            // Ctrl + e + c - commenting
            // Ctrl + e + u - uncommenting
            // Ctrl + k + d - like "prettier" - formatter
            // Ctrl + e + v - copy current line and enter it's after current code
            // Shift + Alt + arrows up and down - multyline line typing
            // snippets
            // cw + tab+tab => Console.WriteLine();
            // F11 - step into
            // F10 - step over
            // Shift + F11 - go out from block (Method)
            // Ctrl + k + s - Surround with...

            /* Console.WriteLine("The first step");
             * fgfg
             * fgfgf
             * fgfg
             * 
            char[] chars = { 'A', };*/

            //int a = 0;

            //int ageOfPerson = 15;
            //Console.WriteLine(ageOfPerson + 89);

            //int age = 37;
            //age = 34; // присвоїти значення справа тому що зліва

            //FunWithBasicDataTypes();
            //FunWithNumericConversions();
            //FunWithOperators();

            // Examples();

            // methods
            //ExecMethods();

            //Console.WriteLine(ReturnLine(4, 8, 0));

            //int result = DivideTwoNumbers(9, 0);

            //Console.WriteLine(result);

            // FunWithConditions();
            //FunWithArray();

            int[] arr = { -4, 1, 1, 5, 3, 7, -2 }; // 0       
            //int[] arr = { 1, 2, 3 }; // 0


            ArrayExamples arrayExamples = new ArrayExamples();
            arrayExamples.ArrayMaxElement(arr);
            Console.WriteLine();
            arrayExamples.AverageArr(arr);
            Console.WriteLine();
            arrayExamples.SumEvenElementOfArr(arr);
            Console.WriteLine();
            //arrayExamples.ReverseArr(arr);
            //Console.WriteLine();
            arrayExamples.IsSortedIntoGrowingOrder(arr);
            Console.WriteLine();
            arrayExamples.SwitchNegativeElements(arr);
        }

        private static void FunWithArray()
        {
            // Collections
            // Queue - First In First Out
            // Stack - First In Last Out

            // Array default value 

            // Одновимірні масиви
            //int i = 100_00_00_00;
            //int[] array = new int[10]; // 0 n(10) - 1
            //int[] array = [78, 22, 34, 7, 9, 8]; // C# 9 .Net 6
            //array[0] = 8;
            //array[1] = 7;
            //// array[10] = 8; exeption

            //Console.WriteLine(array[0]);

            //int[] arr = new int[10];

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    arr[i] = i * 8; // Access
            //    Console.Write(arr[i] + " ");
            //}

            // Багатовимирні масиви
            //      2...3..n (Matrix) Тесиракт
            //      Jagged (Рвані) Charts 

            /* Tasks
             * Напишіть програму, яка знаходить найбільший елемент у масиві.
             * Напишіть програму, яка знаходить середнє арифметичне всіх елементів у масиві.
             * Напишіть програму, яка обчислює суму всіх парних елементів у масиві. 
             * Напишіть програму, яка перевертає масив (змінює порядок елементів на зворотний).
             * Напишіть програму, яка перевіряє, чи масив є відсортованим у зростаючому порядку. 
             * Напишіть програму, яка замінює всі від'ємні елементи у масиві на нульові. 
             * Напишіть програму, яка знаходить позицію (індекс) заданого елемента у масиві.
             * Напишіть програму, яка обчислює кількість входжень заданого елемента у масив.
             */

            int[] arr = new int[10];

            Random rnd = new Random();

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rnd.Next(1, 100);
                Console.Write($"{arr[i]} ");
            }

            int max = arr[0];
            int min = arr[0];
            double sum = 0;
            int evenSum = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];

                if (max < arr[i])
                {
                    max = arr[i];
                }

                if (min > arr[i])
                {
                    min = arr[i];
                }

                if (i % 2 == 0)
                {
                    evenSum += arr[i];
                }
            }
            Console.WriteLine();
            Console.WriteLine($"{min} {max} {sum / arr.Length} {evenSum}");
        }



        //static void FunWithBasicDataTypes()
        //{
        //    //var some = 9.5f;

        //    // integral-numeric-types
        //    byte b = 255; // 0 - 255  -- 1 byte
        //    sbyte sb = -78; // -128 - 127 -- 1 byte // sign

        //    short sh = 45; // -32768 - 32767 -- 2 bytes
        //    ushort ush = 78; // 0 .. 65,535 -- 2 bytes // unsigned

        //    int i = 9; // -2,147,483,648 .. 2,147,483,647 -- 4 bytes
        //    uint ui = 8; // 0 .. 4,294,967,295

        //    long l = 456456; // -9,223,372,036,854,775,808 .. 9,223,372,036,854,775,807 -- 8 bytes
        //    ulong ul = 0; // 0 .. 18,446,744,073,709,551,615

        //    // floating-point-numeric-types
        //    float f = 4.512f; // -- 8 bytes -- 8 after comma  
        //    double d = 0.3; //-- 16 bytes -- 15 after comma

        //    // decimal
        //    decimal dc = 456.789m; // 28 after comma

        //    // char
        //    char ch = 'A'; // 1 byte utf-8 (Unicode) 32000... - utf-16 

        //    Console.WriteLine(ch);

        //    Console.Write("   **   ");
        //    Console.Write("  ****  ");
        //    Console.Write(" **  **");
        //    Console.Write("********");

        //    int cha = 70;
        //    Console.WriteLine((char)cha);

        //    // string
        //    string firstLine = "Hello";
        //    string secondLine = "World!";
        //    string result = firstLine + ", " + secondLine; // string concatination
        //    Console.WriteLine(result); // Hello, World!

        //    Console.Write("Please enter first name ");
        //    string name = Console.ReadLine();

        //    Console.Write("Second name ");
        //    string surname = Console.ReadLine();

        //    string fullName = name + " " + surname;
        //    Console.WriteLine("Hello, " + fullName);

        //    // Escape-sequencies
        //    Console.WriteLine("To be or not to be\n\t\t\'W. Schecspiar\r\'");

        //    Console.WriteLine("Enter password:");
        //    Console.Write("*******\r");

        //    string str2 = string.Empty; // \0


        //    Console.WriteLine();


        //    Console.ReadLine();
        //}

        //static void FunWithNumericConversions()
        //{
        //    // numeric-conversions
        //    // не явне приведення типів
        //    byte b = 255;
        //    int i = b + 1; // numeric-conversions

        //    try
        //    {
        //        checked
        //        {
        //            // явне приведення типів
        //            byte b1 = (byte)i; // ??? 9 Error
        //            Console.WriteLine(b1); // --Error MaxNumber (255) 0 // переповнення регістру
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine(ex.Message);
        //    }

        //    Console.WriteLine("next");


        //    Console.Write("Enter first number: ");
        //    //int firstNumber = int.Parse(Console.ReadLine());
        //    int firstNumber = Convert.ToInt32(Console.ReadLine());

        //    Console.Write("Enter second number: ");
        //    int secondNumber = Convert.ToInt32(Console.ReadLine());

        //    int sum = firstNumber + secondNumber;

        //    string result = "Sum: " + sum;

        //    Console.WriteLine(result);

        //    Console.WriteLine("Task 1");
        //    Console.WriteLine(new string('-', 15));
        //}

        //static void FunWithOperators()
        //{
        //    // operators
        //    int a = 12;
        //    int b = -5;
        //    int resultDivide = a / b; // 3
        //    int resultModule = a % b; // 2

        //    Console.WriteLine(resultDivide);
        //    Console.WriteLine(resultModule);


        //    // +1
        //    //int i = 0;
        //    //i++; i = i + 12; i += 1;
        //    //i *= 9; i = i / 9;

        //    //i = i % 9 + (7 / 5); // 

        //    //i++; // i = i + 1; // 1 // інкремент
        //    //++i; // i = i + 1; // 1 // інкремент
        //    //i--; // i = i - 1; // декримент

        //    //Console.WriteLine(++i); // 1? 0
        //    //Console.WriteLine(-i); // -1

        //    int res = (int)Math.Pow(2, 8); // 256

        //}

        //static void Examples()
        //{
        //    /*
        //     * 
        //     *
        //     * 
        //     * Задано радіус кола. Знайдіть його площу за формулою: Area = π * r^2, де π - число Пі.
        //     * Задано рік. Перевірте, чи він є високосним.
        //     * Задано кількість секунд. Підрахуйте, скільки це буде в днях, годинах і хвилинах. 
        //     * Використовуючи клас Random, згенеруйте випадкове ціле число в певному діапазоні.
        //     * Задана довжина ребра куба. Знайдіть його об'єм за формулою: Volume = sideLength^3.
        //     * Задано три числа. Знайдіть найбільше з них. (Використати Math.Max() та Math.Min())
        //     * Задано число та його ступінь. Підрахуйте його значення.
        //     * Задано два числа. Знайдіть частку та залишок від ділення першого числа на друге.
        //     */

        //    // Задано довжину та ширину прямокутника. Знайдіть його площу.

        //    //Console.Write("Введіть довжину: ");
        //    //double h = Convert.ToDouble(Console.ReadLine());
        //    //Console.Write("Введіть ширину: ");
        //    //double w = Convert.ToDouble(Console.ReadLine());

        //    //double S = h * w;

        //    //Console.WriteLine("Площа прямокутника: " + S);

        //    // Задано температуру в градусах Цельсія. Переведіть її в градуси Фаренгейта за формулою: F = (C * 9/5) + 32.
        //    //double C = new Random().NextDouble() * 100;
        //    //double F = (C * 9 / 5) + 32;
        //    //Console.WriteLine(F); // 0 ... 1


        //    // Задано радіус кола.Знайдіть його площу за формулою: Area = π * r ^ 2, де π -число Пі.
        //    //double R = new Random().NextDouble() * 10;

        //    //double area = 3.14159265 * (R * R);// Math.Pow(R, 2);


        //    // Задано рік. Перевірте, чи він є високосним. >= < > <=

        //    // Задано кількість секунд.Підрахуйте, скільки це буде в днях, годинах і хвилинах.
        //    //int secs = 1001;
        //    //int minutes = secs / 60;
        //    //int hours = secs / 3600;

        //    // Задано три числа.Знайдіть найбільше з них. (Використати Math.Max() та Math.Min())

        //    //int a = 9, b = 10, c = 11;
        //    //int max = Math.Max(Math.Max(a, b), c);
        //    //Console.WriteLine(Math.Max(b, c));

        //    // Задано два числа. Знайдіть частку та залишок від ділення першого числа на друге.
        //    // % /

        //    int num = 45;
        //    int firstDigit = num / 10; // 4
        //    int secondDigit = num % 10; // 5    


        //    Console.WriteLine(Environment.SystemDirectory);
        //    Console.WriteLine(secondDigit);
        //}

        //static void ExecMethods()
        //{
        //    //VoidMethod();

        //    //int a = 9;
        //    //FunWithParams(a, 7);

        //    string str = ReturnLine(5, 7, 9);
        //    Console.WriteLine(str);

        //}

        //// Method Function Procedure
        //static void VoidMethod()// return type Name (optional params)
        //{
        //    Console.WriteLine("Hello from VoidMethod");
        //}

        //static void FunWithParams(int a, double b)
        //{
        //    double d = Math.Sqrt(9);
        //    Console.WriteLine(a + d * b);
        //}

        ///// <summary>
        ///// Returns max of numbers
        ///// </summary>
        ///// <param name="a">first num</param>
        ///// <param name="b">second num</param>
        ///// <param name="c">third num</param>
        ///// <returns>hu is max</returns>
        //static string ReturnLine(int a, int b, int c)
        //{
        //    string result = string.Empty;
        //    double max = Math.Max(Math.Max(a, b), c);
        //    result = "Max num is: " + max;

        //    int y = 9;


        //    Console.WriteLine("Hello, World!");
        //    var number = 5.5;
        //    number += 7; // number = number + 7;
        //    Console.WriteLine(number);


        //    return result + y; // 0 
        //}

        static int DivideTwoNumbers(int firstNumber, int secondNumber)
        {
            int result = 0;

            int a = 8; int b = 9;

            int c = a * 9;

            try
            {
                secondNumber = Convert.ToInt32(Console.ReadLine());
                result = firstNumber / secondNumber;
            }
            catch (DivideByZeroException ex)
            {
                // Show user
                // logging
                Console.WriteLine(ex.Message);
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);

            }
            finally
            {
                Console.WriteLine("Finally is here");
            }

        l0:;
            Console.WriteLine("After divide");

            return result;
        }

        static void FunWithConditions()
        {
            //int a = 5;//new Random().Next(1, 100); // 99
            //int b = 15;//new Random().Next(1, 100); // 99
            //int c = 25;

            //bool res = c > a & c > b; // true & true => true

            // Bin alg
            // & &&
            // true & true => true
            // true & false => false
            // false && true => false
            // false & false => false

            // | ||
            // true | true => true
            // true | false => true
            // false | true => true
            // false | false => false

            // bool trueFalse = a > b; 5 > 3 => true 
            // bool trueFalse = a < b; 2 > 3 => true
            // bool trueFalse = a >= b; 5 > 4 or 5 = 5 => true
            // bool trueFalse = a <= b; 5 < 4 or 5 = 5 => true
            // bool trueFalse = a == b; 5 = 5 true
            // bool trueFalse = a != b; 1 != 9 true

            // Задається ціле число.Якщо він позитивний, додайте до нього 1;
            // В іншому випадку не змінюйте його. Виведіть отримане число.

            //int r1 = new Random().Next(-10, 5);
            //int r2 = new Random().Next(1, 100);

            //if (r1 > 0)
            //{
            //    r1++;
            //}
            //else 
            //{
            //    r1 += 2; // r1 = r1 + 2
            //}

            //Console.WriteLine(r1);

            //// Дано два числа.Виведіть більше з них
            //int r1 = new Random().Next(1, 3);
            //int r2 = new Random().Next(1, 3);

            //if (r1 == r2)
            //{
            //    Console.WriteLine("r1 equal r2");
            //}
            //else if (r1 > r2)
            //{
            //    Console.WriteLine(r1 + "(r1) is bigger");
            //}
            //else
            //{
            //    Console.WriteLine(r2 + "(r2) is bigger");
            //}

            // Дано три числа. Знайдіть найменший.
            //int r1 = new Random().Next(1, 100);
            //int r2 = new Random().Next(1, 100);
            //int r3 = new Random().Next(1, 100);

            //if (r1 < r2 && r1 < r3)
            //{
            //    Console.WriteLine(r1 + "min is r1");
            //}
            //else if (r2 < r1 && r2 < r3)
            //{
            //    Console.WriteLine(r2 + "min is r2");
            //}
            //else
            //{
            //    Console.WriteLine( r3 + "min is r3");
            //}

            //int min = Math.Min(r1, Math.Min(r2, r3));
            //Console.WriteLine("Min is: " + min);

            // Дано дві змінні цілочисельного типу: A і B.Якщо їх значення не рівні,
            // то призначте суму цих значень кожній змінній, а якщо вони рівні,
            // то привласніть змінним нульові значення. Вивести нові значення змінних A і B.

            //int A = new Random().Next(1, 100);
            //int B = new Random().Next(1, 100);
            //int sum = A + B;

            //if (A != B)
            //{
            //    A = sum;
            //    B = sum;
            //}
            //else
            //{
            //    A = B = 0;
            //}

            //Console.WriteLine($"{A} {B}");


            // a & b sign operation - + - / * %

            //int a = new Random().Next(1, 100);
            //int b = new Random().Next(1, 100);
            //label1:
            //Console.Write("Type the sign of operstion: ");
            //string country = Console.ReadLine();
            //Console.Write("Type the lang: ");
            //string langCult = Console.ReadLine();

            //switch (country)
            //{
            //    case "ENG":
            //    case "USA":
            //        Console.WriteLine("Translate to English");
            //        break;
            //    case "CAN":
            //        {
            //            if (langCult == "FR")
            //            {
            //                Console.WriteLine("Translate to Fr");
            //            }
            //            else
            //            {
            //                Console.WriteLine("Translate to English");
            //            }
            //            break;
            //        }
            //    default:
            //        break;
            //}


            //int a = new Random().Next(1, 5);
            //int b = new Random().Next(1, 5);
            //int c = new Random().Next(1, 5);

            //int max = 0;

            //// ?:
            //max = (a > b && a > c) ? a : (b > c && b > a) ? b : c;

            //// if/else
            //if (a > b) max = a;
            //else max = b;


            //switch (sign)
            //{
            //    case "+":
            //        Console.WriteLine(a + b);
            //        break;
            //    case "-":
            //        Console.WriteLine(a - b);
            //        break;
            //    case "*":
            //        Console.WriteLine(a * b);
            //        break;
            //    case "/":
            //        Console.WriteLine(a / b);
            //        break;
            //    default:
            //        Console.WriteLine("You entered fault sign");
            //        goto label1;
            //}

            //Console.WriteLine("After switch");
            //if (sign.Equals("+"))
            //{
            //    Console.WriteLine(a + b);
            //}
            //else if (sign == "-")
            //{
            //    Console.WriteLine(a - b);
            //}
            //else if (sign.Equals("*"))
            //{
            //    Console.WriteLine(a * b);
            //}
            //else if (sign.Equals("/"))
            //{
            //    if (b == 0)
            //    {
            //        throw new DivideByZeroException();
            //    }
            //    else
            //    {
            //        Console.WriteLine(a / b);
            //    }
            //}

            // Вгадати число, яке загадав користувач, використовуючи тільки інструкцію if-else

            //int compVar = new Random().Next(1, 5);
            //int answer = 0;

            //try
            //{
            //    answer = Convert.ToInt32(Console.ReadLine());
            //    if (answer == compVar)
            //    {
            //        Console.WriteLine("Компьютер вгадав " + compVar);
            //    }
            //    else 
            //    {
            //        Console.WriteLine("Компьютер не вгадав " + compVar);
            //    }
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}

            // Loops

            //int i = 0; // змінна, яка управляє циклом -- лічильник цикла

            //while (i < 10) 
            //{
            //    Console.WriteLine(i);
            //    i++;
            //}

            // Складіть програму для виведення будь-якого числа будь-яку задану кількість разів у формі,
            // подібній до тієї, що показана в попередньому завданні.

            //int i = 0;
            //int num = new Random().Next(1, 1000);
            //int count = new Random().Next(1, 10);

            //while (i < count)
            //{
            //    Console.WriteLine(num);
            //    i++;
            //}

            // Одна штука якогось виробу коштує 20,4 грн.
            // Вивести таблицю вартості 2, 3, ..., 20 штук цього товару

            //int i = 2;
            //double cost = 20.4;

            //while (i < 21)
            //{
            //    Console.WriteLine("Price of " + i + " cost " + i * cost);
            //    i++;
            //}

            // Вивести таблицю множення на 7:   1 х 7 = 7    2 х 7 = 14 ... 9 х 7 = 63
            //int i = 1;
            //while (i <= 9) 
            //{
            //    Console.WriteLine(i + " x 7 = " + i * 7);

            //    i++;
            //}

            // Задається ціле число N (> 0).
            // Використовуючи операції ділення на ціло і взявши залишок від ділення,
            // знайдіть кількість та суму його цифр.
            // 1235456 6 digits 21

            //int num = new Random().Next(10, 1_000); // 1 5
            //int temp = num;
            //int sum = 0;
            //int count = 0;

            //while (num > 0)
            //{
            //    count++;
            //    sum += num % 10;
            //    num /= 10;
            //}

            //Console.WriteLine($"Your {temp} has {count} digits and they sum is {sum}");

            //// 123456



            //Console.WriteLine();

            // do while 1 * 2 * 3

            // факторіал числа
            //int resualt = 1, num = 1;
            //int n = 16;

            //Console.WriteLine("!0 = " + resualt);


            //try
            //{
            //    checked
            //    {
            //        do
            //        {
            //            resualt *= num;
            //            Console.WriteLine("!{0} = {1}", num, resualt);
            //            num++;
            //        } while (num <= n);
            //    }
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}

            // for

            //int i = 0;
            //while (i < 10) { Console.WriteLine("Test"); i++; }

            //for (int i = 0, j = 10; i < 10 && j > 4; i++, j--)
            //{
            //    Console.WriteLine($"{i}\t\t{j}");
            //}

            //while (true) 
            //{

            //}

            //int i = 0;

            //for (int i = 0; ; i += 2)
            //{
            //    if (i > 100) break;

            //    Console.WriteLine(i);
            //    //if (i % 2 != 0)
            //    //{
            //    //    Console.WriteLine(i);
            //    //    continue;
            //    //}

            //}

            // foreach

            //string str = "Hello, World!";

            //int[] arr = { 1, 2, 3 };
            // unmutable
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    arr[i] = i * 2;
            //    Console.WriteLine(arr[i]);
            //}

            //Console.WriteLine();
            //Console.WriteLine();
            //Console.WriteLine();

            //foreach (int i in arr)
            //{
            //    Console.Write(i + " ");
            //}

            // 25  2 5 = 7 * 7 = 49

            //do 
            //{
            //    //

            //}while (true);
            //while (true)
            //{

            //}

            //for (int i = 0; i < 10 ; i++ )
            //{

            //    if (i == 8)
            //        continue;
            //    Console.WriteLine(i);
            //}


            //for (int i = 1; i < 10; i++)
            //{
            //    for (int j = 1; j < 10; j++)
            //    {
            //        bool isTrue = j % 2 != 0;

            //        if (isTrue)
            //        {
            //            Console.Write($"{i} x {j} = {i * j}\t");
            //        }
            //    }
            //    Console.WriteLine();
            //}

            //for (int i = 1; i < 10; i++)
            //{
            //    for (int j = 1; j < 10; j++)
            //    {
            //        if (j % 2 != 0)
            //            Console.Write($"{i} x {j} = {i * j}\t");
            //    }
            //    Console.WriteLine();
            //}

            // Anti-pattern - Spagetti-code

            //l2:;

            //bool flag = false;

            //for (int i = 0; i < 10; i++)
            //{
            //    if (!flag) // flag != true
            //    {
            //        for (int j = 0; j < 10; j++)
            //        {
            //            if (!flag)
            //            {
            //                if (i * j == 0)
            //                {
            //                    flag = true;
            //                    break;
            //                }
            //            }
            //        }
            //    }
            //        break;
            //}

            //l1:; // label

            //goto l2;


            //    int i = 0;
            //l1:;
            //    if (i < 10)
            //    {
            //        Console.WriteLine(i);
            //        i++;
            //        goto l1;
            //    }


            //    string str = "Hello";
            //    foreach (var item in str)
            //    {
            //        Console.WriteLine(item);
            //    }
        }
    }
}
