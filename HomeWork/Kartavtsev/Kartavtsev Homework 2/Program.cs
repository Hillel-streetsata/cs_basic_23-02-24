namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number;
            Console.Write("Введите число:");
            number=Convert.ToInt32(Console.ReadLine());
            if (number > 0)
            {
                Console.WriteLine(number + 1);
            }
            else 
            {
                Console.WriteLine(number -2);
            }
            if (number == 0)
            { 
               Console.WriteLine("10");
                    
            }



        }
    }
}
