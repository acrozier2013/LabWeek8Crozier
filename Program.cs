using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrozierLabW8
{
    class Program
    {
        static void Main(string[] args)
        {
            //// 1.Create a simple while loop that loops from 1 - 9, incrementing the loop control variable by 2.Add a counter as well.Using comments in your code, 
            ////identify the following 1) loop control variable, 2) counter, 3) loop terminating condition, and 4) where you modify the loop control variable.

            //// i is the loop control variable (as long as i is less than 10, the loop will continue.
            //int i = 1;
            ////1 is the counter
            ////the 'while (i < 10)' is the loop terminating condition
            //while (i < 10)
            //{
            //    Console.WriteLine(i);
            //    // this is where I modify the loop control variable
            //    i = i + 2;
            //}


            //2.Create a for loop that loops through values 30 - 45 using a variable named i as the loop control variable.Increment the loop control variable 
            //by 1.Each time through the loop, output whether or not the variable is even or odd
            //Hint: Use and if-else statement and the modulus % operator to determine whether the variable is even or odd.Example: if ((i % 2) == 0) // it’s even

            //int i;

            //i = 30;
            //while (i < 46) 
            //{
            //    Console.WriteLine(i);
            //    i = i + 1;
            //    if((i % 2) == 0)
            //    {
            //        Console.WriteLine("Odd");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Even");
            //    }


            //3.Use an if…else-if…else statement to output the following based on an int time entered in military time(ie. 23 == 11:00 p.m., 11 == 11:00 a.m.).  
            //You will need to use a ReadLine() and then convert the input to an int value.  Based on the input, output the following messages:
            //Input 0 - 11 Output Good Morning
            //Input 12 - 16 Output Good Afternoon
            //Input > 16 Good Evening

            //int time;

            //Console.WriteLine("Enter a time: ");
            //time = Convert.ToInt32(Console.ReadLine());
            //switch (time)
            //{
            //    case 24:
            //        Console.WriteLine("Good Evening");
            //        break;

            //    case 16:
            //        Console.WriteLine("Good Afternoon");
            //        break;

            //    case 11:
            //        Console.WriteLine("Good Morning");
            //        break;
            //}


            ////4.The following code is meant to loop and output 10 - 20, each number on a separate line.  What’s wrong?  Fix the problem.Explain what was wrong in a comment.
            //// i = 10;
            ////while (i < 21)
            ////{
            ////Console.WriteLine(i);
            ////}

            ////there was nothing to increase i by one.
            //int i = 10;
            //while (i < 21)
            //{
            //    Console.WriteLine(i);
            //    i++;
            //}


            ////5.The following statement is supposed to output every number from 0 - 100 separated by a line with asterisks on it.  What is wrong with the code?  
            ////Fix it without changing any of the statements.
            ////for (int i = 0; i < 101; i++)
            ////Console.WriteLine(i);
            ////Console.WriteLine("********");
            //for (int i = 0; i < 101; i++)
            //{
            //    Console.WriteLine(i);
            //    Console.WriteLine("********");
            //}

            ////6.You only need to create one of the shapes but are welcome to create more than one.  Use nested for loops to generate the patterns.
            ////All asterisks(*) should be displayed by a single statement of the form Console.Write('*'); which causes the asterisks to display side by side.
            ////A statement of the form Console.WriteLine(); can be used to move to the next line.A statement of the form Console.Write(' '); can be used to display 
            ////a space for the last two patterns.There should be no other output statements in the application. [Hint: The last two patterns require that each line 
            ////begin with an appropriate number of blank spaces.]


           

            //for (int i = 0; i <= 10; i++)
            //{
            //    for (int j = 0; j < i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}








        }
    }
}
