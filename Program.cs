using System;

namespace TicTacToe
{
    class Program
    {
        static bool gameWon = false;
        static char[,] field = new char[3, 3]{
            {'1', '2', '3'},
            {'4', '5', '6'},
            {'7', '8', '9'}
        };

        static void Main(string[] args)
        {
            int player = 1;
            int input = 0;
            bool inputCorrect = true;

            Console.WriteLine("Welcome to Tic Tac Toe!");
            Console.WriteLine("Player 1: X");
            Console.WriteLine("Player 2: O");

            CreateField();

            // Check if game is won

               
            do
            {
                Console.WriteLine($"Player {player}: Choose your field!");
                try
                {
                    input = Convert.ToInt32(Console.ReadLine());

                    if (input < 1 || input > 9)
                    {
                        Console.WriteLine("Please enter a number between 1 and 9!");
                        continue;
                    }

                    
                    do
                    {
                        if ((input == 1) && (field[0, 0] == '1'))
                            inputCorrect = true;
                        else if ((input == 2) && (field[0, 1] == '2'))
                            inputCorrect = true;
                        else if ((input == 3) && (field[0, 2] == '3'))
                            inputCorrect = true;
                        else if ((input == 4) && (field[1, 0] == '4'))
                            inputCorrect = true;
                        else if ((input == 5) && (field[1, 1] == '5'))
                            inputCorrect = true;
                        else if ((input == 6) && (field[1, 2] == '6'))
                            inputCorrect = true;
                        else if ((input == 7) && (field[2, 0] == '7'))
                            inputCorrect = true;
                        else if ((input == 8) && (field[2, 1] == '8'))
                            inputCorrect = true;
                        else if ((input == 9) && (field[2, 2] == '9'))
                            inputCorrect = true;
                        else
                        {
                            Console.WriteLine("Field already taken! Please choose another field!");
                            break;
                        }

                        if (inputCorrect)
                        {
                            XorO(player, input);

                            Console.Clear();
                            CreateField();

                            if (player == 1)
                                player = 2;
                            else
                                player = 1;

                             CheckWin();

                            if (gameWon)
                                break;
                        }
                    }
                    while (!inputCorrect);
                }
                catch
                {
                    Console.WriteLine("Please enter a number!");
                }
            }
            while (!gameWon);

        }

        public static void XorO(int player, int input)
        {
            char playerSign = (player == 1) ? 'X' : 'O';

            switch (input)
            {
                case 1:
                    field[0, 0] = playerSign;
                    break;
                case 2:
                    field[0, 1] = playerSign;
                    break;
                case 3:
                    field[0, 2] = playerSign;
                    break;
                case 4:
                    field[1, 0] = playerSign;
                    break;
                case 5:
                    field[1, 1] = playerSign;
                    break;
                case 6:
                    field[1, 2] = playerSign;
                    break;
                case 7:
                    field[2, 0] = playerSign;
                    break;
                case 8:
                    field[2, 1] = playerSign;
                    break;
                case 9:
                    field[2, 2] = playerSign;
                    break;
            }
        }

        public static void CheckWin(){

                if ((field[0, 0] == field[0, 1]) && (field[0, 1] == field[0, 2])){
                    gameWon = true;
                    if (field[0, 0] == 'X')
                        Console.WriteLine("Player 1 has won!");
                    else
                        Console.WriteLine("Player 2 has won!");

                }
                else if ((field[1, 0] == field[1, 1]) && (field[1, 1] == field[1, 2])){
                    gameWon = true;
                    if (field[1, 0] == 'X')
                        Console.WriteLine("Player 1 has won!");
                    else
                        Console.WriteLine("Player 2 has won!");

                }   
                else if ((field[2, 0] == field[2, 1]) && (field[2, 1] == field[2, 2])){
                    gameWon = true;
                    if (field[2, 0] == 'X')
                        Console.WriteLine("Player 1 has won!");
                    else
                        Console.WriteLine("Player 2 has won!");

                }   
                else if ((field[0, 0] == field[1, 0]) && (field[1, 0] == field[2, 0])){
                    gameWon = true;
                    if (field[0, 0] == 'X')
                        Console.WriteLine("Player 1 has won!");
                    else
                        Console.WriteLine("Player 2 has won!");
                }   
                else if ((field[0, 1] == field[1, 1]) && (field[1, 1] == field[2, 1])){
                    gameWon = true;
                    if (field[0, 1] == 'X')
                        Console.WriteLine("Player 1 has won!");
                    else
                        Console.WriteLine("Player 2 has won!");
                }   
                else if ((field[0, 2] == field[1, 2]) && (field[1, 2] == field[2, 2])){
                    gameWon = true;
                    if (field[0, 2] == 'X')
                        Console.WriteLine("Player 1 has won!");
                    else
                        Console.WriteLine("Player 2 has won!");
                }   
                else if ((field[0, 0] == field[1, 1]) && (field[1, 1] == field[2, 2])){
                    gameWon = true;
                    if (field[0, 0] == 'X')
                        Console.WriteLine("Player 1 has won!");
                    else
                        Console.WriteLine("Player 2 has won!");
                }   
                else if ((field[0, 2] == field[1, 1]) && (field[1, 1] == field[2, 0])){
                    gameWon = true;
                    if (field[0, 2] == 'X')
                        Console.WriteLine("Player 1 has won!");
                    else
                        Console.WriteLine("Player 2 has won!");
                }   
                else if ((field[0, 0] != '1') && (field[0, 1] != '2') && (field[0, 2] != '3') && (field[1, 0] != '4') && (field[1, 1] != '5') && (field[1, 2] != '6') && (field[2, 0] != '7') && (field[2, 1] != '8') && (field[2, 2] != '9')){
                    gameWon = true;
                    Console.WriteLine("Draw!");
                }
                
        }

        public static void CreateField()
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("|   |   |   |");
            Console.WriteLine($"| {field[0, 0]} | {field[0, 1]} | {field[0, 2]} |");
            Console.WriteLine("|___|___|___|");
            Console.WriteLine("|   |   |   |");
            Console.WriteLine($"| {field[1, 0]} | {field[1, 1]} | {field[1, 2]} |");
            Console.WriteLine("|___|___|___|");
            Console.WriteLine("|   |   |   |");
            Console.WriteLine($"| {field[2, 0]} | {field[2, 1]} | {field[2, 2]} |");
            Console.WriteLine("|___|___|___|");
            Console.WriteLine();
        }
    }
}