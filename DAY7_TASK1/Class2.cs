using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAY7_TASK1
{
    class Product
    {
        int id;
        string name;
        String category;
        double price;

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Category { get => category; set => category = value; }
        public double Price { get => price; set => price = value; }

        public Product(int id, string name, String category, double price)
        {
            id = id;
            category = category;
            name = name;
            price = price;
        }

        public Product()
        {

        }
        public override string ToString()
        {
            return String.Format("id: {0} \n  catagory: {1} \n  name: {2} \n  price: {3}  ", id, category, name, price);
        }
    }
}