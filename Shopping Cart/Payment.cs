using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart
{
    class Payment
    {
        public IPayment GetPaymentType(string itemType)
        {
            System.Reflection.Assembly assembly = System.Reflection.Assembly.GetExecutingAssembly();
            var productType = assembly.GetTypes().FirstOrDefault(t => t.Name == itemType);
            return (IPayment)Activator.CreateInstance(productType);
        }
    }
}
