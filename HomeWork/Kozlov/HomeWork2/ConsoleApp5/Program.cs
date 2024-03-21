using System.Reflection.Emit;
using System.Text;
using System.Threading.Channels;

namespace ConsoleApp5
{
    internal class Program
    {
        static void Divider() 
        {
            Console.WriteLine(new string('-', 14));
        }
        static void TaskOne()
        {
            try
            {
                Console.WriteLine("Task №1 \n");
                
                Console.Write("Введіть число: ");             
                int number = Convert.ToInt32(Console.ReadLine());

                bool isPositive = number > 0;

                bool isNegative = number < 0;

                bool isZero = number == 0;



                if (isPositive)
                {
                    number += 1;
                }
                if (isNegative)
                {
                    number -= 2;
                }
                if (isZero)
                {
                    number = 10;
                }
                Console.WriteLine("Отримане число: " + number );               
            }
            catch (Exception ex) 
            {
                Console.WriteLine("Помилка, була введена літера, або символ\n");               
            }
        }
        static void TaskTwo()
        {
            Console.WriteLine("Task №2\n");
            try
            {
                Console.Write("Запишіть перше число: ");
                int num1 = Convert.ToInt32(Console.ReadLine());

                Console.Write("Запишіть друге число: ");
                int num2 = Convert.ToInt32(Console.ReadLine());

                Console.Write("Запишіть третє число: ");
                int num3 = Convert.ToInt32(Console.ReadLine());

                int count = 0;
                if (num1 > 0) count++;
                if (num2 > 0) count++;
                if (num3 > 0) count++;

                Console.WriteLine($"Кількіст додатних чисел у вихідному наборі: {count}" + "");
            }
            catch (FormatException)
            {
                Console.WriteLine();

                Console.WriteLine("Помилка, була введена літера, або символ\n");
            }
        }
        static void TaskThree()
        {
            Console.WriteLine("Task №3\n");
            try
            {
                Console.Write("Запишіть перше число: ");
                int num1 = Convert.ToInt32(Console.ReadLine());

                Console.Write("Запишіть друге число: ");
                int num2 = Convert.ToInt32(Console.ReadLine());

                Console.Write("Запишіть третє число: ");
                int num3 = Convert.ToInt32(Console.ReadLine());

                int positiveCount = 0;
                int negativeCount = 0;

                if (num1 > 0) positiveCount++;
                else if (num1 < 0) negativeCount++;

                if (num2 > 0) positiveCount++;
                else if (num2 < 0) negativeCount++;

                if (num3 > 0) positiveCount++;
                else if (num3 < 0) negativeCount++;

                Console.Write("Кількість додатніх чисел: " + positiveCount + "\n");
                Console.Write("Кідькість відємних чисел: " + negativeCount + "\n");
            }
            catch (FormatException)
            {
                Console.WriteLine();

                Console.WriteLine("Помилка, була введена літера, або символ\n");
            }
        }
        static void TaskFour()
        {
            Console.WriteLine("Task №4\n");
            try
            {
                Console.Write("Введіть число A: ");
                int A = int.Parse(Console.ReadLine());
                Console.WriteLine();

                Console.Write("Введіть число B: ");
                int B = int.Parse(Console.ReadLine());
                Console.WriteLine();

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
                Console.WriteLine($"Нові значення:  A = {A}, B = {B}\n");
            }
            catch 
            {
                Console.WriteLine("Помілка, була введена літера, або символ");            
            }
        }
        static void TaskFive() 
        {
            Console.WriteLine("Tasl №5\n");
            try
            {
                Console.Write("Введіть число: ");
                int num = int.Parse(Console.ReadLine());

                if (num % 2 == 0)
                {
                    Console.WriteLine($"Число {num} є парним\n");
                }
                else
                {
                    Console.WriteLine($"Число {num} не є парним\n");
                }
            }
            catch 
            {
                Console.WriteLine("Помілка, була введена літера, або символ\n");
            }
        }
        static void TaskSix() 
        {
            Console.WriteLine("Task №6 \n");

            Console.Write("Введіть номер одиниці довжини (1-5): ");
            int unitNumber = int.Parse(Console.ReadLine());

            Console.Write("Введіть довжину відрізка: ");
            double length = double.Parse(Console.ReadLine());

            double lengthInMeters;

            switch (unitNumber)
            {
                case 1: 
                    lengthInMeters = length * 0.1;
                    break;
                case 2: 
                    lengthInMeters = length * 1000;
                    break;
                case 3: 
                    lengthInMeters = length;
                    break;
                case 4: 
                    lengthInMeters = length * 0.001;
                    break;
                case 5: 
                    lengthInMeters = length * 0.01;
                    break;
                default:
                    Console.WriteLine("Невірний номер одиниці довжини!");
                    return;
            }

            Console.WriteLine($"Довжина відрізка в метрах: {lengthInMeters}");
         }
        static void TaskSeven()
        {
            Console.WriteLine("Task №7 \n");

            Console.Write("Введіть початковий напрямок робота (N, W, S, E): ");
            char currentDirection = Console.ReadLine()[0];
      
            Console.Write("Введіть команду (0 - продовжити рух, 1 - повернути ліворуч, -1 - повернути праворуч.): ");
            int command = Convert.ToInt32(Console.ReadLine());

            char newDiectoin = CalculateNewDirection(currentDirection, command);
            Console.WriteLine($"Напрямок руху робота після команди: {newDiectoin}");
        }

        static char CalculateNewDirection(char currentDirection, int command)
        {
            char[] directions = {'N', 'E', 'S', 'W'};
            int currentIndex = Array.IndexOf(directions, currentDirection);

            currentIndex = (currentIndex + command) % 4;

            if (currentIndex < 0) 
            { 
                currentIndex += 4; 
            }

            return directions[currentIndex];

        }
        static void TaskEight()
        {
                Console.WriteLine("Task №8 \n");

                Console.Write("Введіть вік: ");
                int age = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine(AgeToString(age));
            }
        static string AgeToString(int age)
            {
                string[] units = { "", "один", "два", "три", "чотири", "п'ять", "шість", "сім", "вісім", "дев'ять" };
                string[] tens = { "", "", "двадцять", "тридцять", "сорок", "п'ятдесят", "шістдесят" };

                int unit = age % 10;
                int ten = age / 10;

                string result = tens[ten];

                if (unit > 0)
                {
                    result += " " + units[unit];
                }

                if (age == 21)
                {
                    result += " один";
                }
                else if (age == 22)
                {
                    result += " два";
                }

                if (unit == 1 && age != 11)
                {
                    result += " рік";
                }
                else if ((unit >= 2 && unit <= 4) || (age >= 5 && age <= 20) || (unit >= 5 && unit <= 9 && age >= 21 && age <= 29))
                {
                    result += " роки";
                }
                else
                {
                    result += "років: ";
                }

                return result;
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

            TaskEight();
        
            }
    }
}
