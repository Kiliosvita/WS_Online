using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shuffle_2
{
    public class Hand
    {
        public List<Card> cards { get; set; }
        public int cardsleft;
        public Hand()
        { 
            cards = new List<Card>();
            cardsleft = 0;
        }

        public void insertCards(List<Card> cardsToInsert)
        {
            foreach (Card cardToInsert in cardsToInsert)
            {
                cards.Add(cardToInsert);
                cardsleft += 1;
            }
        }

        public void insertCard(Card cardToInsert)
        {
            cards.Add(cardToInsert);
            cardsleft += 1;
        }

        

    }
}
