using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vendingmachine
{
    public partial class Form1 : Form
    {
        string product;
        double price = 0;
        Product prods = new Product();
        public Form1()
        {
            InitializeComponent();
        }

        private void ShowProduct()
        {
            productLabel.Text = product;
            priceLabel.Text = price.ToString("C2");
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            Button b = sender as Button;
            if (b.Text == "A1")
            {
                product = "Lays Classic";
                price = 1.00;
                ShowProduct();
                    prods.Buy("Classic", 1.00);
                if (prods.GetCount("Classic") == 0)
                {
                    button1.Enabled = false;
                    pictureBox1.Visible = false;
                }
                    totalLabel.Text = prods.CS.total.ToString("C2");
                    label1.Text = "Purchase Complete";
            }
            if (b.Text == "A2")
            {
                product = "Lays Cheddar and Sour Cream";
                price = 1.00;
                ShowProduct();
 
                    prods.Buy("Cheddar and Sour Cream", 1.00);
                if (prods.GetCount("Cheddar and Sour Cream") == 0)
                {
                    button2.Enabled = false;
                }
                totalLabel.Text = prods.CS.total.ToString("C2");
                    label1.Text = "Purchase Complete";
            }
            if (b.Text == "A3")
            {
                product = "Lays Salt and Vinegar";
                price = 1.00;
                ShowProduct();
                    prods.Buy("Salt and Vinegar", 1.00);
                if (prods.GetCount("Salt and Vinegar") == 0)
                {
                    button3.Enabled = false;
                }
                totalLabel.Text = prods.CS.total.ToString("C2");
                    label1.Text = "Purchase Complete";
            }
            if (b.Text == "A4")
            {
                product = "Lays Barbecue";
                price = 1.00;
                ShowProduct();
                prods.Buy("Barbecue", 1.00);
                if (prods.GetCount("Barbecue") == 0)
                {
                    button4.Enabled = false;
                }
                prods.Buy("Barbecue", 1.00);
                    totalLabel.Text = prods.CS.total.ToString("C2");
                    label1.Text = "Purchase Complete";
            }
            if (b.Text == "A5")
            {
                product = "Lays Honey Barbecue";
                price = 1.00;
                ShowProduct();
                    prods.Buy("Honey Barbecue", 1.00);
                if (prods.GetCount("Honey Barbecue") == 0)
                {
                    button5.Enabled = false;
                }
                totalLabel.Text = prods.CS.total.ToString("C2");
                    label1.Text = "Purchase Complete";
            }
            if (b.Text == "A6")
            {
                product = "Lays Sour Cream and Onion";
                price = 1.00;
                ShowProduct();
                    prods.Buy("Sour Cream and Onion", 1.00);
                if (prods.GetCount("Sour Cream and Onion") == 0)
                {
                    button6.Enabled = false;
                }
                totalLabel.Text = prods.CS.total.ToString("C2");
                    label1.Text = "Purchase Complete";
            }
            if (b.Text == "B1")
            {
                product = "Doritos Sweet Chili";
                price = 2.00;
                ShowProduct();
                prods.Buy("Sweet Chili", 2.00);
                    if (prods.GetCount("Sweet Chili") == 0)
                {
                    button7.Enabled = false;
                }
                totalLabel.Text = prods.CS.total.ToString("C2");
                    label1.Text = "Purchase Complete";
            }
            if (b.Text == "B2")
            {
                product = "Doritos Nacho Cheese";
                price = 2.00;
                ShowProduct();
                    prods.Buy("Nacho", 2.00);
                if (prods.GetCount("Nacho") == 0)
                {
                    button8.Enabled = false;
                }
                totalLabel.Text = prods.CS.total.ToString("C2");
                    label1.Text = "Purchase Complete";
            }
            if (b.Text == "B3")
            {
                product = "Doritos Flamin' Hot Nacho";
                price = 2.00;
                ShowProduct();
                    prods.Buy("Flamin' Hot Nacho", 2.00);
                if (prods.GetCount("Flamin' Hot Nacho") == 0)
                {
                    button9.Enabled = false;
                }
                totalLabel.Text = prods.CS.total.ToString("C2");
                    label1.Text = "Purchase Complete";
            }
            if (b.Text == "B4")
            {
                product = "Doritos Cool Ranch";
                price = 2.00;
                ShowProduct();
                    prods.Buy("Cool Ranch", 2.00);
                if (prods.GetCount("Cool Ranch") == 0)
                {
                    button10.Enabled = false;
                }
                totalLabel.Text = prods.CS.total.ToString("C2");
                    label1.Text = "Purchase Complete";
            }
            if (b.Text == "B5")
            {
                product = "Ruffles Original";
                price = 1.50;
                ShowProduct();
                    prods.Buy("Original", 1.50);
                if (prods.GetCount("Original") == 0)
                {
                    button11.Enabled = false;
                }
                totalLabel.Text = prods.CS.total.ToString("C2");
                    label1.Text = "Purchase Complete";
            }
            if (b.Text == "B6")
            {
                product = "Ruffles Queso";
                price = 1.50;
                ShowProduct();
                    prods.Buy("Queso", 1.50);
                if (prods.GetCount("Queso") == 0)
                {
                    button12.Enabled = false;
                }
                totalLabel.Text = prods.CS.total.ToString("C2");
                    label1.Text = "Purchase Complete";
            }
        }

        private void button16_MouseDown(object sender, MouseEventArgs e)
        {
            Button b = sender as Button;
            prods.CS.InsertCoin(b.Text);
            totalLabel.Text = prods.CS.total.ToString("C2");
        }

        private void button17_Click(object sender, EventArgs e)
        {
            prods.CS.CoinReturn();
            totalLabel.Text = prods.CS.total.ToString("C2");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            prods.AddProduct("Classic", 10);
            prods.AddProduct("Cheddar and Sour Cream", 5);
            prods.AddProduct("Salt and Vinegar", 3);
            prods.AddProduct("Barbecue", 2);
            prods.AddProduct("Honey Barbecue", 6);
            prods.AddProduct("Sour Cream and Onion", 4);
            prods.AddProduct("Sweet Chili", 3);
            prods.AddProduct("Nacho", 5);
            prods.AddProduct("Flamin' Hot Nacho", 3);
            prods.AddProduct("Cool Ranch", 2);
            prods.AddProduct("Original", 6);
            prods.AddProduct("Queso", 4);
        }
    }
}
