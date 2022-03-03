/* Write an console application that creates an two-dimensional array. 
 * Allow the user to input the size of the array (number of rows and number of columns at least10). 
 * Fill the array with random numbers between 0 and 100. Search the array for the largest and smallest value. 
 * Display the array values, numbers aligned, and the indexes where the largest value is stored.*/


using System;

namespace SalesMan2D
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Random values = new Random();
            int Rowsize = 0;
            int colsize = 0;
            int min = 100;
            int max = 0;
            int maxIndexRow = 0;
            int maxIndexCol = 0;
             
            Rowstart:
            Console.WriteLine(" Enter the number of rows: ");
            Rowsize = Convert.ToInt32 (Console.ReadLine());
            if (Rowsize <10)
            {
                Console.WriteLine(" Put a valid number: ");
                goto Rowstart;
            }
          
            colstart:
            Console.WriteLine(" Enter the number of columns: ");
            colsize = Convert.ToInt32(Console.ReadLine());
            if (colsize < 10)
            {
                Console.WriteLine(" Put a valid number: ");
                goto colstart;
            }
            Console.WriteLine();
            int[,] twoD = new int[Rowsize, colsize];
            for (int a = 0; a <Rowsize; a++)
            {
                for (int b = 0; b <colsize; b++)
                {
                    twoD[a, b] = values.Next(0, 100);
                    if (min > twoD[a, b])
                    {
                        min = twoD[a, b];
                    }
                    if (max < twoD[a, b])
                    {
                        max = twoD[a, b];
                        maxIndexRow = a;
                        maxIndexCol = b;
                    }
                    Console.Write(twoD[a,b] + "\t ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("\nMax: " + max + " " + "Min: " + min );
            Console.WriteLine("The Max value can be found at Row " + maxIndexRow + ", Column " + maxIndexCol);
        }
    }
}
