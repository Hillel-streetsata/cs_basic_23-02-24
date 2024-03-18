using System.Reflection.Emit;
using System.Security.Cryptography;
using System.Text;

namespace Homework2___conditions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;

            //1.
            FirstTask();
            //2.
            SecondTask();
            //3.
            ThirdTask();
            //4.
            FourthTask();
            //5.
            FifthTask();
            //6.
            SixthTask();

            //7. - не зрозумів як то взагалі писати

            //8. - те ж саме

        }

        static void FirstTask()
        {

            Console.WriteLine("1. задача\n_______________________");

            try
            {

                Console.WriteLine("введіть  число:");
                int numbr = int.Parse(Console.ReadLine());


                if (numbr > 0)
                {

                    numbr = numbr + 1;
                }

                else if (numbr < 0)
                {

                    numbr = numbr - 2;
                }
                else
                {

                    numbr = 10;
                }


                Console.WriteLine("Результат: " + numbr);
            }
            catch (FormatException)
            {
                Console.WriteLine("Помилка: треба ввести число");

            }
            Console.WriteLine("_______________________");
        }



        static void SecondTask()
        {

            Console.WriteLine("2. задача\n_______________________");

            try
            {

                Console.WriteLine("Введіть три цілих числа:");
                int num1 = Convert.ToInt32(Console.ReadLine());
                int num2 = Convert.ToInt32(Console.ReadLine());
                int num3 = Convert.ToInt32(Console.ReadLine());


                int count = 0;
                if (num1 > 0)
                    count++;
                if (num2 > 0)
                    count++;
                if (num3 > 0)
                    count++;


                Console.WriteLine("Кількість додатних чисел: " + count);
            }
            catch (FormatException)
            {
                Console.WriteLine("Помилка: треба ввести число");
            }

            Console.WriteLine("_______________________");

        }


        static void ThirdTask()
        {
            Console.WriteLine("3. задача\n_______________________");

            try
            {

                Console.WriteLine("Введіть перше число:");
                int number1 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Введіть друге число:");
                int number2 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Введіть третє число:");
                int number3 = Convert.ToInt32(Console.ReadLine());


                int positiveCount = 0;
                int negativeCount = 0;


                if (number1 > 0)
                    positiveCount++;
                else if (number1 < 0)
                    negativeCount++;

                if (number2 > 0)
                    positiveCount++;
                else if (number2 < 0)
                    negativeCount++;

                if (number3 > 0)
                    positiveCount++;
                else if (number3 < 0)
                    negativeCount++;


                Console.WriteLine($"Кількість позитивних чисел: {positiveCount}");
                Console.WriteLine($"Кількість негативних чисел: {negativeCount}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Помилка: треба ввести число");
            }

            Console.WriteLine("_______________________");


        }



        static void FourthTask()
        {

            Console.WriteLine("4. задача\n_______________________");

            try
            {

                Console.WriteLine("Введіть значення для A:");
                int A = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Введіть значення для B:");
                int B = Convert.ToInt32(Console.ReadLine());


                if (A != B)
                {

                    A = A + B;
                    B = A;
                }
                else
                {

                    A = 0;
                    B = 0;
                }


                Console.WriteLine("Нове значення  A: " + A);
                Console.WriteLine("Нове значення  B: " + B);
            }
            catch (FormatException)
            {
                Console.WriteLine("Помилка: треба ввести число");
            }

            Console.WriteLine("_______________________");
        }





        static void FifthTask()
        {

            Console.WriteLine("5. задача\n_______________________");

            try
            {

                Console.WriteLine("введіть число:");
                int number = Convert.ToInt32(Console.ReadLine());


                if (number % 2 == 0)
                {
                    Console.WriteLine("введене число парне");
                }
                else
                {
                    Console.WriteLine("введене число не парне.");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Помилка: треба ввести число.");
            }


            Console.WriteLine("_______________________");
        }





        static void SixthTask()
        {

            Console.WriteLine("6. задача\n_______________________");

            try
            {

                Console.WriteLine("ведіть номер довжини від 1 до 5:");
                int numbr = Convert.ToInt32(Console.ReadLine());


                Console.WriteLine("введіть довжину відрізка:");
                double length = Convert.ToDouble(Console.ReadLine());

                double lengthInMeters = 0;


                switch (numbr)
                {
                    case 1: // дециметр
                        lengthInMeters = length / 10;
                        break;
                    case 2: // кілометр
                        lengthInMeters = length * 1000;
                        break;
                    case 3: // метр 
                        lengthInMeters = length;
                        break;
                    case 4: // міліметр
                        lengthInMeters = length / 1000;
                        break;
                    case 5: // сантиметр
                        lengthInMeters = length / 100;
                        break;
                    default:
                        Console.WriteLine("введено невійрний номер");
                        return;
                }


                Console.WriteLine($"Довжина відрізка в метрах: {lengthInMeters} м");
            }
            catch (FormatException)
            {
                Console.WriteLine("Помилка: треба ввести число.");
            }

            Console.WriteLine("_______________________");


        }



    }


}
