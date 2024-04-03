namespace Zharskyi_Nazar_HW_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //task_1();
            //task_2();
            //task_3();
            //task_4();
            //task_5();
            //task_6();
            //task_7();
            //SecondHW6Part tasks = new SecondHW6Part();
            //tasks.task_1S();
            //tasks.task_2S();
            //tasks.task_3S();
            //tasks.task_4S();
            //tasks.task_5S();
            //tasks.task_6S();
            //tasks.task_7S();
            //tasks.task_8S();
            //tasks.task_9S();
            Console.Write("Enter the part of homework(1 or 2): ");
            int num = 0;
            try
            {
                num = Convert.ToInt32(Console.ReadLine());
                if (num == 1)
                {
                    int num1 = 0;
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
                        beauty1();
                    }
                }
                else if (num == 2)
                {
                    int num1 = 0;
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
                        beauty2();
                    }
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
        static void beauty1()
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
                Console.WriteLine();
            }
            else if (task_num == 2)
            {
                Console.WriteLine("Task " + task_num);
                task_2();
                Console.WriteLine();
            }
            else if (task_num == 3)
            {
                Console.WriteLine("Task " + task_num);
                task_3(); Console.WriteLine();
            }
            else if (task_num == 4)
            {
                Console.WriteLine("Task " + task_num);
                task_4(); Console.WriteLine();
            }
            else if (task_num == 5)
            {
                Console.WriteLine("Task " + task_num);
                task_5(); Console.WriteLine();
            }
            else if (task_num == 6)
            {
                Console.WriteLine("Task " + task_num);
                task_6(); Console.WriteLine();
            }
            else if (task_num == 7)
            {
                Console.WriteLine("Task " + task_num);
                task_7(); Console.WriteLine();
            }
            else
            {
                Console.WriteLine("You`ve entered incorrect task");
            }
            Console.WriteLine(new string('-', 30));
            Console.WriteLine();
        }
        static void beauty2()
        {
            Console.Write("Enter the number of task: ");
            int task_num = 0;
            SecondHW6Part tasks = new SecondHW6Part();
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
                tasks.task_1S(); Console.WriteLine();
            }
            else if (task_num == 2)
            {
                Console.WriteLine("Task " + task_num);
                tasks.task_2S(); Console.WriteLine();
            }
            else if (task_num == 3)
            {
                Console.WriteLine("Task " + task_num);
                tasks.task_3S(); Console.WriteLine();
            }
            else if (task_num == 4)
            {
                Console.WriteLine("Task " + task_num);
                tasks.task_4S(); Console.WriteLine();
            }
            else if (task_num == 5)
            {
                Console.WriteLine("Task " + task_num);
                tasks.task_5S(); Console.WriteLine();
            }
            else if (task_num == 6)
            {
                Console.WriteLine("Task " + task_num);
                tasks.task_6S(); Console.WriteLine();
            }
            else if (task_num == 7)
            {
                Console.WriteLine("Task " + task_num);
                tasks.task_7S(); Console.WriteLine();
            }
            else if (task_num == 8)
            {
                Console.WriteLine("Task " + task_num);
                tasks.task_8S(); Console.WriteLine();
            }
            else if (task_num == 9)
            {
                Console.WriteLine("Task " + task_num);
                tasks.task_9S(); Console.WriteLine();
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
            int[] numbers = new int[8];
            numbers[0] = 37;
            numbers[1] = 0; numbers[2] = 50; numbers[3] = 46;
            numbers[4] = 34; numbers[5] = 46; numbers[6] = 0;
            numbers[7] = 13;

            int[] numbers1 = { 37, 0, 50, 46, 34, 46, 0, 13 };
            Console.WriteLine("First way: ");
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write(numbers[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine("Second way: ");
            for (int i = 0; i < numbers1.Length; i++)
            {
                Console.Write(numbers1[i] + " ");
            }
        }
        static void task_2()
        {
            int[] heights = new int[12];
            for (int i = 0; i < heights.Length; i++)
            {
                heights[i] = new Random().Next(163, 190);
            }
            for (int i = 0; i < heights.Length; i++)
            {
                Console.Write(heights[i] + " ");
            }
        }
        static void task_3()
        {
            int[] arr = new int[10];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = i + 1;
            }
            for (int i = 0; i < arr.Length; i++)
            {
                if (i % 2 == 0)
                {
                    Console.Write(arr[i] + " ");
                }
            }
        }
        static void task_4()
        {
            int[] arr = new int[10];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = new Random().Next(0, 10);
            }
            Console.WriteLine("Common array: ");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine("Reversed array: ");
            for (int i = arr.Length - 1; i >= 0; i--)
            {
                Console.Write(arr[i] + " ");
            }
        }
        static void task_5()
        {
            int[] arr = new int[12];
            int counter = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"Enter number for {i+1} element: ");
                try
                {
                    arr[i] = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            Console.Write("Massive: ");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
            for (int i = 0; i < arr.Length ; i++)
            {
                counter += arr[i];
            }

            Console.WriteLine($"The sum of elements is {counter}");
        }

        static void task_6()
        {
            int[] arr = new int[20];
            for(int i = 0;i < arr.Length;i++)
            {
                arr[i]=new Random().Next(1,10);
            }
            Console.Write("Massive: ");
            for(int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i]+" ");
            }
            Console.WriteLine();
            double counter = 0;
            for(int i = 0;i<arr.Length;i++)
            {
                counter += 1/arr[i];
            }
            Console.WriteLine("The total resistance of the circuit is: " + counter);
        }
        static void task_7()
        {
            int[] arr = new int[10];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = new Random().Next(1, 10);
            }
            Console.Write("Massive: ");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
            Console.Write("Massive after changing of 2 and 5th element: ");
            int element1 = arr[2], element2=arr[5] ;
            arr[2] = element2;
            arr[5] = element1;
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
            int m = 0, n = 0;
            Console.Write("Enter first element number: ");
            try
            {
                m = Convert.ToInt32(Console.ReadLine());
            }
            catch(Exception ex) 
            { 
                Console.WriteLine (ex.Message);
            }
            Console.Write("Enter second element number: ");
            try
            {
                n = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            element1 = arr[m];
            element2 = arr[n];
            arr[m] = element2;
            arr[n] = element1;
            Console.Write($"Massive after changing of {m} and {n}th element: ");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
        }
    }
}
