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
    public partial class Login : Form
    {

        Profile profile = new Profile();

        public Login()
        {
            InitializeComponent();
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.BackgroundImage = Properties.Resources.UserHover;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackgroundImage = Properties.Resources.User;
        }

        private void button2_MouseEnter(object sender, EventArgs e)
        {
            button2.BackgroundImage = Properties.Resources.UserHover;
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.BackgroundImage = Properties.Resources.User;
        }

        private void button3_MouseEnter(object sender, EventArgs e)
        {
            button3.BackgroundImage = Properties.Resources.UserHover;
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            button3.BackgroundImage = Properties.Resources.User;
        }

        private void button4_MouseEnter(object sender, EventArgs e)
        {
            button4.BackgroundImage = Properties.Resources.UserHover;
        }

        private void button4_MouseLeave(object sender, EventArgs e)
        {
            button4.BackgroundImage = Properties.Resources.User;
        }

        private void button5_MouseEnter(object sender, EventArgs e)
        {
            button5.BackgroundImage = Properties.Resources.UserHover;
        }

        private void button5_MouseLeave(object sender, EventArgs e)
        {
            button5.BackgroundImage = Properties.Resources.User;
        }

        private void button6_MouseEnter(object sender, EventArgs e)
        {
            button6.BackgroundImage = Properties.Resources.UserHover;
        }

        private void button6_MouseLeave(object sender, EventArgs e)
        {
            button6.BackgroundImage = Properties.Resources.User;
        }

        private void button7_MouseEnter(object sender, EventArgs e)
        {
            button7.BackgroundImage = Properties.Resources.UserHover;
        }

        private void button7_MouseLeave(object sender, EventArgs e)
        {
            button7.BackgroundImage = Properties.Resources.User;
        }

        private void button8_MouseEnter(object sender, EventArgs e)
        {
            button8.BackgroundImage = Properties.Resources.UserHover;
        }

        private void button8_MouseLeave(object sender, EventArgs e)
        {
            button8.BackgroundImage = Properties.Resources.User;
        }

        private void button9_MouseEnter(object sender, EventArgs e)
        {
            button9.BackgroundImage = Properties.Resources.UserHover;
        }

        private void button9_MouseLeave(object sender, EventArgs e)
        {
            button9.BackgroundImage = Properties.Resources.User;
        }

        private void button10_MouseEnter(object sender, EventArgs e)
        {
            button10.BackgroundImage = Properties.Resources.UserHover;
        }

        private void button10_MouseLeave(object sender, EventArgs e)
        {
            button10.BackgroundImage = Properties.Resources.User;
        }

        private void button1_MouseUp(object sender, MouseEventArgs e)
        {
            this.Hide();
            profile.Show();
        }
    }
}
