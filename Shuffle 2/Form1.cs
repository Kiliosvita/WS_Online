using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
namespace Shuffle_2
{



    public partial class Form1 : Form
    {

        private Deck currentDeck;
        private Hand currentHand;
        private Card currentCard;
        private Image currentImage;

        Zones[] myZone = new Zones[50];


        PictureBox[] Zone = new PictureBox[29];

        int lastclick;
        int lastcard;
        int oldspot;
        int newspot;

        // Declare Array for Deck & Hand
        


        // Declear Variables for Deck & Hand Size
        int deckSize;
        int handSize;
        int csL_members;
        int csR_members;
        int csM_members;
        int BsL_members;
        int BsR_members;
        int memorySize;
        int stockSize;
        int wroomSize;
        int rsltnSize;
        int lvlSize;
        int clockSize;

        // Boolean to declare 'Start' button been pressed
        bool gameStart = false;

        public Form1()
        {
            InitializeComponent();
            Buildthedeck();
        }

        private void Buildthedeck()
        {
            currentDeck = Generator.buildNewDeck();
            currentHand = Generator.buildNewHand();
            
        }   

        private void Form1_Load(object sender, EventArgs e)
        {
            

            //pictureBoxBSL.Image = Card

            Zone[0] = h1;
            Zone[1] = h2;
            Zone[2] = h3;
            Zone[3] = h4;
            Zone[4] = h5;

            Zone[5] = c1;
            Zone[6] = c2;
            Zone[7] = c3;
            Zone[8] = c4;
            Zone[9] = c5;
            Zone[10] = c6;
            Zone[11] = c7;
            
            Zone[12] = pictureBoxBSL;
            Zone[13] = pictureBoxBSR;
            Zone[14] = pictureBoxCSL;
            Zone[15] = pictureBoxCSM;
            Zone[16] = pictureBoxCSR;

            Zone[17] = Res1;
            Zone[18] = Res2;
            Zone[19] = Res3;
            Zone[20] = Res4;


            for (int i = 0; i <= 20; i++)
            {
                Zone[i].AllowDrop = true;
            }
            
        }

        public void displayDeck()
        {
            // Clear 'Deck' Label
            lblDeck.Text = "";

            // Display Deck
            //for (int i = 0; i < myDeck.Length; i++)
           // {
           //     lblDeck.Text += "deck[" + i + "] = " + myDeck[i].deckMembers + "\n";
           // }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            // Only works if 'Start' button has been pressed
            if (gameStart == true)
            {

                // Call Function to Shuffle Deck
              //  shuffleDeck(myDeck, myDeck[0].decksize);

                // Call Function to Display Deck
                displayDeck();
            }
        }
        // ---------------------------------------------------------------------------------------- //

        // Functions for Shuffling Deck ----------------------------------------------------------- //

        // Execute Function to Shuffle Deck
        public static void shuffleDeck(int r, int n)
        {
            Random rand = new Random();

            // Shuffle all Cards in Deck by Randomly Changing Positions
            for (int i = 0; i < n; i++)
            {
                // Generate Random Number for all Remaining Positions
               // int r = i + rand.Next(n - i);

                // Swapping Card to Random Positon
               // int temp = card[r];
               // card[r] = card[i];
               // card[i] = temp;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
           // int temp = location[0];
            // Copy First Card of Deck to Last Card in Hand



                // Incerease Hand Size by 1
                handSize++;

                // Call Function to Shift Deck Cards Up 1
                shiftDeckCardsUp1(0); // Send 0 to Rep Top Card of Deck -> deck[0]

                // Set Value of Last Card in Deck to 0 after Shifting
               // location[deckSize - 1] = 0;
                // Decrease Deck Size by 1
                deckSize--;

                // Call Function to Display Hand
                displayHand();

                // Call Function to Display Deck
                displayDeck();
            
            
            for (int i = 0; i < 5; i++)
            {
                if (Zone[i].Image == null)
                {
                   // Zone[i].Image = Cards[temp];

                    break;
                }
            }

        }
        public void displayHand()
        {
            // Clear Hand Label
            lblHand.Text = "";

            // Display Hand
            //for (int i = 50; i < 100; i++)
            //{
                //lblHand.Text += "location[" + i + "] = " + location[i] + "\n";
            //}
            for(int i = 0; i < currentHand.getCardsleft(); i++)
            {
                Zone[i].Image = currentHand.getCards()[i].getPic();
            }
        }


        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_DragEnter(object sender, DragEventArgs e) 
        {
            PictureBox btn = sender as PictureBox;

            if (e.Data.GetDataPresent(DataFormats.Bitmap) && (e.AllowedEffect == DragDropEffects.Move))
                e.Effect = DragDropEffects.Move;
            else
                e.Effect = DragDropEffects.None;
            
        }

            private void pictureBox1_DragDrop(object sender, DragEventArgs e)
        {
            var index = -1;
            var cardindex = -1;
            PictureBox btn = sender as PictureBox;
            Image img = null;

            //find array number  of picturebox as index
            for (int i = 0; i < Zone.Length; i++)
            {
                if (Zone[i] == btn)
                {
                    index = i;
                    break;
                }
            }
            newspot = index;
           
            //For card moving to empty space, card value is stored as Cards[cardindex]
            if (Zone[index].Image == null)
            {
                Zone[index].Image = (Bitmap)e.Data.GetData(DataFormats.Bitmap, true);
                //Find the card to change the label

                //for (int i = 0; i < Cards.Length; i++)
               // {
                //    if (Cards[i] == Zone[index].Image)
                //    {
                //        cardindex = i;
              //          break;
              //      }
              //  }
              //  Zone[lastclick].Image = null;
                
            }

            // Card moving to occupied space, positions are swapped instead
            else
            {
                img = Zone[index].Image;
                //Zone[19].Image = img; 
                //testing to see if img works (yes)
                Zone[index].Image = (Bitmap)e.Data.GetData(DataFormats.Bitmap, true);
                //transfer image
               // for (int i = 0; i < Cards.Length; i++)
              //  {
               //     if (Cards[i] == Zone[index].Image)
              //      {
              //          cardindex = i;
              //          break;
              //      }
               // }
              //  Zone[index].Image = Cards[cardindex];
               // Zone[lastclick].Image = img;
                //MessageBox.Show(lastclick.ToString());
                
            
        }
             
        }
        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            var index = -1;
            PictureBox btn = sender as PictureBox;
            if (btn.Image != null)
            {
                if (e.Button == MouseButtons.Left)
                {
                    for (int i = 0; i < Zone.Length; i++)
                    {
                        if (Zone[i] == btn)
                        {
                            index = i;
                            break;
                        }
                    }
                    lastclick = index;
                    Zone[index].DoDragDrop(Zone[index].Image, DragDropEffects.Move);
                    //Position[index].Text = nope;
                }
            }
        }
        
        

        private void button4_Click(object sender, EventArgs e)
        {
            
        }

        private void btnstart_Click(object sender, EventArgs e)
        {
            // 'Start' button has been pressed
            gameStart = true;   

                // Clear all Labels
                lblDeck.Text = "";
                lblHand.Text = "";
            //lblShow.Text = "";

            // Set all values for Deck Array from 1 to 50
            
            
                // Call Function to Display Deck
                displayDeck();
        }

        private void btnShiftUp1_Click(object sender, EventArgs e)
        {
         
                // Only works if 'Start' button has been pressed
                if (gameStart == true)
                {
                    // Call Function to Shift Deck Cards Up 1
                    shiftDeckCardsUp1(0); // Send 0 to Rep Top Slot of Deck -> deck[0]

                    // Call Function to Display Deck
                    displayDeck();
                }
            }

           

        private void btnShiftDown1_Click_1(object sender, EventArgs e)
        {
            // Only works if 'Start' button has been pressed
            if (gameStart == true)
            {
                // Call Function to Shift Deck Cards Down 1
               // shiftDeckCardsDown1();

                // Call Function to Display Deck
                displayDeck();
            }
        }
        public void shiftDeckCardsUp1(int topCard)
        {
           // int temp;
           // int botCard = deckSize - 1;

            // Copy all Cards Up 1
          //  temp = location[topCard];
           // for (int i = topCard; i < botCard; i++)
           // {
         //       location[i] = location[i + 1];
          //  }
         //   location[botCard] = temp;
       // }
       // public void shiftDeckCardsDown1()
       // {
       //     int temp;
          //  int topCard = 0;
          //  int botCard = deckSize - 1;

            // Copy all Cards Down 1
           // temp = location[botCard];
          //  for (int i = botCard; i > topCard; i--)
          //  {
          //      location[i] = location[i - 1];
          //  }
          //  location[topCard] = temp;
        }

        private void BtmDraw_Click(object sender, EventArgs e)
        {
           // int temp = location[deckSize - 1];
            // Copy Last Card of Deck to Last Card in Hand
         //   location[handSize+50] = location[deckSize - 1];
                // Incerease Hand Size by 1
                handSize++;

                // Set Value of Copied Card in Deck to 0
               // location[deckSize - 1] = 0;
                // Decrease Deck Size by 1
                deckSize--;

                currentCard = currentDeck.draw();
                currentHand.insertCard(currentCard);

            // Call Function to Display Hand
                displayHand();

                // Call Function to Display Deck
                displayDeck();

                
           // for (int i = 0; i < 5; i++)
           // {
            //    if (Zone[i].Image == null)
           //     {
           //         Zone[i].Image = Cards[temp];

            //        break;
            //    }
           // }

        }

    }
}

