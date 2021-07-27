using System;
using System.Collections.Generic;

namespace GoodsStorage
{
    public class Order
    {
        // Items in order.
        public List<Item> Purchases = new List<Item>();
        public double OrderPrice { get; set; }
        public int ItemsCount { get; set; }
        public string OrderNumber { get; set; }
        public Status OrderStatus { get; set; }
        public Order(List<Item> items, DateTime orderTime)
        {
            Purchases = items;
            OrderStatus = Status.________;
            OrderNumber = ParseOrderNumber(orderTime);
            OrderPrice = FindPrice(items);
            ItemsCount = items.Count;
        }
        /// <summary>
        /// Method to find the total price of order.
        /// </summary>
        /// <param name="items">List of all items in the order.</param>
        /// <returns>Total price of order.</returns>
        public double FindPrice(List<Item> items)
        {
            double totalPrice = 0;
            for (int i = 0; i < items.Count; i++)
            {
                totalPrice += items[i].Price;
            }
            return totalPrice;
        }
        /// <summary>
        /// Method for parsing DateTime to the string.
        /// </summary>
        /// <param name="orderTime">DateTime value that need to be parsed.</param>
        /// <returns>Parsed DateTime.</returns>
        public string ParseOrderNumber(DateTime orderTime)
        {
             return DateTime.Now.ToString().Replace(":", string.Empty).Replace(".", string.Empty).Replace(" ", string.Empty); ;
        }
        /// <summary>
        /// Empty constructor for the deserialization.
        /// </summary>
        public Order()
        {

        }
    }
    /// <summary>
    /// Enumeration for the orders status.
    /// </summary>
    public enum Status
    {
        Processed,
        Paid, 
        Shipped,
        Completed,
        ________
    }
}
