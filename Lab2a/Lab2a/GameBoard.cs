using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2a
{
    class GameBoard
    {

        int playercash;

        List<Card> Playerhand;
        List<Card> Dealerhand;
        int playerscore;
        int dealerscore;
        Dealer Dean;

        public GameBoard()
        {

            Dean = new Dealer();
            playercash = 100;
            playerscore = 0; 
            dealerscore = 0;
            Playerhand = new List<Card>();
            Dealerhand = new List<Card>();

        }

        public void recetTable()
        {
            playerscore = 0;
            dealerscore = 0;
            Dean.resetDeck();
            Playerhand.Clear();
            Dealerhand.Clear();
        }

        internal void printPlayerCards()
        {
            Console.WriteLine("The Player have:");
            for (int i = 0; i < Playerhand.Count(); i++)
            {

                Card thecard = Playerhand[i];
                String Ckind="";
                String Ctype="";

                if (thecard.GettheType() == 1 )
                {
                    Ctype = "Ace";

                }
                else if (thecard.GettheType()>1 && thecard.GettheType() < 11)
                {
                    Ctype = thecard.GettheType().ToString();

                }else if (thecard.GettheType()==11)
                {
                    Ctype = "Jack";
                }
                else if (thecard.GettheType() == 12)
                {
                    Ctype = "Queen";
                }
                else if (thecard.GettheType() == 13)
                {
                    Ctype = "King";
                }


                if (thecard.GetKind() == 1)
                {
                    Ckind = "Clubs";
                }else if (thecard.GetKind() == 2)
                {
                    Ckind = "Diamonds";
                }
                else if (thecard.GetKind() == 3)
                {
                    Ckind = "Hearts";
                }
                else if (thecard.GetKind() == 4)
                {
                    Ckind = "Spades";
                }


                    Console.WriteLine(Ctype + " of " + Ckind);

            }


        }

        public void printDealerCards()
        {
            Console.WriteLine("\nThe Dealer have:");
            for (int i = 0; i < Dealerhand.Count(); i++)
            {

                Card thecard = Dealerhand[i];
                String Ckind = "";
                String Ctype = "";

                if (thecard.GettheType() == 1)
                {
                    Ctype = "Ace";

                }
                else if (thecard.GettheType() > 1 && thecard.GettheType() < 11)
                {
                    Ctype = thecard.GettheType().ToString();

                }
                else if (thecard.GettheType() == 11)
                {
                    Ctype = "Jack";
                }
                else if (thecard.GettheType() == 12)
                {
                    Ctype = "Queen";
                }
                else if (thecard.GettheType() == 13)
                {
                    Ctype = "King";
                }


                if (thecard.GetKind() == 1)
                {
                    Ckind = "Clubs";
                }
                else if (thecard.GetKind() == 2)
                {
                    Ckind = "Diamonds";
                }
                else if (thecard.GetKind() == 3)
                {
                    Ckind = "Hearts";
                }
                else if (thecard.GetKind() == 4)
                {
                    Ckind = "Spades";
                }


                Console.WriteLine(Ctype + " of " + Ckind);

            }
        }

        public void DealThePalyerCard()
        {
            Card thecard = Dean.Deal();
           
            playerscore = playerscore + getcardscore(thecard);

            Playerhand.Add(thecard);


        }

        public void DealTheDealerCard()
        {
            Card thecard = Dean.Deal();

            dealerscore = dealerscore + getcardscore(thecard);

            Dealerhand.Add(thecard);


        }


        public int getPlayercash()
        {
            return playercash;

        }

        public void setPlayercash(int i)
        {
            playercash = i;
        }

        public int getPalyerScore()
        {
            return playerscore;
        }

        public int getDealerScore()
        {
            return dealerscore;
        }

        public int getplayerAmountofcards()
        {
            return Playerhand.Count();
        }

        public bool hasMorethatnFour()
        {
            if (Playerhand.Count()>4)
            {
                return true;
            }

            return false;
        }


        public int getcardscore( Card thecard)
        {
            int value = thecard.GettheType();

            if (value == 1 && (playerscore +11 < 21))
            {
                return 11;

            }else if (value == 1 && (playerscore + 11 > 21))
            {
                return 1;

            }else if(value>10 && value < 14)
            {
                return 10;

            }
            else
            {
                return value;
            }

            
        }

        public void printscore()
        {
            Console.WriteLine("Player: " + getPalyerScore().ToString());
            Console.WriteLine("Dealer: " + getDealerScore().ToString());
            Console.WriteLine();

            printPlayerCards();

            printDealerCards();

            Console.WriteLine();

        }


    }


}
