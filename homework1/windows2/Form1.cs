using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace windows2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string m = textBox1.Text;
            string n = textBox2.Text;
            double a = Double.Parse(m);
            double b = Double.Parse(n);
            int s = comboBox1.SelectedIndex;
            switch (s)
            {
                case 0:
                    label5.Text = $"{a + b}";
                    break;
                case 1:
                    label5.Text = $"{a - b}";
                    break;
                case 2:
                    label5.Text = $"{a * b}";
                    break;
                case 3:
                    label5.Text = $"{a / b}";
                    break;
            }
        }
       
    }
}
