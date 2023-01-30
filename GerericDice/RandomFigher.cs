using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

// ---- C# II (Dor Ben Dor) ----
// Roee Tal & Amit Kremer
// -----------------------------

namespace GerericDice
{
    internal class RandomFigher<T> where T : struct, IComparable<T>

    {
  
        bool figherSimulation = true;
        //private GenericDeck<T> randomFigherDeck1;
        //private GenericDice<T> randomFigherDice1;


        public void StartSimulation(GenericDeck<T> deck, GenericDice<T> dice) 
        {
         
     
            T deckCardVal;
            T diceVal;
            
           
            int diceWins = 0;
            int deckWins = 0;
            int draws = 0;
            while (figherSimulation)
            {

                if (deck.TryDraw())
                {
                    deckCardVal = deck.Draw();
                    diceVal = dice.Roll();
                    int compareVal = deckCardVal.CompareTo(diceVal);
                    Console.WriteLine("compare value is:" + compareVal);

                    
                   
                    if (compareVal == -1) diceWins++;
                    if (compareVal == 0) draws++;
                    if (compareVal == 1) deckWins++;

                }

                else
                {
                    Console.WriteLine($"dice won:{diceWins}, deck won:{deckWins},draws count:{draws}");
                    figherSimulation = false;
                }
            }
        }

    }

}

