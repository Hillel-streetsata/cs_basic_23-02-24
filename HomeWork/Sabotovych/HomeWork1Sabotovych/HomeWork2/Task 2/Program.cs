namespace Task_2
{
    internal class Program
    {
        static void Main()
        {
            Task1();
            Task2();
            Task3();
            Task4();
            Task5();
            Task6();
            Task7();
        }

        static void Task1()
        {
            try
            {
                Console.Write("Введiть цiле число: ");
                int number = int.Parse(Console.ReadLine());

                if (number > 0)
                {
                    number += 1;
                }
                else if (number < 0)
                {
                    number -= 2;
                }
                else
                {
                    number = 10;
                }
                Console.WriteLine("Отримане число: " + number);
                Console.ReadLine();
            }
            catch (FormatException)
            {
                Console.WriteLine("Write numbers");
            }

        }
        static void Task2()
        {
            int num1, num2, num3;

            try
            {
                Console.Write("Введiть перше цiле число: ");
                num1 = int.Parse(Console.ReadLine());

                Console.Write("Введiть друге цiле число: ");
                num2 = int.Parse(Console.ReadLine());

                Console.Write("Введiть третє цiле число: ");
                num3 = int.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Помилка введення. Введiть цiле число.");
                return;
            }

            int positiveCount = CountPositiveNumbers(num1, num2, num3);

            Console.WriteLine("Кiлькiсть додатних чисел у вихiдному наборi: " + positiveCount);

            Console.ReadLine();
        }
        static int CountPositiveNumbers(int a, int b, int c)
        {
            int count = 0;

            if (a > 0)
            {
                count++;
            }

            if (b > 0)
            {
                count++;
            }

            if (c > 0)
            {
                count++;
            }

            return count;
        }
        static void Task3()
        {
            int num1, num2, num3;

            try
            {
                Console.Write("Введiть перше цiле число: ");
                num1 = int.Parse(Console.ReadLine());

                Console.Write("Введiть друге цiле число: ");
                num2 = int.Parse(Console.ReadLine());

                Console.Write("Введiть третє цiле число: ");
                num3 = int.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Помилка введення. Введiть цiле число.");
                return;
            }

            int positiveCount = CountPositiveNumbers(num1, num2, num3);
            int negativeCount = CountNegativeNumbers(num1, num2, num3);

            Console.WriteLine("Кiлькiсть позитивних чисел у вихiдному наборi: " + positiveCount);
            Console.WriteLine("Кiлькiсть негативних чисел у вихiдному наборi: " + negativeCount);

            Console.ReadLine();
        }
        static int CountNegativeNumbers(int a, int b, int c)
        {
            int count = 0;

            if (a < 0)
            {
                count++;
            }

            if (b < 0)
            {
                count++;
            }

            if (c < 0)
            {
                count++;
            }

            return count;
        }
        static void Task4()
        {
            int A = 10;
            int B = 5;

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

            Console.WriteLine("Результат першої задачi:");
            Console.WriteLine("A = " + A);
            Console.WriteLine("B = " + B);

            int numberToCheck = 7;

            if (IsEven(numberToCheck))
            {
                Console.WriteLine("\nРезультат другої задачi:");
                Console.WriteLine(numberToCheck + " є парним числом.");
            }
            else
            {
                Console.WriteLine("\nРезультат другої задачi:");
                Console.WriteLine(numberToCheck + " є непарним числом.");
            }

            Console.ReadLine();
        }
        static bool IsEven(int number)
        {
            return number % 2 == 0;
        }
        static void Task5()
        {
            Console.WriteLine("Введiть номер одиницi довжини (1-5): ");
            int unitNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("Введiть довжину вiдрiзка в цих одиницях: ");
            double length = double.Parse(Console.ReadLine());

            double[] conversionFactors = { 0.1, 1000, 1, 0.001, 0.01 };

            if (unitNumber >= 1 && unitNumber <= conversionFactors.Length)
            {
                double lengthInMeters = length * conversionFactors[unitNumber - 1];

                Console.WriteLine("Довжина вiдрiзка в метрах: " + lengthInMeters + " м");
            }
            else
            {
                Console.WriteLine("Невiрний номер одиницi довжини. Введiть число вiд 1 до 5.");
            }

            Console.ReadLine();
        }
        static void Task6()
        {
            char direction = 'C';

            Console.WriteLine("Введiть початковий напрямок (North, West, South, East): ");
            string initialDirectionInput = Console.ReadLine();

            if (string.IsNullOrEmpty(initialDirectionInput) || !IsValidDirection(initialDirectionInput[0]))
            {
                Console.WriteLine("\nНевiрний початковий напрямок. Використовуйте North, West, South або East.");
                return;
            }

            direction = char.ToUpper(initialDirectionInput[0]);

            Console.WriteLine("\nВведiть команду для робота (0 - продовжити, 1 - повернути лiворуч, -1 - повернути праворуч): ");
            int command = int.Parse(Console.ReadLine());

            direction = ChangeDirection(direction, command);

            Console.WriteLine("Новий напрямок робота: " + direction);

            Console.ReadLine();
        }
        static bool IsValidDirection(char dir)
        {
            return dir == 'N' || dir == 'W' || dir == 'S' || dir == 'E';
        }
        static char ChangeDirection(char currentDirection, int command)
        {
            char[] directions = { 'N', 'W', 'S', 'E' };
            int currentIndex = Array.IndexOf(directions, currentDirection);

            currentIndex = (currentIndex + command + 4) % 4;

            return directions[currentIndex];
        }
        static void Task7()
        {
            try
            {
                Console.Write("Введiть вiк (20-69): ");
                int age = int.Parse(Console.ReadLine());

                if (age < 20 || age > 69)
                {
                    throw new ArgumentOutOfRangeException("age", "Невiрний вiк. Введiть число вiд 20 до 69.");
                }

                string ageDescription = GetAgeDescription(age);
                Console.WriteLine($"{age} - {ageDescription}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Помилка введення. Будь ласка, введiть цiле число.");
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("Не туди полiз");
            }

            Console.ReadLine();
        }

        static string GetAgeDescription(int age)
        {
            string[] ones = { "", "один", "два", "три", "чотири", "п'ять", "шiсть", "сiм", "вiсiм", "дев'ять" };
            string[] teens = { "десять", "одинадцять", "дванадцять", "тринадцять", "чотирнадцять", "п'ятнадцять", "шiстнадцять", "сiмнадцять", "вiсiмнадцять", "дев'ятнадцять" };
            string[] tens = { "", "", "двадцять", "тридцять", "сорок", "п'ятдесят", "шiстдесят" };

            int tensDigit = age / 10;
            int onesDigit = age % 10;

            string ageDescription = "";

            if (tensDigit > 1)
            {
                ageDescription += tens[tensDigit] + " ";
                if (onesDigit > 0)
                {
                    ageDescription += ones[onesDigit] + " ";
                }

                if (onesDigit == 1)
                {
                    ageDescription += "рiк";
                }
                else if (onesDigit > 1 && onesDigit < 5)
                {
                    ageDescription += "роки";
                }
                else
                {
                    ageDescription += "рокiв";
                }
            }
            else if (tensDigit == 1)
            {
                ageDescription += teens[onesDigit] + " ";

                if (onesDigit == 1)
                {
                    ageDescription += "рiк";
                }
                else if (onesDigit > 1 && onesDigit < 5)
                {
                    ageDescription += "роки";
                }
                else
                {
                    ageDescription += "рокiв";
                }
            }
            else if (onesDigit > 0)
            {
                ageDescription += ones[onesDigit] + " ";

                if (onesDigit == 1)
                {
                    ageDescription += "рiк";
                }
                else if (onesDigit > 1 && onesDigit < 5)
                {
                    ageDescription += "роки";
                }
                else
                {
                    ageDescription += "рокiв";
                }
            }

            return ageDescription;
        }
    }
}
