//Henry Harvey
//This is my own work
//CST-117 Lydia Frtiz
//4-18-19
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Milestone4_
{
    class Product
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Brand { get; set; }
        public int Stock { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }

        public Product(int id, string name, string brand, int stock, double price, string description)
        {
            ID = id;
            Name = name;
            Brand = brand;
            Stock = stock;
            Price = price;
            Description = description;
        }

        public Product()
        {
            ID = -1;
            Name = "N/A";
            Brand = "N/A";
            Stock = -1;
            Price = -1;
            Description = "N/A";
        }

        public void addStock(int amntIn)
        {
            this.Stock += amntIn;
        }

        public void removeStock(int amntOut)
        {
            this.Stock -= amntOut;
        }

        public override string ToString()
        {
            return "ID: " + ID + ", Name: " + Name + ", Brand: " + Brand + ", Stock: " + Stock + ", Price: " + Price + ", Description: " + Description;
        }

    }
}
