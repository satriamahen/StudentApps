using StudentApps;
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
    public partial class Level : Form
    {
        public Level()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();

            math1 Menu = new math1();

            Menu.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();

            math2 Menu = new math2();

            Menu.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();

            math3 Menu = new math3();

            Menu.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();

            math4 Menu = new math4();

            Menu.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();

            math5 Menu = new math5();

            Menu.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();

            Profile Menu = new Profile();

            Menu.Show();
        }

        private void button6_MouseEnter(object sender, EventArgs e)
        {
            button6.BackgroundImage = Properties.Resources.button_Art_hover;
        }

        private void button6_MouseLeave(object sender, EventArgs e)
        {
            button6.BackgroundImage = Properties.Resources.button_Art;
        }
    }
}
