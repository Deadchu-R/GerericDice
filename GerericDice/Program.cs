using System.Diagnostics.CodeAnalysis;
using System.Reflection;
using GerericDice;

// ---- C# II (Dor Ben Dor) ----
// Roee Tal & Amit Kremer
// -----------------------------
class program
{
    
    static public void Main(String[] args)
    {
        List<int> _deckCards = new List<int>();
        List<int> _diceSidesObjects = new List<int>();

        for (int i = 0; i < 40; i++)
       {
           Random rand = new Random();
           int cardVal = rand.Next(0,40);
           _deckCards.Add(cardVal);
       }
        for (int i = 0; i < 20; i++)
        {
            Random rand = new Random();
            int diceSideVal = rand.Next(0, 40);
            _diceSidesObjects.Add(diceSideVal);  
        }

    
        GenericDeck<int>  deck = new GenericDeck<int>(_deckCards);
        GenericDice<int> dice = new GenericDice<int>(_diceSidesObjects);

        
      RandomFigher<int> randFighter = new RandomFigher<int>();
      randFighter.StartSimulation(deck,dice);
        
    }
}




