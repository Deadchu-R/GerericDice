using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerericDice
{
    internal class RandomFigher
    {
        DeckInt randomFigherDeck1 = new DeckInt(40);

        public void UseDeck(int drawTimes)
        {
            randomFigherDeck1.FillDeck(1, 20);
            while (drawTimes >= 0)
            {
                if (randomFigherDeck1.TryDraw())
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
