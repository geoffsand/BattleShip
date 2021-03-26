using System;
using System.Data;

// 1 print grid
// 2 ask for input row/column for a hit
// writeline - enter coords
// readline - x & y
// 3 cross reference input coordinate with ship coordinates
// 4 store a miss or a hit
// 5 relay the information
// 6 repeat back to step 1

namespace Day_7_Battleship
{
    class Program
    {
        static void printGrid(char[,] chart)
        {
            for (int row = 0; row < 10; row++)
            {
                for (int column = 0; column < 10; column++)
                {
                    Console.Write(chart[row, column]);
                }
                Console.WriteLine();      // this is just a linebreak to make each row print on a new line after the "for column" loops x10
            }
        }
        static void Main(string[] args)
        {
            int[,] gridBoats = new int[10, 10];

            gridBoats[1, 3] = 1;
            gridBoats[4, 4] = 1;
            gridBoats[0, 3] = 1;
            gridBoats[5, 8] = 1;

            int boatCounter = 4;
            int turnCounter = 0;

            char[,] gridPlayer = new char[10, 10];

            for (int x = 0; x < 10; x++)
            {
                for (int y = 0; y < 10; y++)
                {
                    gridPlayer[x, y] = '?';
                }
            }
            while (boatCounter > 0)
            {
                printGrid(gridPlayer);

                Console.WriteLine("Please enter your row (0-9)");
                int row = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Please enter your column (0-9)");
                int column = Convert.ToInt32(Console.ReadLine());

                turnCounter = turnCounter + 1;

                if (gridBoats[row, column] == 1)
                {
                    Console.WriteLine("Hit!");
                    gridPlayer[row, column] = 'H';
                    --boatCounter;  // this is the same as boatCounter = boatCounter - 1
                                    // --variable or variable-- is prefix or postfix, determines which operations happen first on line
                }
                else
                {
                    Console.WriteLine("Miss! You Suck!");
                    gridPlayer[row, column] = 'M';
                }
            }
            Console.WriteLine("You sank all my battleships! You finished in " + turnCounter + " turns!");
            if (turnCounter <= 5)
            {
                Console.WriteLine("I just wanted to tell you how wonderful you are. I love you.");
            }
            else if (turnCounter > 5 && turnCounter <= 50)
            {
                Console.WriteLine("Not bad. At least you sunk them all.");
            }
            else
            {
                Console.WriteLine("You did bad and you should feel bad.");
            }
        }
    }
}

