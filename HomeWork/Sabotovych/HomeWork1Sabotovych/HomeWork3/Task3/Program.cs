namespace Task3
{
    internal class Program
    {
        static void Main()
        {
            Task1();
            Task2();
            Task3a();
            Task3b();
            Task4();
            Task5();
            Task6();
            Task7();
        }
        static void Task1()
        {
            int sum = 0;

            for (int i = 1; i < 50; i += 2)
            {
                sum += i;
            }
            Console.WriteLine("Сума додатних непарних чисел менше 50: " + sum);
        }
        static void Task2()
        {
            try
            {
                Console.Write("Введіть значення a: ");
                int a = int.Parse(Console.ReadLine());

                Console.Write("Введіть значення b: ");
                int b = int.Parse(Console.ReadLine());

                int sum = 0;

                for (int i = a; i <= b; i++)
                {
                    if (i % 4 == 0)
                    {
                        sum += i;
                    }
                }
                Console.WriteLine("Сума натуральних чисел від " + a + " до " + b + ", кратних чотирьом: " + sum);
            }
            catch (FormatException)
            {
                Console.WriteLine("Помилка: Неправильний формат введених даних.");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Помилка: Значення перевищує діапазон цілих чисел.");
            }
        }
        static void Task3a()
        {
            Console.WriteLine("Двозначні числа, сума квадратів цифр яких ділиться на 13:");

            for (int i = 10; i < 100; i++)
            {
                int tensDigit = i / 10;
                int unitsDigit = i % 10;

                int sumOfSquares = (tensDigit * tensDigit) + (unitsDigit * unitsDigit);

                if (sumOfSquares % 13 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
        static void Task3b()
        {
            Console.WriteLine("Двозначні числа з властивістю: якщо до суми цифр числа додати квадрат цієї суми, то знову вийде шукане число:");

            for (int i = 10; i < 100; i++)
            {
                int tensDigit = i / 10;
                int unitsDigit = i % 10;

                int sumOfDigits = tensDigit + unitsDigit;
                int squareOfSumOfDigits = sumOfDigits * sumOfDigits;

                if (i == sumOfDigits + squareOfSumOfDigits)
                {
                    Console.WriteLine(i);
                }
            }
        }
        static void Task4()
        {
            Console.Write("Введіть значення A: ");
            int A = int.Parse(Console.ReadLine());

            Console.Write("Введіть значення B (B > A): ");
            int B = int.Parse(Console.ReadLine());

            int sum = 0;
            int product = 1;

            for (int i = A; i <= B; i++)
            {

                sum += i;

                product *= i;
            }

            Console.WriteLine("Сума чисел від A до B: " + sum);
            Console.WriteLine("Добуток чисел від A до B: " + product);
        }
        static void Task5()
        {
            Console.Write("Введіть значення A: ");
            int A = int.Parse(Console.ReadLine());

            Console.Write("Введіть значення B (B > A): ");
            int B = int.Parse(Console.ReadLine());

            int count = 0;

            Console.WriteLine("Цілі числа між A і B включно:");

            for (int i = A; i <= B; i++)
            {
                Console.WriteLine(i);
                count++;
            }

            Console.WriteLine("Кількість чисел між A і B: " + count);
        }
        static void Task6()
        {
            try
            {
                Console.Write("Введіть ціну за 1 кг цукерок: ");
                double pricePerKg = double.Parse(Console.ReadLine());

                Console.WriteLine("Кількість (кг)\tЦіна");

                for (double kg = 1.0; kg <= 2.0; kg += 0.2)
                {
                    double totalPrice = pricePerKg * kg;

                    Console.WriteLine($"{kg:F1}\t\t{totalPrice:F2}");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Ви ввели некоректне значення для ціни за 1 кг цукерок.");
            }
        }
        static void Task7()
        {
            try
            {
                Console.Write("Введіть значення A: ");
                int A = int.Parse(Console.ReadLine());

                Console.Write("Введіть значення B (B > A): ");
                int B = int.Parse(Console.ReadLine());

                for (int i = A; i <= B; i++)
                {
                    for (int j = 0; j < i; j++)
                    {
                        Console.Write(i + " ");
                    }
                    Console.WriteLine();
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Некоректний формат введених даних. Будь ласка, введіть ціле число.");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Введене число занадто велике або занадто мале.");
            }
        }
    }
}
