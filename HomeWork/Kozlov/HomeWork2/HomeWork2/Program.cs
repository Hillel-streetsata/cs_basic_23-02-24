using System;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = UTF8Encoding.UTF8;
        FirstTask();
        SecondTask();
        ThirdTask();
        FourthTask();
        FifthTask();
        SixthTask();
        SeventhTask();
        EigthTask();
        NeinthTask();
        TenthTask();
        EleventhTask();
        TwelfthTask();
        ThirteenthTask();
        FourteenththTask();
    }

    static void FirstTask()
    {

        // Завдання 1
        Console.WriteLine("Завдання 1".PadLeft((Console.WindowWidth + "Завдання 1".Length) / 2));

        string word = "Cлово";

        if (word.Length >= 3)
        {
            char thirdLetter = word[2];
            Console.WriteLine("Третій символ: " + thirdLetter);
        }
        else
        {
            Console.WriteLine("Рядок занадто короткий, щоб отримати третій символ.");

        }
    }
    static void SecondTask()
    {

        // Завдання 2
        Console.WriteLine("Завдання 2".PadLeft((Console.WindowWidth + "Завдання 2".Length) / 2));

        string word = "Слово";

        if (word.Length >= 4)
        {

            if (word[1] == word[3])
            {
                Console.WriteLine("Другий і четвертий символи однакові: " + word[1]);
            }
            else
            {
                Console.WriteLine("Другий і четвертий символи різні.");
            }
        }
        else
        {
            Console.WriteLine("Слово занадто коротке для порівняння другого і четвертого символів.");
        }
    }
    static void ThirdTask()
    {

        // Завдання 3
        Console.WriteLine("Завдання 3".PadLeft((Console.WindowWidth + "Завдання 3".Length) / 2));

        string clubName = "Шахтар";


        foreach (char symbol in clubName)
        {
            Console.WriteLine(symbol);
        }
    }
    static void FourthTask()
    {

        // Завдання 4
        Console.WriteLine("Завдання 4".PadLeft((Console.WindowWidth + "Завдання 4".Length) / 2));

        string s1 = "Слово";
        string s2 = "";

        // Проходимо по кожній літері слова s1
        for (int i = 0; i < s1.Length; i++)
        {
            // Додаємо до s2 літери з непарними індексами
            if (i % 2 != 0)
            {
                s2 += s1[i];
            }
        }

        Console.WriteLine("s2, утворене непарними літерами слова s1: " + s2);
    }
    static void FifthTask()
    {

        // Завдання 5
        Console.WriteLine("Завдання 5".PadLeft((Console.WindowWidth + "Завдання 5".Length) / 2));

        string text = "2+2=4 та 2*2=4, але 3+3=6 та 3*3=9";

        int plusCount = 0;
        int starCount = 0;


        foreach (char symbol in text)
        {
            if (symbol == '+')
            {
                plusCount++;
            }
            else if (symbol == '*')
            {
                starCount++;
            }
        }

        Console.WriteLine("Кількість символів '+': " + plusCount);
        Console.WriteLine("Кількість символів '*': " + starCount);

    }
    static void SixthTask()
    {

        // Завдання 6
        Console.WriteLine("Завдання 6".PadLeft((Console.WindowWidth + "Завдання 6".Length) / 2));

        string text = "Тут текст у котрому всі літери 'е' буде замінено на 'і' ";


        string modifiedText = text.Replace('е', 'і'); // Заміна всіх букв "е" на "і"

        Console.WriteLine("Оригінальний текст: " + text);
        Console.WriteLine("Текст після зaміни: " + modifiedText);

    }
    static void SeventhTask()
    {

        // Завдання 7
        Console.WriteLine("Завдання 7".PadLeft((Console.WindowWidth + "Завдання 7".Length) / 2));

        string text = "Тут текст у котрому всі пробіли буде замінено на '_'";


        string modifiedText = text.Replace(' ', '_'); // Заміна всіх пробілів на "_"

        Console.WriteLine("Оригінальний текст: " + text);
        Console.WriteLine("Текст після зaміни: " + modifiedText);

    }
    static void EigthTask()
    {

        // Завдання 8
        Console.WriteLine("Завдання 8".PadLeft((Console.WindowWidth + "Завдання 8".Length) / 2));

        string text = "Число 45 більше ніж число 34";

        Console.WriteLine("Цифри у тексті:");


        foreach (char symbol in text)
        {

            if (Char.IsDigit(symbol))
            {
                Console.WriteLine(symbol);
            }
        }
    }
    static void NeinthTask()
    {

        // Завдання 9
        Console.WriteLine("Завдання 9".PadLeft((Console.WindowWidth + "Завдання 9".Length) / 2));

        string text = "У тексті є цифри 1239, 31, 34, 120";

        int sum = 0;
        int max = int.MinValue;


        foreach (char symbol in text)
        {

            if (Char.IsDigit(symbol))
            {
                int number = symbol - '0';


                sum += number;


                if (number > max)
                {
                    max = number;
                }
            }
        }


        Console.WriteLine("Сума цифр у тексті: " + sum);
        Console.WriteLine("Максимальна цифра у тексті: " + max);
    }
    static void TenthTask()
    {

        // Завдання 10
        Console.WriteLine("Завдання 10".PadLeft((Console.WindowWidth + "Завдання 10".Length) / 2));

        string[] country = new string[3];
        string[] capital = new string[3];


        for (int i = 0; i < country.Length; i++)
        {
            Console.Write("Введіть назву держави: ");
            country[i] = Console.ReadLine();

            Console.Write("Введіть назву столиці цієї держави: ");
            capital[i] = Console.ReadLine();
        }


        for (int i = 0; i < country.Length; i++)
        {
            Console.WriteLine("Столиця держави " + country[i] + " — місто " + capital[i]);
        }
    }
    static void EleventhTask()
    {

        // Завдання 11
        Console.WriteLine("Завдання 11".PadLeft((Console.WindowWidth + "Завдання 11".Length) / 2));


        Console.WriteLine("Введіть три слова:");
        string word1 = Console.ReadLine();
        string word2 = Console.ReadLine();
        string word3 = Console.ReadLine();


        char[] chars1 = word1.ToCharArray();
        char[] chars2 = word2.ToCharArray();
        char[] chars3 = word3.ToCharArray();


        var Letters = chars1.Intersect(chars2).Intersect(chars3);


        Console.WriteLine("Загальні літери в трьох словах:");
        foreach (char letter in Letters)
        {
            Console.WriteLine(letter);
        }
    }
    static void TwelfthTask()
    {

        // Завдання 12
        Console.WriteLine("Завдання 12".PadLeft((Console.WindowWidth + "Завдання 12".Length) / 2));


        string sentence = "Тут буде написанно 10 слів (м'яч, футболист, баскетболист, літак, авто)";


        string[] words = sentence.Split(' ');


        if (words.Length == 10)
        {

            Console.WriteLine("Слова з пропозиції:");
            foreach (string word in words)
            {
                Console.WriteLine(word);
            }
        }
        else
        {
            Console.WriteLine("Помилка: кількість слів у пропозиції не дорівнює 10.");
        }
    }
    static void ThirteenthTask()
    {

        // Завдання 13
        Console.WriteLine("Завдання 13".PadLeft((Console.WindowWidth + "Завдання 13".Length) / 2));


        string text = "мама мила раму";


        string[] words = text.Split(' ');


        Console.WriteLine("Текст у зворотному порядку слів:");
        for (int i = words.Length - 1; i >= 0; i--)
        {
            Console.Write(words[i] + " ");


        }
    }
    static void FourteenththTask()
    {

        // Завдання 14
        Console.WriteLine("Завдання 14".PadLeft((Console.WindowWidth + "Завдання 14".Length) / 2));


        string text = "Всим привіт! Під кінець курсу у вас буде залікова. Використовувати можна все що вивчили, та навіть більше. Здебільшого тут використання всього алгоритмичного арсеналу, що вивчали, методів та можливо використання ООП (в легкому варіанті). Наразі ваша задача вибрати одну тему з перерахованих. Це ваша залікова робота.";


        string[] words = text.Split(new char[] { ' ', ',', '.', '!', '?', '-', ';', ':', '(', ')', '\"', '\'' }, StringSplitOptions.RemoveEmptyEntries);


        int startsWithN = 0;
        int endsWithR = 0;

        foreach (string word in words)
        {

            if (word.StartsWith("н", StringComparison.OrdinalIgnoreCase))
            {
                startsWithN++;
            }


            if (word.EndsWith("р", StringComparison.OrdinalIgnoreCase))
            {
                endsWithR++;
            }
        }


        Console.WriteLine("Кількість слів, що починаються з літери 'н': " + startsWithN);
        Console.WriteLine("Кількість слів, що закінчуються літерою 'р': " + endsWithR);

    }
}
