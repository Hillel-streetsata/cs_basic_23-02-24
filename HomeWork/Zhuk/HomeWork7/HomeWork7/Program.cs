using System;

class Program
{
    static void Main()
    {
        FirstTask();
        SecondTask();
        ThirdTask();
        FourthTask();
        FifthTask();
        SixthTask();
        SeventhTask();
        EighthTask();
        NinethTask();
        TenthTask();
        EleventhTask();
        TwelfthTask();
        ThirteenthTask();
        FourteenthTask();
    }


    //1. Дане слово. Вивести на екран його третій символ.

    static void FirstTask()
    {

        //Console.WriteLine("Введіть будь-яке слово:  ");
        //string wordStr = Console.ReadLine();

        //if (wordStr.Length < 3)
        //{
        //    Console.WriteLine("Введіть слово, яке складається з більше ніж 2 символи.");
        //    return;
        //}

        //Console.WriteLine("Третій символ вашого слова:  " + wordStr[2]);

    }

    //2. Дане слово. Визначити, чи однакові другий і четвертий символи у ньому.

    static void SecondTask()
    {
        //try
        //{
        //    Console.WriteLine("Bведіть будь-яке слово:  ");
        //    string compareElementsStr = Console.ReadLine();

        //    if (compareElementsStr[1] == compareElementsStr[3])
        //    {
        //        Console.WriteLine("Eлемент 2 у вашому слові дорівнює елементу 4 ");
        //    }
        //    else
        //    {
        //        Console.WriteLine("Eлемент 2 у вашому слові не дорівнює елементу 4 ");
        //    }
        //}

        //catch (Exception ex)
        //{
        //    Console.WriteLine("Недостатньо велике слово.");
        //}
    }

    //3. Дана назва футбольного клубу. Надрукувати його на екрані "стовпчиком".

    static void ThirdTask()
    {
        //    try
        //    {

        //        string[] clubsStr = { "Динамо", "Шахтар", "Дніпро", "Карпати", "Таврія", "Чорноморець " };

        //        Console.WriteLine("Введіть число від 1 до 6, щоб вибрати футбольну команду:  ");

        //        int clubNum = int.Parse(Console.ReadLine());

        //        if (clubNum >= 1 && clubNum <= 6)
        //        {
        //            Console.WriteLine();
        //            foreach (char letter in clubsStr[clubNum - 1])
        //            {
        //                Console.WriteLine("Виведення стовпчиком: " + letter);
        //            }
        //        }
        //        else
        //        {
        //            Console.WriteLine("Введене число не відповідає жодній команді.");
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine(ex.Message);
        //    }

    }


    //4. Дане слово s1. Отримати слово s2, утворене непарними літерами слова s1

    static void FourthTask()
    {
        //try
        //{
        //    Console.WriteLine("Введіть слово:  ");
        //    string s1Str = Console.ReadLine();
        //    string s2Str = " ";

        //    for (int i = 0; i < s1Str.Length; i += 2)
        //    {
        //        s2Str += s1Str[i];

        //    }
        //    Console.WriteLine("S2 слово:  " + s2Str);
        //}
        //catch (Exception ex)
        //{
        //    Console.WriteLine(ex.Message);
        //}
    }

    //5. Даний текст. Скільки разів у ньому є символ "+" і скільки разів символ "*"?

    static void FifthTask()
    {
        //try
        //{
        //    int plusCount = 0;
        //    int starCount = 0;

        //    Console.WriteLine("Введіть текст:  ");
        //    string textCountStr = Console.ReadLine();

        //    for (int i = 0; i < textCountStr.Length; i++)
        //    {
        //        if (textCountStr[i] == '+')
        //        {
        //            plusCount++;
        //        }
        //        else if (textCountStr[i] == '*')
        //        {
        //            starCount++;
        //        }
        //    }
        //    Console.WriteLine("Кількість символів '+' в тексті: " + plusCount);
        //    Console.WriteLine("Кількість символів '*' в тексті: " + starCount);


        //}
        //catch (Exception ex)
        //{
        //    Console.WriteLine(ex.Message);
        //}

    }

    // 6. Даний текст. Всі букви е в ньому замінити літерою і.

    static void SixthTask()
    {
        //try
        //{
        //    Console.WriteLine("Введіть текст: ");
        //    string textChangeStr = Console.ReadLine();

        //    char[] characters = textChangeStr.ToCharArray();

        //    for ( int i = 0; i < characters.Length; i++)
        //    {
        //        if (characters[i] == 'e')
        //        {
        //            characters[i] = 'i';
        //        }

        //    }
        //    string newTextStr = new string(characters);

        //    Console.WriteLine("Текст зі зміненою 'е' на 'i':" + newTextStr);

        //}

        //catch (Exception ex)
        //{
        //    Console.WriteLine(ex.Message);
        //}

    }

    //7. Даний текст. Усі пробіли у ньому замінити символом "_".

    static void SeventhTask()
    {
        //try
        //{
        //    Console.WriteLine("Введіть текст: ");
        //    string textStr = Console.ReadLine();

        //    string new2TextStr = textStr.Replace(' ', '_');
        //    /*Метод Replace() використовується для заміни всіх входжень певного символу 
        //    Передаємо два аргументи методу Replace(): перший аргумент - це символ, який шукаємо у рядку (' ' - пробіл),
        //    і другий аргумент - це символ, яким замінюємо кожне входження першого символу ('_' - символ "_").*/

        //    Console.WriteLine("Текст зі зміненими пробілами:" + new2TextStr);

        //}
        //catch (Exception ex)
        //{
        //    Console.WriteLine(ex.Message);
        //}

    }

    //8. Даний текст. Надрукувати всі наявні в ньому цифри.

    static void EighthTask()
    {
        //try
        //{
        //    Console.WriteLine("Введіть текст: ");
        //    string numTextStr = Console.ReadLine();

        //    for (int i = 0; i < numTextStr.Length; i++)
        //    {
        //        if (char.IsDigit(numTextStr[i]))
        //        {
        //            Console.WriteLine("Всі наявні в тексті цифри: " + numTextStr[i]);
        //        }
        //    }
        //}
        //catch (Exception ex)
        //{
        //    Console.WriteLine(ex.Message);
        //}
    }

    //9. Даний текст, у якому є цифри. а) Знайти їхню суму. б) Знайти максимальну цифру

    static void NinethTask()
    {
        //try
        //{
        //    Console.WriteLine("Введіть текст: ");
        //    string textNumStr = Console.ReadLine();

        //    int sum = 0;
        //    int maxDigit = 0;

        //    foreach (char symbol in textNumStr)
        //    {
        //        if(char.IsDigit(symbol))
        //        {
        //            int digit = int.Parse(symbol.ToString());

        //            sum += digit;
        //            if (digit > maxDigit)
        //            {
        //                maxDigit = digit;

        //            }
        //        }

        //    }
        //    Console.WriteLine("Сума всіх чисел: " + sum);
        //    Console.WriteLine("Максимальна цифра: " + maxDigit);
        //}

        //catch (Exception ex)
        //{
        //    Console.WriteLine(ex.Message);
        //}
    }

    //10. Скласти програму, яка запитує назву держави та її столиці, а потім виводить повідомлення:
    //"Столиця держави... — місто..."(на місці багатокрапок мають бути виведені відповідні значення).
    //Спробувати вирішити за допомогою масивів або swtich/case

    static void TenthTask()
    {
        //Console.WriteLine("Введіть назву держави:");
        //string country = Console.ReadLine();

        //string capital;

        //switch (country)
        //{
        //    case "Україна":
        //        capital = "Київ";
        //        break;
        //    case "США":
        //        capital = "Вашингтон";
        //        break;
        //    case "Франція":
        //        capital = "Париж";
        //        break;
        //    case "Німеччина":
        //        capital = "Берлін";
        //        break;
        //    case "Італія":
        //        capital = "Рим";
        //        break;
        //    case "Іспанія":
        //        capital = "Мадрид";
        //        break;
        //    case "Велика Британія":
        //        capital = "Лондон";
        //        break;
        //    case "Польща":
        //        capital = "Варшава";
        //        break;
        //    case "Швеція":
        //        capital = "Стокгольм";
        //        break;
        //    case "Данія":
        //        capital = "Копенгаген";
        //        break;
        //    default:
        //        capital = "не відомо";
        //        break;
        //}

        //Console.WriteLine($"Столиця держави {country} — місто {capital}");
    }

    //11. Дано три слова. Надрукувати їх великі літери. Літери, що повторюються, кожного слова не розглядати.

    static void EleventhTask()
    {
        //    try
        //    {
        //        Console.WriteLine("Введiть перше слово, використовуючи великi лiтери:");
        //        string word1Str = Console.ReadLine();

        //        Console.WriteLine("Введіть друге слово, використовуючи великі літери:");
        //        string word2Str = Console.ReadLine();

        //        Console.WriteLine("Введіть третє слово, використовуючи великі літери:");
        //        string word3Str = Console.ReadLine();

        //        string allWords = word1Str + word2Str + word3Str;

        //        string uniqueUpperCaseLetters = "";

        //        foreach (char letter in allWords)
        //        {

        //            int firstIndex = allWords.IndexOf(letter);
        //            int lastIndex = allWords.LastIndexOf(letter);

        //            if (char.IsUpper(letter) && firstIndex == lastIndex)
        //            {
        //                uniqueUpperCaseLetters += letter;
        //            }   
        //        }
        //        Console.WriteLine("Всі унікальні великі літери, введені користувачем: " + uniqueUpperCaseLetters);
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine(ex.Message);
        //    }
    }

    //12. Дана пропозиція із 10 слів. Заповнити ними масив із 10 елементів.

    static void TwelfthTask()
    {
        //try
        //{
        //    Console.WriteLine("Введіть пропозицію, що складається з 10 слів:");
        //    string sentence = Console.ReadLine();

        //    string[] words = sentence.Split(' ');

        //    if (words.Length != 10)
        //    {
        //        Console.WriteLine("Введіть пропозицію, яка містить рівно 10 слів.");
        //        return;
        //    }

        //    Console.WriteLine("Введені слова: ");
        //    foreach (string word in words)
        //    {
        //        Console.Write( word + " ");
        //    }
        //}
        //catch (Exception ex)
        //{
        //    Console.WriteLine(ex.Message);
        //}
    }

    //13. Даний текст. Надрукувати його у зворотному порядку слів, наприклад, пропозиція мама мила раму має бути надруковано у вигляді раму мила мама.

    static void ThirteenthTask()
    {
        //    try
        //    {
        //        Console.WriteLine("Введіть текст: ");
        //        string textReverseStr = Console.ReadLine();

        //        string[] wordsStr = textReverseStr.Split(' ');

        //        Console.WriteLine("Текст у зворотньому порядку слів:");
        //        for (int i = wordsStr.Length - 1; i >= 0; i--)
        //        {
        //            Console.Write( wordsStr[i] + " ");
        //        }
        //        Console.WriteLine();


        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine(ex.Message);
        //    }
    }

    //14. Даний текст. Визначити: а) кількість слів, що починаються з літери н; б) кількість слів, що закінчуються літерою р.

    static void FourteenthTask()
    {
        //try
        //{
        //    Console.WriteLine("Введіть текст:");
        //    string textCountStr = Console.ReadLine();

        //    string[] words = textCountStr.Split(' ');

        //    int countWordsStartWithN = 0;
        //    int countWordsEndWithR = 0;

        //    foreach (string word in words)
        //    {
        //        if (!string.IsNullOrEmpty(word))
        //        {
        //            if (word[0] == 'н')
        //            {
        //                countWordsStartWithN++;
        //            }

        //            if (word[word.Length - 1] == 'р')
        //            {
        //                countWordsEndWithR++;
        //            }
        //        }
        //    }

        //    Console.WriteLine("Кількість слів, що починаються з 'н': " + countWordsStartWithN);
        //    Console.WriteLine("Кількість слів, що закінчуються на 'р': " + countWordsEndWithR);
        //}
        //catch (Exception ex)
        //{
        //    Console.WriteLine(ex.Message);
        //}
    }

}