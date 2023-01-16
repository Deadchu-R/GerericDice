using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace GerericDice
{
   abstract class GenericDeck<T>  where T : struct, IComparable<T>
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


       public virtual T Draw()
       {

           T drawCard = this.deck[0];
           this.discardPile.Add(drawCard);
          this.deck.RemoveAt(0);
           return drawCard;

       }
        public  bool TryDraw<T>(T card) 
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
