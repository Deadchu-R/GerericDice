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
        DeckInt deck = new DeckInt(40);
        Dice dice = new Dice(20, 1);
        deck.FillDeck(1,20);
        
      RandomFighterInt randFighter = new RandomFighterInt();
      randFighter.StartSimulation(deck,dice);
        
    }
}




