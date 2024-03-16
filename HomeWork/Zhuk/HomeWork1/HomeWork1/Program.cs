using System;

class Program
{
    static void Main()
    {

        FirstTask(); // Викликаю метод FirstTask()
        SecondTask();
        ThirdTask();
        //FourthTask();
        FifthTask();
        SixthTask();
        SeventhTask();
        EighthTask();
        //NinethTask();
        TenthTask();
        EleventhTask();
        TwelfthTask();
    }


    //1. Відобразити число Пі різними способами.
    static void FirstTask()
    {
        //double pi = Math.PI;
        //Console.WriteLine("Число Пі:  " + pi);

        //int num1 = 22;
        //int num2 = 7;
        //double p = (double)num1 / num2;
        //Console.WriteLine("Результат ділення: " + p);
    }


    //    //2. Клас System.Environment. Напишіть програму для відображення інформації про комп'ютер на консолі.
    static void SecondTask()
    {
        //string osVersion = Environment.OSVersion.ToString();
        //Console.WriteLine("Версія операційної системи:  " + osVersion);

        //string machineName = Environment.MachineName;
        //Console.WriteLine("Назва машини:  " + machineName);

        //string userName = Environment.UserName;
        //Console.WriteLine("Поточний користувач:  " + userName);

        //string processorCount = Environment.ProcessorCount.ToString();
        //Console.WriteLine(" Кількість процесорів:  " + processorCount);

        //bool is64BitOperatingSystem = Environment.Is64BitOperatingSystem;
        //Console.WriteLine("Перевірки чи є операційна система 16-ти бітною:  " + is64BitOperatingSystem);
    }


    //    //3. Відстань дається в сантиметрах. Знайдіть в ньому кількість повних метрів.
    static void ThirdTask()
    {
        //Console.Write(" Введіть число, яке позначає сантиметри:  ");
        //int centimeters = Convert.ToInt32(Console.ReadLine());
        //int resultTask3 = centimeters / 100;

        //Console.WriteLine("Кількість повних метрів:  " + resultTask3);

    }

    //    // 4. З якогось моменту минуло 234 дні. Скільки повних тижнів пройшло за цей період?
    //static int FourthTask()
    //{
    //    int days = 234;
    //    int week = 7;

    //    int resultTask4 = days / week;
    //    Console.WriteLine("Кількість тижнів:  " + resultTask4);

    //    return resultTask4;
    //}

    //    //5. Наведено прямокутник з розмірами 543 х 130 мм. Скільки квадратів зі стороною 130 мм можна з нього вирізати?
    static void FifthTask()
    {
        //int height = 130;
        //int width = 543;
        //int areaRetangle = (height * width);
        //Console.WriteLine("Площа прямокутника:  " + areaRetangle);

        //int sideSquare = 130;
        //int areaSquare = (int)Math.Pow(sideSquare, 2);
        //Console.WriteLine("Площа квадрата:  " + areaSquare);

        //int numOfsquare = (areaRetangle / areaSquare);
        //Console.WriteLine("Кількість квадратів:  " + numOfsquare);

    }


    //    //6. Створіть програму, яка обчислює середнє арифметичне двох чисел.
    static void SixthTask()
    {
        //int firstNum = new Random().Next(1, 101);
        //Console.WriteLine($"Перше випадкове число:  {firstNum}");

        //int secondNum = new Random().Next(1, 101);
        //Console.WriteLine($"Друге випадкове число:  {secondNum}");

        //int resTask6 = ((firstNum + secondNum) / 2);
        //Console.WriteLine($"Середнє арифметичне:  {resTask6}");

    }

    //    //7. Створіть програму, яка обчислює квадрат будь-якого введеного числа.
    static void SeventhTask()
    {
        //Console.Write("Введіть число:  ");
        //double num = Convert.ToDouble(Console.ReadLine());

        //double pow = Math.Pow(num, 2);
        //Console.WriteLine("Квадрат введеного числа:  " + pow);
    }


    //    //8. Створіть програму, яка запитує в користувача два числа та виводить на екран їх суму, різницю, добуток та частку.
    static void EighthTask()
    {
        //Console.Write("Введіть перше число:  ");
        //int yourNum1 = Convert.ToInt32(Console.ReadLine());

        //Console.Write("Введіть друге число:  ");
        //int yourNum2 = Convert.ToInt32(Console.ReadLine());

        //int sum = (yourNum1 + yourNum2);
        //Console.WriteLine("Сума двох чисел:  " + sum);

        //int difference = (yourNum1 - yourNum2);
        //Console.WriteLine("Різниця двох чисел:  " + difference);

        //int product = (yourNum1 * yourNum2);
        //Console.WriteLine("Добуток двох чисел:  " + product);

        //int quotient = (yourNum1 / yourNum2);
        //Console.WriteLine(" Частака двох чисел:  " + quotient);

    }


    //    //9. Створіть програму, яка запитує в користувача його рік народження та обчислює його вік.
    //static int NinethTask()
    //{
    //    Console.Write("Введіть рік Вашого народження:  ");
    //    int year = Convert.ToInt32(Console.ReadLine());

    //    int resTask9 = 2024 - year;
    //    Console.WriteLine("Ваш вік:  " + resTask9);
    //    return resTask9;
    //}

    //    //10. Створіть програму, яка запитує в користувача довжину сторін прямокутного трикутника, а потім обчислює його гіпотенузу за формулою c = √(a² + b²).
    static void TenthTask()
    {
        //Console.Write("Введіть довжину одного з катетів:  ");
        //int sideTriangle = Convert.ToInt32(Console.ReadLine());

        //Console.Write("Введіть довжину другого катета:  ");
        //int anotherSideTriangle = Convert.ToInt32(Console.ReadLine());

        //double hypotenuse = Math.Sqrt((sideTriangle * sideTriangle) + (anotherSideTriangle * anotherSideTriangle));
        //Console.WriteLine("Довжина гіпотенузи:  " + hypotenuse);

    }

    //    //11. Створіть програму, яка запитує в користувача кількість грошей в доларах та перетворює їх в євро за поточним курсом.
    static void EleventhTask()
    {
        //Console.Write("Введіть суму в доларах:  ");
        //double sumInDolar = Convert.ToDouble(Console.ReadLine());
        ////1 usd = 0,91 eur

        //double sumInEuro = (sumInDolar / 0.91);
        //Console.WriteLine("Сума в євро:  " + sumInEuro);
    }

    //    //12. Створіть програму, яка запитує в користувача його зріст у футах та дюймах,
    //    //а потім перетворює його в сантиметри за формулою 1 фут = 30.48 см, 1 дюйм = 2.54 см.
    static void TwelfthTask()
    {
        //Console.Write("Введіть ваш зріст у футах:  ");
        //double heightInFT = Convert.ToDouble(Console.ReadLine());

        //Console.Write("Введіть ваш зріст у дюймах:  ");
        //double heightInInch = Convert.ToDouble(Console.ReadLine());

        //double yourHeight1 = (heightInFT * 30.48);
        //double yourHeight2 = (heightInInch * 2.54);
        //double yourHeight = (yourHeight1 + yourHeight2);

        //Console.WriteLine("Ваш зріст у см:  " + yourHeight);
    }

}




