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

        public string slot { get; set; }
        public int position { get; set; }
        public int cardNum { get; set; }
        public Image card_img { get; set; }
        public Card(string slot, int position, int cardNum, Image card_img)
        {
            this.slot = slot;
            this.position = position;
            this.cardNum = cardNum;
            this.card_img = card_img;
        }
        public static Card[] setup()
        {
            Card[] mycards = new Card[50];

            Image[] pictures = new Image[]  {null, Shuffle_2.Properties.Resources._01, Shuffle_2.Properties.Resources._02,
            Shuffle_2.Properties.Resources._03, Shuffle_2.Properties.Resources._04, Shuffle_2.Properties.Resources._05, Shuffle_2.Properties.Resources._06, Shuffle_2.Properties.Resources._07,
            Shuffle_2.Properties.Resources._08, Shuffle_2.Properties.Resources._09, Shuffle_2.Properties.Resources._10, Shuffle_2.Properties.Resources._11, Shuffle_2.Properties.Resources._12,
            Shuffle_2.Properties.Resources._13, Shuffle_2.Properties.Resources._14, Shuffle_2.Properties.Resources._15, Shuffle_2.Properties.Resources._16, Shuffle_2.Properties.Resources._17,
            Shuffle_2.Properties.Resources._18, Shuffle_2.Properties.Resources._19, Shuffle_2.Properties.Resources._20, Shuffle_2.Properties.Resources._21, Shuffle_2.Properties.Resources._22,
            Shuffle_2.Properties.Resources._23, Shuffle_2.Properties.Resources._24, Shuffle_2.Properties.Resources._25,
            Shuffle_2.Properties.Resources._26, Shuffle_2.Properties.Resources._27,
            Shuffle_2.Properties.Resources._28, Shuffle_2.Properties.Resources._29,
            Shuffle_2.Properties.Resources._30, Shuffle_2.Properties.Resources._31,
            Shuffle_2.Properties.Resources._32, Shuffle_2.Properties.Resources._33,
            Shuffle_2.Properties.Resources._34, Shuffle_2.Properties.Resources._35,
            Shuffle_2.Properties.Resources._36, Shuffle_2.Properties.Resources._37,
            Shuffle_2.Properties.Resources._38, Shuffle_2.Properties.Resources._39,
            Shuffle_2.Properties.Resources._40, Shuffle_2.Properties.Resources._41,
            Shuffle_2.Properties.Resources._42, Shuffle_2.Properties.Resources._43,
            Shuffle_2.Properties.Resources._44, Shuffle_2.Properties.Resources._45,
            Shuffle_2.Properties.Resources._46, Shuffle_2.Properties.Resources._47,
            Shuffle_2.Properties.Resources._48, Shuffle_2.Properties.Resources._49,
            Shuffle_2.Properties.Resources._50, Shuffle_2.Properties.Resources.wscb
            };
            for (int i = 0; i < 50; i++)
            {
                mycards[i] = new Card("Deck", i, i + 1, pictures[i + 1]);
            }

            return mycards;
        }

    }



}
