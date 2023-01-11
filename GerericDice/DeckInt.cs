using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerericDice
{
    internal class DeckInt : GenericDeck<int>
    {

        public int Size;
        public int Remaining;

        List<int> deck;
        List<int> discardPile;

        public DeckInt(int bagSize) 
        {
            this.Size = bagSize;

            deck = new List<int>(bagSize);
        }

 

        public override int Peek()
        {
            throw new NotImplementedException();
        }


        public override void Shuffle()
        {
            if (Remaining > 1)
            {

                List<int> remainingCards = new List<int>();
               foreach (int item in deck)
                {
                    remainingCards.Add(item);
                }
                List<int> ShuffledCards = new List<int>();

                foreach (int item in remainingCards)
                {
                    ShuffledCards.Add(item);
                    
                }
            }
        }
    }
}

