using System.Text;

namespace HomeWork4
{
    internal class Program
    {
        static void Divider()
        {
            Console.WriteLine(new string('-', 12));
        }
        static void TaskOne() 
        {
            Console.WriteLine("Task№1\n");
            try
            {
                Console.Write("Введіть число: " );
                int num = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine($"Таблиця множення для числа: {num}");

                int i = 1;

                while (i < num)
                {
                    Console.WriteLine($"{num} * {i} = {num * i}");
                    i++;
                }
            }
            catch (Exception ex) 
            {
                Console.WriteLine("Букви та символи не підтримуються \n");
            }
        }
        static void TaskTwo() 
        {
            Console.WriteLine("Task№2\n");

            int num;
            bool isValidInput;

            do
            {
                Console.Write("Введіть число: ");
                string input = Console.ReadLine();

                isValidInput = int.TryParse(input, out num);

                if (!isValidInput)
                {
                    Console.WriteLine("Введено неправильне значення. введіть ціле число.");
                }
            } while (!isValidInput);
            Console.WriteLine($"Введене павильне число: {num}");
       }
        static void TaskThree() 
        {
            Console.WriteLine("Task№3\n");

            Console.Write("Введіть кількість рядків для пераміди: ");
            int height = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Піраміда: ");

            for (int i = 1; i <= height; i++)
            {
                
                for (int j = 1; j <= height - i; j++)
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
            Console.WriteLine("Task№4\n");

            Console.Write("Введіть число: ");
            string numberString = Console.ReadLine();

            int sum = 0;

            foreach(char digid in numberString)
            {
                if (char.IsDigit(digid)) 
                {
                int digitValue = (int)Char.GetNumericValue(digid);
                    sum += digitValue;
                }
            }
            Console.WriteLine($"Сума всіх цифр у чеслі {numberString} дорівнює {sum}");
        }
        static void TaskFive() 
        {
            Console.WriteLine("Task№5\n");

            Console.Write("Введіть число: ");
            int number = Convert.ToInt32(Console.ReadLine());

            int factorial = 1;
            
            for (int i = 1;i <= number;i++)
            {
                factorial *= i;
            }
            Console.WriteLine($"факторіал числа {number} дорівнює {factorial}");
        }
        static void TaskSix() 
        {
            Console.WriteLine("Task№6\n");

            Random random = new Random();
            string input;

            do
            {
                Console.WriteLine("Гра в кубики!");
                int dice1 = random.Next(1, 7); 
                int dice2 = random.Next(1, 7); 

                Console.WriteLine($"Вам випало {dice1} та {dice2}.");

                Console.Write("Бажаєте грати ще раз? (так/ні): ");
                input = Console.ReadLine();

                Console.WriteLine(); 

            } while (input.ToLower() == "так");
        }
        static void TaskSeven() 
        {
            Console.WriteLine("Task№7\n");

            List<int> num = new List<int> { 10, 5, 20, 15, 8 };

            int max = int.MinValue;
            int min = int.MaxValue;

            foreach (int number in num)
            {
            if(number > max)
                {
                    max = number;
                }
            if(number < min) 
                {
                min = number;
                }
            }
            Console.WriteLine("Найбільше значення: " +  max);
            Console.WriteLine("Найменше значення: " + min);
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = UTF8Encoding.UTF8;
            Divider();
            TaskOne();
            Divider();
            TaskTwo();
            Divider();
            TaskThree();
            Divider();
            TaskFour();
            Divider();
            TaskFive();
            Divider();
            TaskSix();
            Divider();
            TaskSeven();
            Divider();
        }
    }
}
