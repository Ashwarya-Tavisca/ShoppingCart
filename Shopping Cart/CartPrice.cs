using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart
{
    class CartPrice
    {
        double totalPrice = 0;
        public void CalculatePayment(IPayment payment, List<Items> itemsList)
        {
            totalPrice = 0;
            foreach (Items item in itemsList)
            {
                totalPrice += item.ItemPrice;
            }
            payment.pay(totalPrice);
        }
    }
}
