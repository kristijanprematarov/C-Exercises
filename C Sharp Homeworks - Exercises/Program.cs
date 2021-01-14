using C_Sharp_Homeworks___Exercises_INTERFACES;
using System;
using System.Collections.Generic;
using System.Linq;

namespace C_Sharp_Homeworks___Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(AppStrings.ChooseOption);
            Console.WriteLine(AppStrings.Option1);
            Console.WriteLine(AppStrings.Option2);
            Console.WriteLine(AppStrings.Option3);
            Console.WriteLine(AppStrings.Option4);
            Console.WriteLine(AppStrings.Option5);
            Console.WriteLine(AppStrings.Option6);
            Console.WriteLine(AppStrings.Option7);
            Console.WriteLine(AppStrings.Option8);
            Console.WriteLine(AppStrings.Exit);
            Console.WriteLine(AppStrings.DelimiterLine);
            Console.WriteLine(AppStrings.NewLine);

            int theOption = int.Parse(Console.ReadLine());

            switch (theOption)
            {
                case 0:

                    break;

                case 1:
                    //Given a fraction as a string, return whether or not it is greater than 1 when evaluated.
                    Console.WriteLine("Enter fraction");
                    string fraction = Console.ReadLine();
                    IFractionGreaterThanOne fractionGreaterThanOne = new FractionGreaterThanOne();
                    bool resultFromFraction = fractionGreaterThanOne.GreaterThanOne(fraction);
                    Console.WriteLine("Is the result from the fraction bigger than one?");
                    Console.WriteLine("The answer is: {0}!!!", resultFromFraction);

                    Console.WriteLine(AppStrings.NewLine);
                    Console.WriteLine(AppStrings.DelimiterLine);
                    Console.WriteLine(AppStrings.NewLine);

                    Main(args);
                    break;

                case 2:
                    //Create a function that takes an array of integers and strings, converts integers to strings, and returns the array as a string array.
                    Console.WriteLine("If you want an empty array simply type --> exitNow");
                    Console.WriteLine("Insert elements of array one by one by pressing Enter after each element !");
                    Console.WriteLine("When done insert this --> exitNow");

                    Console.WriteLine(AppStrings.DelimiterLine);

                    IReturnStringArray returnStringArray = new ReturnStringArray();

                    string[] theStringArray = returnStringArray.ReturnTheStringArray();

                    if (theStringArray.Any())
                    {
                        Console.WriteLine("The string array members final:");

                        for (int i = 0; i < theStringArray.Length; i++)
                        {
                            Console.Write(theStringArray[i] + (i < theStringArray.Length - 1 ? ", " : ""));
                        }

                        Console.WriteLine(AppStrings.NewLine);

                        Console.WriteLine("The type of each member:");

                        for (int i = 0; i < theStringArray.Length; i++)
                        {
                            Console.Write(theStringArray[i].GetType() + (i < theStringArray.Length - 1 ? ", " : ""));
                        }
                    }
                    else
                        Console.WriteLine("The array is empty !!!");

                    Console.WriteLine(AppStrings.NewLine);
                    Console.WriteLine(AppStrings.DelimiterLine);
                    Console.WriteLine(AppStrings.NewLine);

                    Main(args);
                    break;

                case 3:
                    //Count Ones in Binary Representation of Integer.
                    Console.WriteLine("Enter a number !");
                    int number = int.Parse(Console.ReadLine());
                    ICountOnesBinary countOnesBinary = new CountOnesBinary();
                    int numberOfBits = countOnesBinary.BitsCount(number);
                    Console.WriteLine($"There are {numberOfBits} bits in the binary representation of the number {number}");

                    Console.WriteLine(AppStrings.NewLine);
                    Console.WriteLine(AppStrings.DelimiterLine);
                    Console.WriteLine(AppStrings.NewLine);

                    Main(args);
                    break;

                case 4:
                    //Count Ones in Binary Representation of Integer.
                    Console.WriteLine("Enter a string !");
                    string theString = Console.ReadLine();
                    IReturnMiddleCharChars returnMiddleCharChars = new ReturnMiddleCharChars();

                    string theMiddle = returnMiddleCharChars.ReturnMidCharChars(theString);

                    Console.WriteLine($"The middle string is: \"{theMiddle}\" ");

                    Console.WriteLine(AppStrings.NewLine);
                    Console.WriteLine(AppStrings.DelimiterLine);
                    Console.WriteLine(AppStrings.NewLine);

                    Main(args);
                    break;

                case 5:
                    //Positive Count...Negative Sum.
                    Console.WriteLine("Insert numbers, positive or negative with comma in between.");

                    string posNegNumbers = Console.ReadLine();
                    IPositiveCountNegativeSum positiveCountNegativeSum = new PositiveCountNegativeSum();

                    int[] thePosCountNegSumArray = positiveCountNegativeSum.PosCountNegSum(posNegNumbers);

                    for (int i = 0; i < thePosCountNegSumArray.Length; i++)
                    {
                        Console.Write(thePosCountNegSumArray[i] + (i < thePosCountNegSumArray.Length - 1 ? ", " : ""));
                    }

                    Console.WriteLine(AppStrings.NewLine);
                    Console.WriteLine(AppStrings.DelimiterLine);
                    Console.WriteLine(AppStrings.NewLine);

                    Main(args);
                    break;

                case 6:
                    //Is the Number Symmetrical?
                    Console.Write("Enter a number: ");
                    INumberSymmetrical numberSymmetrical = new NumberSymmetrical();

                    int aNumber = int.Parse(Console.ReadLine());
                    bool isItSymmetrical = numberSymmetrical.CheckIfSymmetrical(aNumber);
                    Console.WriteLine(isItSymmetrical);


                    Console.WriteLine(AppStrings.NewLine);
                    Console.WriteLine(AppStrings.DelimiterLine);
                    Console.WriteLine(AppStrings.NewLine);

                    Main(args);
                    break;

                case 7:
                    //Solve the Equation.
                    Console.WriteLine("Enter equation");
                    string equation = Console.ReadLine();
                    ISolveEquation solveEquation = new SolveEquation();
                    int resultFromEquation = solveEquation.EquationSolving(equation);
                    Console.WriteLine($"The result of the equation is: {equation} = {resultFromEquation}");

                    Console.WriteLine(AppStrings.NewLine);
                    Console.WriteLine(AppStrings.DelimiterLine);
                    Console.WriteLine(AppStrings.NewLine);

                    Main(args);
                    break;

                case 8:
                    //Basic E-Mail Validation
                    Console.WriteLine("Enter string");
                    string input = Console.ReadLine();
                    IEmailValidation emailValidation = new EmailValidation();
                    bool isItEmail = emailValidation.IsStringEmail(input);
                    Console.WriteLine(AppStrings.NewLine);
                    Console.WriteLine(isItEmail);

                    Console.WriteLine(AppStrings.NewLine);
                    Console.WriteLine(AppStrings.DelimiterLine);
                    Console.WriteLine(AppStrings.NewLine);

                    Main(args);
                    break;

                default:
                    Main(args);
                    break;
            }

        }
    }
}
