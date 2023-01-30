using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// ---- C# II (Dor Ben Dor) ----
// Roee Tal & Amit Kremer
// -----------------------------

namespace GerericDice
{
    class GenericDice<T> where T : struct, IComparable<T>
    {
        private uint _numberOfSides;

        private List<T> _valuesOfSides;


        public GenericDice( List<T> valuesOfSides)
        {
            this._numberOfSides = (uint)valuesOfSides.Count;
            this._valuesOfSides = new List<T>();

            foreach (T value in valuesOfSides)
            {
                _valuesOfSides.Add(value);
            }

        }
        public T Roll()
        {


            Random rnd = new Random();

            int diceSideIndex = rnd.Next(0, _valuesOfSides.Count);

            T value = _valuesOfSides[diceSideIndex];

            return value;
        }






        public override string ToString()
        {
            return $"die type:{_numberOfSides}sides,   ";

        }
        public override bool Equals([NotNullWhen(true)] object? obj)
        {

            if (obj is GenericDice<T> diceObj) // casting obj as dice
            {

                return this.GetHashCode() == diceObj.GetHashCode();
            }
            return false;

        }
        public override int GetHashCode()
        {
            int a = (int)this._numberOfSides;



            return a * 100;
        }
    }

}

