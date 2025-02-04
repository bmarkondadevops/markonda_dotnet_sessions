using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderOrderItemApp.Models
{
    public class OrderItem
    {
        public string _itemName { get; set; }
        public int _quantity { get; set; }
        public double _price { get; set; }

        public OrderItem(string itemName, int quantity, double price)
        {
            _itemName = itemName;
            _quantity = quantity;
            _price = price;
        }

        public override string ToString()
        {
            return $"Item: {_itemName}, Quantity: {_quantity}, Price: {_price:C}";
        }
    }
}
