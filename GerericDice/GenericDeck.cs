using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

// ---- C# II (Dor Ben Dor) ----
// Roee Tal & Amit Kremer
// -----------------------------

namespace GerericDice
{
    class GenericDeck<T> where T : struct, IComparable<T>
    {

        public int Size;
        public int Remaining;

        private List<T> deck;
        private List<T> discardPile;


        public GenericDeck(List<T> Cards)
        {
            this.Size = Cards.Count;
            deck = new List<T>();
            foreach (T item in Cards)
            {
                deck.Add(item);
            }

            discardPile = new List<T>();
        }

        public virtual T Draw()
        {
            Console.WriteLine(this.deck[0]);
            T drawCard = this.deck[0];
            this.discardPile.Add(drawCard);
            this.deck.RemoveAt(0);
            return drawCard;

        }
        public bool TryDraw()
        {
            if (deck.Count > 0)
            {
                return true;
            }
            else return false;

        }


        public void Shuffle()
        {
            Console.WriteLine("Shuffling...");
            if (Remaining > 0)
            {
                List<T> remainingCards = new List<T>();
                for (int i = 0; i < deck.Count; i++)
                {
                    remainingCards.Add(deck[i]);
                }

                List<T> ShuffledCards = new List<T>();

                Random rand = new Random();
                for (int i = 0; i < remainingCards.Count; i++)
                {
                    int randomPlace = rand.Next(remainingCards.Count);
                    ShuffledCards.Add(remainingCards[randomPlace]);
                }


                for (int i = 0; i < deck.Count; i++)
                {
                    deck[i] = ShuffledCards[i];
                }

            }
        }

        public void ReShuffle()
        {

            int discardPileCardCount = discardPile.Count;
            if (discardPileCardCount > 0)
            {
                List<T> remainingCards = new List<T>();
                for (int i = 0; i < deck.Count; i++)
                {
                    remainingCards.Add(deck[i]);
                }


                List<T> ShuffledCards = new List<T>();

                Random rand = new Random();
                for (int i = 0; i < discardPile.Count; i++)
                {
                    remainingCards.Add(discardPile[i]);
                    deck.Add(discardPile[i]);
                    discardPileCardCount--;

                }

                for (int i = 0; i < remainingCards.Count; i++)
                {
                    int randomPlace = rand.Next(remainingCards.Count);
                    ShuffledCards.Add(remainingCards[randomPlace]);
                    remainingCards.RemoveAt(randomPlace);
                }


                for (int i = 0; i < ShuffledCards.Count; i++)
                {
                    deck[i] = ShuffledCards[i];
                }
                discardPile.Clear();

            }
        }

        public T Peek()
        {
            T card;
            if (deck.Count > 0)
            {
                card = this.deck[0];
                return card;
            }

            else
            {
                Console.WriteLine("no cards in the deck, card is:" + default(T));
                return default(T);
            }
        }


    }
}
