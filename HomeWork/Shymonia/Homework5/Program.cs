using System.Text;

namespace Homework5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;

            Divider();
            TaskOne();
            Divider();
            TaskTwo();
            Divider();
            TaskThree();
            Divider();
            TaskFour();
            Divider();
            TaskSix();
            Divider();
            TaskSeven();
        }

        static void Divider()
        {
            Console.WriteLine(new string('-', 16));
        }
        static void TaskOne()
        {
            Console.WriteLine("Task 1\n");


            int number;
            bool isValid = false;

            do
            {
                try
                {
                    Console.Write("Введіть число: ");
                    number = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine($"Таблиця множення для числа {number}:");

                    int i = 1;
                    while (i <= 10)
                    {
                        Console.WriteLine($"{number} * {i} = {number * i}");
                        i++;
                    }

                    isValid = true; 
                }
                catch (FormatException)
                {
                    Console.WriteLine("Помилка: не ціле число.");
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Помилка: значення занадто велике або мале");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Помилка: {ex.Message}");
                }
            } while (!isValid);

        }


        static void TaskTwo()
        {

            Console.WriteLine("Task 2\n");

            int number;
            bool isValid;

            do
            {
                Console.Write("Введіть число: ");
                string input = Console.ReadLine();

                isValid = int.TryParse(input, out number);

                if (!isValid)
                {
                    Console.WriteLine("Введено неправильне значення. введіть ще ращ.");
                }
            } while (!isValid);

            Console.WriteLine("Ви ввели правильне число: " + number);


        }



        static void TaskThree()
        {

            Console.WriteLine("Task 3\n");



            int rows;

            Console.WriteLine("Введіть кількість рядків для піраміди:");
            rows = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= rows; i++)
            {

                for (int j = 1; j <= rows - i; j++)
                {
                    Console.Write(" ");
                }


                for (int k = 1; k <= 2 * i - 1; k++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }


        }



        static void TaskFour()
        {
            Console.WriteLine("Task 4\n");

            Console.WriteLine("Введіть число:");
            string numberStr = Console.ReadLine();

            int sum = 0;
            foreach (char digitChar in numberStr)
            {
                if (char.IsDigit(digitChar))
                {
                    int digit = int.Parse(digitChar.ToString());
                    sum += digit;
                }
            }

            Console.WriteLine($"Сума всіх цифр у числі {numberStr} дорівнює {sum}.");


        }


        static void TaskSix()
        {
            Console.WriteLine("Task 6\n");

            Random random = new Random();
            string input;

            do
            {
                Console.WriteLine("Натисніть Enter, щоб кинути кубики, або введіть 'exit', щоб вийти з гри:");
                input = Console.ReadLine();

                if (input.ToLower() == "exit")
                {
                    Console.WriteLine("Гра завершена.");
                    break;
                }

                int dice1 = random.Next(1, 7);
                int dice2 = random.Next(1, 7);

                Console.WriteLine($"Результат першого кубика: {dice1}, результат другого кубика: {dice2}");
            } while (true);

        }


        static void TaskSeven()
        {

            Console.WriteLine("Task 7\n");

            List<int> numbers = new List<int> { 10, 5, 8, 15, 3 };

            
            int max = int.MinValue;
            int min = int.MaxValue;

            
            foreach (int number in numbers)
            {
                if (number > max)
                {
                    max = number;
                }

                if (number < min)
                {
                    min = number;
                }
            }

            Console.WriteLine($"Найбільше значення: {max}");
            Console.WriteLine($"Найменше значення: {min}");


        }



    }

}