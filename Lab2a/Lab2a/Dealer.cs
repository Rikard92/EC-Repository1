using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2a
{
    class Dealer
    {
        Deck BJDeck;
        int dealercash;

        public Dealer()
        {
            BJDeck = new Deck();
            BJDeck.Shufel();
            dealercash= 100;
        }


        public Card Deal()
        {
            
            Card aCard = BJDeck.getaCard();

            return aCard;

        }

    }
}
