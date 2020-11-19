using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab6
{
    public partial class Form1 : Form
    {
        List<Product> products = new List<Product>();
        Product selectedProduct;
        double resultSum = 0;
        double amount;
        double cash = 1000;
        public Form1()
        {
            InitializeComponent();
            inizialazeList();
            inizDrop();
            cash_text.Text = cash.ToString();
            toThread();
        }

        private void toThread()
        {
            System.Timers.Timer timer = new System.Timers.Timer();
            timer.Elapsed += new System.Timers.ElapsedEventHandler(sells);
            timer.Interval = 1000 * 30; // 30 seconds
            timer.Start();
           
        }

        private void inThread(Label cash, Label amount, List<Product> products, double cash1)
        {
            Random rnd = new Random();
            Product pr = products[rnd.Next(0, 5)];
            pr.amount--;
            cash1 -= pr.price_sell;
            cash.Text = cash1.ToString();
            amount.Text = pr.amount.ToString();
            MessageBox.Show("Было продано в другом потоке: \nПродукт: " + pr.name + "\nКоличество: 1 \nИтого: " + pr.price_sell);
        } 

        private void sells(object sender, EventArgs e)
        {
            Thread thread = new Thread(
               delegate ()
               {
                  
                   Action action = () =>
                   {
                       inThread(cash_text, amount_product, products, cash);
                   };

                   if (InvokeRequired)
                   {
                       Invoke(action);
                   } else
                   {
                       action();
                   }
               }

               );

            thread.Start();

        }

        private void inizDrop()
        {
            drop_list.Items.Clear();
            foreach(Product pr in products)
            {
                drop_list.Items.Add(pr.name);
            }
            drop_list.SelectedIndex = 0;
            
        }

        private void inizialazeList()
        {
            products.Add(new Product("Картошка", 50, 8.73));
            products.Add(new Product("Лук", 10, 8.79));
            products.Add(new Product("Помидор", 5.3, 29.99));
            products.Add(new Product("Огурец 1с", 7, 43.21));
            products.Add(new Product("Мандарин в/с", 15, 20.25));
            products.Add(new Product("Мандарин 1с", 25, 15.99));

        }

        private void drop_list_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedProduct = products[drop_list.SelectedIndex];
            amount_product.Text = selectedProduct.amount.ToString();
            Double.TryParse(text_amount.Text, out amount);

            sumText.Text = (amount * selectedProduct.price_sell).ToString();
        }

        private void text_amount_TextChanged(object sender, EventArgs e)
        {
            
            Double.TryParse(text_amount.Text, out amount);
            
            sumText.Text = (amount * selectedProduct.price_sell).ToString();
        }

        private void add_to_bin_Click(object sender, EventArgs e)
        {
            double sum;
            Double.TryParse(sumText.Text, out sum);
            if (sum > selectedProduct.price_sell * selectedProduct.amount)
            {
                MessageBox.Show("Слишком много. На складе столько нет.\nКупите меньше, и придите позже!");
            }
            else
            {
                selectedProduct.amount -= amount;
                resultSum += sum;
                amount_product.Text = selectedProduct.amount.ToString();
                sum_in_bin.Text = resultSum.ToString();
            }
        }

        private void pay_Click(object sender, EventArgs e)
        {
            cash -= resultSum;
            sum_in_bin.Text = "0";
            text_amount.Text = "";
            MessageBox.Show("Оплата произведена успешно!");
            cash_text.Text = cash.ToString();

        }
    }
}
