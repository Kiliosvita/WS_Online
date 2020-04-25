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
    public class Hand:Card
    {
        public int handID { get; set; }
        public Image handPic { get; set; }
        public List<Card> theHand { get; set; }
        public Hand(int ID, Image Pic) : base(ID, Pic)
        {
            theHand = new List<Card>();
        }
    }
}
