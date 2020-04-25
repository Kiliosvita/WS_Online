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
    public static class Generator
    {
        //setup lists to store values

        public static readonly List<Card> allCards = new List<Card>();
        public static readonly List<Deckcards> allDecks = new List<Deckcards>();
        public static readonly List<Card> theHand = new List<Card>();

        //Since deck is a child class of card, it needs an image parameter 
        public static Image cardback = Shuffle_2.Properties.Resources.wscb;

        public const int player1_deck = 1;

        //the cards by ID no
        public const int Card01 = 1;
        public const int Card02 = 2;
        public const int Card03 = 3;
        public const int Card04 = 4;
        public const int Card05 = 5;
        public const int Card06 = 6;
        public const int Card07 = 7;
        public const int Card08 = 8;
        public const int Card09 = 9;
        public const int Card10 = 10;

        static Generator()
        {
            printCards();
            buildDeck();
        }

        private static void printCards()
        {
            //There will 100% be a better way to do this but shut up 
            allCards.Add(new Card(Card01, Shuffle_2.Properties.Resources._01));
            allCards.Add(new Card(Card02, Shuffle_2.Properties.Resources._02));
            allCards.Add(new Card(Card03, Shuffle_2.Properties.Resources._03));
            allCards.Add(new Card(Card04, Shuffle_2.Properties.Resources._04));
            allCards.Add(new Card(Card05, Shuffle_2.Properties.Resources._05));
            allCards.Add(new Card(Card06, Shuffle_2.Properties.Resources._06));
            allCards.Add(new Card(Card07, Shuffle_2.Properties.Resources._07));
            allCards.Add(new Card(Card08, Shuffle_2.Properties.Resources._08));
            allCards.Add(new Card(Card09, Shuffle_2.Properties.Resources._09));
            allCards.Add(new Card(Card10, Shuffle_2.Properties.Resources._10));
            
        }

        private static void buildDeck()
        {
            //bring all cards to deck
            Deckcards deck01 = new Deckcards(player1_deck, cardback);
            //Not sure why this doesn't work
            //deck01.deck.Add(new Deckcards(cardbyID(Card01)));
            deck01.deck.Add(new Deckcards(Card10, Shuffle_2.Properties.Resources._01));
            deck01.deck.Add(new Deckcards(Card10, Shuffle_2.Properties.Resources._02));
            deck01.deck.Add(new Deckcards(Card10, Shuffle_2.Properties.Resources._03));
            deck01.deck.Add(new Deckcards(Card10, Shuffle_2.Properties.Resources._04));
            deck01.deck.Add(new Deckcards(Card10, Shuffle_2.Properties.Resources._05));
            deck01.deck.Add(new Deckcards(Card10, Shuffle_2.Properties.Resources._06));
            deck01.deck.Add(new Deckcards(Card10, Shuffle_2.Properties.Resources._07));
            deck01.deck.Add(new Deckcards(Card10, Shuffle_2.Properties.Resources._08));
            deck01.deck.Add(new Deckcards(Card10, Shuffle_2.Properties.Resources._09));
            deck01.deck.Add(new Deckcards(Card10, Shuffle_2.Properties.Resources._10));

            allDecks.Add(deck01);
        }

        //Find card by ID
        public static Card cardbyID(int id)
        {
            foreach(Card acard in allCards)
            {
                if(acard.ID == id)
                {
                    return acard;
                }
            }
         return null;
        }

        //Find deck by ID
        public static Deckcards PlayerDeck(int deckID)
        {
            foreach(Deckcards finddeck in allDecks)
            {
                if(finddeck.ID == deckID)
                {
                    return finddeck;
                }
            }
            return null;
        }

        //Find card by Image
        public static Card imgofcard(Image cardImage)
        {
            foreach (Card imgofcard in allCards)
            {
                if (imgofcard.Pic == cardImage)
                {
                    return imgofcard;
                }
            }
            return null;
        }

    }
}
