using System;
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
    public partial class LevelSelect : Form
    {
        public LevelSelect()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();

            Science1 Menu = new Science1();

            Menu.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();

            //Science.Science4 Menu = Science.Science4();

            //Menu.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Hide();

            Science5 Menu = new Science5();

            Menu.Show();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.Hide();

            Science7 Menu = new Science7();

            Menu.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Hide();

            Science9 Menu = new Science9();

            Menu.Show();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.BackgroundImage = StudentApps.Properties.Resources.button_Art___Copy;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackgroundImage = StudentApps.Properties.Resources.button_Art;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
