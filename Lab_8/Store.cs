using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Lab_8
{
    internal class Store
    {
        public List<product> products = new List<product>();
        public List<Manager> managers= new List<Manager>();
        public List<SalesAssociates> salesAssociates= new List<SalesAssociates>();
        public Store() 
        {
            Console.WriteLine("Store has been Created");
        }

        public void showStoreDetails()
        {
            foreach(product p in products)
            {
                string s = $"ID : {p.Id}  Product Name : {p.name}  Price : {p.price}  qty : {p.inventory_level}  Min_qty : {p.inventory_min}  Req Amount : {p.req_level}";
                Console.WriteLine(s);
            }
        }

    }
}
