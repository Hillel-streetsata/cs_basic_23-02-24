using System.Linq.Expressions;
using System.Runtime.InteropServices.Marshalling;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        //Задається ціле число. Якщо він позитивний, додайте до нього 1; якщо негативне, відніміть з нього 2; Якщо нуль, то замініть його на 10. Виведіть отримане число.
        {
            try
            {
                int a = new Random().Next(-100, 101);
                Console.WriteLine("\n" + "Result = " + a);

                if (a > 0)
                {
                    int sum = a + 1;
                    Console.WriteLine("Positive = (so, +1)" + sum);
                }
                else if (a < 0)
                {
                    int diff = a - 2;
                    Console.WriteLine("Negative = (so, -2)" + diff);
                }
                else if (a == 0)
                {
                    Console.WriteLine("Zero = (so, 0)" + 10);
                }
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Error" + ex.Message);
            }
            ThreeNumbersInOne();
        }
        //Дано три цілих числа. Знайдіть кількість додатних чисел у вихідному наборі
        static void ThreeNumbersInOne()
        {
            try
            {
                int firstnum = new Random().Next(-500, 500);
                int secondnum = new Random().Next(-500, 500);
                int thirdnum = new Random().Next(-500, 500);

                int quantity = 0;

                Console.WriteLine("\n" + "First number = " + firstnum);
                Console.WriteLine("Second number = " + secondnum);
                Console.WriteLine("Third number = " + thirdnum);

                if (firstnum > 0)
                {
                    quantity++;
                }
                if (secondnum > 0)
                {
                    quantity++;
                }
                if (thirdnum > 0)
                {
                    quantity++;
                }
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("Positive numbers = " + quantity);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            ThreeNumbers();
        }
        //Дано три цілих числа.Знайдіть число позитивних і кількість негативних чисел у вихідному наборі. 
        static void ThreeNumbers()
        {
            Console.ForegroundColor = ConsoleColor.White;
            try
            {
                int b = new Random().Next(-100, 101);
                int c = new Random().Next(-100, 101);
                int d = new Random().Next(-100, 101);

                //  int a = 0;
                Console.WriteLine("\n" + "Result first = " + b);
                Console.WriteLine("Result second = " + c);
                Console.WriteLine("Result third = " + d);

                int numer = 0;
                if (b > 0)
                {
                    numer++;
                }
                if (c > 0)
                {
                    numer++;
                }
                if (d > 0)
                {
                    numer++;
                }
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Positive numbers = " + numer);
                int numero = 0;
                if (b < 0)
                {
                    numero++;
                }
                if (c < 0)
                {
                    numero++;
                }
                if (d < 0)
                {
                    numero++;
                }
                Console.WriteLine("Negativ numbers = " + numero);
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Error" + ex.Message);
            }
            Integers();
        }
        //Дано дві змінні цілочисельного типу: A і B.Якщо їх значення не рівні, то призначте суму цих значень кожній змінній, а якщо вони є, то привласніть змінним нульові значення. Вивести нові значення змінних A і B.
        static void Integers()
        {
            Console.ForegroundColor = ConsoleColor.White;
            try
            {
                int A = new Random().Next(1, 100);
                int B = new Random().Next(1, 100);
                // int A = 55;
                //int B = 55;
                Console.WriteLine("\n" + "A = " + A);
                Console.WriteLine("B = " + B);
                if (A != B)
                {
                    A = A + B;
                    B = A;
                }
                else if (A == B)
                {
                    A = 0;
                    B = 0;
                }
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Result A = " + A);
                Console.WriteLine("Result B = " + B);
            }
            catch (Exception ab)
            {
                Console.WriteLine("Error 3" + ab);
            }
            Parity();
        }
        //Напишіть програму, яка перевіряє число на парність.
        static void Parity()
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            int v = new Random().Next(1, 100);
            if (v % 2 == 0)
            {
                Console.WriteLine("\n" + "Parity number." +v);
            }
            else
            {
                Console.WriteLine("\n" + "Odd number." + v);
            }
            SegmentLength();

        }
        //Одиниці довжини нумеруються наступним чином: 1 - дециметр, 2 - кілометр, 3 - метр, 4 - міліметр, 5 - сантиметр.Наведено номер одиниці довжини(ціле число в діапазоні 1 - 5) і довжину відрізка в цих одиницях(дійсне число). Знайдіть довжину відрізка в метрах.
        static void SegmentLength()
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            int units = new Random().Next(1, 5);
            int lenght = new Random().Next(1, 255);
            Console.WriteLine("\n"+"lenght " +lenght+", units "+units);

            if (units == 1)
            {
                Console.WriteLine("decimetres");
                int final = lenght * 10;
                Console.WriteLine("Meters  " + final);
            }
            else if (units == 2)
            {
                Console.WriteLine("kilometers");
                double final = lenght * 0.001;
                Console.WriteLine("Meters  " + final);
            }
            else if (units == 3)
            {
                Console.WriteLine("meters");
                int final = lenght;
                Console.WriteLine("Meters  " + final);
            }
            else if (units == 4)
            {
                Console.WriteLine("millimeters");
                int final = lenght * 1000;
                Console.WriteLine("Meters  " + final);
            }
            else if (units == 5)
            {
                Console.WriteLine("centimeters");
                int final = lenght * 100;
                Console.WriteLine("Meters  " + final);
            }
            Compass();
        }
        //Робот може рухатися в чотирьох напрямках(північ, захід, південь, схід) і отримувати три цифрові команди: 0 - продовжувати рух, 1 - повернути ліворуч, -1 - повернути праворуч.Символ C -початковий напрямок робота, а ціле число N - послана йому команда. Відобразіть напрямок робота після виконання отриманої команди.
        static void Compass()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\n" + "C - direction of movement of the robot.");
            int N = new Random().Next(-1, 2);
            if (N == 0)
            {
                Console.WriteLine("Yoy need to move in the same direction.Value = " + N);
            }
            else if (N == 1)
            {
                Console.WriteLine("You need to turn left. Value = " + N);
            }
            else
            {
                Console.WriteLine("You need to turn right. Value = " + N);
            }
            Ages();
        }
        //Дано ціле число в діапазоні 20 - 69, яке визначає вік(в роках).Виведіть рядок опису зазначеного віку, забезпечивши правильне узгодження числа зі словом «рік», наприклад: 20 - «двадцять років», 32 - «тридцять два роки», 41 - «сорок один рік»
        static void Ages()
        {
            int A = new Random().Next(20, 69);
            Console.WriteLine("\n" + "Please enter your age? " + A);
            int AA = A % 10;
            if (AA == 1)
            {
                Console.WriteLine($"{A} рік");
            }
            else if (AA == 2 || AA == 3 || AA == 4)
            {
                Console.WriteLine($"{A} роки");
            }
            else
            {
                Console.WriteLine($"{A} років");
            }

        }
    }




}


