using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace dz_11._04
{
    public partial class Cafe : Form
    {
        int price1, price2, price3, price4;
        public Form1 mainform;
        public Cafe()
        {
            InitializeComponent();
        }
        public void Start()
        {
            textBox1.Text = mainform.hotdog;
            textBox2.Text = mainform.humberger;
            textBox3.Text = mainform.potato;
            textBox4.Text = mainform.cocacola;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
                textBox5.ReadOnly = false;
            else
            {
                textBox5.Clear();
                textBox5.ReadOnly = true;

            }
            if (checkBox2.Checked)
            {
                textBox6.ReadOnly = false;
            }
            else
            {
                textBox6.Clear();
                textBox6.ReadOnly = true;
            }
            if (checkBox3.Checked)
            {
                textBox7.ReadOnly = false;
            }
            else
            {
                textBox7.Clear();
                textBox7.ReadOnly = true;
            }
            if (checkBox4.Checked)
            {
                textBox8.ReadOnly = false;
            }
            else
            {
                textBox8.Clear();
                textBox8.ReadOnly = true;
            }
        }
        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            int count = 0;
            int priceProduct = 0;
            int.TryParse(textBox5.Text, out count);
            int.TryParse(mainform.hotdog, out priceProduct);
            int price = count * priceProduct;
            price1 = price;
            label3.Text = (price1 + price2 + price3 + price4).ToString();
            double num1, result;
            num1 = double.TryParse(label3.Text, out num1) ? num1 : 0;
            result = num1;
            label3.Text = result.ToString() + " грн";
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            int count = 0;
            int priceProduct = 0;
            int.TryParse(textBox6.Text, out count);
            int.TryParse(mainform.humberger, out priceProduct);
            int price = count * priceProduct;
            price2 = price;
            label3.Text = (price1 + price2 + price3 + price4).ToString();
            double num1, result;
            num1 = double.TryParse(label3.Text, out num1) ? num1 : 0;
            result = num1;
            label3.Text = result.ToString() + " грн";
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            mainform.Show();
            ShowDialog();
            notifyIcon1.Visible = false;
        }
        private void Form1_Resize(object sender, EventArgs e)
        {
            if (FormWindowState.Minimized == WindowState)
            {
                mainform.Hide();
                Hide();
                this.notifyIcon1.Visible = true;
                this.notifyIcon1.ShowBalloonTip(3);
            }
        }

        private void Cafe_Load(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            int count = 0;
            int priceProduct = 0;
            int.TryParse(textBox7.Text, out count);
            int.TryParse(mainform.potato, out priceProduct);
            int price = count * priceProduct;
            price3 = price;
            label3.Text = (price1 + price2 + price3 + price4).ToString();
            double num1, result;
            num1 = double.TryParse(label3.Text, out num1) ? num1 : 0;
            result = num1;
            label3.Text = result.ToString() + " грн";
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            int count = 0;
            int priceProduct = 0;
            int.TryParse(textBox8.Text, out count);
            int.TryParse(mainform.cocacola, out priceProduct);
            int price = count * priceProduct;
            price4 = price;
            label3.Text = (price1 + price2 + price3 + price4).ToString();
            double num1, result;
            num1 = double.TryParse(label3.Text, out num1) ? num1 : 0;
            result = num1;
            label3.Text = result.ToString() + " грн" ;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
