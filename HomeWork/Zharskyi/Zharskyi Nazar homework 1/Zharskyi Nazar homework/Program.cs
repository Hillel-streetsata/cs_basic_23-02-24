namespace homework_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Task 1");
            Console.WriteLine(new string('-', 30));
            Console.WriteLine();
            MethodsToShowPi(); //1
            Console.WriteLine("Task 2");
            Console.WriteLine(new string('-', 30));
            Console.WriteLine();
            ComputerInfo(); //2
            Console.WriteLine("Task 3");
            Console.WriteLine(new string('-', 30));
            Console.WriteLine();
            CentimetersToMeters(); //3
            Console.WriteLine();
            Console.WriteLine("Task 4");
            Console.WriteLine(new string('-', 30));
            Console.WriteLine();
            HowManyWeeksFromTheMoment();//4
            Console.WriteLine("Task 5");
            Console.WriteLine(new string('-', 30));
            Console.WriteLine();
            HowManySquaresInRectangle();//5
            Console.WriteLine();
            Console.WriteLine("Task 6");
            Console.WriteLine(new string('-', 30));
            Console.WriteLine();
            ArithmeticAverageOfTwoNumbers(); //6
            Console.WriteLine("Task 7");
            Console.WriteLine(new string('-', 30));
            Console.WriteLine();
            SquareOfNumber(); //7
            Console.WriteLine("Task 8");
            Console.WriteLine(new string('-', 30));
            Console.WriteLine();
            MathOperations(); //8
            Console.WriteLine("Task 9");
            Console.WriteLine(new string('-', 30));
            Console.WriteLine();
            HowManyYearsOld(); //9
            Console.WriteLine("Task 10");
            Console.WriteLine(new string('-', 30));
            Console.WriteLine();
            FindingOfHypotenuse(); //10
            Console.WriteLine();
            Console.WriteLine("Task 11");
            Console.WriteLine(new string('-', 30));
            Console.WriteLine();
            DollarsInEuro(); //11
            Console.WriteLine("Task 12");
            Console.WriteLine(new string('-', 30));
            Console.WriteLine();
            FeetAndInchesToCentimeters();//12
        }
        static void MethodsToShowPi()
        {
            double pi1;
            int C = 22, d = 7;
            pi1 = (double)C / d;
            decimal pi2 = 3.1415926535897932384626433832m;
            ulong piRightPart = 14159265358979323846;
            Console.WriteLine("First method: " + Math.PI);
            Console.WriteLine("Second method: " + pi1 + " (it gives approximate value)");
            Console.WriteLine("Third method: " + pi2);
            Console.WriteLine("Fourth method: " + 3 + ',' + piRightPart);
            Console.WriteLine("Fifth method: 3,14159265358979323846264338327950288419716939937510...");
        }
        static void ComputerInfo()
        {
            Console.WriteLine("Hello, " + Environment.UserName);
            Console.WriteLine("Your computer name is: " + Environment.MachineName);
            Console.WriteLine("You have such a OS Version: " + Environment.OSVersion);
            string YesOrNo;
            if (Environment.Is64BitOperatingSystem == true)
            {
                YesOrNo = "Yes";
            }
            else
            {
                YesOrNo = "No";
            }
            Console.WriteLine("Is your OS 64 bit?: " + YesOrNo);
            Console.WriteLine("Your processor has: " + Environment.ProcessorCount + " streams");
        }
        static void CentimetersToMeters()
        {
            Console.Write("Enter a number in centimeters: ");
            int numberInCentimeters = 0;
            try
            {
                numberInCentimeters = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            int numberInMeters = numberInCentimeters / 100;
            Console.Write(numberInCentimeters + " (cm) is equal to " + numberInMeters + " (m) ");
        }
        static void HowManyWeeksFromTheMoment()
        {
            int NumberOfDays = 234, Week = 7;
            Console.WriteLine("234 days have passed since the moment, it`s equal to " + NumberOfDays / Week + " weeks ");
        }
        static void HowManySquaresInRectangle()
        {
            int RectangleSide1 = 543, RectangleSide2 = 130, SquareSide = 130;
            int SquareOfRectangle = RectangleSide1 * RectangleSide2;
            int SquareOfSquare = SquareSide * SquareSide;
            Console.Write("In rectangle with size: " + RectangleSide1 + "mm" + " x " + RectangleSide2 + "mm");
            Console.Write(" may be placed " + SquareOfRectangle / SquareOfSquare);
            Console.Write(" squares with side: " + SquareSide + "mm");
        }
        static void ArithmeticAverageOfTwoNumbers()
        {
            Console.Write("Enter first number: ");
            int FirstNumber = 0;
            int SecondNumber = 0;
            try
            {
                FirstNumber = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            Console.Write("Enter second number: ");
            try
            {
                SecondNumber = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            Console.WriteLine("The arithmetic average of: " + FirstNumber + " and " + SecondNumber + " is equal to " + ((FirstNumber + SecondNumber) / 2));
        }
        static void SquareOfNumber()
        {
            Console.Write("Enter a number: ");
            int Number = 0;
            try
            {
                Number = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            Console.WriteLine("The square of " + Number + " is equal to " + Number * Number);
            Console.WriteLine("Lower is another method");
            Console.WriteLine("The square of " + Number + " is equal to " + Math.Pow(Number, 2));
        }
        static void MathOperations()
        {
            Console.Write("Enter first number: ");
            int Number1 = 0;
            try
            {
                Number1 = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            Console.Write("Enter second number: ");
            int Number2 = 0;
            try
            {
                Number2 = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            int quotient = 0;
            try
            {
                quotient = Number1 / Number2;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            Console.WriteLine("The sum of " + Number1 + " and " + Number2 + " is equal to " + (Number1 + Number2));
            Console.WriteLine("The diference of " + Number1 + " and " + Number2 + " is equal to " + (Number1 - Number2));
            Console.WriteLine("The product of " + Number1 + " and " + Number2 + " is equal to " + (Number1 * Number2));
            Console.WriteLine("The quotient of " + Number1 + " and " + Number2 + " is equal to " + quotient);
        }
        static void HowManyYearsOld()
        {
            Console.Write("Have you already had a birthday this year? (Write: \"Yes or No\"): ");
            string YesOrNo = Console.ReadLine();
            if (YesOrNo == "Yes")
            {
                Console.Write("Enter your year of birth: ");
                int YearOfBirth = Convert.ToInt32(Console.ReadLine());
                int CurrentYear = 2024;
                Console.WriteLine("You are " + (CurrentYear - YearOfBirth) + " years old");
            }
            else if (YesOrNo == "No")
            {
                Console.Write("Enter your year of birth: ");
                int YearOfBirth = Convert.ToInt32(Console.ReadLine());
                int PreviousYear = 2023;
                Console.WriteLine("You are " + (PreviousYear - YearOfBirth) + " years old");
            }
            else
            {
                Console.WriteLine("You wrote incorrectly \"Yes or No\" try to reboot program and write it correctly");
            }
        }
        static void FindingOfHypotenuse()
        {
            Console.Write("Enter the first leg of triangle: ");
            int FirstLeg = 0;
            try
            {
                FirstLeg = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.Write("Enter the second leg of triangle: ");
            int SecondLeg = 0;
            try
            {
                SecondLeg = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            int FirstSquare = FirstLeg * FirstLeg;
            int SecondSquare = SecondLeg * SecondLeg;
            Console.Write("The hypotenuse of triangle with the legs: " + FirstLeg + " and " + SecondLeg + " is equal to " + Math.Sqrt(FirstSquare + SecondSquare));
        }
        static void DollarsInEuro()
        {
            Console.Write("Enter a sum in dollars: ");
            decimal SumInDollars = Convert.ToDecimal(Console.ReadLine());
            decimal CurrentExchangeRate = 0.92m;
            decimal SumInEuro = SumInDollars * CurrentExchangeRate;
            Console.WriteLine(SumInDollars + " Dollars is " + SumInEuro + " Euro");
        }
        static void FeetAndInchesToCentimeters()
        {
            Console.Write("Enter how many feet you are(Do not enter inches): ");
            int Feet = 0;
            try
            {
                Feet = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.Write("Enter how many inches you are: ");
            int Inches = 0;
            try
            {
                Inches = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            double FeetToCentimetres = Feet * 30.48;
            double InchesToCentimetres = Inches * 2.54;
            double CentimetresResult = FeetToCentimetres + InchesToCentimetres;
            Console.WriteLine(Feet + " ft " + Inches + " inch " + " is equal to " + CentimetresResult + " cm ");
        }
    }
}