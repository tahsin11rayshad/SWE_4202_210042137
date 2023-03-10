using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_8
{
    internal class Manager : Employee
    {
        public Manager(string _name, int _age, double _salary)
        {
            this.name= _name;
            this.age= _age;
            this.salary= _salary;

            Console.WriteLine("Manager has been added");
            string s = $"Name : {name} -- Age : {age} -- Salary {salary}:";
            Console.WriteLine(s);            
        }
        public void addExistingProduct(int id, int amount, Store s)
        {
            foreach (product p in s.products)
            {
                p.inventory_level += amount;
                Console.WriteLine($"- Added {amount} pieces of {p.name} -");
            }
        }
        public void addproduct(int id, string name, double price, int qty, int min_qty, int req, Store s)
        {
            product p = new product(id, name, price, qty, min_qty, req);
            Console.WriteLine("Product has been added");

            string k = $"ID: {p.Id}, Price: {p.price}, Quantity: {p.inventory_level}, Minimum Quantity: {p.inventory_min}, Reg Amount: {p.req_level} ";
            Console.WriteLine(k);
            s.products.Add(p);
        }

        public override void showEmployeeinfo()
        {
            string s = $"\n\nName : {name} -- Age : {age} -- Salary {salary}:";
            Console.WriteLine(s);
        }

        public void sendRequisition(Store s)
        {
            foreach (product p in s.products)
            {
                if (p.inventory_level<p.inventory_min)
                {
                    Console.WriteLine($"Added {p.req_level} pieces of {p.name}");
                    p.inventory_level += p.req_level;
                }
            }
        }
    }
}
