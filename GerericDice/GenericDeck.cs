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

       //abstract public T Draw();
       public virtual T Draw()
       {
           // Random rand = new Random();
           //int drawnCardNum = rand.Next(deck.Count);
           //int drawnCard = deck[drawnCardNum];
           //discardPile.Add(drawnCard);
           //deck.RemoveAt(drawnCardNum);
           //Remaining = deck.Count;
           T drawCard = this.deck[0];
           this.discardPile.Add(drawCard);
          this.deck.RemoveAt(0);
           return drawCard;

       }

        abstract public void Shuffle();

        abstract public void ReShuffle();
       
        public virtual bool TryDraw()
        {
           if (deck.Count > 0) return true;
           else return false;
        }
        abstract public T Peek();
      





    }
}
