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
        private List<Card> cards;
        private int cardsleft;
        public Hand()
        { 
            cards = new List<Card>();
            cardsleft = 0;
        }

        public int getCardsleft()
        {
            return cardsleft;
        }

        public List<Card> getCards()
        {
            return cards;
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
