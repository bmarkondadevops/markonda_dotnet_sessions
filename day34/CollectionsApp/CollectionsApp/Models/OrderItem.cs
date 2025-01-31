using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsApp.Models
{
    internal class OrderItem
    {
        private int _id;
        private string _name;
        private double _price;
        private int _quantity;

        //Constructor
        public OrderItem(int id, string name, double price, int quantity)
        {
            _id = id;
            _name = name;
            _price = price;
            _quantity = quantity;

        }

        public int Id { get { return _id; } }
        public string Name { get { return _name; } }
        public double Price { get { return _price; } }
        public int Quantity { get { return _quantity; } }

        public double LineItemCost
        {
            get { return _quantity * _price; }
        }
    }
}
