
using System;
using System.Text;

namespace Homework7
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Console.InputEncoding = Encoding.UTF8;
            //Console.OutputEncoding = Encoding.UTF8;


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
            TaskTwelve();
        }


        static void Divider()
        {
            Console.WriteLine(new string('-', 32));
        }


        static void TaskOne()
        {

            Console.WriteLine("1. Дане слово. Вивести на екран його третій символ.");

            Console.WriteLine("\nВведите слово:");
            string word = Console.ReadLine();

            if (word.Length >= 3)
            {
                char thirdCharacter = word[2];
                Console.WriteLine("\nТретья Буква: " + thirdCharacter);
            }
            else
            {
                Console.WriteLine("Слово меньше трех букв .");
            }

        }

        static void TaskTwo()
        {
            Console.WriteLine("2. Дане слово. Визначити, чи однакові другий і четвертий символи у ньому.");

            Console.WriteLine("\nВведите слово:");
            string word = Console.ReadLine();

            if (word.Length >= 4)
            {
                if (word[2] == word[4])
                {
                    Console.WriteLine("\nВторая и четвертая буква одинаковы");
                }
                else
                {
                    Console.WriteLine("\nВторая и четрветная буква разные");
                }
            }
        }


        static void TaskThree()
        {
            Console.WriteLine("3. Дана назва футбольного клубу. Надрукувати його на екрані \"стовпчиком\"..");

            try
            {
                Console.WriteLine("\nВведите название футбольного клуба:");
                string clubName = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(clubName))
                {
                    throw new ArgumentException("Имя клуба не модет быть пустое.");
                }

                Console.WriteLine("\nИмя клуба:");

                foreach (char letter in clubName)
                {
                    Console.WriteLine(letter);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ошибка: " + ex.Message);
            }
        }


        static void TaskFour()
        {
            Console.WriteLine("4. Дане слово s1. Отримати слово s2, утворене непарними літерами слова s1.");

            Console.WriteLine("\nВведите слово:");
            string s1 = Console.ReadLine();

            string s2 = GetOddLetters(s1);
            Console.WriteLine("\nСлово, состоящее из нечетных букв слова {0}:", s1);
            Console.WriteLine(s2);
        }

        static string GetOddLetters(string input)
        {
            string result = "";
            for (int i = 0; i < input.Length; i++)
            {

                if (i % 2 == 0)
                {
                    result += input[i];
                }
            }
            return result;
        }


        static void TaskFive()
        {
            Console.WriteLine("5. Даний текст. Скільки разів у ньому є символ \"+\" і скільки разів символ \"*\"?.");

            Console.WriteLine("\nВведите текст:");
            string text = Console.ReadLine();

            int countPlus = 0;
            int countStar = 0;

            foreach (char symbol in text)
            {
                if (symbol == '+')
                {
                    countPlus++;
                }
                else if (symbol == '*')
                {
                    countStar++;
                }
            }

            Console.WriteLine("\nКоличество символов '+' в тексте: " + countPlus);
            Console.WriteLine("\nКоличество символов '*' в тексте: " + countStar);
        }


        static void TaskSix()
        {
            Console.WriteLine("6. Даний текст. Всі букви е в ньому замінити літерою і..");

            Console.WriteLine("Введите текст:");
            string text = Console.ReadLine();

            string modifiedText = text.Replace('е', 'и');

            Console.WriteLine("Измененный текст:");
            Console.WriteLine(modifiedText);
        }


        static void TaskSeven()
        {
            Console.WriteLine("7. Даний текст. Усі пробіли у ньому замінити символом \"_\".");

            Console.WriteLine("Введите текст:");
            string text = Console.ReadLine();

            string modifiedText = text.Replace(' ', '_');

            Console.WriteLine("Измененный текст:");
            Console.WriteLine(modifiedText);
        }


        static void TaskEight()
        {

            Console.WriteLine("8. Даний текст. Надрукувати всі наявні в ньому цифри.");

            Console.WriteLine("Введите текст:");
            string text = Console.ReadLine();

            Console.WriteLine("Цифры в тексте:");

            foreach (char symbol in text)
            {
                if (Char.IsDigit(symbol))
                {
                    Console.WriteLine(symbol);
                }
            }
        }


        static void TaskNine()
        {
            Console.WriteLine("9. Даний текст, у якому є цифри. а) Знайти їхню суму. б) Знайти максимальну цифру.");

            Console.WriteLine("Введите текст:");
            string text = Console.ReadLine();

            int sum = 0;
            int maxDigit = int.MinValue;

            foreach (char symbol in text)
            {
                if (Char.IsDigit(symbol))
                {
                    int digit = int.Parse(symbol.ToString());
                    sum += digit;
                    if (digit > maxDigit)
                    {
                        maxDigit = digit;
                    }
                }
            }

            Console.WriteLine("Сумма цифр в тексте: " + sum);
            Console.WriteLine("Максимальная цифра в тексте: " + maxDigit);
        }

        static void TaskTen()
        {
            Console.WriteLine("10. Cтраны и столицы");


            Console.WriteLine("Введите страну:");
            string country = Console.ReadLine();

            string capital;
            switch (country)
            {
                case "Украина":
                    capital = "Киев";
                    break;
                case "США":
                    capital = "Вашингтон";
                    break;
                case "Франция":
                    capital = "Париж";
                    break;
                case "Великобритания":
                    capital = "Лондон";
                    break;
                case "Германия":
                    capital = "Берлин";
                    break;
                case "Испания":
                    capital = "Мадрид";
                    break;
                case "Италия":
                    capital = "Рим";
                    break;
                case "Канада":
                    capital = "Оттава";
                    break;
                case "Китай":
                    capital = "Пекин";
                    break;
                default:
                    capital = "Неизвестно";
                    break;
            }


            Console.WriteLine($"Столица страны {country} — город {capital}.");
        }

        static void TaskTwelve()
        {

            Console.WriteLine("12. Дана пропозиція із 10 слів. Заповнити ними масив із 10 елементів.");

            string[] wordsArray = new string[10];

            wordsArray[0] = "один";
            wordsArray[1] = "два";
            wordsArray[2] = "три";
            wordsArray[3] = "четыре";
            wordsArray[4] = "пять";
            wordsArray[5] = "шесть";
            wordsArray[6] = "семь";
            wordsArray[7] = "восемь";
            wordsArray[8] = "девять";
            wordsArray[9] = "десять";

            Console.WriteLine("Масив с 10 елементов:");
            for (int i = 0; i < wordsArray.Length; i++)
            {
                Console.WriteLine(wordsArray[i]);
            }
        }
    }
    



}