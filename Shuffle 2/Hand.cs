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
        private const int maxSize = 7;
        private Card[] cards;

        public Hand()
        { 
            cards = new Card[5];
        }

        public int getCardsleft()
        {
            return cards.Length;
        }

        public Card[] getCards()
        {
            return cards;
        }
        
        public Card getCardAt(int position)
        {
            return cards[position];
        }


        public Card removeCard(int position)
        {
            Card theCard = cards[position];
            cards[position] = null;
            return theCard;
        }

/*        public void insertCards(List<Card> cardsToInsert)
        {
            foreach (Card cardToInsert in cardsToInsert)
            {
                cards.Add(cardToInsert);
            }
        }
*/
        public void insertCard(Card cardToInsert)
        {
            for(int i = 0; i < cards.Length; i++)
            {
                if(cards[i] == null)
                {
                    cards[i] = cardToInsert;
                    break;

                }
            }
        }

        

    }
}
