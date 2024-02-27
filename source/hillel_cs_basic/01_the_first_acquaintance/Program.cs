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

            FunWithBasicDataTypes();
            // FunWithNumericConversions();
            // FunWithOperators();

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
            // string
        }

        static void FunWithNumericConversions()
        {
            // numeric-conversions
        }

        static void FunWithOperators()
        {
            // operators
        }

        static void Examples()
        {
            /*
             * Задано довжину та ширину прямокутника. Знайдіть його площу.
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
