using static System.Runtime.InteropServices.JavaScript.JSType;

namespace _01_the_first_acquaintance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // F5 - build (compile)
            // Ctrl + Space - Intellesence 
            // Ctrl + e + c - commenting
            // Ctrl + e + u - uncommenting
            // Ctrl + k + d - like "prettier" - formatter
            // Ctrl + e + v - copy current line and enter it's after current code
            // Shift + Alt + arrows up and down - multyline line typing
            // snippets
            // cw + tab+tab => Console.WriteLine();

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
            FunWithOperators();

            // Examples();

            // methods


        }

        static void FunWithBasicDataTypes()
        {
            //var some = 9.5f;

            // integral-numeric-types
            byte b = 255; // 0 - 255  -- 1 byte
            sbyte sb = -78; // -128 - 127 -- 1 byte // sign

            short sh = 45; // -32768 - 32767 -- 2 bytes
            ushort ush = 78; // 0 .. 65,535 -- 2 bytes // unsigned

            int i = 9; // -2,147,483,648 .. 2,147,483,647 -- 4 bytes
            uint ui = 8; // 0 .. 4,294,967,295

            long l = 456456; // -9,223,372,036,854,775,808 .. 9,223,372,036,854,775,807 -- 8 bytes
            ulong ul = 0; // 0 .. 18,446,744,073,709,551,615

            // floating-point-numeric-types
            float f = 4.512f; // -- 8 bytes -- 8 after comma  
            double d = 0.3; //-- 16 bytes -- 15 after comma

            // decimal
            decimal dc = 456.789m; // 28 after comma

            // char
            char ch = 'A'; // 1 byte utf-8 (Unicode) 32000... - utf-16 

            Console.WriteLine(ch);

            Console.Write("   **   ");
            Console.Write("  ****  ");
            Console.Write(" **  **");
            Console.Write("********");

            int cha = 70;
            Console.WriteLine((char)cha);

            // string
            string firstLine = "Hello";
            string secondLine = "World!";
            string result = firstLine + ", " + secondLine; // string concatination
            Console.WriteLine(result); // Hello, World!

            Console.Write("Please enter first name ");
            string name = Console.ReadLine();

            Console.Write("Second name ");
            string surname = Console.ReadLine();

            string fullName = name + " " + surname;
            Console.WriteLine("Hello, " + fullName);

            // Escape-sequencies
            Console.WriteLine("To be or not to be\n\t\t\'W. Schecspiar\r\'");

            Console.WriteLine("Enter password:");
            Console.Write("*******\r");

            string str2 = string.Empty; // \0

            
            Console.WriteLine();


            Console.ReadLine();
        }

        static void FunWithNumericConversions()
        {
            // numeric-conversions
            // не явне приведення типів
            byte b = 255;
            int i = b + 1; // numeric-conversions

            try
            {
                checked
                {
                    // явне приведення типів
                    byte b1 = (byte)i; // ??? 9 Error
                    Console.WriteLine(b1); // --Error MaxNumber (255) 0 // переповнення регістру
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine("next");


            Console.Write("Enter first number: ");
            //int firstNumber = int.Parse(Console.ReadLine());
            int firstNumber = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter second number: ");
            int secondNumber = Convert.ToInt32(Console.ReadLine());

            int sum = firstNumber + secondNumber;

            string result = "Sum: " + sum;

            Console.WriteLine(result);

            Console.WriteLine("Task 1");
            Console.WriteLine(new string('-', 15));
        }

        static void FunWithOperators()
        {
            // operators
            int a = 12;
            int b = -5;
            int resultDivide = a / b; // 3
            int resultModule = a % b; // 2

            Console.WriteLine(resultDivide);
            Console.WriteLine(resultModule);

            // +1
            int i = 0;
            //i++; // i = i + 1; // 1 // інкремент
            //++i; // i = i + 1; // 1 // інкремент
            //i--; // i = i - 1; // декримент

            Console.WriteLine(++i); // 1? 0
            Console.WriteLine(-i); // -1
        }

        static void Examples()
        {
            /*
             * Задано довжину та ширину прямокутника. Знайдіть його площу.
             *
             * Задано температуру в градусах Цельсія. Переведіть її в градуси Фаренгейта за формулою: F = (C * 9/5) + 32.
             * Задано радіус кола. Знайдіть його площу за формулою: Area = π * r^2, де π - число Пі.
             * Задано рік. Перевірте, чи він є високосним.
             * Задано кількість хвилин. Підрахуйте, скільки це буде в днях, годинах і хвилинах.
             * Використовуючи клас Random, згенеруйте випадкове ціле число в певному діапазоні.
             * Задана довжина ребра куба. Знайдіть його об'єм за формулою: Volume = sideLength^3.
             * Задано три числа. Знайдіть найбільше з них. (Використати Math.Max() та Math.Min())
             * Задано число та його ступінь. Підрахуйте його значення.
             * Задано два числа. Знайдіть частку та залишок від ділення першого числа на друге.
             */
        }
    }
}
