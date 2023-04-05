namespace IterationStatements
{
    public class Program
    {
        //LukeWarm Section: Create methods below
        //Write a method that will print to the console all numbers 1000 through - 1000
        public static void Print1000s()
        {
            for (var i = 1000; i >= -1000; i--)
            {
                Console.WriteLine(i);
            }
            //Write a method that will print to the console numbers 3 through 999 by 3 each time
            static void PrintThrees()
            {
                for (var i = 3; i <= 999; i += 3)
                {
                    Console.WriteLine(i);
                }
                //Write a method to accept two integers as parameterss and check whether they are equal or not
                static void TwoIntEqual(int num1, int num2)
                {
                    if (num1 == num2)
                    {
                        Console.WriteLine("Those numbers are equal");
                    }
                    else
                    {
                        Console.WriteLine("Those numbers are NOT equal");
                    }


                }
                //Write a method to check whether a given number is even or odd
                static void EvenOrOdd(int number)
                {
                    //if (number % 2 == 0)
                    // {
                    //   Console.WriteLine($"{number} is even");
                    //}
                    //else
                    //{
                    //   Console.WriteLine($"{number}is odd");
                    //}

                    Console.WriteLine((number % 2 == 0) ? $"{number} is even" : $"{number}is odd");
                }
                //Write a method to check whether a given number is positive or negative
                static void PositiveOrNegative(int num)
                {
                    if (num > 0)
                    {
                        Console.WriteLine($"{num}is positive");
                    }
                    else if (num < 0)
                    {
                        Console.WriteLine($"{num} is negative");
                    }
                    else
                    {
                        Console.WriteLine($"{num}is neither positive nor negative");
                    }

                }



                //Write a method to read the age of a candidate and determine whether they can vote.
                //Hint: Use Parse or the safer TryParse() for an extra challenge
                //Parse()
                //TryParse()
                static void AgeCheck()
                {
                    bool userAge;
                    int result;

                    do
                    {
                        Console.WriteLine("Please enter your age:");
                        userAge = int.TryParse(Console.ReadLine(), out result);

                    } while (!userAge);

                    if (result < 18)
                    {
                        Console.WriteLine("Sorry you're not old enough to vote");
                    }
                    else
                    {
                        Console.WriteLine("Congrats! You can vote!");
                    }
                }
                //Heatin Up Section:
                //Write a method to check if an integer(from the user) is in the range -10 to 10
                static void InRange()
                {
                    bool userResponse;
                    int result;

                    do
                    {
                        Console.WriteLine("Enter an integer");

                        userResponse = int.TryParse(Console.ReadLine(), out result);

                    } while (!userResponse);

                    //if (result >= -10 && result <= 10)
                    // {
                    //   Console.WriteLine($"{result} is between -10 & 10");
                    //}
                    //else
                    //{
                    //  Console.WriteLine($"{result} is NOT between -10 & 10");
                    //}

                    Console.WriteLine((result >= -10 && result <= 10) ? $"{result} is between -10 & 10"
                        : $"{result} is NOT between -10 & 10");
                }
                //Write a method to display the multiplication table(from 1 to 12) of a given integer
                static void MultTable()
                {
                    bool cont;
                    int userInput;

                    do
                    {
                        Console.WriteLine("Enter an integer");
                        cont = int.TryParse(Console.ReadLine(), out userInput);

                        if (!cont)
                        {
                            Console.WriteLine("Invalid Input. Please try again");
                        }

                    } while (!cont);
                    for (var x = 1; x <= 12; x++)
                    {
                        Console.WriteLine($"{x}x {userInput} = {x * userInput}");
                    }

                    //Call the methods to test them in the Main method below
                    static void Main(string[] args)
                    {
                        //Print1000s();
                        //InRange();
                        //TwoIntEqual(5,8);
                        //TwoIntEqual(6,6);
                        //EvenOrOdd(8);
                        //EvenOrOdd(5);
                        //PositiveOrNegative(100);
                        //PositiveOrNegative(-47);
                        //PositiveOrNegative(0);

                        //AgeCheck();
                        //AgeCheck();
                        //InRange();
                        MultTable();
                    }
                }
            }
        }
    }
}