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
        // 3 Dimond
        // 4 Spades
        int kind;

        enum cardkind
        {
            Hearts =1,
            Clover =2,
            Dimond =3,
            Spades =4
        }


        // 1 Ace
        // 2-10 number
        // 11 jack 
        // 12 queen
        // 13 king
        int type;

        public Card(int kind, int type)
        {
            this.type = type;
            this.kind = kind;
        }

        public int GettheType()
        {
            return type;
        }

        public int GetKind()
        {
            return kind;
        }

    }
}
