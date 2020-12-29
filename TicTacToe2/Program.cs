using System;

namespace TicTacToe2
{
    class Program
    {
        
        static char[] part = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
        static int player = 1;
        static int PrefersOnMenu;
        static int flag = 0;
        static int prefer;
        static void Main(string[] args)
        {
            while (true)
            {
                Gamemenu();

                PrefersOnMenu = Convert.ToChar(Console.ReadLine());
                switch (PrefersOnMenu)
                {
                    case '1':
                        Console.WriteLine("GAME BOARD");
                        do
                        {
                            Console.Clear();
                            Console.WriteLine("Welcome to tic-tac-toe awesome gameeeee!");
                            Console.WriteLine("PLAYER 1 is X and PLAYER 2 is O \n");
                            


                            
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

                            prefer = int.Parse(Console.ReadLine());


                            if (part[prefer] != 'X' && part[prefer] != 'O')
                            {
                                if (player % 2 == 0)
                                {
                                    part[prefer] = 'O';

                                    player++;
                                }
                                else
                                {
                                    part[prefer] = 'X';
                                    player++;
                                }
                            }

                            else
                            {
                                Console.WriteLine("sorry the row {0} is already marked with {1} ", prefer, part[prefer]);
                                Console.WriteLine("\n");
                                Console.WriteLine("PLEASE WAIT ");


                            }
                            flag = whoWon();  

                            Console.Clear();
                            gameBoard();

                            if (flag == 1)
                            {
                                Console.WriteLine("PLAYER {0} WON CONGRATS!! AWESOMEEEEE", (player % 2) + 1);
                            }
                            else
                            {
                                Console.WriteLine("DRAWWWW !"); 
                            }


                        } while (flag != 1 && flag != -1); 
                        Console.WriteLine("press the key to get any menu!");
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
                        Console.WriteLine("do you want to quit are u sure ? (y/n)");
                        prefer = Convert.ToChar(Console.ReadLine());
                        switch (prefer)
                        {
                            case 'y':
                                Console.WriteLine("It was really good game Thank u ! ");
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


            Console.WriteLine(" {0} | {1} | {2} ", part[1], part[2], part[3]);
            Console.WriteLine("---+---+---");
            Console.WriteLine(" {0} | {1} | {2} ", part[4], part[5], part[6]);
            Console.WriteLine("---+---+---");
            Console.WriteLine(" {0} | {1} | {2} ", part[7], part[8], part[9]);
        }



        private static int whoWon()
        {  
            if (part[1] == part[2] && part[2] == part[3])
            {
                return 1;
            }

            else if (part[4] == part[5] && part[5] == part[6])
            {
                return 1;
            }
            else if (part[6] == part[7] && part[7] == part[8])
            {
                return 1;
            }

            
            else if (part[1] == part[4] && part[4] == part[7])
            {
                return 1;
            }

            
            else if (part[2] == part[5] && part[5] == part[8])
            {
                return 1;
            }

            
            else if (part[3] == part[6] && part[6] == part[9])
            {
                return 1;
            }

            
            else if (part[1] == part[5] && part[5] == part[9])
            {
                return 1;
            }


            else if (part[3] == part[5] && part[5] == part[7])
            {
                return 1;
            }

            else if (part[1] != '1' && part[2] != '2' && part[3] != '3' && part[4] != '4' && part[5] != '5' && part[6] != '6' && part[7] != '7' && part[8] != '8' && part[9] != '9')
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
                Console.WriteLine("WELCOME TO TIC TAC TOE GAMEEE!!! ");
                Console.WriteLine("PRESS ANY KEY TO ACCESS MENU");
                Console.WriteLine("1. Start a new game ");
                Console.WriteLine("2. Author ");
                Console.WriteLine("3. Exit ");






            }
        }
    }
