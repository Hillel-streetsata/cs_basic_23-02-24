﻿using System.Threading.Channels;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main()
        {
            NumberPi();
            SysInfo();
            CenInMetrs();
            YearCalendar();
            Rectangle();
            ArithmeticMean();
            SqNumber();
            OperWithNumbers();
            YearsOperations();
            Gipotenuse();
            DollarToEuro();
            Zrist();
        }
        static void NumberPi()
        {
            Console.WriteLine("Task 1");

            Console.WriteLine(double.Pi);

            double Pi = Math.PI;
            Console.WriteLine("Число Пi: " + Pi);

            Console.WriteLine("--------------");
        }
        static void SysInfo()
        {
            Console.WriteLine("Task 2");

            Console.WriteLine("___PC-Info___");
            string osVersion = Environment.OSVersion.ToString();
            Console.WriteLine($"Операцiйна система: {osVersion}"); ; // про $ взнав від знайомого сінйора, кльова штука:)

            Console.WriteLine("--------------");
        }
        static void CenInMetrs()
        {
            Console.WriteLine("Task 3");

            Console.Write("Введiть кiлькiсть сантиметрiв: ");
            int centimeters = Convert.ToInt32(Console.ReadLine());
            int meters = centimeters / 100;
            Console.WriteLine($"Повних метрiв стiльки -> {meters}м.");

            Console.WriteLine("--------------");
        }
        static void YearCalendar()
        {
            Console.WriteLine("Task 4");

            int days = 234;
            int weeks = days / 7;

            Console.WriteLine($"Пройшло {weeks} повних тижня(-iв).");

            Console.WriteLine("--------------");
        }
        static void Rectangle()
        {
            Console.WriteLine("Task 5");

            double storonaRect = 543;
            double storonaCube = 130;
            double fullCubesIn = storonaRect / storonaCube;

            Console.WriteLine($"Повних кубiв помiстилось -> {fullCubesIn}");

            Console.WriteLine("--------------");
        }
        static void ArithmeticMean()
        {
            Console.WriteLine("Task 6");

            Console.Write("Введiть перше число: ");
            double firstNumber = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введiть друге число: ");
            double secondNumber = Convert.ToInt32(Console.ReadLine());

            double arithMean = (firstNumber + secondNumber) / 2;

            Console.WriteLine($"Середнє арифметичне = {arithMean}");

            Console.WriteLine("--------------");
        }
        static void SqNumber()
        {
            Console.WriteLine("Task 7");

            Console.Write("Введiть ваше число, щоб порахувати: ");
            double yourNumber = Convert.ToInt32(Console.ReadLine());

            double yourNumberInSq = Math.Pow(yourNumber, 2);
            Console.WriteLine($"Ваше число -> {yourNumberInSq}");

            Console.WriteLine("--------------");
        }
        static void OperWithNumbers()
        {
            Console.WriteLine("Task 8");

            Console.Write("Введiть перше число: ");
            double firstNumber = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введiть друге число: ");
            double secondNumber = Convert.ToInt32(Console.ReadLine());

            double sum = firstNumber + secondNumber;
            double multiplication = firstNumber * secondNumber;
            double dividing = firstNumber / secondNumber;
            double subtraction = firstNumber - secondNumber;

            Console.WriteLine($"Ось результати додавання - {sum}, множення {multiplication}, дiлення {dividing} та вiднiмання {subtraction}.");

            Console.WriteLine("--------------");
        }
        static void YearsOperations()
        {
            Console.WriteLine("Task 9");

            Console.Write("Введiть, будь ласка, ваш рiк народження: ");
            int candYear = Convert.ToInt32(Console.ReadLine());

            int currentYear = 2024;
            int yourAge = currentYear - candYear;

            if (yourAge > 65) { Console.WriteLine($"Холера, яке ти старе, по тобi могила плаче:), тобi aж {yourAge} рокiв."); }
            if (yourAge < 65) { Console.WriteLine($"Холера, Ти шооо, тобi аж {yourAge}, до ТЦК вам туди -> 'Будiвля ТЦК'."); }

            Console.WriteLine("--------------");
        }
        static void Gipotenuse()
        {
            Console.WriteLine("Task 10");

            Console.Write("Введiть довжину першого катета: ");
            double firstGypNumber = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введiть довжину другого катета: ");
            double secondGypNumber = Convert.ToInt32(Console.ReadLine());

            double gypotenysa = Math.Sqrt(Math.Pow(firstGypNumber, 2) + Math.Pow(secondGypNumber, 2));

            Console.WriteLine($"Ось ваша гiпотенуза - {gypotenysa} одиниць вимiрювання!");

            Console.WriteLine("--------------");
        }
        static void DollarToEuro()
        {
            Console.WriteLine("Task 11");

            Console.Write("Введiть суму обмiну: ");
            double dollarHere = Convert.ToInt32(Console.ReadLine());

            double euro = 0.78;

            double dollarToEuros = dollarHere * euro;

            Console.WriteLine($"Money,Money,Money - {dollarToEuros} Euros.");

            Console.WriteLine("--------------");
        }
        static void Zrist()
        {
            Console.WriteLine("Task 12");

            Console.Write("Введiть ваш зрiст у футах: ");
            double footHeight = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введiть ваш зрiст у дюймах: ");
            double inchHeight = Convert.ToDouble(Console.ReadLine());

            double footInCent = 30.48;

            double inchInCent = 2.54;

            double fullFootInCentHeight = footHeight * footInCent;

            double fullInchInCentHeight = inchHeight * inchInCent;

            Console.WriteLine($"Твоя висота у сантиметрах в переводi з футiв - {fullFootInCentHeight}см та в переводi з дюймiв {fullInchInCentHeight}см.");

            Console.WriteLine("--------------");
        }
    }
}
