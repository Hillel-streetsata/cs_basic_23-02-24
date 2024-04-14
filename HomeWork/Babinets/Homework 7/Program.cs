using System.ComponentModel.Design;
using System.Diagnostics.CodeAnalysis;
using System.Numerics;
using System.Text.RegularExpressions;
using static System.Runtime.InteropServices.JavaScript.JSType;
class Homework7
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.InputEncoding = System.Text.Encoding.UTF8;
        Console.WriteLine("\n 1.Дане слово. Вивести на екран його третій символ.");
        string num1 = "Found";
        for (int i = 0; i < num1.Length; i++)
        {
            if (i == 3)
            {
                Console.WriteLine("Word - \"found\", the third letter is - " + num1[2]);
            }
        }
        Task2("SLOVO");
    }
    static void Task2(string slovo)
    {
        Console.WriteLine("\n 2.Дане слово. Визначити, чи однакові другий і четвертий символи у ньому.");
        slovo = "SLOVO";
        if (slovo[1] == slovo[3])
        {
            Console.Write($"Дане слово \"{slovo}\" має однакові символи.");
        }
        else
        {
            Console.Write($"Дане словo \"{slovo}\" має різні символи.");
        }
        Task3("Manchester United");
    }
    static void Task3(string football)
    {
        Console.WriteLine("\n 3.Дана назва футбольного клубу. Надрукувати його на екрані стовпчиком.");
        foreach (char s in football)
        {
            Console.WriteLine(s);
        }
        Task4("Strenghts");
    }
    static void Task4(string wordnum1)
    {
        Console.WriteLine("\n 4.Дане слово s1 = \"Strenghts\".Отримати слово s2, утворене непарними літерами слова s1");
        for (int i = 0; i < wordnum1.Length; i++)
        {
            if (i != wordnum1.Length)
            {
                Console.Write(wordnum1[i]);
                i++;
            }
        }
        Task5(0, 0);
    }
    static void Task5(int plus, int product)
    {
        string text = " х + 98; 2) х * 67; 3) 23 + у; 4) (1788 + х) * 89; 5) (х + 67) * 21;";
        Console.WriteLine(" \n\n 5.Даний текст.Скільки разів у ньому є символ \" + \" і скільки разів символ \" * \" ? " + text);
        plus = text.Count(c => c == '+');
        product = text.Count(b => b == '*');
        Console.WriteLine($"\"+\" =  {plus}, \"*\" = {product}");
        Task6();
    }
    static void Task6()
    {
        Console.WriteLine("\n 6.Даний текст.Всі букви е в ньому замінити літерою і.");
        string changetoi = "Мета: Формування поняття рівняння, кореня рівняння (розв'язку); вироблення навичок розв'язування рівнянь за правилами \n знаходження невідомих компонентів додавання і віднімання. Розвивати систематичність і послідовність мислення.\n Виховувати математичну культуру та культуру запису.";
        string changetoi2 = changetoi.Replace("е", "і");
        Console.WriteLine(changetoi2);
        Task7("Мета: Формування поняття рівняння, кореня рівняння (розв'язку); вироблення навичок розв'язування рівнянь за правилами \n знаходження невідомих компонентів додавання і віднімання. Розвивати систематичність і послідовність мислення.\n Виховувати математичну культуру та культуру запису.");
    }
    static void Task7(string changetoi)
    {
        Console.WriteLine("\n 7.Даний текст. Усі пробіли у ньому замінити символом \"_\".");
        string changetospace = changetoi.Replace(" ", "_");
        Console.WriteLine("\n" + changetospace);
        Task8();
    }
    static void Task8()
    {
        Console.WriteLine("\n 8.Даний текст \"Хотіли повідомити, що в пʼятницю, 23.02.2024 о 19:15 за київським часом відбудеться перше заняття з курсу C# Basic. Ваш стандартний розклад – вівторок о 19:15 та пʼятниця о 19:15. Тривалість заняття – 2 години.\". Надрукувати\n всі наявні в ньому цифри.");
        string numbersInText = "Хотіли повідомити, що в пʼятницю, 23.02.2024 о 19:15 за київським часом відбудеться перше заняття з курсу C# Basic.\n Ваш стандартний розклад – вівторок о 19:15 та пʼятниця о 19:15. Тривалість заняття – 2 години.";
        string n = Regex.Replace(numbersInText, "[^0-9]", " ");
        Console.WriteLine(n);
        Task9(numbersInText);
    }
    static void Task9(string numbersInText)
    {
        Console.WriteLine("\n 9.Даний текст, у якому є цифри.а) Знайти їхню суму.б) Знайти максимальну цифру.");
        int sum = 0; int maxvalue = 0; 
        string numbers = "Хотіли повідомити, що в пʼятницю, 23.02.2024 о 19:15 за київським часом відбудеться перше заняття з курсу C# Basic.\n Ваш стандартний розклад – вівторок о 19:15 та пʼятниця о 19:15. Тривалість заняття – 2 години.";
        string n = Regex.Replace(numbers, "[^0-9]", "");
        Console.WriteLine("Cleaned string: " + n);
        foreach (char a in n)
        {
          int value = int.Parse(a.ToString());
            if (maxvalue < value)
            { 
                maxvalue = value;
            }
        }
        Console.WriteLine("Max = " + maxvalue);

        foreach (char a in n)
        {
            sum += int.Parse(a.ToString());
        }
        Console.WriteLine("Сума всіх цифр = " + sum);
        Task10();
    }
    static void Task10()
    {
        try
        {
            Console.WriteLine("\n\n 10.Скласти програму, яка запитує назву держави та її столиці, а потім виводить повідомлення: \"Столиця держави... — місто...\"(на місці багатокрапок мають бути виведені відповідні значення).Спробувати вирішити за допомогою масивів або swtich\\case");
            string country, capital;
            Console.Write("Введіть назву держави: ");
            country = Console.ReadLine();
            Console.Write("Введіть столицю держави: ");
            capital = Console.ReadLine();
            switch (country)
            {
                case "Україна":
                    Console.WriteLine($"Столиця  {country} — місто {capital}");
                    break;
                case "Сполучені Штати Америки":
                    Console.WriteLine($"Столиця  {country} — місто {capital}");
                    break;
                case "Франція":
                    Console.WriteLine($"Столиця  {country} — місто {capital}");
                    break;
                default:
                    Console.WriteLine($"Невідома держава: {country}");
                    break;
            }
        }
        catch (Exception)
        {
            Console.WriteLine(" Ви ввели некоректне значення.");
        }
        Task11();
    }
    static void Task11()
    {
        Console.WriteLine("\n\n 11.Дано три слова.Надрукувати їх загальні літери. Літери, що повторюються, кожного слова не розглядати.");
        string[] words = { "Word", "World", "Vocabulary" };
        Dictionary<char, int> letterCounts = new Dictionary<char, int>();
        foreach (string word in words)
        {
            HashSet<char> uniqueLetters = new HashSet<char>();
            foreach (char letter in word)
            {
                if (!uniqueLetters.Contains(letter))
                {
                    uniqueLetters.Add(letter);
                }
            }
            foreach (char letter in uniqueLetters)
            {
                if (!letterCounts.ContainsKey(letter))
                {
                    letterCounts[letter] = 1;
                }
                else
                {
                    letterCounts[letter]++;
                }
            }
            foreach (var kvp in letterCounts)
            {
                if (kvp.Value == 1)
                {
                    Console.WriteLine(kvp.Key);
                }
            }
        }
        Task12();
    }
    static void Task12()
    {
        Console.WriteLine("\n\n 12.Дана пропозиція із 10 слів.Заповнити ними масив із 10 елементів.");
        string[] tenWords = { "pumpkin", "caprisum", "mushroom", "brinjal", "cauliflower", "beetroot", "yam", "ginger", "leek", "drumstick" };
        foreach (string tenWord in tenWords)
        {
            Console.Write(tenWord + "\t ");
        }
        Task13();
    }
    static void Task13()
    {
        Console.WriteLine("\n\n 13.Даний текст. Надрукувати його у зворотному порядку слів, наприклад, пропозиція мама мила раму має бути надруковано у вигляді раму мила мама.");
        string[] text = { "мама", "мила", "раму" };
        for (int i = text.Length - 1; i >= 0; i--)
        {
            Console.Write(text[i] + " ");
        }
        Task14();
    }
    static void Task14()
    {
        Console.WriteLine("\n\n 14.Даний текст \"Любі друзі! Перший інструмент, який потрібно освоїти у програмуванні — система контролю версій (GIT). GIT дозволяє розробникам мати безліч незалежних гілок коду. Створення, видалення та об'єднання цих гілок відбувається без проблем та великих витрат часу. Все найважливіше про GIT можна вивчити за відеокурсом, розробленим нашою Школою. Словонар\". \n Визначити: а) кількість слів, що починаються з літери н; б) кількість слів, що закінчуються літерою р.");
        string text = "Любі друзі! Перший інструмент, який потрібно освоїти у програмуванні — система контролю версій (GIT). GIT дозволяє розробникам мати безліч незалежних гілок коду. Створення, видалення та об'єднання цих гілок відбувається без проблем та великих витрат часу. Все найважливіше про GIT можна вивчити за відеокурсом, розробленим нашою Школою. Словонар";
        string[] text2 = text.Split(' ', StringSplitOptions.RemoveEmptyEntries);
        char[] a = "н".ToCharArray();
        char[] letterr = "р".ToCharArray();
        int number = 0; int number2 = 0;
        for (int i = 0; i < text2.Length; i++)
        {
            if (text2[i][0] == a[0])
            {
                number++;
            }
            else if (text2[i][text2[i].Length - 1] == letterr[0])
            {
                number2++;
            }
        }
        Console.WriteLine("Number \"н\" = " + number);
        Console.WriteLine("Number \"р\" = " + number2);
    }
}






