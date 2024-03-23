using System;
using System.Net.Http.Headers;
using System.Runtime.InteropServices.Marshalling;
using System.Security.Cryptography.X509Certificates;
using System.Text;

class Programr
{

    static void Divider()
    {
        Console.WriteLine(new string('-', 15));
    }
    static void TaskOne()
    {

        Console.WriteLine("Task №1");
        Console.WriteLine("Відобразити число Пі різними способами.\n");
        Console.Write($"1.Визначення числа (pi), через вбудовану константу: ");
        Console.WriteLine(Math.PI + "\n");
        Console.Write("2.за допомогою форматування: ");
        Console.WriteLine($"{Math.PI:F2}\n");
        Console.Write("3.У вигляді дробу: ");
        Console.WriteLine($"{Math.PI:N10}\n");
        Console.Write("4.У вигляді експоненту: ");
        Console.WriteLine($"{Math.PI:E}");
    }
    static void TaskTwo()
    {
        Console.WriteLine("Task №2");
        Console.WriteLine("Клас System.Environment. Напишіть програму для відображення інформації про комп'ютер на консолі.\n");
        Console.WriteLine("Директорія проекту: {0}\n", Environment.CurrentDirectory);
        Console.WriteLine("Ім'я ПК: {0}\n", Environment.MachineName);
        Console.WriteLine("Версія OS: {0}\n", Environment.OSVersion.ToString());
        Console.WriteLine("Директорія Windows: {0}", Environment.SystemDirectory);
    }
    static void TaskThree()
    {
        Console.WriteLine("Task№3");
        Console.WriteLine("Відстань дається в сантиметрах. Знайдіть в ньому кількість повних метрів.\n");
        var random = new Random();
        long distanceInCentimeters = random.NextInt64(5000);

        double distanceInMeters = distanceInCentimeters / 100.0;
        Console.WriteLine("Кількість сантиметрів: " + distanceInCentimeters + "\n");
        Console.WriteLine("Кількість повних метрів: " + distanceInMeters);

    }
    static void TaskFour()
    {
        Console.WriteLine("Task№4");
        Console.WriteLine("З якогось моменту минуло 234 дні. Скільки повних тижнів пройшло за цей період?\n");
        int days = 234;
        double resoult = days / 7;
        Console.WriteLine("Кількість тижнів: " + resoult);
    }
    static void TaskFive()
    {
        Console.WriteLine("Task№5");
        Console.WriteLine("Наведено прямокутник з розмірами 543 х 130 мм. Скільки квадратів зі стороною 130 мм можна з нього вирізати?\n");
        int lenght = 534;
        int width = 130;
        int squre = 130;
        int area = lenght * width;
        int squareArea = squre * squre;
        int squares = area / squareArea;
        Console.WriteLine("Кількість квадратів: " + squares);
    }
    static void TaskSix()
    {
        Console.WriteLine("Task№6");
        Console.WriteLine("Створіть програму, яка обчислює середнє арифметичне двох чисел.\n");
        Console.Write("Введіть перше число: ");
        double num1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine();
        Console.Write("Введіть друге число: ");
        double num2 = Convert.ToDouble(Console.ReadLine());
        Divider();
        Console.WriteLine();
        double avarage = (num1 + num2) / 2;
        Console.WriteLine("Середне арифметичне: " + avarage);
    }
    static void TaskSeven()
    {
        Console.WriteLine("Task №7");
        Console.WriteLine("Створіть програму, яка обчислює квадрат будь-якого введеного числа.\n");
        Console.Write("Введіть число: ");
        double number = Convert.ToDouble(Console.ReadLine());
        Divider();
        Console.WriteLine();
        double squere = number * number;
        Console.WriteLine("Квадрат числа: " + number + " = " + squere);
    }
    static void TaskEight()
    {
        Console.WriteLine("Task №8");
        Console.WriteLine("Створіть програму, яка запитує в користувача два числа та виводить на екран їх суму, різницю, добуток та частку.\n");
        Console.Write("Введіть перше число: ");
        double num1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine();
        Console.Write("Введіть друге число: ");
        double num2 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine();
        Divider();
        double sum = num1 + num2;
        double differens = num1 - num2;
        double product = num1 * num2;
        double quotent = num1 / num2;
        Console.WriteLine("Сума: " + sum + "\n");
        Console.WriteLine("Різниця: " + differens + "\n");
        Console.WriteLine("Добуток: " + product + "\n");
        Console.WriteLine("Частка: " + quotent + "\n");

    }
    static void TaskNine()
    {
        Console.WriteLine("Task №9");
        Console.WriteLine("Створіть програму, яка запитує в користувача його рік народження та обчислює його вік.\n");
        int currentYear = DateTime.Now.Year;
        Console.Write("Введіть ваш рік нарадження: ");
        int birthYear = Convert.ToInt32(Console.ReadLine());
        Divider();
        int age = currentYear - birthYear;
        Console.WriteLine("Вік: " + age);
    }
    static void TaskTen()
    {
        Console.WriteLine("Task №10");
        Console.WriteLine("Створіть програму, яка запитує в користувача довжину сторін прямокутного трикутника, а потім обчислює його гіпотенузу за формулою c = √(a² + b²).\n");
        Console.Write("Введіть довжину першого катета: ");
        double a = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine();
        Console.Write("Введіть довжину другого катета: ");
        double b = Convert.ToDouble(Console.ReadLine());
        Divider();
        double c = Math.Sqrt(a * a + b * b);
        Console.WriteLine("Гіпотенуза: " + c);
    }
    static void TaskEleven()
    {
        Console.WriteLine("Task №11");
        Console.WriteLine("Створіть програму, яка запитує в користувача кількість грошей в доларах та перетворює їх в євро за поточним курсом.\n");
        double exchengeRate = 0.92;
        Console.Write("Введіть кількість грошей у доларах: ");
        double amounthInDollars = Convert.ToDouble(Console.ReadLine());
        Divider();
        double amounthInEuro = amounthInDollars * exchengeRate;
        Console.WriteLine("Гроші у євро: " + amounthInEuro);
    }
    static void TaskTwelve()
    {
        Console.WriteLine("Task №12");
        Console.WriteLine("Створіть програму, яка запитує в користувача його зріст у футах та дюймах, а потім перетворює його в сантиметри за формулою 1 фут = 30.48 см, 1 дюйм = 2.54 см.\n");
        const double cmPerFoot = 30.48;
        const double cmPerInch = 2.54;
        Console.Write("Введіть ваш зріст у фунтах: ");
        double feet = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine();
        Console.Write("Введіть ваш зріст у дюймах: ");
        double inches = Convert.ToDouble(Console.ReadLine());
        Divider();
        double heightInCm = (feet * cmPerFoot) + (inches * cmPerInch);
        Console.WriteLine("Ваш зріст у см: " + heightInCm);

        {

        }
    }


    static void Main()
    {
        Console.OutputEncoding = UTF8Encoding.UTF8;
        Divider();
        TaskOne();
        Divider();
        TaskTwo();
        Divider();
        TaskThree();
        Divider();
        TaskFour();
        Divider();
        TaskFive();
        Divider();
        TaskSix();
        Divider();
        TaskSeven();
        Divider();
        TaskEight();
        Divider();
        TaskNine();
        Divider();
        TaskTen();
        Divider();
        TaskEleven();
        Divider();
        TaskTwelve();
        Divider();


        var random = new Random();
        random.NextInt64();
    }
}


