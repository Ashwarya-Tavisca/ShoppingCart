using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart
{
    
    class CashPayment
    {
        class Cash : IPayment
        {
            public void pay(double cash)
            {
                Console.WriteLine("Payable Amount:" + cash);
            }
        }
    }
}
