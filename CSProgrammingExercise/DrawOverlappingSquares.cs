using System;

namespace CSProgrammingExercise
{
    class DrawOverlappingSquares
    {
        public static string InvalidNumberMessage = "Please provide valid input";

        public static string InvalidInnerSquareSizeMessage =
            "Size of inner square is bigger then outer one. Please correct the input";

        public static void DrawSquare(int innerSquareSize, int outerSquareSize)
        {
            if (outerSquareSize < 1 || innerSquareSize < 1)
            {
                throw new Exception(InvalidNumberMessage);
            }
            if (innerSquareSize > outerSquareSize)
            {
                throw new Exception(InvalidInnerSquareSizeMessage);
            }
            for (var i = 0; i < outerSquareSize; i++)
            {
                for (var j = 0; j < outerSquareSize; j++)
                {
                    //Fill top & bottom rows as well as corners with 'x' and other elements with a space
                    //For inner square, ensure that row and columns are not falling beyond the inner square size
                    if (i == 0 || i == outerSquareSize - 1 || j == 0 || j == outerSquareSize - 1
                        ||  (i == innerSquareSize-1 && j < innerSquareSize) || (j == innerSquareSize-1 && i < innerSquareSize))
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
        }
    }
}
