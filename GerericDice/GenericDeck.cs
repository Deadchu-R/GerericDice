using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace GerericDice
{
   abstract class GenericDeck<T> where T : struct, IComparable<T>
    {

        public int Size;
        public int Remaining;

        List<T> deck;
        List<T> discardPile;

        public GenericDeck(int bagSize)
        {
            this.Size = bagSize;
     
            deck = new List<T>(bagSize);
           
        }

        abstract public void Shuffle();
  
        public void ReShuffle()
        {

        }
        public bool TryDraw(T card)
        {
            return true;
        }
        abstract public T Peek();
      





    }
}
