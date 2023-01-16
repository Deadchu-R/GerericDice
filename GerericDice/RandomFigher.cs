using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace GerericDice
{
    internal class RandomFigher<T> where T : struct, IComparable<T>

    {
        bool figherSimulation = true;
        DeckInt randomFigherDeck1 = new DeckInt(40);
        private Dice randomFigherDice1 = new Dice(1, 20);
        private CompareItem compareItem = new CompareItem();

        public void StartSimulation(GenericDeck<T> deck, GenericDice<T> dice) 
        {
            T deckCardVal;
            T diceVal;
            
           
            int diceWins = 0;
            int deckWins = 0;
            int draws = 0;
            while (figherSimulation)
            {

                if (deck.TryDraw(randomFigherDeck1))
                {
                    deckCardVal = deck.Draw();
                    diceVal = dice.Roll();
                    int compareVal = deckCardVal.CompareTo(diceVal);
                    Console.WriteLine("compare value is:" + compareVal);

                    if (deckCardVal > diceVal)
                   
                    //if (compareVal == -1) diceWins++;
                    //if (compareVal == 0) draws++;
                    //if (compareVal == 1) deckWins++;

                }

                else
                {
                    Console.WriteLine($"dice won:{diceWins}, deck won:{deckWins},draws count:{draws}");
                    figherSimulation = false;
                }
            }
        }

        public void UseDeck(int drawTimes)
        {
            randomFigherDeck1.FillDeck(1, 20);
            while (drawTimes >= 0)
            {
                if (randomFigherDeck1.TryDraw(0))
                {
                    Console.WriteLine(randomFigherDeck1.Draw());
                }

                drawTimes--;
            }

            randomFigherDeck1.Shuffle();
            Console.WriteLine(randomFigherDeck1.Draw());
            Console.WriteLine(randomFigherDeck1.Draw());
            randomFigherDeck1.ReShuffle();





        }


    }
}
