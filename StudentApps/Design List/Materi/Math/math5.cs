﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class math5 : Form
    {
        public math5()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "2")
            {
                this.Hide();

                Level Menu = new Level();

                Menu.Show();
            }
        }

            private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();

            Level Menu = new Level();

            Menu.Show();
        }
    }
}