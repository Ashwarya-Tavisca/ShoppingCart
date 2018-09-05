using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart
{
    class Users
    {
        public static void Main(string[] args)
        {
            List<Items> items = new List<Items>()
            {
            new Items()
                {
                    ItemId = 1,
                    ItemName = "Cup",
                    ItemPrice = 100,
                    ItemQuantity = 5
                },
                new Items()
                {
                    ItemId = 2,
                    ItemName = "Plate",
                    ItemPrice = 120,
                    ItemQuantity = 10
                },
                new Items()
                {
                    ItemId = 3,
                    ItemName = "Glass",
                    ItemPrice = 40,
                    ItemQuantity = 2
                },
                new Items()
                {
                    ItemId = 4,
                    ItemName = "Containers",
                    ItemPrice = 240,
                    ItemQuantity = 10
                }


            };
           
            CartOperations cartOperations = new CartOperations();
            CartPrice cartpriceobj = new CartPrice();
            bool flag = true;
            while (flag)
            {
                int selectedOption;
                Console.WriteLine("Enter 1 to Display cart\nEnter 2 To add item\nEnter 3 To delete item\nEnter 4 To view cart amount\nEnter 5 To clear cart \nEnter 6 to Enter Payment Method \nEnter 7 to Exit");
                int.TryParse(Console.ReadLine(), out selectedOption);
                switch (selectedOption)
                {
                    case 1:
                        cartOperations.ShowCart(items);
                        break;
                    case 2:
                        Items item = new Items();
                        cartOperations.AddItemsToCart(cartOperations.GetItemDetails(item),items);
                        break;
                    case 3:
                        Console.WriteLine("Enter item Id to delete");
                        int id;
                        int.TryParse(Console.ReadLine(), out id);
                        cartOperations.RemoveItemsFromCart(id,items);
                        break;
                    case 4:
                        Console.WriteLine("Amount = " + cartOperations.TotalAmountOfCart(items));
                        break;
                    case 5:
                        cartOperations.ClearCart(items);
                        break;
                    case 6:
                        Console.WriteLine("Enter the payment mode: ");
                        string paymentType = Console.ReadLine();
                        Payment pobj = new Payment();
                        IPayment paymentMode = pobj.GetPaymentType(paymentType);
                        cartpriceobj.CalculatePayment(paymentMode, items);
                        break;

                    case 7:
                        flag = false;
                        break;
                    default:
                        break;
                }
            }
        }
       
    }

}

