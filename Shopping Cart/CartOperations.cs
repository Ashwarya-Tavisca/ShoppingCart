using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart
{
    class CartOperations:IShoppingCart
    {
        public void AddItemsToCart(Items item,List<Items> items)
        {
            items.Add(item);
        }

        public void RemoveItemsFromCart(int ItemId,List<Items> items)
        {
            items.Remove(items.Find(x => x.ItemId == ItemId));
        }

        public void ShowCart(List<Items> items)
        {
            foreach (Items item in items)
                Console.WriteLine("Id = {0}\tName = {1}\tPrice = {2}\tQuantity = {3}", item.ItemId, item.ItemName, item.ItemPrice, item.ItemQuantity);
        }

        public double TotalAmountOfCart(List<Items> items)
        {
            return items.Sum(it => it.ItemPrice * it.ItemQuantity);
        }

        public void ClearCart(List<Items> items)
        {
            items.Clear();
        }
        public Items GetItemDetails(Items item)
        {
            Console.WriteLine("Enter item Id");
            int id;
            int.TryParse(Console.ReadLine(), out id);
            Console.WriteLine("Enter item Name");
            string name = Console.ReadLine();
            double price;
            Console.WriteLine("Enter item price");
            double.TryParse(Console.ReadLine(), out price);
            int quantity;
            Console.WriteLine("Enter item quantity");
            int.TryParse(Console.ReadLine(), out quantity);
            return new Items()
            {
                ItemId = id,
                ItemName = name,
                ItemPrice = price,
                ItemQuantity = quantity
            };
        }

    }
}
