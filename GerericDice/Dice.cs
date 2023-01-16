using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerericDice
{
    class Dice : GenericDice<int>
    {
        public Dice(uint die, uint scalar) : base(die, scalar)
        {

        }

  
        public override int Roll()
        {

            uint die = this._die;
            uint scalar = this._scalar;

            Console.WriteLine(this.ToString());
            Random rnd = new Random();
            int value = 0;
            int cubeNam = 0;
            Console.WriteLine($" Dice {scalar} times");


            for (int i = 0; i < scalar; i++)
            {
                cubeNam++;
                int cubeVal = rnd.Next(1, (int)die + 1);
                if (i == 0) Console.Write($"1st Roll Value:{cubeVal}");
                if (i == 1) Console.Write($",2nd Roll Value:{cubeVal}");
                if (i == 2) Console.Write($",3rd Roll Value:{cubeVal}");
                if (i >= 3) Console.Write($",{cubeNam}th Roll Value: {cubeVal} ");
                value += cubeVal;
            }
            int moddedValue = value;
            Console.WriteLine("");
            Console.WriteLine($"Value is:{moddedValue} = DiceValue:{value} ");
            Console.WriteLine("");

            return moddedValue;
        }

    }
}
