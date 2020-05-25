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
    public class WaitingRoom : PictureBox
    {
        private Card cardontop;
        private List<Card> cards;

        public WaitingRoom()
        {
            cards = new List<Card>();
        }


        /*
        public Card getCard()
        {
            return cardinhand;
        }
        */
        public int getCardsleft()
        {
            return cards.Count;
        }

        public void insertCard(Card cardToInsert)
        {
            cards.Add(cardToInsert);
        }

        public Card Card_Select (int index)
        {
            Card selected = cards[index];
            return selected;
        }

        public List<Card> getCards()
        {
            return cards;
        }

        public void updateImage()
        {
            cardontop = cards[getCardsleft() - 1];
            if (cardontop != null)

                Image = cardontop.getPic();
            else
                Image = null;

               
        }
        public void remove()
        {
            cards.RemoveAt(getCardsleft() - 1);
        }
        
    }
}
