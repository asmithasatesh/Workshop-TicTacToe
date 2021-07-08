using System;

namespace TicTacToe
{
    class TicTacToeGame
    {
        public static char[] BoardInitialise()
        {
            char[] board = { '0', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1' };
            foreach (char i in board)
            {
                Console.WriteLine("Element is: {0}\t",i);
            }
            return board;
        }
        public static char GetPlayerInput()
        {
            Console.WriteLine("\nChoose X or O");
            char player =Convert.ToChar(Console.ReadLine());
            return player;
        }
        static void Main(string[] args)
        {
    
            Console.WriteLine("welcome to TicTacToe!");
            char[] board= BoardInitialise();
            char player1 = GetPlayerInput();
            Console.WriteLine("Player has chosen {0}", player1);

        }
    }
}
