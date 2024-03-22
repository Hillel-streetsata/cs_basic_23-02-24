namespace Homework1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1.Вiдобразити число Пi рiзними способами");
            Console.WriteLine("-----------------------");
            VariablePi();



            static void VariablePi() /*1.Вiдобразити число Пi рiзними способами*/
            {


                float pi = (float)Math.PI;
                Console.WriteLine("Число пi: " + Math.PI);


                double Pi = Math.PI;
                Console.WriteLine("Число Пi: " + pi);

            }
            Console.WriteLine("--------------------------");
            Console.WriteLine("2. Характеристики Пк");
            Console.WriteLine("--------------------------");

            SystemSpec();

            static void SystemSpec() /*2.Характерристики ПК*/
            {
                Console.WriteLine("OC: " + Environment.OSVersion);
                Console.WriteLine("пользователь: " + Environment.UserName);
                Console.WriteLine("Поточна дериктория: " + Environment.CurrentDirectory);
            }

            Console.WriteLine("--------------------------");
            Console.WriteLine("3. Сантиметри в метри");
            Console.WriteLine("--------------------------");

            SentimetersToMeters();

            static void SentimetersToMeters() /*3. Сантиметры в метры*/
            {
                try
                {
                    Console.WriteLine("Введите сантиметры:");
                    double centimeters = Convert.ToDouble(Console.ReadLine());
                    double meters = centimeters / 100;
                    Console.WriteLine("буде " + meters + " метров");
                }
                catch (FormatException)
                {
                    Console.WriteLine("введіть число.");
                }
            }

            Console.WriteLine("--------------------------");
            Console.WriteLine("4. 234 дней в полные недели");
            Console.WriteLine("--------------------------");

            WeeksInDays();

            static void WeeksInDays() /*4. 234 дней в полные недели*/
            {

                int days = 234;

                int weeks = days / 7;

                Console.WriteLine("За " + days + " дней прошло " + weeks + " недель");


            }

            Console.WriteLine("--------------------------");
            Console.WriteLine("5.Прямоугольник размерами 543 х 130 мм. Скільки квадратів зі стороною 130 мм можна з нього вирізати? ");
            Console.WriteLine("--------------------------");

            RectangleDementions();

            static void RectangleDementions() /*5. Наведено прямокутник з розмірами 543 х 130 мм. Скільки квадратів зі стороною 130 мм можна з нього вирізати?*/
            {


                int lengthRectangle = 543;
                int widthRectangle = 130;
                int sideSquare = 130;

                int areaRectangle = lengthRectangle * widthRectangle;
                int areaSquare = sideSquare * sideSquare;

                int numberOfSquares = areaRectangle / areaSquare;

                Console.WriteLine(numberOfSquares + " квадратов");
            }

            Console.WriteLine("--------------------------");
            Console.WriteLine("6. Середне арифметичне двух чисел ");
            Console.WriteLine("--------------------------");


            MiddleNumber();

            static void MiddleNumber() /*6. Середне арифметичне двух чисел*/
            {
                try
                {
                    Console.Write("Первое число:");

                    double number1 = Convert.ToDouble(Console.ReadLine());

                    Console.Write("Второе число:");
                    double number2 = Convert.ToDouble(Console.ReadLine());

                    double average = (number1 + number2) / 2;

                    Console.WriteLine("Середнє арифметичне " + average);
                }
                catch (FormatException)
                {
                    Console.WriteLine("введіть число.");
                }

            }

            Console.WriteLine("--------------------------");
            Console.WriteLine("7.Квадрат числа ");
            Console.WriteLine("--------------------------");

            SquareNumber();

            static void SquareNumber() /*7.Квадрат числа*/
            {
                try
                {
                    Console.WriteLine("Введите число:");
                    double number = Convert.ToDouble(Console.ReadLine());

                    double square = Math.Pow(number, 2);

                    Console.WriteLine("Квадрат числа " + number + " равно " + square);
                }
                catch (FormatException)
                {
                    Console.WriteLine("введіть число.");
                }


            }

            Console.WriteLine("--------------------------");
            Console.WriteLine("8.Створіть програму, яка запитує в користувача два числа та виводить на екран їх суму, різницю, добуток та частку. ");
            Console.WriteLine("--------------------------");

            TwoNumbersSum();

            static void TwoNumbersSum() /*8.Створіть програму, яка запитує в користувача два числа та виводить на екран їх суму, різницю, добуток та частку.*/
            {

                try
                {
                    Console.WriteLine("Первое число:");
                    double number1 = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Второе число:");
                    double number2 = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Сума: " + (number1 + number2));
                    Console.WriteLine("Різниця: " + (number1 - number2));
                    Console.WriteLine("Добуток: " + (number1 * number2));
                    Console.WriteLine("Частка: " + (number1 / number2));
                }
                catch (FormatException)
                {
                    Console.WriteLine("введіть число.");
                }





            }


            Console.WriteLine("--------------------------");
            Console.WriteLine("9. Створіть програму, яка запитує в користувача його рік народження та обчислює його вік.");
            Console.WriteLine("--------------------------");

            YearOfBirth();

            static void YearOfBirth() /*9. Створіть програму, яка запитує в користувача його рік народження та обчислює його вік.*/
            {



                try
                {
                    Console.WriteLine("Год рождения:");

                    int yearOfBirth = Convert.ToInt32(Console.ReadLine());

                    int currentYear = DateTime.Now.Year;

                    int age = currentYear - yearOfBirth;


                    Console.WriteLine("Ваш вік: " + age);
                }
                catch (FormatException)
                {
                    Console.WriteLine("введіть число.");
                }


            }

            Console.WriteLine("--------------------------");
            Console.WriteLine("11.Конвертор валюти");
            Console.WriteLine("--------------------------");

            HypotenuseSquare();

            static void HypotenuseSquare() /*11.Конвертор валюти*/
            {
                try
                {
                    Console.WriteLine("Кількість долларів:");
                    double dollars = Convert.ToDouble(Console.ReadLine());

                    double exchangeRate = 38.23;

                    double uah = dollars * exchangeRate;

                    Console.WriteLine(uah + " Гривень");
                }
                catch (FormatException)
                {
                    Console.WriteLine("введіть число.");
                }

            }


            Console.WriteLine("--------------------------");
            Console.WriteLine("12.Створіть програму, яка запитує в користувача його зріст у футах та дюймах");
            Console.WriteLine("--------------------------");


            UsaSystemtoCm();

            static void UsaSystemtoCm() /*12.Створіть програму, яка запитує в користувача його зріст у футах та дюймах*/
            {

                try
                {
                    Console.Write("Зріст у футах:");
                    double feet = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Зріст у дюймах:");
                    double inches = Convert.ToDouble(Console.ReadLine());

                    double cmPerFoot = 30.48;
                    double cmPerInch = 2.54;

                    double totalHeightCm = (feet * cmPerFoot) + (inches * cmPerInch);

                    Console.WriteLine("Ваш зріст у сантиметрах: " + totalHeightCm);
                }
                catch (FormatException)
                {
                    Console.WriteLine("введіть число.");
                }





            }



        }
    }
}