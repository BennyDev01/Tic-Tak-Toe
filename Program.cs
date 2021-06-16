using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tic_Tak_Toe
{
    class Program
    {
        static void Main(string[] args)
        {
            //title
            Console.Title = "Tic Tak Toe";

            //start info
            Console.WriteLine("Tic Tak Toe");
            Console.WriteLine("------------");
            Console.WriteLine();
            Console.WriteLine("Player 1 = x");
            Console.WriteLine("Player 2 = o");
            Console.WriteLine();
            Console.WriteLine();
            
            Console.WriteLine("Press Enter to start...");
            Console.ReadLine();
            
            

            //slot deffine
            string[] slots = { "1", "2", "3", "4", "5", "6", "7", "8", "9" };

            slots[0] = "1";
            slots[1] = "2";
            slots[2] = "3";
            slots[3] = "4";
            slots[4] = "5";
            slots[5] = "6";
            slots[6] = "7";
            slots[7] = "8";
            slots[8] = "9";

            //variables
            bool restart = true;
            bool playerSel01 = true;

            //restart
            while (restart == true)
            {
                //reboot
                Console.Clear();

                //player selector 
                if (playerSel01 == true)
                {
                    //player 1
                    
                    //board print
                    Console.WriteLine("Tic Tak Toe");
                    Console.WriteLine("------------");
                    Console.WriteLine();
                    Console.WriteLine("Player 1: ");
                    Console.WriteLine();

                    Console.WriteLine("       Board");
                    Console.WriteLine("+-----+-----+-----+");
                    Console.WriteLine("|  " + slots[0] + "  |  " + slots[1] + "  |  " + slots[2] + "  |");
                    Console.WriteLine("+-----+-----+-----+");
                    Console.WriteLine("|  " + slots[3] + "  |  " + slots[4] + "  |  " + slots[5] + "  |");
                    Console.WriteLine("+-----+-----+-----+");
                    Console.WriteLine("|  " + slots[6] + "  |  " + slots[7] + "  |  " + slots[8] + "  |");
                    Console.WriteLine("+-----+-----+-----+");

                    string player01 = Console.ReadLine();

                    //checking were player01 wants point at
                    if (player01 == "1")
                    {
                        //checks if already selected 1
                        if (slots[0] == "O" || slots[0] == "X")
                        {
                            continue;
                        }
                        else
                        {
                            slots[0] = "X";
                        }
                        
                    }
                    else if (player01 == "2")
                    {
                        //checks if already selected 2
                        if (slots[1] == "O" || slots[1] == "X")
                        {
                            continue;
                        }
                        else
                        {
                            slots[1] = "X";
                        }
                    }
                    else if (player01 == "3")
                    {
                        //checks if already selected 3
                        if (slots[2] == "O" || slots[2] == "X")
                        {
                            continue;
                        }
                        else
                        {
                            slots[2] = "X";
                        }
                    }
                    else if (player01 == "4")
                    {
                        //checks if already selected 4
                        if (slots[3] == "O" || slots[3] == "X")
                        {
                            continue;
                        }
                        else
                        {
                            slots[3] = "X";
                        }
                    }
                    else if (player01 == "5")
                    {
                        //checks if already selected 5
                        if (slots[4] == "O" || slots[4] == "X")
                        {
                            continue;
                        }
                        else
                        {
                            slots[4] = "X";
                        }
                    }
                    else if (player01 == "6")
                    {
                        //checks if already selected 6
                        if (slots[5] == "O" || slots[5] == "X")
                        {
                            continue;
                        }
                        else
                        {
                            slots[5] = "X";
                        }
                    }
                    else if (player01 == "7")
                    {
                        //checks if already selected 7
                        if (slots[6] == "O" || slots[6] == "X")
                        {
                            continue;
                        }
                        else
                        {
                            slots[6] = "X";
                        }
                    }
                    else if (player01 == "8")
                    {
                        //checks if already selected 8
                        if (slots[7] == "O" || slots[7] == "X")
                        {
                            continue;
                        }
                        else
                        {
                            slots[7] = "X";
                        }
                    }
                    else if (player01 == "9")
                    {
                        //checks if already selected 9
                        if (slots[8] == "O" || slots[8] == "X")
                        {
                            continue;
                        }
                        else
                        {
                            slots[8] = "X";
                        }
                    }
                    
                    //checks if player 1 wins
                    if (slots[0] == "X" && slots[1] == "X" && slots[2] == "X")
                    {
                        //win side to side 1
                        Console.WriteLine("Player 1 Wins");
                        Console.WriteLine();


                        //exit
                        Console.WriteLine("Press Enter To exit...");
                        Console.ReadLine();
                        break;
                    }
                    else if (slots[3] == "X" && slots[4] == "X" && slots[5] == "X")
                    {
                        //win side to side 2
                        Console.WriteLine("Player 1 Wins");
                        Console.WriteLine();


                        //exit
                        Console.WriteLine("Press Enter To exit...");
                        Console.ReadLine();
                    }
                    else if (slots[6] == "X" && slots[7] == "X" && slots[8] == "X")
                    {
                        //win side to side 3
                        Console.WriteLine("Player 1 Wins");
                        Console.WriteLine();


                        //exit
                        Console.WriteLine("Press Enter To exit...");
                        Console.ReadLine();
                    }
                    else if (slots[0] == "X" && slots[3] == "X" && slots[6] == "X")
                    {
                        //win vert 1
                        Console.WriteLine("Player 1 Wins");
                        Console.WriteLine();


                        //exit
                        Console.WriteLine("Press Enter To exit...");
                        Console.ReadLine();
                    }
                    else if (slots[1] == "X" && slots[4] == "X" && slots[7] == "X")
                    {
                        //win vert 2
                        Console.WriteLine("Player 1 Wins");
                        Console.WriteLine();


                        //exit
                        Console.WriteLine("Press Enter To exit...");
                        Console.ReadLine();
                    }
                    else if (slots[2] == "X" && slots[5] == "X" && slots[8] == "X")
                    {
                        //win vert 3
                        Console.WriteLine("Player 1 Wins");
                        Console.WriteLine();


                        //exit
                        Console.WriteLine("Press Enter To exit...");
                        Console.ReadLine();
                    }
                    else if (slots[0] == "X" && slots[4] == "X" && slots[8] == "X")
                    {
                        //win dia 1
                        Console.WriteLine("Player 1 Wins");
                        Console.WriteLine();


                        //exit
                        Console.WriteLine("Press Enter To exit...");
                        Console.ReadLine();
                    }
                    else if (slots[6] == "X" && slots[4] == "X" && slots[2] == "X")
                    {
                        //win dia 2
                        Console.WriteLine("Player 1 Wins");
                        Console.WriteLine();


                        //exit
                        Console.WriteLine("Press Enter To exit...");
                        Console.ReadLine();
                    }

                    //player 2s turn
                    playerSel01 = false;

                }
                else if (playerSel01 == false)
                {
                    //player 2

                    //board print
                    Console.WriteLine("Tic Tak Toe");
                    Console.WriteLine("------------");
                    Console.WriteLine();
                    Console.WriteLine("Player 2: ");
                    Console.WriteLine();

                    Console.WriteLine("       Board");
                    Console.WriteLine("+-----+-----+-----+");
                    Console.WriteLine("|  " + slots[0] + "  |  " + slots[1] + "  |  " + slots[2] + "  |");
                    Console.WriteLine("+-----+-----+-----+");
                    Console.WriteLine("|  " + slots[3] + "  |  " + slots[4] + "  |  " + slots[5] + "  |");
                    Console.WriteLine("+-----+-----+-----+");
                    Console.WriteLine("|  " + slots[6] + "  |  " + slots[7] + "  |  " + slots[8] + "  |");
                    Console.WriteLine("+-----+-----+-----+");

                    string player02 = Console.ReadLine();

                    //checking were player01 wants point at
                    if (player02 == "1")
                    {
                        //checks if already selected 1
                        if (slots[0] == "O" || slots[0] == "X")
                        {
                            continue;
                        }
                        else
                        {
                            slots[0] = "O";
                        }
                    }
                    else if (player02 == "2")
                    {
                        //checks if already selected 2
                        if (slots[1] == "O" || slots[1] == "X")
                        {
                            continue;
                        }
                        else
                        {
                            slots[1] = "O";
                        }
                    }
                    else if (player02 == "3")
                    {
                        //checks if already selected 3
                        if (slots[2] == "O" || slots[2] == "X")
                        {
                            continue;
                        }
                        else
                        {
                            slots[2] = "O";
                        }
                    }
                    else if (player02 == "4")
                    {
                        //checks if already selected 4
                        if (slots[3] == "O" || slots[3] == "X")
                        {
                            continue;
                        }
                        else
                        {
                            slots[3] = "O";
                        }
                    }
                    else if (player02 == "5")
                    {
                        //checks if already selected 5
                        if (slots[4] == "O" || slots[4] == "X")
                        {
                            continue;
                        }
                        else
                        {
                            slots[4] = "O";
                        }
                    }
                    else if (player02 == "6")
                    {
                        //checks if already selected 6
                        if (slots[5] == "O" || slots[5] == "X")
                        {
                            continue;
                        }
                        else
                        {
                            slots[5] = "O";
                        }
                    }
                    else if (player02 == "7")
                    {
                        //checks if already selected 7
                        if (slots[6] == "O" || slots[6] == "X")
                        {
                            continue;
                        }
                        else
                        {
                            slots[6] = "O";
                        }
                    }
                    else if (player02 == "8")
                    {
                        //checks if already selected 8
                        if (slots[7] == "O" || slots[7] == "X")
                        {
                            continue;
                        }
                        else
                        {
                            slots[7] = "O";
                        }
                    }
                    else if (player02 == "9")
                    {
                        //checks if already selected 9
                        if (slots[8] == "O" || slots[8] == "X")
                        {
                            continue;
                        }
                        else
                        {
                            slots[8] = "O";
                        }
                    }

                    //checks if player 2 wins
                    if (slots[0] == "O" && slots[1] == "O" && slots[2] == "O")
                    {
                        //win side to side 1
                        Console.WriteLine("Player 2 Wins");
                        Console.WriteLine();


                        //exit
                        Console.WriteLine("Press Enter To exit...");
                        Console.ReadLine();
                        break;
                    }
                    else if (slots[3] == "O" && slots[4] == "O" && slots[5] == "O")
                    {
                        //win side to side 2
                        Console.WriteLine("Player 2 Wins");
                        Console.WriteLine();


                        //exit
                        Console.WriteLine("Press Enter To exit...");
                        Console.ReadLine();
                    }
                    else if (slots[6] == "O" && slots[7] == "O" && slots[8] == "O")
                    {
                        //win side to side 3
                        Console.WriteLine("Player 2 Wins");
                        Console.WriteLine();


                        //exit
                        Console.WriteLine("Press Enter To exit...");
                        Console.ReadLine();
                    }
                    else if (slots[0] == "O" && slots[3] == "O" && slots[6] == "O")
                    {
                        //win vert 1
                        Console.WriteLine("Player 2 Wins");
                        Console.WriteLine();


                        //exit
                        Console.WriteLine("Press Enter To exit...");
                        Console.ReadLine();
                    }
                    else if (slots[1] == "O" && slots[4] == "O" && slots[7] == "O")
                    {
                        //win vert 2
                        Console.WriteLine("Player 2 Wins");
                        Console.WriteLine();


                        //exit
                        Console.WriteLine("Press Enter To exit...");
                        Console.ReadLine();
                    }
                    else if (slots[2] == "O" && slots[5] == "O" && slots[8] == "O")
                    {
                        //win vert 3
                        Console.WriteLine("Player 2 Wins");
                        Console.WriteLine();


                        //exit
                        Console.WriteLine("Press Enter To exit...");
                        Console.ReadLine();
                    }
                    else if (slots[0] == "O" && slots[4] == "O" && slots[8] == "O")
                    {
                        //win dia 1
                        Console.WriteLine("Player 2 Wins");
                        Console.WriteLine();


                        //exit
                        Console.WriteLine("Press Enter To exit...");
                        Console.ReadLine();
                    }
                    else if (slots[6] == "O" && slots[4] == "O" && slots[2] == "O")
                    {
                        //win dia 2
                        Console.WriteLine("Player 2 Wins");
                        Console.WriteLine();


                        //exit
                        Console.WriteLine("Press Enter To exit...");
                        Console.ReadLine();
                    }

                    //player 1s turn
                    playerSel01 = true;

                }
                
            }
            
        }
        
        
    }
}
