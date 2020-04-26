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
        //public int id { get; set; }
        private Image pic;
        private Boolean flipped;
        
        public Image getPic()
        {
            return pic;
        }

        public Boolean getFlipped()
        {
            return flipped;
        }

        public Card(Image cardPic)
        {
            // id = cardID;
            flipped = false;
            pic = cardPic;
        }

        public void flip()
        {
            if (flipped)
            {
                flipped = false;
            }
            else
                flipped = true;
        }

    }
}
