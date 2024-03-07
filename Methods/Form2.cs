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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        int Sum(int s1,int s2)
        {
            int s3 = s1 + s2;
            return s3;
        }
        int Multi(int m1,int m2,int m3)
        {
            int m4 = m1 * m2 * m3;
            return m4;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            //label1.Text = Sum(3,4).ToString();
            label1.Text=Multi(4,6,8).ToString();
            
        }
    }
}
