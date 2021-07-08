using System;

namespace TicTacToe
{
    class TicTacToeGame
    {
        public static void BoardInitialise()
        {
            char[] board = { '0', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1' };
            foreach (char i in board)
            {
                Console.WriteLine("Element is: {0} ",i);
            }
        }
        static void Main(string[] args)
        {

            Console.WriteLine("welcome to TicTacToe!");
            BoardInitialise();
        }
    }
}
