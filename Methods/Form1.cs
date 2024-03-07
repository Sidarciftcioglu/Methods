﻿using System;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void clear()
        {
            textBox1.Text = " ";
            textBox2.Text = " ";
            textBox3.Text = " ";
            textBox4.Text = " ";
            textBox1.Focus();
        }

        private void colorIt()
        {
            textBox1.BackColor= Color.Red;
            textBox2.BackColor= Color.Green;
            textBox3.BackColor= Color.Yellow;
            textBox4.BackColor= Color.Blue;

        }
        private void person()
        {
            textBox1.Text = "Sidar";
            textBox2.Text = "Çiftçioğlu";
            textBox3.Text = "Sofware Engineer";
            textBox4.Text = "Mardin";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            colorIt();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            person();
        }
    }
}
