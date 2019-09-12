 using System;

namespace ISM4330_Dv2_IterativeStatement
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ask the user for input
            Console.Write("Enter an Integer value between 1 and 100 to execute an iterative statement: ");
            /*
               Use the try catch block to validate user input.
               If the user provides bad input, the catch block
               will handle the error and a message will be displayed.
            */
            try
            {
                // This variable will gather data from user input
                string input = Console.ReadLine();
                // This variable will be used to perform the various iterative statements and is parsed as an integer
                int value_of_input = int.Parse(input);
                /* 
                   This conditional IF/ELSE IF/ELSE statement is used to test the values of user input.
                   Depending on the value of the user input between 1 and 100, a different type of 
                   iterative statement will execute. 
                */
                // If the value of user input is between 1 and 5, execute a For Loop
                if ((value_of_input > 0) && (value_of_input <= 100))
                {
                    Console.WriteLine("Executing a For Loop!");
                    Console.WriteLine("The For Loop will iterate " + value_of_input.ToString() + " times.");
                    // Here is the For Loop
                    for (int i = 1; i < value_of_input+1; i++)
                    {
                        Console.WriteLine("You have entered " + input + " This is the current integer value in the loop: " + i.ToString());
                    }
                    Console.WriteLine("Press any key to exit the program ...");
                    // Pause the program and await the user to press a key to end the program
                    Console.ReadKey(true);
                }
                
                // If the user does not enter a value between 1 and 100, display a message
                else
                {
                    Console.WriteLine("Please enter an integer between 1 and 100 and try again ...");
                    Console.WriteLine("Press any key to exit the program and try again ...");
                    Console.ReadKey(true);
                }
            }// End of try
            catch
            {
                Console.WriteLine("Please enter an integer value and try running the program again ...");
                Console.WriteLine("Press any key to exit the program ...");
                Console.ReadKey(true);
            }// End of catch
        } // End of Main
    }// End of class
}// End of namespace
