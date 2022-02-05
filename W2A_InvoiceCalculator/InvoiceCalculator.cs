using System;
using System.Collections.Generic;
using System.Text;

namespace W2A_InvoiceCalculator
{
    class InvoiceCalculator
    {
        public double Subtotal;
        public double TipPercentage;

        public double GetTipAmount()
        {
            return Subtotal * TipPercentage / 100;
        }

        public double GetHst()
        {
            return Subtotal * 0.13;
        }

        public double GetTotal()
        {
            return Subtotal + GetTipAmount() + GetHst();
        }
    }
}


