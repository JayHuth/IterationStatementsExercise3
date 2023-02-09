using System.Runtime.CompilerServices;

namespace IterationStatements
{
    public class Program
    {
        public static void Print1000() 
        {
        for (int i = 1000; i >= -1000; i--)

            { 
            Console.WriteLine(i);
            }
        }

        //Write a method that will print to the console numbers 3 through 999 by 3 each time
        public static void Print999()
        {
            for (int i = 3; i <= 999; i += 3)
            {
                Console.WriteLine(i);
            }
        }
        
        //Write a method to accept two integers as parameterss and check whether they are equal or not
        public static void Equal(int num1, int num2)
        {
            if(num1 == num2)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }
   
        }
        //Write a method to check whether a given number is even or odd
        public static void EvenOrOdd(int num1)
        {
            if(num1 % 2 == 0)
            {
                Console.WriteLine("Even");
            }
            else
            {
                Console.WriteLine("odd");
            }
        }
        
        //Write a method to check whether a given number is positive or negative
        public static void PositiveOrNegitive(int num1)
        {
            if(num1 >=0) 
            {
                Console.WriteLine("positive");
            }
            else
            {
                Console.WriteLine("negitive");
            }
                    
        }
        
        //Write a method to read the age of a candidate and determine whether they can vote.
        public static void AgeAndVote(int num1)
            
        {
            if(num1 >= 18)
            {
                Console.WriteLine("you can vote!");
            }
            else
            {
                Console.WriteLine("you cannot vote yet");
            }
        }
        //Hint: Use Parse or the safer TryParse() for an extra challenge
        //Parse()
        //TryParse()

        //Heatin Up Section:
        //Write a method to check if an integer(from the user) is in the range -10 to 10
        public static void UserNumberRange()
        {
            Console.WriteLine("give me a number?");
            int num1 = int.Parse(Console.ReadLine());

            if (num1 <= 10 && num1 >= -10)
            {
                Console.WriteLine("this number is in the aceptable range");
            }
            else
            {
                Console.WriteLine("this number is outside of acceptable range");
            }
            
            
        }

        //Write a method to display the multiplication table(from 1 to 12) of a given integer
        public static void MultiTable()
        {
            Console.WriteLine("give me a number.");
            int num1 = int.Parse(Console.ReadLine());

            for (int i = 1; i <= 12; i++)
            {
             Console.WriteLine(num1 * i);
            } 

        }


        //Call the methods to test them in the Main method below
        static void Main(string[] args)
        {
           MultiTable();
        }
    }
}
