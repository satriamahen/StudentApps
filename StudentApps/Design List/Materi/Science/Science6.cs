﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Science
{
    public partial class Science6 : Form
    {
        public Science6()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();

            Science7 Menu = new Science7();

            Menu.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();

            LevelSelect Menu = new LevelSelect();

            Menu.Show();
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.BackgroundImage = StudentApps.Properties.Resources.button_Art___Copy;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackgroundImage = StudentApps.Properties.Resources.button_Art;
        }
    }
}