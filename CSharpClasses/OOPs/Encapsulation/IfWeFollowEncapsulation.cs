using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpClasses.OOPs.Encapsulation
{
    internal class IfWeFollowEncapsulation
    {
        private int Amount;
        public int GetAmount()
        {
            return Amount;
        }
        public void SetAmount(int Amount)
        {
            if (Amount > 0)
            {
                this.Amount = Amount;
            }
            else
            {
                throw new Exception("Please Pass a Positive Value");
            }
        }
    }
}
