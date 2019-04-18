using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Milestone4_
{
    public partial class Form1 : Form
    {
        private Inventory inventory;

        public Form1()
        {
            InitializeComponent();
            inventory = new Inventory();

            load();

            // Testing Products
            //inventory.addItem(new Product(1, "Reese's Cup", "Hershey's", 20, 2.99, "Peanut Butter Chocolate Candy"));
            //inventory.addItem(new Product(2, "Kiss", "Hershey's", 50, .99, "Chocolate"));
            //inventory.addItem(new Product(3, "Dum Dums", "Dum Dums", 10, 1.99, "lollipops"));
            //inventory.addItem(new Product(4, "Sour Patch Kids", "Sour Patch Kids", 20, 1.99, "Sweet and Sour candy"));

            // Populate combo boxes
            for(int i = 0; i < inventory.getInventorySize(); i++)
            {
                comboBox_brandSearch.Items.Add(inventory.getItem(i).Brand);
                comboBox_productToAddRemove.Items.Add(inventory.getItem(i));
                comboBox_removeProductID.Items.Add(inventory.getItem(i));
            }

            this.dataGridView.DataSource = this.inventory.getAllProducts();
        }

        private void btn_updateGrid_Click(object sender, EventArgs e)
        {
            // Search by Price & Brand
            if (checkBox_searchPrice.Checked && checkBox_searchBrand.Checked)
            {
                if (!textBox_lowPriceSearch.Text.Equals("") && !textBox_highPriceSearch.Text.Equals("") && !comboBox_brandSearch.Text.Equals(""))
                {
                    int lowPrice = int.Parse(textBox_lowPriceSearch.Text);
                    int highPrice = int.Parse(textBox_highPriceSearch.Text);
                    string brand = comboBox_brandSearch.Text;

                    this.dataGridView.DataSource = inventory.findByPriceAndBrand(lowPrice, highPrice, brand);
                }
                else
                {
                    MessageBox.Show("Please enter a high price, a low price, and a brand");
                }
            }

            // Search by Price
            else if (checkBox_searchPrice.Checked)
            {
                if (!textBox_lowPriceSearch.Text.Equals("") && !textBox_highPriceSearch.Text.Equals(""))
                {
                    int lowPrice = int.Parse(textBox_lowPriceSearch.Text);
                    int highPrice = int.Parse(textBox_highPriceSearch.Text);

                    this.dataGridView.DataSource = inventory.findByPrice(lowPrice, highPrice);
                }
                else
                {
                    MessageBox.Show("Please enter a high and low price");
                }
            }

            // Search by Brand
            else if (checkBox_searchBrand.Checked)
            {
                if (!comboBox_brandSearch.Text.Equals(""))
                {
                    this.dataGridView.DataSource = inventory.findByBrand(comboBox_brandSearch.Text);
                }
                else
                {
                    MessageBox.Show("Please select a brand");
                }
            }
            else
            {
                this.dataGridView.DataSource = this.inventory.getAllProducts();
            }

        }

        // Add Product
        private void btn_addProduct_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox_newName.Text) || string.IsNullOrEmpty(textBox_newBrand.Text) || string.IsNullOrEmpty(textBox_newStock.Text) || string.IsNullOrEmpty(textBox_newPrice.Text) || string.IsNullOrEmpty(richTextBox_newDescription.Text))
            {
                MessageBox.Show("Please Fill In All Fields");
            }
            else
            {
                int newID = inventory.getInventorySize() + 1;
                Product p = new Product(newID, textBox_newName.Text, textBox_newBrand.Text, int.Parse(textBox_newStock.Text), double.Parse(textBox_newPrice.Text), richTextBox_newDescription.Text);
                inventory.addItem(p);

                comboBox_brandSearch.Items.Add(textBox_newBrand.Text);
                comboBox_productToAddRemove.Items.Add(p);
                comboBox_removeProductID.Items.Add(p);

                this.dataGridView.DataSource = this.inventory.getAllProducts();

                textBox_newName.Text = "";
                textBox_newBrand.Text = "";
                textBox_newStock.Text = "";
                textBox_newPrice.Text = "";
                richTextBox_newDescription.Text = "";

                save();
            }
        }

        // Remove Product
        private void btn_removeProduct_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(comboBox_removeProductID.Text))
            {
                MessageBox.Show("Please Fill In All Fields");
            }
            else
            {
                Product product = (Product)comboBox_removeProductID.SelectedItem;

                inventory.removeItem(product);

                comboBox_brandSearch.Items.Remove(product.Brand);
                comboBox_productToAddRemove.Items.Remove(product);
                comboBox_removeProductID.Items.Remove(product);

                this.dataGridView.DataSource = this.inventory.getAllProducts();

                save();
            }
        }

        // Add/Remove Stock
        private void btn_addRemove_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(comboBox_productToAddRemove.Text) || string.IsNullOrEmpty(comboBox_addRemove.Text) || string.IsNullOrEmpty(comboBox_stockToAddRemove.Text))
            {
                MessageBox.Show("Please Fill In All Fields");
            }
            else
            {
                Product product = (Product) comboBox_productToAddRemove.SelectedItem;

                int amount = int.Parse(comboBox_stockToAddRemove.Text);

                // Add Stock
                if (comboBox_addRemove.Text.Equals("Add"))
                {
                    product.addStock(amount);
                }

                // Remove Stock
                if (comboBox_addRemove.Text.Equals("Remove"))
                {
                    if (product.Stock >= amount)
                    {
                        product.removeStock(amount);
                    }
                    else
                    {
                        MessageBox.Show("Cannot Have Negative Stock");
                    }
                }
                label_stock.Text = product.Stock.ToString();
            }
        }

        public void save()
        {
            StreamWriter outputFile;
            outputFile = File.CreateText("inventory.txt");

            for (int i = 0; i < inventory.getInventorySize(); i++)
            {
                outputFile.WriteLine(inventory.getItem(i).ID.ToString() + "|" + inventory.getItem(i).Name + "|" + inventory.getItem(i).Brand + "|" + inventory.getItem(i).Stock.ToString() + "|" + inventory.getItem(i).Price.ToString() + "|" + inventory.getItem(i).Description);
            }
            outputFile.Close();
        }

        public void load()
        {
            StreamReader inputFile;
            inputFile = File.OpenText("inventory.txt");
            int lineCount = File.ReadAllLines("inventory.txt").Length;
            for (int i = 0; i < lineCount; i++)
            {
                String[] words = inputFile.ReadLine().Split('|');
                inventory.addItem(new Product(int.Parse(words[0]), words[1], words[2], int.Parse(words[3]), double.Parse(words[4]), words[5]));
            }
            inputFile.Close();
        }

    }
}
