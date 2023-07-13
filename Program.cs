using System;

namespace TicTacToe
{
    class Program
    {  
        // create bool to check if game is won
        static bool gameWon = false;

        // create the field using a 2d array
        static char[,] field = new char[3,3]{
            {'1','2','3'},
            {'4','5','6'},
            {'7','8','9'}
        };
        static void Main(string[] args)
        {
            // variable for player turn
            int player = 1;
            // variable for input
            int input = 0;

            Console.WriteLine("Welcome to Tic Tac Toe!");
            Console.WriteLine("Player 1: X");
            Console.WriteLine("Player 2: O");

            // Print the initial field
            CreateField();

            do
            {
                Console.WriteLine($"Player {player}: Choose your field!");
                try
                {
                    input = Convert.ToInt32(Console.ReadLine());

                    if(input < 1 || input > 9)
                    { 
                        Console.WriteLine("Please enter a number between 1 and 9!");
                        continue;
                    }

                    XorO(player, input);

                    if (player == 1)
                        player = 2;
                    else if (player == 2)
                        player = 1;

                    Console.Clear();
                    CreateField(); // Print the updated field
                }
                catch
                {
                    Console.WriteLine("Please enter a number!");
                }
            }
            while(!gameWon);
        }

        // method to place X or O
        public static void XorO(int player, int input)
        {
            char playerSign = ' ';

            if (player == 1)
                playerSign = 'X';
            else if (player == 2)
                playerSign = 'O';

            switch (input)
            {
                case 1: field[0, 0] = playerSign; break;
                case 2: field[0, 1] = playerSign; break;
                case 3: field[0, 2] = playerSign; break;
                case 4: field[1, 0] = playerSign; break;
                case 5: field[1, 1] = playerSign; break;
                case 6: field[1, 2] = playerSign; break;
                case 7: field[2, 0] = playerSign; break;
                case 8: field[2, 1] = playerSign; break;
                case 9: field[2, 2] = playerSign; break;
            } 
        }

        // create method to create the field
        public static void CreateField()
        {
            Console.Clear();
            Console.WriteLine(); // Empty line to create separation
            Console.WriteLine("|   |   |   |");
            Console.WriteLine($"| {field[0,0]} | {field[0,1]} | {field[0,2]} |");
            Console.WriteLine("|___|___|___|");
            Console.WriteLine("|   |   |   |");
            Console.WriteLine($"| {field[1,0]} | {field[1,1]} | {field[1,2]} |");
            Console.WriteLine("|___|___|___|");
            Console.WriteLine("|   |   |   |");
            Console.WriteLine($"| {field[2,0]} | {field[2,1]} | {field[2,2]} |");
            Console.WriteLine("|___|___|___|");
            Console.WriteLine(); // Empty line to create separation
        }
    }  
}