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
            Char computer;
            if (player == 'X' || player == 'x')
            {
                computer = Convert.ToChar(Convert.ToInt32(player) - 9);
            }
                
            else if (player == 'O' || player == 'o')
            {
                computer = Convert.ToChar(Convert.ToInt32(player) + 9);
                
            }
            else
            {
                Console.WriteLine("Invalid player Option! Please try Again!");
                return default;
            }

            Console.WriteLine("Player has chosen: {0} and computer has chosen: {1}", player, computer);
            return (computer);
        }

        //Display Board
        public static void DisplayBoard(char[] board)
        {
            Console.WriteLine("Displaying Board");

            Console.WriteLine("\n  {0}  |  {1}  |  {2}", board[1], board[2], board[3]);
            Console.WriteLine("_____|_____|_____ ");
            Console.WriteLine("     |     |      ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", board[4], board[5], board[6]);
            Console.WriteLine("_____|_____|_____ ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", board[7], board[8], board[9]);
            Console.WriteLine("     |     |      ");
        }

        public static void MakeaMove(char[] board, char player)
        {
            while(true)
            {
                Console.WriteLine("Enter which position to place in range(1 to 9)");
                int position = Convert.ToInt32(Console.ReadLine());
                if(board[position]== ' ')
                {
                    board[position] = player;
                    break;
                }
                else
                {
                    Console.WriteLine("that position is already occupied! Try again");
                }
            }
        }
        //Main method
        static void Main(string[] args)
        {    
            Console.WriteLine("welcome to TicTacToe!");
            char[] board= BoardInitialise();
            char player = GetPlayerInput();
            char computer = CalculateComputerInput(player);
            DisplayBoard(board);
            MakeaMove(board,player);
            DisplayBoard(board);

        }
    }
}
