using System;

namespace TicTacToe
{
    class Program
    {
        //The playfield
        static char[,] playfield =
        {
            {'1','2', '3' },
            {'4','5', '6' },
            {'7','8', '9' }
        };
     
        static int turns = 0;
        static void Main(string[] args)
        {
            int player = 2;
            int input = 0;
            bool inputCorrect = true;

            //Run code as long as the program runs
            do
            {

                if (player == 2)
                {
                    player = 1;
                    EnterXorO(player, input);
                }
                else if (player == 1)
                {
                    player = 2;
                    EnterXorO(player, input);
                }

                SetField();
                #region
                //check winning condition
                char[] playerChars = { 'X', 'O' };

                foreach (char playerChar in playerChars)
                {
                    if (((playfield[0, 0] == playerChar) && (playfield[0, 1] == playerChar) && (playfield[0, 2] == playerChar))
                        || ((playfield[1, 0] == playerChar) && (playfield[1, 1] == playerChar) && (playfield[1, 2] == playerChar))
                        || ((playfield[2, 0] == playerChar) && (playfield[2, 1] == playerChar) && (playfield[2, 2] == playerChar))
                        || ((playfield[0, 0] == playerChar) && (playfield[1, 0] == playerChar) && (playfield[2, 0] == playerChar))
                        || ((playfield[0, 1] == playerChar) && (playfield[1, 1] == playerChar) && (playfield[2, 1] == playerChar))
                        || ((playfield[0, 2] == playerChar) && (playfield[1, 2] == playerChar) && (playfield[2, 2] == playerChar))
                        || ((playfield[0, 0] == playerChar) && (playfield[1, 1] == playerChar) && (playfield[2, 2] == playerChar))
                        || ((playfield[2, 0] == playerChar) && (playfield[1, 2] == playerChar) && (playfield[0, 2] == playerChar))
                        )
                    {
                        if (playerChar == 'X')
                        {
                            Console.WriteLine("\nPlayer 2 has won!");
                        }
                        else
                        {
                            Console.WriteLine("\nPlayer 1 has won!");
                        }
                        Console.WriteLine("Press any key to reset the game!");
                        Console.ReadKey();
                        ResetField();
                        break;
                    }
                    else if (turns ==10)
                    {
                        Console.WriteLine("\nThe game ended in a tie!");
                        Console.WriteLine("Press any key to reset the game!");
                        Console.ReadKey();
                        ResetField();
                        break;
                    }

                }
                #endregion

                #region
                //test if field is already taken
                do
                {
                    Console.WriteLine($"\nPlayer {player} :Choose your field!");
                    try
                    {
                        input = Convert.ToInt32(Console.ReadLine());
                    }
                    catch
                    {
                        Console.WriteLine("\nPlease enter a number!");
                    }
                    if ((input == 1) && (playfield[0, 0] == '1'))
                        inputCorrect = true;
                    else if ((input == 2) && (playfield[0, 1] == '2')) 
                    inputCorrect = true;
                    else if ((input == 3) && (playfield[0, 2] == '3'))
                        inputCorrect = true;
                    else if ((input == 4) && (playfield[1, 0] == '4'))
                        inputCorrect = true;
                    else if ((input == 5) && (playfield[1, 1] == '5'))
                        inputCorrect = true;
                    else if ((input == 6) && (playfield[1, 2] == '6'))
                        inputCorrect = true;
                    else if ((input == 7) && (playfield[2, 0] == '7'))
                        inputCorrect = true;
                    else if ((input == 8) && (playfield[2, 1] == '8'))
                        inputCorrect = true;
                    else if ((input == 9) && (playfield[2, 2] == '9'))
                        inputCorrect = true;
                    else
                    {
                        Console.WriteLine("\n Incorrect input! Please use another field!");
                        inputCorrect = false;
                    }

                } while (!inputCorrect);
                #endregion

            } while (true);

            
           

        }
        public static void ResetField()
        {
            char[,] playfieldInitial =
            {
            {'1','2', '3' },
            {'4','5', '6' },
            {'7','8', '9' }
            };
            playfield = playfieldInitial;
            SetField();
            turns = 0;
        }

        public static void SetField()
        {
            Console.Clear();
            Console.WriteLine("         |         |         ");
            Console.WriteLine("   {0}     |   {1}     |   {2}   ",playfield[0,0], playfield[0,1], playfield[0,2]); 
            Console.WriteLine("_________|_________|_________");
            Console.WriteLine("         |         |         ");

            Console.WriteLine("   {0}     |   {1}     |   {2}   ",playfield[1,0], playfield[1,1], playfield[1,2]);
            Console.WriteLine("_________|_________|_________");
            Console.WriteLine("         |         |         ");

            Console.WriteLine("   {0}     |   {1}     |   {2}   ",playfield[2,0], playfield[2,1], playfield[2,2]);
            Console.WriteLine("_________|_________|_________");
            Console.WriteLine("         |         |         ");
            turns++;
        }

        public static void EnterXorO(int player, int input)
        {
            char playerSign = ' ';

            if (player == 1)
                playerSign = 'X';
            else if (player == 2)
                playerSign = 'O';
            switch (input)
            {
                case 1: playfield[0, 0] = playerSign; break;
                case 2: playfield[0, 1] = playerSign; break;
                case 3: playfield[0, 2] = playerSign; break;
                case 4: playfield[1, 0] = playerSign; break;
                case 5: playfield[1, 1] = playerSign; break;
                case 6: playfield[1, 2] = playerSign; break;
                case 7: playfield[2, 0] = playerSign; break;
                case 8: playfield[2, 1] = playerSign; break;
                case 9: playfield[2, 2] = playerSign; break;
            }
            
        }       

        
    }
}
