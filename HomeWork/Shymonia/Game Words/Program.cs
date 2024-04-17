using System;

class Program
{
    static void Main(string[] args)
    {
        string[] words = { "привіт", "сонце", "море", "квітка", "друг" };
        Random random = new Random();

        int attemptsLeft = 6;
        string guessedLetters = "";
        string wrongLetters = "";

        Console.WriteLine("Давайте пограємо в гру в слова?");
        Console.Write("<т/н> ");
        string playAgain = Console.ReadLine().ToLower();

        while (playAgain == "т")
        {
            Console.Clear();
            attemptsLeft = 6;
            guessedLetters = "";
            wrongLetters = "";

            string secretWord = words[random.Next(words.Length)];

            Console.WriteLine("Вгадай таємне слово. Містить {0} букв.", secretWord.Length);

            while (attemptsLeft > 0 && !IsWordGuessed(secretWord, guessedLetters))
            {
                Console.WriteLine($"Ваше слово: {GetVisibleWord(secretWord, guessedLetters)}");
                Console.WriteLine($"Неправильні варіанти: {wrongLetters}");
                Console.WriteLine($"Залишилося {attemptsLeft} неправильних варіантів");

                Console.Write("Вгадайте букву: ");
                char letter = Console.ReadKey().KeyChar;
                Console.WriteLine();

                if (secretWord.Contains(letter))
                {
                    guessedLetters += letter;
                    Console.WriteLine("Правильно!");
                }
                else
                {
                    wrongLetters += letter + " ";
                    Console.WriteLine("Неправильно!");
                    attemptsLeft--;
                }
            }

            Console.Clear();
            if (IsWordGuessed(secretWord, guessedLetters))
            {
                Console.WriteLine($"Ваше слово: {secretWord}");
                Console.WriteLine("Все вірно!");
            }
            else
            {
                Console.WriteLine("Ви вичерпали всі спроби. Таємне слово було: {0}", secretWord);
            }

            Console.WriteLine("Давайте грати ще? <т/н>");
            playAgain = Console.ReadLine().ToLower();
        }

        Console.WriteLine("Успіхів!");
    }

    static string GetVisibleWord(string secretWord, string guessedLetters)
    {
        string visibleWord = "";
        foreach (char letter in secretWord)
        {
            if (guessedLetters.Contains(letter))
            {
                visibleWord += letter;
            }
            else
            {
                visibleWord += "_";
            }
        }
        return visibleWord;
    }

    static bool IsWordGuessed(string secretWord, string guessedLetters)
    {
        foreach (char letter in secretWord)
        {
            if (!guessedLetters.Contains(letter))
            {
                return false;
            }
        }
        return true;
    }
}
