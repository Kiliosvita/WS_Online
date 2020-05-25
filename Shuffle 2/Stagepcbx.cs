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
    class Stagepcbx : PictureBox
    {
        Card cardonstage;

        public Stagepcbx() { }

        public Card getCard()
        {
            return cardonstage;
        }

        public void setCard(Card a)
        {
            cardonstage = a;
        }

        public void updateImage()
        {
            if (cardonstage != null)
                Image = cardonstage.getPic();
            else
                Image = null;
        }
    }
}
