namespace ConsoleApp1
{
    internal class Program2
    {
        static void Main (string[] args)
        {
            Console.WriteLine("Hi, Boss");
            //   1. Math.PI:
            Console.ForegroundColor = ConsoleColor.Green;
            double pi = Math.PI;
            Console.WriteLine($"1.MathPi = {pi}");
            // Ручне введення:
            double Pi = 3.14159265358979323846;
            Console.WriteLine($"Manual Input = {Pi}");
            //Рядок:
            String PiString = "3.14159265358979323846";
            Console.WriteLine($"PiString = {PiString}");
            SystemEnvironment();
        }
        // 2. Клас System.Environment. Напишіть програму для відображення інформації про комп'ютер на консолі.
        static void SystemEnvironment()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"2.Operation System: {Environment.OSVersion}");
            Console.WriteLine("The name of PC :" + Environment.MachineName);
            Console.WriteLine("User name: " + Environment.UserName);
            Console.WriteLine("Processor number: " + Environment.ProcessorCount);
            Console.WriteLine(".NET Framework: " + Environment.Version);
            Meters();
        }
        //3. Відстань дається в сантиметрах. Знайдіть в ньому кількість повних метрів.
        static void Meters()
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("3.Enter the value in centimeters:");
            double a = new Random().NextDouble() * 10;
            Console.WriteLine(a);
            double meters = a / 100;
            Console.WriteLine($"The number of complete ={meters} meters");
            Weeks234();
        }
        //4. З якогось моменту минуло 234 дні. Скільки повних тижнів пройшло за цей період?
        static void Weeks234()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("4.How much weeks?");
            double result = 234 / 7;
            Console.WriteLine($"{result} weeks in 234 days");
            Squares();
        }
        //5.Наведено прямокутник з розмірами 543 х 130 мм. Скільки квадратів зі стороною 130 мм можна з нього вирізати?
        static void Squares()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(" 5.How many squares with a side of 130 mm can be cut out of a rectangle?");
            double results = 543 / 130;
            Console.WriteLine($" Squares inside = {results}");
            average();
        }
        //6. Створіть програму, яка обчислює середнє арифметичне двох чисел.
        static void average()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("6. Write two numbers with space to calculate the average?");
            string input = Console.ReadLine();
            double[] numbers = input.Split().Select(double.Parse).ToArray();
            double average = numbers.Average();
            Console.WriteLine($" Average = {average}");
            squares();
        }
        // 7.Створіть програму, яка обчислює квадрат будь-якого введеного числа.
        static void squares()
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("7. Write number to calculate the square ?");
            double a = Convert.ToDouble(Console.ReadLine());
            double y = a * a;
            Console.WriteLine($"The square of a number = {y}");
            calculate();
        }
        // 8. Створіть програму, яка запитує в користувача два числа та виводить на екран їх суму, різницю, добуток та частку.
        static void calculate()
        {
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("8.Enter the first number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the second number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());
            double sum = num1 + num2;
            Console.WriteLine("Suma = " + sum);
            double diff = num1 - num2;
            Console.WriteLine(" Difference = " + diff);
            double product = num1 * num2;
            Console.WriteLine("Product =" + product);
            double division = num1 / num2;
            if (num2 > 1)
                Console.WriteLine("Division = " + division);
            year();
        }
        //9.Створіть програму, яка запитує в користувача його рік народження та обчислює його вік.
        static void year()
        {
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("9. Please tell me what year you were born?");
            double g = Convert.ToDouble(Console.ReadLine());
            double difference = 2024 - g;
            Console.WriteLine($"Your age is {difference}");
            // 10. Створіть програму, яка запитує в користувача довжину сторін прямокутного трикутника, а потім обчислює його гіпотенузу за формулою c = √(a² + b²).
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine(" 10. Please, enter the first  lenghth of the sides of the right triangle ");
            double l = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(" Please, enter the second  lenghth of the sides of the right triangle ");
            double m = Convert.ToDouble(Console.ReadLine());
            double formula = (l * l) + (m * m);
            double squareRoot = Math.Sqrt(formula);
            Console.WriteLine($"Hypotenuse = {squareRoot}");
            conventer();
        }
        // 11. Створіть програму, яка запитує в користувача кількість грошей в доларах та перетворює їх в євро за поточним курсом.
        static void conventer()
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("11.Please enter the dollar amount?");
            double dollar = Convert.ToDouble(Console.ReadLine());
            double conv = 0.92 * dollar;
            Console.WriteLine("Your amounts is in euros =" + conv);
            tall();
        }
        // 12. Створіть програму, яка запитує в користувача його зріст у футах та дюймах, а потім перетворює його в сантиметри за формулою 1 фут = 30.48 см, 1 дюйм = 2.54 см.
        static void tall()
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("12.How tall are you in feet?");
            double d = Convert.ToDouble(Console.ReadLine());
            double cent = d * 30.48;
            Console.WriteLine($"Your tall in the centimeters is {cent}");
            Console.WriteLine("What is your height in inches?");
            string inches = Console.ReadLine();
            double e = Convert.ToDouble(Console.ReadLine());
            double sant = e * 2.54;
            Console.WriteLine($"Your tall in the centimeters is {sant}");
        }



    }
}

