using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Shuffle_2
{
    public class Deck
    {
        
        public int decksize { get; set; }
        public Card[] deckMembers { get; set; }
        public Deck(int decksize, Card[] deckMembers)
        {
            this.decksize = decksize;
            this.deckMembers = deckMembers;
        }
    }
}
