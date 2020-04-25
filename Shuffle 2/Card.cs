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
    public class Card
    {
        public int ID { get; set; }
        public Image Pic { get; set; }
        public List<Card> allCards { get; set; }
        public Card(int cardID, Image cardPic)
        {
            ID = cardID;
            Pic = cardPic;

            allCards = new List<Card>();
        }
        
    }
}
