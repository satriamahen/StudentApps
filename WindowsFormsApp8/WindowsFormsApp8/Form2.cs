﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp8
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();

            Form1 Menu = new Form1();

            Menu.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();

            Form3 Menu = new Form3();

            Menu.Show();
        }
    }
}
