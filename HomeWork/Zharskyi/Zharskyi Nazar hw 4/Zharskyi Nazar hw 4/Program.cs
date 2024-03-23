namespace hw3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 0;
            Console.Write("Enter how many tasks there are: ");
            try
            {
                num = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            for (int i = 0; i < num; i++)
            {
                beauty();
            }
        }
        static void beauty()
        {
            Console.Write("Enter the number of task: ");
            int task_num = 0;
            try
            {
                task_num = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            if (task_num == 1)
            {
                Console.WriteLine("Task " + task_num);
                task_1();
            }
            else if (task_num == 2)
            {
                Console.WriteLine("Task " + task_num);
                task_2();
            }
            else if (task_num == 3)
            {
                Console.WriteLine("Task 3a");
                task_3a();
                Console.WriteLine();
                Console.WriteLine(new string('-', 30));
                Console.WriteLine();
                Console.WriteLine("Task 3b");
                task_3b();
                Console.WriteLine();
            }
            else if (task_num == 4)
            {
                Console.WriteLine("Task " + task_num);
                task_4();
            }
            else if (task_num == 5)
            {
                Console.WriteLine("Task " + task_num);
                task_5();
            }
            else if (task_num == 6)
            {
                Console.WriteLine("Task " + task_num);
                task_6();
            }
            else if (task_num == 7)
            {
                Console.WriteLine("Task " + task_num);
                task_7();
            }
            else
            {
                Console.WriteLine("You`ve entered incorrect task");
            }
            Console.WriteLine(new string('-', 30));
            Console.WriteLine();
        }
        static void task_1()
        {
            int n = 0;
            for (int i = 0; i < 50; i++)
            {
                if (i % 2 != 0)
                {
                    n += i;
                }
            }
            Console.WriteLine(n);
        }
        static void task_2()
        {
            int a = 0, b = 0, sum = 0;
            Console.Write("Enter first natural number: ");
            try
            {
                a = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.Write("Enter second natural number: ");
            try
            {
                b = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            while (a <= b)
            {
                if (a % 4 == 0)
                {
                    sum += a;
                }
                a++;
            }
            Console.WriteLine("The answer is: " + sum);
        }
        static void task_3a()
        {
            int counter1 = 0, counter2 = 0, num1 = 0, num2 = 0;

            Console.WriteLine("Next numbers fulfill our condition: ");
            for (int i = 10; i < 100; i++)
            {
                int number = i, number1 = i;
                num1 = number % 10;
                number /= 10;
                num2 = number;
                counter1 = num1 * num1;
                counter2 = num2 * num2;
                if ((counter1 + counter2) % 13 == 0)
                {
                    Console.Write(number1 + " ");
                }
            }
        }
        static void task_3b()
        {
            int counter1 = 0, counter2 = 0, num1 = 0, num2 = 0;
            Console.WriteLine("Next numbers fulfill our condition: ");
            for (int i = 10; i < 100; i++)
            {
                int number = i, number1 = i;
                num1 = number % 10;
                number /= 10;
                num2 = number;
                counter1 = num1 + num2;
                counter2 = counter1 * counter1;
                if ((counter1 + counter2) == number1)
                {
                    Console.Write(number1 + " ");
                }
            }
        }
        static void task_4()
        {
            int A = 0, B = 0;
            Console.Write("Enter A (A<B): ");
            try
            {
                A = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.Write("Enter B (B>A): ");
            try
            {
                B = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            int counter1 = 0; decimal counter2 = 1;
            if (A < B)
            {
                try
                {
                    while (A <= B)
                    {
                        counter1 += A;
                        counter2 *= A;
                        A++;
                    }
                    checked
                    {
                        Console.WriteLine("The sum is: " + counter1 + "\nThe product is: " + counter2);
                    }
                }
                catch (OverflowException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            else
            {
                Console.WriteLine("You`ve entered incorrect data, try to restart the program");
            }
        }
        static void task_5()
        {
            int A = 0, B = 0;
            Console.Write("Enter A (A<B): ");
            try
            {
                A = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.Write("Enter B (B>A): ");
            try
            {
                B = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            int counter = 0;
            if (A < B)
            {
                counter = B - A;
                Console.Write("The list of numbers from " + A + " to " + B + ": \n");
                while (A <= B)
                {
                    Console.Write(A + " ");
                    A++;
                }
                Console.WriteLine("\nThere are " + ++counter + " numbers");
            }
            else
            {
                Console.WriteLine("You`ve entered incorrect data, try to restart the program");
            }
        }
        static void task_6()
        {
            double price = 0.0;
            Console.Write("If the price is not natural number enter with \",\" not with \".\" f.e. 103,5\n Enter the price for 1kg: ");
            try
            {
                price = Convert.ToDouble(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            for (double i = 1; i <= 2; i += 0.2)
            {
                Console.WriteLine("Price for " + Math.Round(i, 2) + "kg" + " equal to " + Math.Round((price * i), 2));
            }
        }
        static void task_7()
        {
            int A = 0, B = 0;
            Console.Write("Enter A (A<B): ");
            try
            {
                A = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.Write("Enter B (B>A): ");
            try
            {
                B = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            int counter = 0;
            if (A < B)
            {
                counter = B - A;
                Console.Write("The list of numbers from " + A + " to " + B + " N times: \n");
                while (A <= B)
                {
                    for (int i = 0; i < A; i++)
                    {
                        Console.Write(A + " ");
                    }
                    A++;
                }
                Console.WriteLine("\nThere are " + ++counter + " numbers");
            }
            else
            {
                Console.WriteLine("You`ve entered incorrect data, try to restart the program");
            }
        }
    }
}