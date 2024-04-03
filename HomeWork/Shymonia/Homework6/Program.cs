using System.Text;

namespace Homework6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;

            Divider();
            TaskOne();
            Divider();
            TaskTwo();
            Divider();
            TaskThree();
            Divider();
            TaskFour();
            Divider();
            Task1();

        }

        static void Divider()
        {
            Console.WriteLine(new string('-', 16));
        }

        static void TaskOne()
        {
            Console.WriteLine("ОДНОВИМІРНІ МАСИВИ");

            Console.WriteLine("Завдання 1\n Заповніть масив з восьми елементів наступними значеннями: перший елемент масиву - 37, другий - 0, третій - 50, четвертий - 46, п'ятий - 34, шостий - 46, сьомий - 0, а восьмий - 13. Відобразити на екрані.");

            int[] array = new int[8];


            array[0] = 37;
            array[1] = 0;
            array[2] = 50;
            array[3] = 46;
            array[4] = 34;
            array[5] = 46;
            array[6] = 0;
            array[7] = 13;


            Console.WriteLine("Масив:");
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"елемент {i + 1}: {array[i]}");
            }

        }




        static void TaskTwo()
        {
            Console.WriteLine("Завдання 2\n Масив призначений для зберігання значень висоти дванадцяти чоловік.  Використовуючи випадкові числа, заповніть масив цілими значеннями в діапазоні від 163 до 190 включно.");

            int[] heights = new int[12];


            Random random = new Random();


            for (int i = 0; i < heights.Length; i++)
            {
                heights[i] = random.Next(163, 191);
            }


            Console.WriteLine("Висота 12 людей:");
            for (int i = 0; i < heights.Length; i++)
            {
                Console.WriteLine($"Людина {i + 1}: {heights[i]} см");
            }



        }


        static void TaskThree()
        {

            Console.WriteLine("Завдання 3\n Присвоюються початкові значення від 1, 2, 3,... , до 10 елементам масиву і відобразити елементи масиву з парним індексом.");


            int[] array = new int[10];


            for (int i = 1; i < array.Length; i++)
            {
                array[i] = i + 1;
            }


            Console.WriteLine("Парні елементи:");
            for (int i = 1; i < array.Length; i += 2)
            {
                Console.WriteLine($"елемент {i}: {array[i]}");
            }


        }

        static void TaskFour()
        {

            Console.WriteLine("Завдання 4\n Створіть масив розмірністю 10 елементів, відобразіть всі елементи масиву в зворотному порядку.");

            int[] array = new int[10];

           
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = i + 1;
            }


            Console.WriteLine("Елементи в зворотньому порядку:");

            for (int i = array.Length - 1; i >= 0; i--)
            {
                Console.WriteLine($"елемент {i}: {array[i]}");
            }
        }

        static void Task1()
        {
            Console.WriteLine("ДВОВИМІРНІ МАСИВИ");

            Console.WriteLine("Завдання 1\n Заповніть масив з 10 елементів випадковими числами в інтервалі [-10..10]");

            int[] array = new int[10];

          
            Random random = new Random();

           
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(-10, 11);
            }

            Console.WriteLine("Масив випадкових чисел [-10, 10]:");
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"Елемент {i + 1}: {array[i]}");
            }




        }

    }
}