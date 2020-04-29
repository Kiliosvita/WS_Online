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
        private object currentBlank;
        private object currentBlank2;
        private Image currentImage;

        PictureBox[] TheHand = new PictureBox[50];
        PictureBox[] TheClock = new PictureBox[7];
        PictureBox[] TheStage = new PictureBox[5];
        PictureBox[] Resolution = new PictureBox[5];
        PictureBox[] test = new PictureBox[5];
        PictureBox[] zoneArray;

        PictureBox lastbox;
        int index;

        int lastclick;
        int lastcard;
        int oldspot;
        int newspot;

        // Declare Array for Deck & Hand
        


        // Declear Variables for Deck & Hand Size
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


        //method called on mouse down to track what area the card is coming from
        private void FindArray(PictureBox pbx)
        {

            foreach (PictureBox currentPbx in TheHand)
            {
                if (currentPbx == pbx)
                {
                    zoneArray = TheHand;
                    for (int i=0; i<zoneArray.Length; i++)
                    {
                        if (zoneArray[i] == currentPbx) {
                            index = i;
                            currentCard = currentHand.getCardAt(index);
                            currentHand.removeCard(index);
                            currentBlank = currentHand;
                        }
                    }
                }
            }
            foreach (PictureBox currentPbx in TheClock)
            {
                if (currentPbx == pbx)
                {
                    zoneArray = TheClock;
                }
            }
            foreach (PictureBox currentPbx in TheStage)
            {
                if (currentPbx == pbx)
                {
                    zoneArray = TheStage;
                }
            }
            foreach (PictureBox currentPbx in Resolution)
            {
                if (currentPbx == pbx)
                {
                    zoneArray = Resolution;
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //pictureBoxBSL.Image = Card

            TheHand[0] = handpcbx1;
            TheHand[1] = handpcbx2;
            TheHand[2] = handpcbx3;
            TheHand[3] = handpcbx4;
            TheHand[4] = handpcbx5;


            TheClock[0] = c1;
            TheClock[1] = c2;
            TheClock[2] = c3;
            TheClock[3] = c4;
            TheClock[4] = c5;
            TheClock[5] = c6;
            TheClock[6] = c7;
            
            TheStage[0] = pictureBoxBSL;
            TheStage[1] = pictureBoxBSR;
            TheStage[2] = pictureBoxCSL;
            TheStage[3] = pictureBoxCSM;
            TheStage[4] = pictureBoxCSR;

            Resolution[0] = Res1;
            Resolution[1] = Res2;
            Resolution[2] = Res3;
            Resolution[3] = Res4;

            test[0] = pictureBox6;
            test[1] = pictureBox5;
            test[2] = pictureBox4;
            test[3] = pictureBox3;
            test[4] = pictureBox2;

            for (int i = 0; i <5; i++)
            {
                TheHand[i].AllowDrop = true;
            }
            for (int i = 0; i < 7; i++)
            {
                TheClock[i].AllowDrop = true;
            }
            for (int i = 0; i < 5; i++)
            {
                TheStage[i].AllowDrop = true;
            }
            for (int i = 0; i < 4; i++)
            {
                Resolution[i].AllowDrop = true;
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
                currentDeck.shuffle();
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
            if (currentDeck.getCardsleft() != 0)
            {
                currentCard = currentDeck.draw();
                currentHand.insertCard(currentCard);

                // Call Function to Display Hand
                displayHand();

                // Call Function to Display Deck
                displayDeck();
            }
            else
            {
                MessageBox.Show("The deck is empty");
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
                TheHand[i].Image = currentHand.getCards()[i].getPic();
            }
        }
        

        private void button3_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 5; i++)
            {
                test[i].Image = null;
            }
            for (int i = 0; i < currentHand.getCardsleft(); i++)
            {
                test[i].Image = currentHand.getCards()[i].getPic();
            }
        }

        private void pictureBox1_DragEnter(object sender, DragEventArgs e) 
        {
            PictureBox btn = sender as PictureBox;

            if (e.Data.GetDataPresent(DataFormats.Bitmap) && (e.AllowedEffect == DragDropEffects.Move))
                e.Effect = DragDropEffects.Move;
            else
                e.Effect = DragDropEffects.None;
            
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            lastbox = sender as PictureBox;
            if (lastbox.Image != null)
            {
                if (e.Button == MouseButtons.Left)
                {
                    lastbox.DoDragDrop(lastbox.Image, DragDropEffects.Move);
                }
            }
        }

        private void pictureBox1_DragDrop(object sender, DragEventArgs e)
        {
          
            PictureBox pbx = sender as PictureBox;
            Image img = null;
            FindArray(lastbox);
            int in1 = index;

            //For card moving to empty space, card value is stored as Cards[cardindex]
            if (pbx.Image == null)
            {
                //remove current card handled by other
                //insert new value handled elsewhere as well
                pbx.Image = (Bitmap)e.Data.GetData(DataFormats.Bitmap, true);
                lastbox.Image = null;
                FindArray(pbx);


            }
            // Card moving to occupied space, positions are swapped instead
            else
            {
                img = pbx.Image;
                pbx.Image = (Bitmap)e.Data.GetData(DataFormats.Bitmap, true);
                lastbox.Image = img;
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
            if (currentDeck.getCardsleft() != 0)
            {
                currentCard = currentDeck.drawFromBot();
                currentHand.insertCard(currentCard);

                // Call Function to Display Hand
                displayHand();

                // Call Function to Display Deck
                displayDeck();
            }
            else
            {
                MessageBox.Show("The deck is empty");
            }
        }

       
    }
}

