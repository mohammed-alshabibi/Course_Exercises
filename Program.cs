namespace Part1Exs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // exs 1 even or odd
            //int number;
            //Console.WriteLine("Enter a number: ");
            //number = int.Parse(Console.ReadLine());

            //if (number%2 ==0)
            //{
            //    Console.WriteLine("The number is even");
            //}
            //else
            //{
            //    Console.WriteLine("The number is odd");
            //}


            //---------------------------------------
            //2. Largest of Three Numbers 
            int num1, num2, num3;
            Console.WriteLine("Enter the first number: ");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second number: ");
            num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the third number: ");
            num3 = int.Parse(Console.ReadLine());
            if(num1 > num2 & num1 > num3)
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

            //----------------------------------------------------------
            //3. Temperature Converter
            //double  C ,F;


            //Console.WriteLine("Enter the temperature in Celsius: " );

            //C = double.Parse(Console.ReadLine());


            //F = (C * 9 / 5) -32 ;
            //Console.Write("The temperature in Fahrenheit is: " + F);

            //----------------------------------------------------------
            //4. Simple Discount Calculator
            //float price;
            //Console.WriteLine("Enter the price of the item: ");
            //price = float.Parse(Console.ReadLine());
            //float discount;
            //float finalPrice;
            //if ( price > 100)
            //{
            //    discount = price * 10 / 100;
            //    finalPrice = price - discount;
            //    Console.WriteLine("The discount is 10% and the price after discount is: " + finalPrice);
            //}
            //else
            //{
            //    Console.WriteLine("No discount is applicable and the price is: " + price);
            //}

            //----------------------------------------------------------
            //5. Grading System
            //int score;
            //Console.WriteLine("Enter the score: ");
            //score = int.Parse(Console.ReadLine());
            //if (score >= 90 & score <= 100 ) 
            //{ 
            //    Console.WriteLine("The grade is A");
            //}
            //else if (score >= 80 & score <= 89)
            //{
            //    Console.WriteLine("The grade is B");
            //}
            //else if (score >= 70 & score <= 79)
            //{
            //    Console.WriteLine("The grade is C");
            //}
            //else if (score >= 60 & score <= 69)
            //{
            //    Console.WriteLine("The grade is D");
            //}
            //else if (score >= 0 & score <= 59)
            //{
            //    Console.WriteLine("The grade is F");
            //}
            //else
            //{
            //    Console.WriteLine("Invalid score");
            //}

            //----------------------------------------------------------
            //6. Swap Two Numbers 
            //int num1, num2, temp;
            //Console.WriteLine("Enter the first number: ");
            //num1 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter the second number: ");
            //num2 = int.Parse(Console.ReadLine());
            //temp = num1;
            //num1 = num2;
            //num2 = temp;


            //Console.Write("number 2 after swap is " +num2);
            //Console.Write(" number 1 after swap is " + num1);


            //----------------------------------------------------------
            //7. Days to Weeks and Days Converter
            //int days;
            //double weeks;
            //float remainingDays;
            //Console.WriteLine("Enter the number of days: ");
            //days = int.Parse(Console.ReadLine());

            //weeks = days / 7;
            //remainingDays = days % 7;
            //Console.Write("The number of weeks is: " + weeks + " and remaining days is "+ remainingDays);

            //----------------------------------------------------------
            //8. Electricity Bill Calculator
            //int unitsConsumed;
            //double billAmount;
            //Console.WriteLine("Enter the number of units consumed: ");
            //unitsConsumed = int.Parse(Console.ReadLine());
            //if (unitsConsumed >=0 & unitsConsumed <=100)
            //{
            //    billAmount = unitsConsumed * 0.5;
            //    Console.WriteLine("The bill amount is: " + billAmount);
            //}
            //else if (unitsConsumed >= 101 & unitsConsumed <= 300)
            //{
            //    billAmount = unitsConsumed * 0.75;
            //    Console.WriteLine("The bill amount is: " + billAmount);
            //}
            //else if( unitsConsumed >= 301)
            //{
            //    billAmount = unitsConsumed * 1;
            //    Console.WriteLine("The bill amount is: " + billAmount);
            //}
            //else
            //{
            //    Console.WriteLine("Invalid input");
            //}

            //----------------------------------------------------------
            //9. Simple Calculator
            //int num1, num2;
            //char operation;
            //Console.WriteLine("Enter the first number: ");
            //num1 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter the second number: ");
            //num2 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter the operation: ");
            //operation = char.Parse(Console.ReadLine());
            //if (operation == '+')
            //{
            //    Console.WriteLine("The sum is: " + (num1 + num2));
            //}
            //else if (operation == '-')
            //{
            //    Console.WriteLine("The difference is: " + (num1 - num2));
            //}
            //else if (operation == '*')
            //{
            //    Console.WriteLine("The product is: " + (num1 * num2));
            //}
            //else if (operation == '/')
            //{
            //    Console.WriteLine("The quotient is: " + (num1 / num2));
            //}
            //else
            //{
            //    Console.WriteLine("Invalid operation");
            //}
        }
    }
}
