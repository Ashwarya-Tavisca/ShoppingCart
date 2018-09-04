using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopping_Cart
{
    class CardPayment:IPayment ,ICardPayment
    {
        public void SaveDetails()
        {
            throw new NotImplementedException();
        }
        public void SaveCardDetails()
        {
            throw new NotImplementedException();
        }
    }
}
