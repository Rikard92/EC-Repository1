using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2a
{
    class Card
    {
        // 1 Hearts
        // 2 Clover
        // 3 Diemond
        // 4 Spades
        int kind;


        // 0 Ace
        // 1-10 number
        // 11 jack 
        // 12 queen
        // 13 king
        int type;

        public Card(int kind, int type)
        {
            this.type = type;
            this.kind = kind;
        }

        int GettheType()
        {
            return type;
        }

        int GetKind()
        {
            return kind;
        }

    }
}
