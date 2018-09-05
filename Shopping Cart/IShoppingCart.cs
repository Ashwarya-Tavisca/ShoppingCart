using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart
{
    interface IShoppingCart
    {
        void AddItemsToCart(Items item, List<Items> items);
        void RemoveItemsFromCart(int ItemId, List<Items> items);
        double TotalAmountOfCart(List<Items> items);
        void ShowCart(List<Items> items);
        void ClearCart(List<Items> items);
    }
}
