using System.Diagnostics.CodeAnalysis;
using System.Reflection;
using GerericDice;

class program
{
    
  


    static public void Main(String[] args)
    {
        DeckInt deck = new DeckInt(40);
        Dice dice = new Dice(1, 20);
        deck.FillDeck(1,20);
        
      RandomFighterInt randFighter = new RandomFighterInt();
      randFighter.StartSimulation(deck,dice);
        
    }
}




