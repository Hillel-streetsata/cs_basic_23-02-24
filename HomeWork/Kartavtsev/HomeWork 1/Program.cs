namespace HW_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Завдання 1");
            double pi = Math.PI;
            Console.WriteLine(pi);

            Console.WriteLine("Завдання 2");
            Console.WriteLine("Інформація про ПК");
            Console.WriteLine($"Ім'я ПК: {Environment.MachineName}");
            Console.WriteLine($"Ім'я користувача: {Environment.UserName}");
            Console.WriteLine($"Версія операційнної системи: {Environment.OSVersion}");
            Console.WriteLine($"Кількість процесорів: {Environment.ProcessorCount}");
            Console.WriteLine($"Місце збереження роботи:{Environment.ProcessPath}");
            Console.WriteLine($"Дата і час: {DateTime.Now}");

            Console.WriteLine("Завдання 3");
            Random random = new Random();
            int distanceInCentimeters = random.Next(1, 1001); 
            int meters = distanceInCentimeters / 100;
            Console.WriteLine($"Відстань в сантиметрах:{distanceInCentimeters} см");
            Console.WriteLine($"Кількість повных метрів:{meters} м");

            Console.WriteLine("Завдання 4");
            int days = 234;
            int weeks = days / 7;
            Console.WriteLine($"Минуло повных тижнів:{weeks}");

            Console.WriteLine("Завдання 5");
            int rectangleLength = 543; // Довжина прямоктуника в мм
            int rectangleWidth = 130; // Ширина прямокутника в мм
            int squareSide = 130; // Сторона квадрта в мм

            int squaresInLength = rectangleLength / squareSide;
            int squaresInWidth = rectangleWidth / squareSide;

            int totalSquares = squaresInLength * squaresInWidth; // загальна кількість квадратів

            Console.WriteLine("Завдання 6");

            Console.WriteLine("Введіть перше число:"); 
            double number1 = Convert.ToDouble(Console.ReadLine()); 

            Console.WriteLine("Введіть друге число:"); 
            double number2 = Convert.ToDouble(Console.ReadLine()); 

            double arithemtic = (number1 + number2) / 2; 
            Console.WriteLine($"Середнє арифметична чисел {number1} і {number2} дорівнює {arithemtic}");

            Console.WriteLine("Завдання 7");

            Console.WriteLine("Введіть число яке хочете возвести в квадрат:"); 
            double number = Convert.ToDouble(Console.ReadLine());  
            double square = number * number; 
            Console.WriteLine($"Квадрат числа {number} дорівнює {square}"); 

            
            Console.WriteLine("Завдання 8");

            Console.WriteLine("Введіть перше число:"); 
            double NumberOne = Convert.ToDouble(Console.ReadLine()); 

            Console.WriteLine("Введіть друге число:"); 
            double NumberTwo = Convert.ToDouble(Console.ReadLine()); 

            double sum = (NumberOne + NumberTwo); 
            double difference = (NumberOne - NumberTwo); 
            double product = (NumberTwo * NumberOne); 
            double quotient = (NumberOne / NumberTwo); 

            Console.WriteLine($"Сума чисел {NumberOne} і {NumberTwo} дорівнює {sum}, Різниця чисел  {NumberOne} і {NumberTwo} дорівнює {difference}, Добуток чисел {NumberOne} і {NumberTwo} дорівнює {product}, Частка чисел  {NumberOne} і {NumberTwo} дорівнює {quotient}");

           
            Console.WriteLine("Завдання 9");

            Console.WriteLine("Введіть ваш рік народження"); 
            int YearOfBirthday = Convert.ToInt32(Console.ReadLine()); 

            int CurrentYear = DateTime.Now.Year; 

            int age = CurrentYear - YearOfBirthday; 
            Console.WriteLine($"Ваш вік {age} років");

            
            Console.WriteLine("Завдання 10");

            Console.WriteLine("Введіть довжину першого катета трикутника");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введіть довжину другого катета трикутника");
            double b = Convert.ToDouble(Console.ReadLine());

            double c = Math.Sqrt(a * a + b * b); 
            double formattedC = Math.Round(c, 1); 
            Console.WriteLine($"Гіпотенуза трикутника з катетами {a} і {b} дорівнює {formattedC}");

            
            Console.WriteLine("Завдання 11");

            Console.WriteLine($"Введіть кількість грошей в доларах");
            double dollars = Convert.ToDouble(Console.ReadLine());

            double exchange = 0.91; 
            double euro = dollars * exchange; 
            double euros = Math.Round(euro, 2); 
            Console.WriteLine($"Кількість грошей в євро: {euros} євро");

            
            Console.WriteLine("Завдання 12");

            Console.WriteLine("Введіть ваш зріст у футах");
            double feet = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введіть ваш зріст у дюймах");
            double inches = Convert.ToDouble(Console.ReadLine());

            double total = ((feet * 30.48) + (inches * 2.54)); 
            Console.WriteLine($"Ваш зріст у сантиметрах: {total} см");

           


        }


    }
}
