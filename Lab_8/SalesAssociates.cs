using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_8
{
    internal class SalesAssociates : Employee
    {
        public double bonus { get; set; }
        public SalesAssociates(string name, int age, double salary) 
        {
            this.name = name;
            this.age = age;
            this.salary = salary;

            Console.WriteLine("Salesman has been added");
            string s = $"Name : {name} -- Age : {age} -- Salary : {salary} -- Bonous : {bonus} -- Total Salary : {salary}";
            Console.WriteLine(s);
        }
        public void sellProduct(int id, int amount, Store s)
        {
            foreach (product p in s.products)
            {
                if (p.Id == id)
                {
                    p.inventory_level -= amount;
                    double x = p.price * (1 / 100);
                    double y = amount * x;
                    bonus += y;
                    Console.WriteLine($"{p.name} has been sold and {name} has recieved a bonous of BDT {y}");
                }
            }
        }
        public override void showEmployeeinfo()
        {
            string s = $"Name : {name} -- Age : {age} -- Salary : {salary} -- bonous : {bonus} -- Total Salary : {salary + bonus}";
            Console.WriteLine(s);
        }
    }
}
