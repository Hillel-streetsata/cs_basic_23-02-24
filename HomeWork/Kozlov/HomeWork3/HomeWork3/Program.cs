using System.Runtime.Serialization.Formatters;
using System.Text;

namespace HomeWork3
{
    internal class Program
    {
        static void Divider() 
        {
            Console.WriteLine(new string ('-', 16));
        }
        static void TaskOne() 
        {
            Console.WriteLine("Task№1\n");

            int sum = 0;

            for (int i = 1; i < 50; i +=2)
            {
                sum += i;
            }
            Console.WriteLine("Сума додатних чисел від 50: " + sum);
        }
        static void TaskTwo()
        {
            Console.WriteLine("Task№2\n");

            int a = 1; 
            int b = 100;
            int sum = 0;

            int count = (b / 4) - ((a - 1 ) / 4);

            sum = count * (a + b) / 2;

            Console.WriteLine("Сума нейтральних чисел від " + a + " до " + b + ", кратним чотирьом: " + sum);
        }
        static void TaskThree_A()
        {
            Console.WriteLine("Task№3(A)\n");

            Console.WriteLine("Двозначні числа, сума квадратів цифр яких ділиться на 13: ");

            for (int i = 10; i < 100; i++)
            {
                int num1 = i / 10;

                int num2 = i % 10;

                int sumOfnum = num1 + num2;

                int sumOfSquares = num1 * num1 + num2 * num2;

                if (sumOfSquares % 13 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
        static void TaskThree_B()
        {
            Console.WriteLine("Task№3(B)\n");

            Console.WriteLine("Двозначні числа, які мають вказану властивість: ");
            

            for(int i = 10;i < 100;i++)
            {
                int num1 = i / 10;
                int num2 = i % 10;
                int sumOfnum = num1 + num2;
                int sumAndSquare = sumOfnum + sumOfnum * sumOfnum;

                if (sumAndSquare == i) 
                {
                    Console.WriteLine(i);
                }
            }
        }
        static void TaskFour()
        {
            Console.WriteLine("Task№4\n");

            int a = 1;
            int b = 10; 

            int sum = 0;
            int product = 1;

            for (int i = a; i <= b; i++)
            {
                sum += i;
                product *= i;
            }
            Console.WriteLine("Сума чисел від " + a + " до " + b + " включно: " + sum);
            Console.WriteLine("Добуток чисел від " + a + " до " + b + " включно: " + product);
        }
        static void TaskFive() 
        {
            Console.WriteLine("Task№5\n");

            Console.Write("Ведіть два цілих числа A і B, де A < B: ");
            int A = int.Parse(Console.ReadLine());
            int B = int.Parse(Console.ReadLine());

            if (A >= B)
            {
                Console.WriteLine("Помилка: А повино бути менше ніж В.");
                return;
            }
            Console.WriteLine("Цілі числа від А до В включно: ");
            for (int i = A; i <= B; i++)
            {
                Console.WriteLine(i);
            }
            int N = B - A + 1;

            Console.WriteLine("Кількість цілих чисел від А до В включно: " + N);
        }
        static void TaskSix()
        {
            Console.WriteLine("Task№6\n");

            double pricePerKg = 10.0;
            double TotalCost = 0.0;

            for (double kg = 1.0; kg <= 2.0; kg += 0.2)
            {
                double cost = kg * pricePerKg;
                Console.WriteLine($"Вага: {kg} кг, Вртість: {cost} грн");

                TotalCost += cost;

                Console.WriteLine($"Загальна вартість: {TotalCost} грн");
            }
        

        }
        static void TaskSeven() 
        {
            Console.WriteLine("Task№7\n");

            Console.Write("Введіть два натуральних числа А і В, де А < B: ");
            int A = int.Parse(Console.ReadLine());
            int B = int.Parse(Console.ReadLine());
            Divider();

            if(A >= B) 
            {
                Console.WriteLine("Помилка: А повино бути менше ніж В.");
                return;
            }
            for (int i = A; i <= B; i++)
            {
                for (int j = 0; j < i; j++) 
                {
                    Console.WriteLine(i + " ");
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Divider();
            TaskOne();
            Divider();
            TaskTwo();
            Divider();
            TaskThree_A();
            Divider();
            TaskThree_B();
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
