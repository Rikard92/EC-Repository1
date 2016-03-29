using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2a
{
    class Program
    {
        static void Main(string[] args)
        {

            
            GameBoard Table = new GameBoard();
            bool game = true;
            bool placebet = true;
            bool playerplay = true;
            bool dealerplay = true;
            bool playerwin = false;
            bool autodeal = true;
            int thebet=0;
            String s;


            Console.WriteLine("Wellcom to game of Black Jack.");

            while (game)
            {
                

                if (placebet)
                {

                    Console.WriteLine("Place the amount you wish to bet. (1 - 10)");
                    Console.WriteLine("Curent pocket cash: " + Table.getPlayercash());
                    s = Console.ReadLine();
                    thebet = Int32.Parse(s);

                    placebet = false;

                }
                

                if (playerplay)
                {
                    if (autodeal)
                    {
                        Table.DealThePalyerCard();
                        Console.Clear();
                    }
                    else
                    {
                        Console.WriteLine("Hitt or stay?\n");
                        s = Console.ReadLine();
                        if (s == "Hitt" || s == "hitt" || s == "H" || s == "h")
                        {

                            Table.DealThePalyerCard();
                            Console.Clear();

                        }
                        else if (s == "Stay" || s == "stay" || s == "S" || s == "s")
                        {
                            playerplay = false;
                            Console.Clear();

                        }
                    }

                    autodeal = false;
                }

                if (dealerplay)
                {
                    if (Table.getDealerScore()<=17)
                    {
                        Table.DealTheDealerCard();
                    } else if(Table.getPalyerScore()>17 && Table.getDealerScore() <= 17)
                    {

                        Table.DealTheDealerCard();
                    }
                    
                }
                

                Table.printscore();
                
                
                //both have same score
                if (Table.getPalyerScore() == Table.getDealerScore() && !playerplay )
                {

                    Console.WriteLine("Its a tie ");
                    game = false;
                    dealerplay = false;
                    playerplay = false;
                    if (Table.hasMorethatnFour())
                    {
                        Console.Write("but dealer winns.");
                        playerwin = false;
                    }
                    else
                    {
                        Console.Write("but player winns.");
                        playerwin = true;
                    }


                }
                // both have more than 21
                else if (Table.getPalyerScore() > 21 && Table.getDealerScore() > 21)
                {

                    Console.WriteLine("Nobody winns");
                    game = false;
                    dealerplay = false;
                    playerplay = false;
                    playerwin = false;

                }

                //player win
                else if (Table.getPalyerScore() == 21 || (Table.getPalyerScore() < 22 && Table.getDealerScore() > 21))
                {

                    Console.WriteLine("Player winns.");
                    game = false;
                    dealerplay = false;
                    playerplay = false;
                    playerwin = true;

                }
                //Dealer win
                else if (Table.getDealerScore() == 21 ||(Table.getDealerScore() < 22 && Table.getPalyerScore() > 21))
                {
                   
                    Console.WriteLine("Dealer winns");
                    game = false;
                    dealerplay = false;
                    playerplay = false;
                    playerwin = false;


                }
                // dealer wins if deler has more points and player have stayed
                else if (Table.getPalyerScore() < Table.getDealerScore() && !playerplay)
                {
                    
                    Console.WriteLine("Dealer winns");
                    game = false;
                    dealerplay = false;
                    playerplay = false;
                    playerwin = false;

                }
                
                if (!playerplay)
                {
                    Console.ReadKey();
                    Console.Clear();
                }


                if (!game)
                {

                    if (playerwin)
                    {
                        Console.WriteLine("You win " + thebet.ToString() + " cash.");
                        Table.setPlayercash(Table.getPlayercash() + thebet);
                    }
                    else
                    {
                        Console.WriteLine("You lose " + thebet.ToString() + " cash.");
                        Table.setPlayercash(Table.getPlayercash() - thebet);
                    }
                    if (Table.getPlayercash() < 1)
                    {
                        Console.WriteLine("Player dont have any more money to bet.");
                        Console.ReadKey();
                    }
                    else
                    {

                        Console.WriteLine("Curent pocket cash: " + Table.getPlayercash());
                        Console.WriteLine("New round or quit?");
                        s = Console.ReadLine();
                        if (s == "Bet" || s == "bet" || s == "B" || s == "b" || s == "New" || s == "new" || s == "N" || s == "n")
                        {
                            placebet = true;
                            autodeal = true;
                            dealerplay = true;
                            playerplay = true;
                            Table.recetTable();
                            game = true;

                        }
                        else if (s == "Quit" || s == "quit" || s == "Q" || s == "q")
                        {
                            Console.WriteLine("Quiting Blackjack");
                            Console.ReadKey();

                        }

                    }


                }


            }
            
          
        }
    }
}
