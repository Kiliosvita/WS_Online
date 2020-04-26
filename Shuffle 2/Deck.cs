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
    public class Deck
    {

        private List<Card> cards;
        private int cardsleft;

        public Deck()
        {
            cardsleft = 0;
            cards = new List<Card>();
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
            foreach(Card cardToInsert in cardsToInsert)
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

        public Card draw()
        {
            Card theCard = cards[cardsleft-1];
            cards.RemoveAt(cardsleft-1);
            cardsleft -= 1;
            return theCard;

        }
        
    }
}
