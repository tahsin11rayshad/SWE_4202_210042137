using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_8
{
    internal class product
    {
        public int Id { get; set; }
        public string name { get; set; }
        public double price { get; set; }
        public int inventory_level { get; set; }
        public int inventory_min { get; set; }
        public int req_level { get; set; }

        public product(int id, string name, double price, int inventory_level, int inventory_min, int req_level)
        {
            Id = id;
            this.name = name;
            this.price = price;
            this.inventory_level = inventory_level;
            this.inventory_min = inventory_min;
            this.req_level = req_level;
        }
    }
}
