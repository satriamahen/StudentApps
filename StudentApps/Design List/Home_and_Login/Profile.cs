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
    public partial class Profile : Form
    {
        bool goal1, goal2, goal3, goal4 = false;

        bool pulldown1Open = false;

        public Profile()
        {
            InitializeComponent();
        }

        private void button1_MouseUp(object sender, MouseEventArgs e)
        {
            if(goal1 == false)
            {
                pictureBox1.Width = 90;
                button1.BackgroundImage = StudentApps.Properties.Resources.trophy1;
                goal1 = true;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Hide();
            Design_List.Materi.Gross.Form1 level = new Design_List.Materi.Gross.Form1();
            level.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if(pulldown1Open == false)
            {
                button11.Visible = true;
                button12.Visible = true;
                pulldown1Open = true;
            }
            else
            {
                button11.Visible = false;
                button12.Visible = false;
                pulldown1Open = false;
            }
        }

        private void button2_MouseUp(object sender, MouseEventArgs e)
        {
            if (goal1 == true && goal2 == false)
            {
                pictureBox1.Width = 185;
                button2.BackgroundImage = StudentApps.Properties.Resources.tropy2;
                goal2 = true;
            }
        }

        private void button3_MouseUp(object sender, MouseEventArgs e)
        {
            if(goal1 == true && goal2 == true && goal3 == false)
            {
                pictureBox1.Width = 258;
                button3.BackgroundImage = StudentApps.Properties.Resources.tropy3;
                goal3 = true;
            }
        }

        private void button4_MouseUp(object sender, MouseEventArgs e)
        {
            if (goal1 == true && goal2 == true && goal3 == true && goal4 == false)
            {
                pictureBox1.Width = 342;
                button4.BackgroundImage = StudentApps.Properties.Resources.trophy4;
                goal4 = true;
            }
        }
    }
}
