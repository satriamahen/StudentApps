﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentApps
{
    public partial class math3 : Form
    {
        public math3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();

            Level Menu = new Level();

            Menu.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "18")
            {
                this.Hide();

                Level Menu = new Level();

                Menu.Show();
            }
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.BackgroundImage = Properties.Resources.button_Art_hover;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackgroundImage = Properties.Resources.button_Art;
        }
    }
}
