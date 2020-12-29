using System;

namespace TicTacToe2
{
    class Program
    {
        static int ChoiceOnMenu;
        static char[] section = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
        static int player = 1;
        static int flag = 0;
        static int choice;
        static void Main(string[] args)
        {
            while (true)
            {
                Gamemenu();

                ChoiceOnMenu = Convert.ToChar(Console.ReadLine());
                switch (ChoiceOnMenu)
                {
                    case '1':
                        Console.WriteLine("GAME BOARD");
                        do
                        {
                            Console.Clear();
                            Console.WriteLine("Welcome to tic-tac-toe!");
                            Console.WriteLine("player 1 is X and plaer2 is O");
                            Console.WriteLine("\n");


                            
                            if (player % 2 == 0)
                            {
                                Console.WriteLine("player 2 chance");

                            }
                            else
                            {
                                Console.WriteLine("player 1 chance ");
                            }
                            Console.Write("\n");

                            gameBoard();

                            choice = int.Parse(Console.ReadLine());


                            if (section[choice] != 'X' && section[choice] != 'O')
                            {
                                if (player % 2 == 0)
                                {
                                    section[choice] = 'O';

                                    player++;
                                }
                                else
                                {
                                    section[choice] = 'x';
                                    player++;
                                }
                            }

                            else
                            {
                                Console.WriteLine("sorry the row {0} is already marked with {1} ", choice, section[choice]);
                                Console.WriteLine("\n");
                                Console.WriteLine("PLEASE WAIT ");


                            }
                            flag = whoWon();  

                            Console.Clear();
                            gameBoard();

                            if (flag == 1)
                            {
                                Console.WriteLine(" PLAYER {0} WON CONGRATS!!", (player % 2) + 1);
                            }
                            else
                            {
                                Console.WriteLine("it's a draw !"); 
                            }


                        } while (flag != 1 && flag != -1); 
                        Console.WriteLine("To go to menu press the key!");
                        Console.ReadKey();
                        Console.Clear();
                        break;



                    case '2':
                        Console.WriteLine("Eren Berkay Dinç");
                        Console.WriteLine("Press any key!");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case '3':
                        Console.WriteLine("are you sure you want to quit ? (y/n)");
                        choice = Convert.ToChar(Console.ReadLine());
                        switch (choice)
                        {
                            case 'y':
                                Console.WriteLine("It was really nice game Thank u ! ");
                                System.Environment.Exit(-1);
                                break;

                            case 'n':
                                Console.Clear();
                                break;

                        }
                        break;
                }
                Console.ReadLine();
            }
        }


        private static void gameBoard()
        {


            Console.WriteLine(" {0} | {1} | {2} ", section[1], section[2], section[3]);
            Console.WriteLine("---+---+---");
            Console.WriteLine(" {0} | {1} | {2} ", section[4], section[5], section[6]);
            Console.WriteLine("---+---+---");
            Console.WriteLine(" {0} | {1} | {2} ", section[7], section[8], section[9]);
        }



        private static int whoWon()
        { //rows 
            if (section[1] == section[2] && section[2] == section[3])
            {
                return 1;
            }

            else if (section[4] == section[5] && section[5] == section[6])
            {
                return 1;
            }
            else if (section[6] == section[7] && section[7] == section[8])
            {
                return 1;
            }

            
            else if (section[1] == section[4] && section[4] == section[7])
            {
                return 1;
            }

            
            else if (section[2] == section[5] && section[5] == section[8])
            {
                return 1;
            }

            
            else if (section[3] == section[6] && section[6] == section[9])
            {
                return 1;
            }

            
            else if (section[1] == section[5] && section[5] == section[9])
            {
                return 1;
            }


            else if (section[3] == section[5] && section[5] == section[7])
            {
                return 1;
            }

            else if (section[1] != '1' && section[2] != '2' && section[3] != '3' && section[4] != '4' && section[5] != '5' && section[6] != '6' && section[7] != '7' && section[8] != '8' && section[9] != '9')
            {
                return -1;

            }
            else
            {
                return 0;
            }


        }

        private static void Gamemenu()
            {
                Console.WriteLine("PRESS ANY KEY TO ACCESS MENU");
                Console.WriteLine("WELCOME TO TIC TAC TOE GAMEEE!!! ");
                Console.WriteLine("1. Start a new game ");
                Console.WriteLine("2. Author ");
                Console.WriteLine("3. Exit the game ");






            }
        }
    }

