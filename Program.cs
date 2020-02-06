/*
 * Author: Christian Nielsen
 * Date: 2/5/20
 * Description: A program that utilizes methods to display a message to the user.
 */
using System;

namespace Deliverable_3_Methods_CNielsen
{
    class Program
    {
        static void Main(string[] args)
        {
            //Give the user instruction for an input
            Console.WriteLine("Please enter your name.");

            //Declare username variable for the method
            string UserName;

            //Small Graphic for orginization
            Console.WriteLine("____________________");

            //Call the DisplayName method
            DisplayName();

            //Small Graphic for orginization
            Console.WriteLine("____________________");

            //Pause program until user presses any key
            Console.WriteLine("Press any key to coninue...");
            Console.ReadKey(true);


            //This is the DisplayName method
            void DisplayName()
            {
                //This variable will hold the user input
                string Input = Console.ReadLine();

                //This statement willput the user input into the variable declared earlier
                UserName = Input;

                //If-else statement will be used in this case to catch user errors
                if (System.Text.RegularExpressions.Regex.IsMatch(Input, "[a-zA-Z]" + " " + "[a-zA-Z]"))
                {
                    //Display a message to the user
                    Console.WriteLine("Hello" + " " + UserName + "!");
                    Console.WriteLine("Thank you for giving an acceptable input.");
                }
                //Allows user to enter one part of their name rather than the whole name
                else if (System.Text.RegularExpressions.Regex.IsMatch(Input, "[a-zA-Z]"))
                {
                    //Display a message to the user
                    Console.WriteLine("Hello" + " " + UserName+"!");
                    Console.WriteLine("Thank you for giving an acceptable input.");
                }
                else
                {
                    //Display error message with instructions to correct the user error
                    Console.WriteLine("Please only enter alphabetical letters.");
                    Console.WriteLine("Please enter your name and try again.");
                }                                                             
            } 
        }        
    }
}
