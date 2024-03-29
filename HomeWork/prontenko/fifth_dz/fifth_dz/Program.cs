namespace fifth_dz
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

            Console.Write("Введiть число: ");
            int num;
            bool success = int.TryParse(Console.ReadLine(), out num);

            if (success)
            {
                int i = 1;
                while (i <= 10)
                {
                    Console.WriteLine($"{num} * {i} = {num * i}");
                    i++;
                }
            }
            else
            {
                Console.WriteLine("Введення не є дійсним числом.");
            }
        }   //+
        static void second_task() 
        {
            Little_bit_beauty();
            Console.WriteLine();

            int number;
            bool isValid;

            do
            {
                Console.Write("Введiть число: ");
                string input = Console.ReadLine();
                isValid = Int32.TryParse(input, out number);

                if (!isValid)
                {
                    Console.WriteLine("Введення не є дiйсним числом. Спробуйте ще раз.");
                }
            }
            while (!isValid);

            Console.WriteLine($"Ви ввели правильне число: {number}");
        } //+
        static void third_task() 
        {
            Little_bit_beauty();
            Console.WriteLine();
             
            Console.Write("Введiть висоту пiрамiди: ");
            int height;
            bool success = Int32.TryParse(Console.ReadLine(), out height);

            if (success)
            {
                for (int i = 0; i < height; i++)
                {
                    for (int j = 0; j < height - i; j++)
                    {
                        Console.Write(" ");
                    }

                    for (int k = 0; k <= i * 2; k++)
                    {
                        Console.Write("*");
                    }

                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("Введення не є дійсним числом.");
            }
        }  //+
        static void fourth_task() 
        {
            Little_bit_beauty() ;
            Console.WriteLine();

            Console.Write("Введiть число: ");
            string input = Console.ReadLine();
            int sum = 0;

            foreach (char digitChar in input)
            {
                int digit;
                bool success = Int32.TryParse(digitChar.ToString(), out digit);

                if (success)
                {
                    sum += digit;
                }
                else
                {
                    Console.WriteLine("Введення містить недійсні символи.");
                    return;
                }
            }

            Console.WriteLine($"Сума цифр введеного числа: {sum}");
        } //+
        static void fifth_task() 
        {
            Little_bit_beauty();
            Console.WriteLine();

            Console.Write("Введiть число: ");
            int num;
            bool success = Int32.TryParse(Console.ReadLine(), out num);

            if (success)
            {
                long factorial = 1;
                for (int i = 1; i <= num; i++)
                {
                    factorial *= i;
                }
                Console.WriteLine($"Факторіал числа {num} дорівнює {factorial}");
            }
            else
            {
                Console.WriteLine("Введення не є дійсним числом.");
            }
        } //+
        static void sixth_task() 
        {
            Little_bit_beauty();
            Console.WriteLine();

            Random rand = new Random();
            string continueGame;

            do
            {
                int roll = rand.Next(1, 7);
                Console.WriteLine("Ви кинули кубик i отримали: " + roll);

                Console.WriteLine("Бажаєте кинути кубик ще раз? (так/ні)");
                continueGame = Console.ReadLine();
            }
            while (continueGame.ToLower() == "так");

            Console.WriteLine("Дякуємо за гру!");
        } //+
        static void seventh_task() 
        {
            Little_bit_beauty() ;
            Console.WriteLine();

            List<int> numbers = new List<int>() { 34, 5, 67, 1, 89, 20, 77, 45, 25 };
            int max = numbers[0];
            int min = numbers[0];

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

            Console.WriteLine("Найбiльше число: " + max);
            Console.WriteLine("Найменше число: " + min);
        } //+
    }
}