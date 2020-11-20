using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Lab6
{
    public partial class Form1 : Form
    {
       public List<Product> products = new List<Product>();
        Product selectedProduct;
        double resultSum = 0;
        double amount;
        double cash = 10000;
        double[] sumAndAmountXML = { 0, 0 };
       
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
            cash.Text = Math.Round(cash1, 2).ToString();
            amount.Text = Math.Round(pr.amount, 2).ToString();
           
            MessageBox.Show("Было продано в другом потоке: \nПродукт: " + pr.name + "\nКоличество: 1 \nИтого: " + pr.price_sell);
        } 

        private void sells(object sender, EventArgs e)
        {
            sumAndAmountXML[1]++;
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
            
            sumText.Text = Math.Round((amount * selectedProduct.price_sell),2).ToString();
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
                amount_product.Text = Math.Round(selectedProduct.amount, 2).ToString();
                sum_in_bin.Text = Math.Round(resultSum, 2).ToString();
            }
        }

        private void pay_Click(object sender, EventArgs e)
        {
            cash -= resultSum;
            sum_in_bin.Text = "0";
            text_amount.Text = "";
            MessageBox.Show("Оплата произведена успешно!");
            cash_text.Text = cash.ToString();
            sumAndAmountXML[1]++;
            sumAndAmountXML[0] += resultSum;
            resultSum = 0;

        }

        private void toXML_Click(object sender, EventArgs e)
        {
            XmlSerializer formatter = new XmlSerializer(typeof(List<Product>));
            XmlSerializer formatter2 = new XmlSerializer(typeof(double[]));
            // получаем поток, куда будем записывать сериализованный объект
            using (FileStream fs = new FileStream(@"D:\products.xml", FileMode.Truncate))
            {
               
                formatter.Serialize(fs, products);
            }

            using (FileStream fs = new FileStream(@"D:\other.xml", FileMode.Truncate))
            {
                formatter2.Serialize(fs, sumAndAmountXML);
            }

            foreach (Product pr in products)
            {
                pr.amount += 9;
                cash -= 9 * pr.price_buy;
                if (cash < 0)
                {
                    cash += 9 * pr.price_buy;
                    break;
                }
            }

            inizDrop();
            cash_text.Text = Math.Round(cash, 2).ToString();
        }

        private void fromXML_Click(object sender, EventArgs e)
        {

            XmlSerializer formatter = new XmlSerializer(typeof(List<Product>));
            XmlSerializer formatter2 = new XmlSerializer(typeof(double[]));
            string str = "Товары по состояни. на прошлый переучет: ";

            using (FileStream fs = new FileStream(@"D:\products.xml", FileMode.Open))
            {
                List<Product> productsTemp = (List<Product>)formatter.Deserialize(fs);
               
                foreach (Product pr in productsTemp)
                {
                    str += $"\nПродукт: {pr.name}\nКоличество: {pr.amount}";
                }
               

                inizDrop();
            }
            using (FileStream fs = new FileStream(@"D:\other.xml", FileMode.Open))
            {
                double[] sumAndAmountXMLTemp = (double[])formatter2.Deserialize(fs);
                str += $"\nЗа все время было продано на: {sumAndAmountXMLTemp[0]}\nЗа все время магазин посетило: {sumAndAmountXMLTemp[1]} людей";

            }

            MessageBox.Show(str);
        }
    }
}
