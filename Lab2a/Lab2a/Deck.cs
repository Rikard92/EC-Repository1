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
            for(int kind=1; kind <5; kind++)
            {
                for (int type=0; type< 14; type++)
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
                Console.WriteLine(TheDeck[i].GetType()+ ","+ TheDeck[i].);

            }
        }



    }
}
