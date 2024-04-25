using System;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = UTF8Encoding.UTF8;
        do
        {
            Console.Clear();
            PlayGame();
            Console.WriteLine("Давайте грати ще? <так/ні>");
        } while (Console.ReadLine().Trim().ToLower() == "так");

        Console.WriteLine("Успіхів!");
    }

    static void PlayGame()
    {
        string secretWord = "програмування";
        int maxAttempts = 6;
        int attemptsLeft = maxAttempts;
        string guessedLetters = "";

        string guessedWord = new string('_', secretWord.Length);

        Console.WriteLine("Давайте пограємо в гру в слова? <так/ні>");
        string play = Console.ReadLine().Trim().ToLower();
        if (play != "так")
            return;

        Console.WriteLine($"Вгадай моє таємне слово. Містить {secretWord.Length} букв.");
        Console.WriteLine($"Причому вгадувати можна по одній букві за раз.");
        Console.WriteLine($"Вам дано {maxAttempts} неправильних здогадок.\n");

        while (attemptsLeft > 0 && guessedWord.Contains('_'))
        {
            Console.WriteLine($"Ваше слово: {guessedWord}");
            Console.WriteLine($"Неправильні варіанти: {guessedLetters}");
            Console.WriteLine($"Залишилося {attemptsLeft} неправильних варіантів");
            Console.Write("Вгадайте букву: ");
            string input = Console.ReadLine().Trim().ToLower();

            if (input.Length != 1 || !char.IsLetter(input[0]))
            {
                Console.WriteLine("Будь ласка, введіть одну літеру.");
                continue;
            }

            char guess = input[0];

            if (guessedLetters.Contains(guess))
            {
                Console.WriteLine("Ви вже вводили цю літеру.");
                continue;
            }

            bool found = false;
            for (int i = 0; i < secretWord.Length; i++)
            {
                if (secretWord[i] == guess && guessedWord[i] == '_')
                {
                    guessedWord = guessedWord.Remove(i, 1).Insert(i, guess.ToString());
                    found = true;
                }
            }

            if (found)
            {
                Console.WriteLine("Правильно!");
            }
            else
            {
                Console.WriteLine("Неправильно!");
                guessedLetters += guess + ", ";
                attemptsLeft--;
            }
        }

        if (guessedWord == secretWord)
        {
            Console.WriteLine($"Ваше слово: {guessedWord}");
            Console.WriteLine("Все вірно!");
        }
        else
        {
            Console.WriteLine($"Ви програли. Таємне слово було: {secretWord}");
        }
    }
}
