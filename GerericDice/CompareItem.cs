using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerericDice
{
    internal class CompareItem : IComparable<CompareItem>
    {
   
        public int CompareTo(CompareItem? other)
        {
            if (this.Value < other)
            {
                return -1;
            }
            else if (this.Value > other)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
    }
}
