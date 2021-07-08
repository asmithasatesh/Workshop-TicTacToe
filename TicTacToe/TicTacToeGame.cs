using System;

namespace TicTacToe
{
    class TicTacToeGame
    {
        //Initialize empty board 
        public static char[] BoardInitialise()
        {
            char[] board = new char[10];
            for(int i=0;i<board.Length;i++)
            {
                board[i] = ' ';
                Console.WriteLine("Element is: {0}\t",board[i]);
            }
            return board;
        }

        //Get user input
        public static char GetPlayerInput()
        {
            Console.WriteLine("\nChoose X or O");
            char player =Convert.ToChar(Console.ReadLine());
            return player;
        }
        //Method to compute computer inputer
        public static char CalculateComputerInput(char player)
        {
            if (player == 'X' || player == 'x')
                return (Convert.ToChar(Convert.ToInt32(player) - 9));
            else
            {
                return (Convert.ToChar(Convert.ToInt32(player) + 9));
            }
        }

        //Main method
        static void Main(string[] args)
        {    
            Console.WriteLine("welcome to TicTacToe!");
            char[] board= BoardInitialise();
            char player = GetPlayerInput();
            char computer = CalculateComputerInput(player);
            Console.WriteLine("Player has chosen {0} and computer has chosen {1}", player,computer);

        }
    }
}
