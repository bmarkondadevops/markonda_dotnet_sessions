using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericCollectionApp.Models
{
    internal class OrderItem 
        // Data Tansfer Objects (DTO),Serializtion,Deserialization, Restful APIS,web development
    {

        public int Id { get;  set; }
        public string Name { get;  set; }
        public double UnitPrice { get;  set; }
        public int Quanity { get;  set; }
        //Note: We can set values any where and no need to declare constructor
      
        public double LineItemCost
        {
            get
            {
                return Quanity * UnitPrice;
            }
        }
        public override string ToString()
        {
            return $" Id is {this.Id} , name is {this.Name} Quantity  {this.Quanity} unit price is {this.UnitPrice} , Line Item cost {this.LineItemCost}";
        }


    }
}
