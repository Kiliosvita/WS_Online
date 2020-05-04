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
    class WiatingRoom : PictureBox
    {
        private Card cardinhand;


       

        public Card getCard()
        {
            return cardinhand;
        }

        public void setCard(Card a)
        {
            cardinhand = a;
        }

        public void updateImage()
        {
            if (cardinhand != null)
                Image = cardinhand.getPic();
            else
                Image = null;
        }
    }
}
