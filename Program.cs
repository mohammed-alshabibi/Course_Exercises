using System.Reflection.Metadata;

namespace Part1Exs
{
    internal class Program
    {
        static void Main(string[] args)
        {

            while (true)
            {
                Console.Clear();
                Console.WriteLine("\nSelect a Program:");
                Console.WriteLine("1. Simple Calculator");
                Console.WriteLine("2. Basic ATM System");
                Console.WriteLine("3. Geometry Calculator");
                Console.WriteLine("4. Factorial of a Number");
                Console.WriteLine("5. Sum of Even and Odd Numbers");
                Console.WriteLine("6. Scientific Calculator");
                Console.WriteLine("7. Print Triangle Pattern");
                Console.WriteLine("8. Print Pyramid Pattern");
                Console.WriteLine("9. Print Diamond Pattern");
                Console.WriteLine("10. Guess the Number Game");
                Console.WriteLine("11. Finde the Large Of Three Number");
                Console.WriteLine("12. Temperature Converter");
                Console.WriteLine("13. Simple Discount Calculator");
                Console.WriteLine("14. Grading System");
                Console.WriteLine("15. Swap Two Numbers");
                Console.WriteLine("16. Days Converter");
                Console.WriteLine("17. Electricity Bill Calculator");
                Console.WriteLine("18. Array");
                Console.WriteLine("0. Exit");

                Console.Write("Enter your choice: ");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1: SimpleCalculator(); break;
                    case 2: BasicATM(); break;
                    case 3: GeometryCalculator(); break;
                    case 4: Factorial(); break;
                    case 5: SumEvenOdd(); break;
                    case 6: ScientificCalculator(); break;
                    case 7: PrintTriangle(); break;
                    case 8: PrintPyramid(); break;
                    case 9: PrintDiamond(); break;
                    case 10: GuessGame(); break;
                    case 11: LargeOfThreeNumber(); break;
                    case 12: TemperatureConverter();break;
                    case 13: SimpleDiscountCalculator();break;
                    case 14:GradingSystem(); break;
                    case 15: SwapTwoNumbers(); break;
                    case 16: DaysConverter(); break;
                    case 17: ElectricityBillCalculator(); break;
                    case 18:
                        ExeArray();break;
                    case 0: return;
                    default: Console.WriteLine("Invalid Choice! Try again."); break;
                }
                Console.Write("\nPress any key to continue...");
                Console.ReadLine();
            }
        }



        static void SimpleCalculator()
        {
            //9. Simple Calculator
            int num1, num2;
            char operation;
            Console.WriteLine("Enter the first number: ");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second number: ");
            num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the operation: ");
            operation = char.Parse(Console.ReadLine());
            if (operation == '+')
            {
                Console.WriteLine("The sum is: " + (num1 + num2));
            }
            else if (operation == '-')
            {
                Console.WriteLine("The difference is: " + (num1 - num2));
            }
            else if (operation == '*')
            {
                Console.WriteLine("The product is: " + (num1 * num2));
            }
            else if (operation == '/')
            {
                Console.WriteLine("The quotient is: " + (num1 / num2));
            }
            else
            {
                Console.WriteLine("Invalid operation");
            }
        }
        static void BasicATM()
        {
            char choice;
            double balance = 1000;
            bool isActive = false;

            do
            {
                Console.Clear();
                Console.WriteLine("Welcome to the ATM");
                Console.WriteLine("1. Withdraw Money ");
                Console.WriteLine("2. Deposit Money ");
                Console.WriteLine("3. Check Balance ");
                Console.WriteLine("4. Exit ");
                int option = int.Parse(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        Console.WriteLine("Enter the amount to withdraw money: ");
                        double withdraw = double.Parse(Console.ReadLine());
                        if (balance <= 0 & withdraw > balance)
                        {
                            Console.WriteLine("the process anavilable");
                            isActive = true;
                            break;
                        }
                        else


                            balance -= withdraw;

                        break;
                    case 2:
                        Console.WriteLine("Enter the amount to deposit money: ");
                        double deposit = double.Parse(Console.ReadLine());
                        balance += deposit;

                        break;
                    case 3:

                        break;
                    case 4:
                        Console.WriteLine("Thank you for using the ATM");
                        isActive = true;
                        break;

                    default:
                        Console.WriteLine("Invalid option");
                        isActive = true;
                        break;

                }
                if (!isActive)
                {
                    Console.WriteLine("The balance is: " + balance);
                }
                Console.WriteLine("Do you want another operation ? y / n\n");
                choice = Console.ReadKey().KeyChar;
            }

            while (choice == 'y' || choice == 'Y');

            Console.WriteLine("\ngood bye");
        }
        static void GeometryCalculator()
        {
            Console.WriteLine("choose a chape:");
            Console.WriteLine("1. Circle (Calculate Area & Circumference) ");
            Console.WriteLine("2. Square(Calculate Area & Perimeter)");
            Console.WriteLine("3. Triangle (Calculate Area)");
            int option = int.Parse(Console.ReadLine());
            switch (option)
            {
                case 1:
                    Console.WriteLine("Enter the radius of the circle: ");
                    double radius = double.Parse(Console.ReadLine());
                    double area = 3.14 * radius * radius;
                    double circumference = 2 * 3.14 * radius;
                    Console.WriteLine("The area of the circle is: " + area);
                    Console.WriteLine("The circumference of the circle is: " + circumference);
                    break;
                case 2:
                    Console.WriteLine("Enter the side of the square: ");
                    double side = double.Parse(Console.ReadLine());
                    double areaSquare = side * side;
                    double perimeter = 4 * side;
                    Console.WriteLine("The area of the square is: " + areaSquare);
                    Console.WriteLine("The perimeter of the square is: " + perimeter);
                    break;
                case 3:
                    Console.WriteLine("Enter the base of the triangle: ");
                    double baseTriangle = double.Parse(Console.ReadLine());
                    Console.WriteLine("Enter the height of the triangle: ");
                    double height = double.Parse(Console.ReadLine());
                    double areaTriangle = 0.5 * baseTriangle * height;
                    Console.WriteLine("The area of the triangle is: " + areaTriangle);
                    break;
            }
        }
        static void Factorial()
        {
            Console.WriteLine("Enter a number of N:");
            int n = int.Parse(Console.ReadLine());
            int fact = 1;
            for (int i = 1; i <= n; i++)
            {
                fact = fact * i;
            }
            Console.WriteLine("The factorial of " + n + " is: " + fact);
        }
        static void SumEvenOdd()
        {
            Console.WriteLine("Enter a number: ");
            int n = int.Parse(Console.ReadLine());
            int sumEven = 0;
            int sumOdd = 0;
            for (int i = 0; i <= n; i++)
            {
                if (i % 2 == 0)
                {
                    sumEven = sumEven + i;
                }
                else
                {
                    sumOdd = sumOdd + i;
                }
            }
            Console.WriteLine("The even numbers are: " + sumEven);
            Console.WriteLine("The odd numbers are: " + sumOdd);
        }
        static void ScientificCalculator()
        {
            Console.WriteLine("Choose an operation: ");
            Console.WriteLine("1.sin\n2.cos\n3.tan\n4.sqrt\n5.log\n6.pow");
            int option = int.Parse(Console.ReadLine());
            switch (option)
            {
                case 1:
                    Console.WriteLine("Enter the number: ");
                    double num = double.Parse(Console.ReadLine());
                    Console.WriteLine("The sin of " + num + " is: " + Math.Sin(num));
                    break;
                case 2:
                    Console.WriteLine("Enter the number: ");
                    double num1 = double.Parse(Console.ReadLine());
                    Console.WriteLine("The cos of " + num1 + " is: " + Math.Cos(num1));
                    break;
                case 3:
                    Console.WriteLine("Enter the number: ");
                    double num2 = double.Parse(Console.ReadLine());
                    Console.WriteLine("The tan of " + num2 + " is: " + Math.Tan(num2));
                    break;
                case 4:
                    Console.WriteLine("Enter the number: ");
                    double num3 = double.Parse(Console.ReadLine());
                    Console.WriteLine("The square root of " + num3 + " is: " + Math.Sqrt(num3));
                    break;
                case 5:
                    Console.WriteLine("Enter the number: ");
                    double num4 = double.Parse(Console.ReadLine());
                    Console.WriteLine("The log of " + num4 + " is: " + Math.Log(num4));
                    break;
                case 6:
                    Console.WriteLine("Enter the base: ");
                    double num5 = double.Parse(Console.ReadLine());
                    Console.WriteLine("Enter the power: ");
                    double num6 = double.Parse(Console.ReadLine());
                    Console.WriteLine("The power of " + num5 + " raised to " + num6 + " is: " + Math.Pow(num5, num6));
                    break;
                default:
                    Console.WriteLine("Invalid operation");
                    break;
            }
        }
        static void PrintTriangle()
        {
            Console.WriteLine("Enter number of N:");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i <= n; i++)
            {

                Console.WriteLine(new string('*', i));

            }
            for (int i = 0; i <= 5; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
        static void PrintPyramid()
        {
            Console.WriteLine("Enter number of N:");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                for (int j = 0; j < n - i; j++)
                {
                    Console.Write(" ");
                }
                Console.WriteLine(new string('*', i * 2 - 1));

            }
            for (int i = 0; i <= n; i++)
            {
                for (int j = n - i; j >= 1; j--)
                {
                    Console.Write(" ");
                }
                for (int j = 1; j <= i * 2 - 1; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
        static void PrintDiamond()
        {
            Console.WriteLine("Enter number of N:");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {

                Console.WriteLine(new string(' ', n - i) + new string('*', i * 2 - 1));


            }
            for (int i = n - 1; i >= 1; i--)
            {
                Console.WriteLine(new string(' ', n - i) + new string('*', i * 2 - 1));
            }



        }
        static void GuessGame()
        {
            Random random = new Random();
            int randomNumber = random.Next(1, 100);

            int attempts = 0;
            bool correct = false;
            while (!correct)
            {
                Console.WriteLine("Guess a number between 1 and 100: ");
                int guess = int.Parse(Console.ReadLine());

                if (randomNumber < guess)
                {
                    Console.WriteLine("try lower");

                    attempts++;


                }
                else if (randomNumber > guess)
                {
                    Console.WriteLine("try higher");
                    attempts++;
                }
                else
                {
                    Console.WriteLine("Correct! The number was " + randomNumber);
                    Console.WriteLine("It took you " + attempts + " attempts");
                    correct = true;
                }
            }
        }
        static void LargeOfThreeNumber()
        {
            // exs 1 even or odd
            int num1, num2, num3;
            Console.WriteLine("Enter the first number: ");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second number: ");
            num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the third number: ");
            num3 = int.Parse(Console.ReadLine());
            if (num1 > num2 & num1 > num3)
            {
                Console.WriteLine("The largest number is: " + num1);
            }
            else if (num2 > num1 & num2 > num3)
            {
                Console.WriteLine("The largest number is: " + num2);
            }
            else if (num3 > num1 & num3 > num2)
            {
                Console.WriteLine("The largest number is: " + num3);
            }
            else
            {
                Console.WriteLine("The numbers are equal");
            }
        }
        static void TemperatureConverter()
        {
            double C, F;
            Console.WriteLine("Enter the temperature in Celsius: ");
            C = double.Parse(Console.ReadLine());
            F = (C * 9 / 5) - 32;
            Console.Write("The temperature in Fahrenheit is: " + F);
        }
        static void SimpleDiscountCalculator()
        {
            float price;
            Console.WriteLine("Enter the price of the item: ");
            price = float.Parse(Console.ReadLine());
            float discount;
            float finalPrice;
            if (price > 100)
            {
                discount = price * 10 / 100;
                finalPrice = price - discount;
                Console.WriteLine("The discount is 10% and the price after discount is: " + finalPrice);
            }
            else
            {
                Console.WriteLine("No discount is applicable and the price is: " + price);
            }
        }
        static void GradingSystem()
        {
            int score;
            Console.WriteLine("Enter the score: ");
            score = int.Parse(Console.ReadLine());
            if (score >= 90 & score <= 100)
            {
                Console.WriteLine("The grade is A");
            }
            else if (score >= 80 & score <= 89)
            {
                Console.WriteLine("The grade is B");
            }
            else if (score >= 70 & score <= 79)
            {
                Console.WriteLine("The grade is C");
            }
            else if (score >= 60 & score <= 69)
            {
                Console.WriteLine("The grade is D");
            }
            else if (score >= 0 & score <= 59)
            {
                Console.WriteLine("The grade is F");
            }
            else
            {
                Console.WriteLine("Invalid score");
            }
        }
        static void SwapTwoNumbers()
        {
            int num1, num2, temp;
            Console.WriteLine("Enter the first number: ");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second number: ");
            num2 = int.Parse(Console.ReadLine());
            temp = num1;
            num1 = num2;
            num2 = temp;



            Console.Write("number 2 after swap is " + num2);
            Console.Write(" number 1 after swap is " + num1);
        }
        static void DaysConverter()
        {
            int days;
            double weeks;
            float remainingDays;
            Console.WriteLine("Enter the number of days: ");
            days = int.Parse(Console.ReadLine());

            weeks = days / 7;
            remainingDays = days % 7;
            Console.Write("The number of weeks is: " + weeks + " and remaining days is " + remainingDays);

        }
        static void ElectricityBillCalculator()
        {
            int unitsConsumed;
            double billAmount;
            Console.WriteLine("Enter the number of units consumed: ");
            unitsConsumed = int.Parse(Console.ReadLine());
            if (unitsConsumed >= 0 & unitsConsumed <= 100)
            {
                billAmount = unitsConsumed * 0.5;
                Console.WriteLine("The bill amount is: " + billAmount);
            }
            else if (unitsConsumed >= 101 & unitsConsumed <= 300)
            {
                billAmount = unitsConsumed * 0.75;
                Console.WriteLine("The bill amount is: " + billAmount);
            }
            else if (unitsConsumed >= 301)
            {
                billAmount = unitsConsumed * 1;
                Console.WriteLine("The bill amount is: " + billAmount);
            }
            else
            {
                Console.WriteLine("Invalid input");
            }
        }
        static void ExeArray()
        {
            //---------------Array Initialization & Output -----------
            //int[] num = new int[5];
            //Console.WriteLine("enter 5 integer number: ");
            //for (int i = 0; i < num.Length; i++)
            //{
            //    num[i] = int.Parse(Console.ReadLine());
            //}
            //for (int i = 0; i < num.Length; i++)
            //{
            //   Console.WriteLine(num[i])  ;
            //}
            //---------------Find Maximum & Minimum in an Array ---------
            // Console.WriteLine("enter 10 number: ");
            // int[] num = new int[10];
            // for (int i = 0; i < num.Length; i++)
            // {
            //     num[i] = int.Parse(Console.ReadLine());
            // }
            //Console.WriteLine("Max number "+num.Max()) ;
            // Console.WriteLine("Min number " + num.Min());
            //----------------Count Even & Odd Numbers----------
            //Console.WriteLine("Enter N number: ");
            //int n = int.Parse(Console.ReadLine());
            //int[] num = new int[n];
            //int countEven = 0;
            //int countOdd = 0;
            //int []EvenArray = new int[n];
            //int []OddArray = new int[n];
            //Console.WriteLine("Enter the number of array: ");
            //for (int i = 0; i < num.Length; i++)
            //{
            //    num[i] = int.Parse(Console.ReadLine());
            //}
            //for (int i = 0; i < num.Length; i++)
            //{
            //    if (num[i] % 2 == 0)
            //    {
            //        EvenArray[countEven] = num[i];
            //        countEven ++;

            //    }
            //    else
            //    {
            //        OddArray[countOdd] = num[i];
            //        countOdd ++;
            //    }
            //}
            //Console.WriteLine("count Even number: "+ countEven);
            //Console.WriteLine("count Odd number: " + countOdd);
            //Console.WriteLine("even number: " + string.Join(",", EvenArray));
            //Console.WriteLine("odd number: " +string.Join(",",OddArray) );
            //-----------------Reverse an Array----------------
            //Console.WriteLine("Enter N number: ");

            //int n = int.Parse(Console.ReadLine());
            //int[] num = new int[n];
            //Console.WriteLine("Enter the number of array: ");
            //for (int i = 0; i < num.Length; i++)
            //{
            //    num[i] = int.Parse(Console.ReadLine());
            //}
            //Array.Reverse(num);
            //Console.WriteLine("Reverse array: " + string.Join(",", num));
            //------------------Search for a Number in an Array------------
            //int[] num = { 1, 2, 3, 4, 5, 6 };
            //Console.WriteLine("Enter the number to search: ");
            //int number = int.Parse(Console.ReadLine());

            //for (int i=0; i < num.Length; i++)
            //{
            //    if (num[i] == number)
            //    {
            //        int index = Array.IndexOf(num, number);
            //        Console.WriteLine("The number is found at index: " +index );

            //    }

            //}
            //------------------Sorting an Array (Ascending Order)-------------
            //Console.WriteLine("Enter N number: ");

            //int n = int.Parse(Console.ReadLine());
            //int[] num = new int[n];
            //Console.WriteLine("Enter the number of array: ");
            //for (int i = 0; i < num.Length; i++)
            //{
            //    num[i] = int.Parse(Console.ReadLine());
            //}
            //Array.Sort(num);
            //Console.WriteLine("Sort array: " + string.Join(",", num));
            //------------------Merging Two Arrays---------------------------
            //Console.WriteLine("Enter length of array: ");

            //int len = int.Parse(Console.ReadLine());
            //int[] arrayOne = new int[len];
            //Console.WriteLine("Enter the number of array one: ");
            //for (int i = 0; i < arrayOne.Length; i++)
            //{
            //    arrayOne[i] = int.Parse(Console.ReadLine());
            //}

            //int[] arrayTwo = new int[len];
            //Console.WriteLine("Enter the number of array two: ");
            //for (int i = 0; i < arrayTwo.Length; i++)
            //{
            //    arrayTwo[i] = int.Parse(Console.ReadLine());
            //}
            //int lengthArrayThree = arrayOne.Length + arrayTwo.Length;
            //int[] arrayThree = new int[lengthArrayThree];
            //for (int i = 0; i < len; i++)
            //{
            //    arrayThree[i] = arrayOne[i];
            //    arrayThree[i+len] = arrayTwo[i];
            //}
            //Console.WriteLine("Merged array: " + string.Join(",", arrayThree));
            //------------------Remove Duplicates from an Array---------------
            Console.WriteLine("Enter N number: ");
            int n = int.Parse(Console.ReadLine());
            int[] num = new int[n];
            Console.WriteLine("Enter the number of array: ");
            for (int i = 0; i < num.Length; i++)
            {
                num[i] = int.Parse(Console.ReadLine());
            }
            int[] uniqueArray = num.Distinct().ToArray();
            Console.WriteLine("Unique array: " + string.Join(",", uniqueArray));










        }








    }


}

