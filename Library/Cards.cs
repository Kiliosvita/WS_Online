using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Shuffle_2
{

    public class Card
    {

        public PictureBox();
        public int cardNum { get; set; }
        public Image card_img { get; set; }
        public Card(int cardNum, Image card_img)
        {
            this.cardNum = cardNum;
            this.card_img = card_img;
        }
    }

}
