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
    public class Deckcards : Card
    {
        public int deckID { get; set; }
        public Image deckPic { get; set; }
        public List<Deckcards> deck { get; set; }
        public Deckcards(int ID, Image Pic) : base(ID, Pic)
        {
            deck = new List<Deckcards>();
        }
        
    }
}
