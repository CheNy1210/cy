using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace homework7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            int n = Int32.Parse(textBox1.Text);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            double leng = double.Parse(textBox2.Text);
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            double per1 = double.Parse(textBox3.Text);
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            double per2 = double.Parse(textBox4.Text);
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            double th1 = double.Parse(textBox5.Text);
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            double th2 = double.Parse(textBox6.Text);
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            string Pen = textBox7.Text;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int n = Int32.Parse(textBox1.Text);
            double leng = double.Parse(textBox2.Text);
            if (graphics == null)
                graphics = groupBox2. CreateGraphics();
            graphics.Clear(BackColor);
            drawCayleyTree(n, 200, 310, leng, -Math.PI / 2);
        }
        private Graphics graphics;
       
        void drawCayleyTree(int n,double x0,double y0,double leng,double th)
        {
            if (n == 0) return;
            double per1 = double.Parse(textBox3.Text);
            double per2 = double.Parse(textBox4.Text);
            double th1 = double.Parse(textBox5.Text);
            double th2 = double.Parse(textBox6.Text);           
            double x1 = x0 + leng * Math.Cos(th);
            double y1 = y0 + leng * Math.Sin(th);
            drawLine(x0, y0, x1, y1);
            drawCayleyTree(n - 1, x1, y1, per1 * leng, th + th1);
            drawCayleyTree(n - 1, x1, y1, per2 * leng, th - th2);

        }
        void drawLine(double x0, double y0, double x1, double y1)
        {              
            graphics.DrawLine(Pens.Black,
                (int)x0, (int)y0, (int)x1, (int)y1);

        }


    }
}
