using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Milestone4_
{
    class Inventory
    {
        private List<Product> InventoryList;

        public Inventory()
        {
            InventoryList = new List<Product>();
        }

        public int getInventorySize()
        {
            return InventoryList.Count;
        }

        public Product getItem(int index)
        {
            return InventoryList[index];
        }

        public void addItem(Product addedItem)
        {
            InventoryList.Add(addedItem);
        }

        public void removeItem(Product removedItem)
        {
            InventoryList.Remove(removedItem);
        }

        public void restockItem(Product product, int amountIn)
        {
            product.addStock(amountIn);
        }

        public void displayAllProducts()
        {
            for (int i = 0; i < InventoryList.Count; i++)
            {
                Console.WriteLine(InventoryList[i]);
            }
        }

        public List<Product> findByName(string name)
        {
            List<Product> searchResults = new List<Product>();
            for (int i = 0; i < InventoryList.Count; i++)
            {
                if (InventoryList[i].Name.Contains(name))
                {
                    searchResults.Add(InventoryList[i]);
                }
            }
            return searchResults;
        }

        public Product findByID(int id)
        {
            Product result = new Product();
            for (int i = 0; i < InventoryList.Count; i++)
            {
                if (InventoryList[i].ID == id)
                {
                    result = InventoryList[i];
                }
            }
            return result;
        }

        public List<Product> findByPrice(int lowPrice, int highPrice)
        {
            List<Product> searchResults = new List<Product>();
            for (int i = 0; i < InventoryList.Count; i++)
            {
                if (InventoryList[i].Price >= lowPrice && InventoryList[i].Price <= highPrice)
                {
                    searchResults.Add(InventoryList[i]);
                }
            }
            return searchResults;
        }

        public List<Product> findByBrand(string brand)
        {
            List<Product> searchResults = new List<Product>();
            for (int i = 0; i < InventoryList.Count; i++)
            {
                if (InventoryList[i].Brand.Equals(brand))
                {
                    searchResults.Add(InventoryList[i]);
                }
            }
            return searchResults;
        }

        public List<Product> findByPriceAndBrand(int lowPrice, int highPrice, string brand)
        {
            List<Product> searchResults = new List<Product>();
            for (int i = 0; i < InventoryList.Count; i++)
            {
                if (InventoryList[i].Brand.Equals(brand) && InventoryList[i].Price >= lowPrice && InventoryList[i].Price <= highPrice)
                {
                    searchResults.Add(InventoryList[i]);
                }
            }
            return searchResults;
        }

        public List<Product> getAllProducts()
        {
            List<Product> allProducts = new List<Product>();
            for (int i = 0; i < InventoryList.Count; i++)
            {
                Product p = InventoryList[i];
                allProducts.Add(p);
            }
            return allProducts;
        }

        public override string ToString()
        {
            string str = "";
            for (int i = 0; i < InventoryList.Count; i++)
            {
                str += InventoryList[i] + " ";
            }
            return str;
        }

        public Product[] getItemArray()
        {
            int index = 0;
            Product[] itemArray = new Product[InventoryList.Count];
            foreach (Product item in InventoryList)
            {
                Product i = item;
                itemArray[index++] = i;
            }
            return itemArray;
        }
    }
}
