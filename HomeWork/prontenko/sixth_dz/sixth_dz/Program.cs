namespace sixth_dz_first_part
{
    internal class Program
    {
        static void Main(string[] args)
        {
            first_task();
            second_task();
            third_task();
            fourth_task();
            fifth_task();
            sixth_task();
            seventh_task();
            eight_task();

        }

        static void Little_bit_beauty()
        {
            Console.WriteLine();
            for (int i = 0; i < 100; i++)
            {
                Console.Write("=");

            }
            Console.WriteLine();
            for (int i = 0; i < 100; i++)
            {
                if (i % 2 == 0)
                {
                    Console.Write("*");
                }
                else
                {
                    Console.Write(" ");
                }

            }
            Console.WriteLine();
            for (int i = 0; i < 100; i++)
            {
                Console.Write("=");

            }
            Console.WriteLine();


        }

        

        static void first_task()
        {
            Little_bit_beauty();
            Console.WriteLine();

            int[] arr = { 37, 0, 50, 46, 34, 46, 0, 13 };

            for (int i = 0;i < arr.Length;i++)
            {
                Console.Write(arr[i] + " ");
            }
        } //+
        static void second_task() 
        {
            Little_bit_beauty();
            Console.WriteLine();

            int[] hight_of_men = new int[12];
            Random random = new Random();

            for (int i = 0;i < hight_of_men.Length ; i++)
            {
                hight_of_men[i] = random.Next(163, 191);
                Console.WriteLine(hight_of_men[i]);
            }

        } //+
        static void third_task()
        {
            Little_bit_beauty();
            Console.WriteLine();

            int[] arr = new int[10];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = i + 1;
            }

            for (int i = 0; i < arr.Length; i+=2)
            {
                Console.WriteLine($"Елемент з індексом {i}: {arr[i]}");
            }
        } //+
        static void fourth_task()
        {
            Little_bit_beauty() ;
            Console.WriteLine();
            Console.WriteLine("----4----");
            Console.WriteLine() ;

            int[] arr = new int[10];

            for(int i = 0; i < arr.Length ; i++)
            {
                arr[i] = i + 1;
            }

            for (int i = arr.Length - 1;  i >= 0 ; i--)
            {
                Console.WriteLine($"Елемент з індексом {i}: {arr[i]}");
            }
        } //+
        static void fifth_task()
        {
            Little_bit_beauty();
            Console.WriteLine();

            int[] arr = new int[12];
            int sum = 0;

            for(int i = 0;i < arr.Length;i++)
            {
                Console.WriteLine($"Введіть {i+1} елемент масиву: ");
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            Console.WriteLine($"Сума елементів масиву: {sum}");

        } //+
        static void sixth_task() 
        {
            Little_bit_beauty();
            Console.WriteLine();

            double[] resistors = new double[20]; 
            Random random = new Random(); 

           
            for (int i = 0; i < resistors.Length; i++)
            {
                resistors[i] = random.Next(1, 4); 
            }

            
            double totalResistance = 0;
            foreach (double resistor in resistors)
            {
                totalResistance += 1 / resistor;
            }
            totalResistance = 1 / totalResistance;

            Console.WriteLine($"Загальний опір ланцюга: {totalResistance} Ом");
        } //+
        static void seventh_task()
        {
            Little_bit_beauty();
            Console.WriteLine();

            int[] array = { -1, 2, 3, -2, 5 }; 
            int sum = 0; 

            foreach (int element in array)
            {
                sum += element; 
            }

            bool isNonNegative = sum >= 0; 

            Console.WriteLine($"Сума елементів масиву: {sum}");
            Console.WriteLine($"Чи є сума невід'ємною: {isNonNegative}");

        } //+
        static void eight_task()
        {
            
                
                Console.Write("Введіть розмір масиву: ");
                int size = int.Parse(Console.ReadLine());
                int[] array = new int[size];

                
                for (int i = 0; i < array.Length; i++)
                {
                    Console.Write($"Введіть елемент масиву під індексом {i}: ");
                    array[i] = int.Parse(Console.ReadLine());
                }

                
                if (array.Length >= 5)
                {
                    int temp = array[1]; 
                    array[1] = array[4]; 
                    array[4] = temp;
                }

                
                Console.Write("Введіть індекс m: ");
                int m = int.Parse(Console.ReadLine());
                Console.Write("Введіть індекс n: ");
                int n = int.Parse(Console.ReadLine());

                
                if (m >= 0 && m < array.Length && n >= 0 && n < array.Length)
                {
                    
                    int temp = array[m];
                    array[m] = array[n];
                    array[n] = temp;
                }
                else
                {
                    Console.WriteLine("Індекси m або n виходять за межі масиву.");
                }

                
                Console.WriteLine("Змінений масив:");
                foreach (int element in array)
                {
                    Console.Write(element + " ");
                }
            } //+
        }

    }



