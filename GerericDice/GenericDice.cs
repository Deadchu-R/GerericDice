using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerericDice
{
    abstract class GenericDice<T> : IComparable
    {
        public uint _die; // how many dice
        public uint _scalar; // how many times die will roll

        public GenericDice(uint die, uint scalar)
        {
            this._die = die;
            this._scalar = scalar;
        }
        public abstract T Roll();
      

        public override string ToString()
        {
            return $"die type:{_die}sides, times to roll:{_scalar},  ";

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
            int a = (int)this._die;
            int b = (int)this._scalar;


            return a * 100 + b * 10;
        }



        public int CompareTo(object? obj)
        {
            throw new NotImplementedException();
        }
    }
}
