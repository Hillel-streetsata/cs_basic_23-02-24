using System;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = UTF8Encoding.UTF8;

        // Завдання 1
        Console.WriteLine("Завдання 1".PadLeft((Console.WindowWidth + "Завдання 1".Length) / 2));
        double pi = Math.PI; // Перший спосіб виводу числа Пі без округлення
        Console.WriteLine(pi);
        double formattedPi = Math.Round(pi, 2); // Другий спосіб виводу числа Пі з округленням до 2 знаків після коми
        Console.WriteLine(formattedPi);

        // Завдання 2
        Console.WriteLine("Завдання 2".PadLeft((Console.WindowWidth + "Завдання 2".Length) / 2));
        Console.WriteLine("Інформація про ПК");
        Console.WriteLine($"Ім'я ПК: {Environment.MachineName}");
        Console.WriteLine($"Ім'я користувача: {Environment.UserName}");
        Console.WriteLine($"Версія операційнної системи: {Environment.OSVersion}");
        Console.WriteLine($"Кількість процесорів: {Environment.ProcessorCount}");
        Console.WriteLine($"Місце збереження роботи:{Environment.ProcessPath}");
        Console.WriteLine($"Дата і час: {DateTime.Now}");

        // Завдання 3
        Console.WriteLine("Завдання 3".PadLeft((Console.WindowWidth + "Завдання 3".Length) / 2));
        Random random = new Random();
        int distanceInCentimeters = random.Next(1, 1001); //Рандомне число
        int meters = distanceInCentimeters / 100;
        Console.WriteLine($"Відстань в сантиметрах:{distanceInCentimeters} см");
        Console.WriteLine($"Кількість повных метрів:{meters} м");

        // Завдання 4
        Console.WriteLine("Завдання 4".PadLeft((Console.WindowWidth + "Завдання 4".Length) / 2));
        int days = 234;
        int weeks = days / 7;
        Console.WriteLine($"Минуло повных тижнів:{weeks}");

        // Завдання 5
        Console.WriteLine("Завдання 5".PadLeft((Console.WindowWidth + "Завдання 5".Length) / 2));
        int rectangleLength = 543; // Довжина прямоктуника в мм
        int rectangleWidth = 130; // Ширина прямокутника в мм
        int squareSide = 130; // Сторона квадрта в мм

        int squaresInLength = rectangleLength / squareSide;
        int squaresInWidth = rectangleWidth / squareSide;

        int totalSquares = squaresInLength * squaresInWidth; // загальна кількість квадратів

        Console.WriteLine($"Можна вирізати {totalSquares} квадрати з стороною {squareSide} мм з прямокутника розміром {rectangleLength} х {rectangleWidth} мм.");

        // Завдання 6 
        Console.WriteLine("Завдання 6".PadLeft((Console.WindowWidth + "Завдання 6".Length) / 2));

        Console.WriteLine("Введіть перше число:"); // Вводимо перше число
        double number1 = Convert.ToDouble(Console.ReadLine()); // Зчитує перше число 

        Console.WriteLine("Введіть друге число:"); // Вводимо друге число
        double number2 = Convert.ToDouble(Console.ReadLine()); // Зчитує друге число

        double arithemtic = (number1 + number2) / 2; // Обчислення середнього арифметичного
        Console.WriteLine($"Середнє арифметична чисел {number1} і {number2} дорівнює {arithemtic}"); // Виведення результату

        // Завдання 7
        Console.WriteLine("Завдання 7".PadLeft((Console.WindowWidth + "Завдання 7".Length) / 2));

        Console.WriteLine("Введіть число яке хочете возвести в квадрат:"); // Вводимо число
        double number = Convert.ToDouble(Console.ReadLine()); // Зчитуємо число 
        double square = number * number; // Обчислюємо квадрат
        Console.WriteLine($"Квадрат числа {number} дорівнює {square}"); // Виведення результату

        // Завдання 8
        Console.WriteLine("Завдання 8".PadLeft((Console.WindowWidth + "Завдання 8".Length) / 2));

        Console.WriteLine("Введіть перше число:"); // Вводимо перше число
        double NumberOne = Convert.ToDouble(Console.ReadLine()); // Зчитує перше число 

        Console.WriteLine("Введіть друге число:"); // Вводимо друге число
        double NumberTwo = Convert.ToDouble(Console.ReadLine()); // Зчитує друге число з консолі

        double sum = (NumberOne + NumberTwo); // Сума
        double difference = (NumberOne - NumberTwo); // Різниця
        double product = (NumberTwo * NumberOne); // Добуток
        double quotient = (NumberOne / NumberTwo); // Частка

        Console.WriteLine($"Сума чисел {NumberOne} і {NumberTwo} дорівнює {sum}, Різниця чисел  {NumberOne} і {NumberTwo} дорівнює {difference}, Добуток чисел {NumberOne} і {NumberTwo} дорівнює {product}, Частка чисел  {NumberOne} і {NumberTwo} дорівнює {quotient}");

        // Завдання 9
        Console.WriteLine("Завдання 9".PadLeft((Console.WindowWidth + "Завдання 9".Length) / 2));

        Console.WriteLine("Введіть ваш рік народження"); // Запитує рік 
        int YearOfBirthday = Convert.ToInt32(Console.ReadLine()); // Зчитує рік

        int CurrentYear = DateTime.Now.Year; // Поточний рік

        int age = CurrentYear - YearOfBirthday; // обчислює вік
        Console.WriteLine($"Ваш вік {age} років");

        // Завдання 10
        Console.WriteLine("Завдання 10".PadLeft((Console.WindowWidth + "Завдання 10".Length) / 2));

        Console.WriteLine("Введіть довжину першого катета трикутника");
        double a = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Введіть довжину другого катета трикутника");
        double b = Convert.ToDouble(Console.ReadLine());

        double c = Math.Sqrt(a * a + b * b); // Обчислюємо гіпотенузу - Math.Sqrt возводить у корінь
        double formattedC = Math.Round(c, 1); // округлення до 1 цифри після коми
        Console.WriteLine($"Гіпотенуза трикутника з катетами {a} і {b} дорівнює {formattedC}");

        // Завдання 11
        Console.WriteLine("Завдання 11".PadLeft((Console.WindowWidth + "Завдання 11".Length) / 2));

        Console.WriteLine($"Введіть кількість грошей в доларах");
        double dollars = Convert.ToDouble(Console.ReadLine());

        double exchange = 0.91; // Курс обміну 1 доллару на 1 євро
        double euro = dollars * exchange; // Кількість євро
        double euros = Math.Round(euro, 2); // Округлення до 2 цифр після коми
        Console.WriteLine($"Кількість грошей в євро: {euros} євро");

        // Завдання 12
        Console.WriteLine("Завдання 12".PadLeft((Console.WindowWidth + "Завдання 12".Length) / 2));

        Console.WriteLine("Введіть ваш зріст у футах");
        double feet = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Введіть ваш зріст у дюймах");
        double inches = Convert.ToDouble(Console.ReadLine());

        double total = ((feet * 30.48) + (inches * 2.54)); // Використовуємо формулу Рост (в см) = (Футы × 30.48) + (Дюймы × 2.54)
        Console.WriteLine($"Ваш зріст у сантиметрах: {total} см");

    }


}

