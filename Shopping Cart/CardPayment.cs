﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart
{
    public class CardPayment : IPayment
    {
        public void pay(double cash)
        {
            Console.WriteLine("Enter cardno:");
            int cardno = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter cvv:");
            int cv = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter Expiry Date:");
            int expirydate = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter Card Name:");
            string cardname = Console.ReadLine();
            Console.WriteLine("The amount: " + cash + "has been successfully deducted from the account");
        }


    }
}
