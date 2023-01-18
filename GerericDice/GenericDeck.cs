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
   abstract class GenericDeck<T>  where T : struct, IComparable<T>
    {

        public int Size;
        public int Remaining;

        protected List<T> deck;
        protected List<T> discardPile;

       public GenericDeck(int bagSize)
        {
            this.Size = bagSize;
         
     
            deck = new List<T>(bagSize);
            discardPile = new List<T>();
        }


       public virtual T Draw()
       {

           T drawCard = this.deck[0];
           this.discardPile.Add(drawCard);
          this.deck.RemoveAt(0);
           return drawCard;

       }
        public  bool TryDraw() 
        {
           if (deck.Count > 0)
            {
                return true;
            }
            else return false;


        }

        abstract public void Shuffle();

        abstract public void ReShuffle();
       
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
