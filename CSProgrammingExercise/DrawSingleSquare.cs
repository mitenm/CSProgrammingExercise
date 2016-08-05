using System;

namespace CSProgrammingExercise
{
    class DrawSingleSquare
    {
        public static string InvalidNumberMessage = "Please provide valid input";

        public static void DrawSquare(int size)
        {
            if (size < 1)
            {
                throw new Exception(InvalidNumberMessage);
            }
            for (var i = 0; i < size; i++)
            {
                for (var j = 0; j < size; j++)
                {
                    //Fill top & bottom rows as well as corners with 'x' and other elements with a space
                    if (i == 0 || i == size-1 || j == 0 || j == size-1)
                    {
                        Console.Write("x");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                //Move cursor to the next line after filling a row
                Console.WriteLine();
            }
            //Console.ReadLine();
        }
    }
}
