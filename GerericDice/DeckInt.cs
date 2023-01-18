using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// ---- C# II (Dor Ben Dor) ----
// Roee Tal & Amit Kremer
// -----------------------------

namespace GerericDice
{
    internal class DeckInt : GenericDeck<int>, IComparable<int>
    {

        public DeckInt(int bagSize) : base(bagSize)
        {
            Console.WriteLine("Size is:" + bagSize);
            this.Size = bagSize;
            //deck = new List<int>(bagSize);
            for (int i = 0; i < bagSize; i++)
            {
                deck.Add(i);
            }


            Console.WriteLine("deck size at start is:" + deck.Count);

        }

        public void FillDeck(int minNum, int maxNum)
        {
            Console.WriteLine("deck size is:" + deck.Count);
            Random rand = new Random();


            for (int i = 0; i < deck.Count; i++)
            {
                int randCard = rand.Next(minNum, maxNum);
                deck[i] = (randCard);
                Console.WriteLine($"deck item:{i} is {deck[i]}");
            }


            Remaining = deck.Count;
        }

        public int Draw()
        {
                int drawCard = deck[0];
                discardPile.Add(drawCard);
                deck.RemoveAt(0);
                return drawCard;
        }

        public override void Shuffle()
        {
            Console.WriteLine("Shuffling...");
            if (Remaining > 0)
            {
                List<int> remainingCards = new List<int>();
                for (int i = 0; i < deck.Count; i++)
                {
                    remainingCards.Add(deck[i]);
                    //  Console.WriteLine($"$Remaining cards item:{i} is {remainingCards[i]}");
                }
                Console.WriteLine("-----------------");

                List<int> ShuffledCards = new List<int>();

                Random rand = new Random();
                for (int i = 0; i < remainingCards.Count; i++)
                {
                    int randomPlace = rand.Next(remainingCards.Count);
                    ShuffledCards.Add(remainingCards[randomPlace]);

                }


                for (int i = 0; i < deck.Count; i++)
                {
                    deck[i] = ShuffledCards[i];
                    Console.WriteLine($"deck item:{i} is {deck[i]}");

                }

            }
        }

        public override void ReShuffle()
        {
            Console.WriteLine("ReShuffling...");
            int discardPileCardCount = discardPile.Count;
            Console.WriteLine("discard pile size is:" + discardPileCardCount);
            if (discardPileCardCount > 0)
            {

                List<int> remainingCards = new List<int>();
                for (int i = 0; i < deck.Count; i++)
                {
                    remainingCards.Add(deck[i]);
                    //Console.WriteLine($"deck item:{i} is {deck[i]}");
                    //  Console.WriteLine($"$Remaining cards item:{i} is {remainingCards[i]}");
                }

                Console.WriteLine("-----------------");

                List<int> ShuffledCards = new List<int>();

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
                    Console.WriteLine($"deck item:{i} is {deck[i]}");
                }
                discardPile.Clear();

            }
        }

        public int CompareTo(int other)
        {
            throw new NotImplementedException();
        }

    }
}

