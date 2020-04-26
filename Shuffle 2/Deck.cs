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
        private const int maxSize = 50;
        private List<Card> cards;

        public Deck()
        {
            cards = new List<Card>();
        }

        public int getCardsleft()
        {
            return cards.Count;
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
            }
        }

        public void insertCard(Card cardToInsert)
        {
            cards.Add(cardToInsert);
        }

        public Card draw()
        {
            Card theCard = cards[getCardsleft()-1];
            cards.RemoveAt(getCardsleft()-1);
            return theCard;

        }

        public void shuffle(){
            Random rng = new Random();
            int n = getCardsleft();  
            while (n > 1) {  
                n--;  
                int k = rng.Next(n + 1);  
                Card value = cards[k];  
                cards[k] = cards[n];  
                cards[n] = value;  
            }  

        }
        
    }
}
