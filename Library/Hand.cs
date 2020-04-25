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
        public int handsize { get; set; }
        public Card[] handMembers { get; set; }
        public Hand(int handsize, Card[] handMembers)
        {
            this.handsize = handsize;
            this.handMembers = handMembers;
        }
    }
}
