using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Methods
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        int Cube(int n1)
        {
            int n2 = n1 * n1 * n1;
            return n2;
        }
        int Sum(int k1,int k2)
        {
            return k1 + k2;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            //int number = Convert.ToInt16(textBox1.Text);
            //label1.Text = Cube(number).ToString();
            
            int number1=Convert.ToInt32(textBox1.Text);
            int number2=Convert.ToInt32(textBox2.Text);
            label1.Text = Sum(number2, number1).ToString();
        }
    }
}
