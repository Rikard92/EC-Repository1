using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2a
{
    class Deck
    {
        Random rng = new Random();
        List<Card> TheDeck;

        public Deck()
        {

            TheDeck = new List<Card>();

            for (int kind=1; kind <5; kind++)
            {
                for (int type=1; type< 14; type++)
                {

                    Card thecard = new Card(kind, type);
                    
                        TheDeck.Add(thecard);


                }
            }
        }

        public void Shufel()
        {
            

            int n = TheDeck.Count();

            for(int i=0; i<n; i++)
            {
                int k = rng.Next(i+1);
                Card tempcard = TheDeck[k];
                TheDeck[k] = TheDeck[i];
                TheDeck[i] = tempcard;


            }
        }

        public void printDeck()
        {
            for(int i=0; i< TheDeck.Count(); i++)
            {

                Card thecard = TheDeck[i];
                Console.WriteLine(thecard.GettheType()+", "+thecard.GetKind());
                
            }

            Console.WriteLine(TheDeck.Count());
        }



        public int getDecsize()
        {
            return TheDeck.Count();
        }

        public Card getaCard()
        {
            Card aCard = TheDeck.First<Card>();
            TheDeck.RemoveAt(0);



            return aCard;
        }


    }
}
