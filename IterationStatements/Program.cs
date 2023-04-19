using System.Diagnostics;
using Internal;

namespace IterationStatements
{
    public class Program
    {
        //LukeWarm Section: Create methods below
        //Write a method that will print to the console all numbers 1000 through - 1000

        //Write a method that will print to the console numbers 3 through 999 by 3 each time

        //Write a method to accept two integers as parameterss and check whether they are equal or not

        //Write a method to check whether a given number is even or odd

        //Write a method to check whether a given number is positive or negative

        //Write a method to read the age of a candidate and determine whether they can vote.
        //Hint: Use Parse or the safer TryParse() for an extra challenge
        //Parse()
        //TryParse()

        //Heatin Up Section:
        //Write a method to check if an integer(from the user) is in the range -10 to 10

        //Write a method to display the multiplication table(from 1 to 12) of a given integer


        //Call the methods to test them in the Main method below
        static void Main(string[] args)
        {

            PrintOneGrand();

            Console.WriteLine("");

            PrintInThrees();

            Console.WriteLine("");

            Console.WriteLine("The numbers are equal?");
            Console.WriteLine("Enter a number:");
            var xNum = Console.ReadLine();
            Console.WriteLine("Enter another number:");
            var yNum = Console.ReadLine();
            Console.WriteLine(Equals(xNum, yNum));

            Console.WriteLine("");

            Console.WriteLine("Is the number even or odd?");
            Console.WriteLine("Enter a number:");
            var bNum = int.Parse(Console.ReadLine());
            EvenOrOdd(bNum);

            Console.WriteLine("");

            Console.WriteLine("Is the number positive?");
            Console.WriteLine("Enter a number:");
            var pNum = int.Parse(Console.ReadLine());
            Console.WriteLine(PosOrNeg(pNum));

            Console.WriteLine("");

            var userAge = "";
            int age;
            bool proceed;
            do
            {
                Console.WriteLine($"How old is the potential voter?");
                userAge = Console.ReadLine();
                proceed = int.TryParse(userAge, out age);

            } while (!proceed);
            VotingAge(age);

            Console.WriteLine("");

            Console.WriteLine("Is the number between -10 and 10?");
            Console.WriteLine("Enter a number:");
            var rNum = int.Parse(Console.ReadLine());
            Console.WriteLine(InRangeTen(rNum));

            Console.WriteLine("");

            Console.WriteLine("Multiplication table (from 1-12).");
            Console.WriteLine("Enter a number:");
            TimesTable();

        }

        public static void PrintOneGrand()
        {
            for (int i = 1000; i >= -1000; i--)
            {
                Console.WriteLine(i);
            }
        }

        public static void PrintInThrees()
        {
            for (int t = 999; t >= 3; t -= 3)
            {
                Console.WriteLine(t);
            }
        }

        public static bool Equals(int xNum, int yNum)
        {
            var check = (xNum == yNum) ? true : false;
            return check;
        }

        public static void EvenOrOdd(int bNum)
        {
            if (bNum % 2 == 0)
            {
                Console.WriteLine($"Even.");
            }
            else
            {
                Console.WriteLine($"Odd.");
            }
        }

        public static bool PosOrNeg(int pNum)
        {
            if (pNum > 0)
            {
                return true;
            }
            return false;
        }

        public static bool VotingAge(int age)
        {
            if (age >= 18)
            {
                Console.WriteLine($"They can Vote!");
                return true;
            }
            else
            {
                Console.WriteLine($"Not yet! They can vote in {18 - age} years.");
                return false;
            }
        }

        public static bool InRangeTen(int rNum)
        {
            if (rNum <= 10 && rNum >= -10)
            {
                return true;
            }
            return false;
        }

        public static void TimesTable()
        {
            var tNum = int.Parse(Console.ReadLine());
            int t;
            for (int m = 1; m <= 12; m++)
            {
                t = tNum * m;
                Console.WriteLine("{0} X {1} = {2} \n", tNum, m, tNum * m);
            }
        }
    }
}
