using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChildrenLearning
{
    public partial class Profile : Form
    {
        bool goal1, goal2, goal3, goal4 = false;

        public Profile()
        {
            InitializeComponent();
        }

        private void button1_MouseUp(object sender, MouseEventArgs e)
        {
            if(goal1 == false)
            {
                pictureBox1.Width = 90;
                button1.BackgroundImage = ChildrenLearning.Properties.Resources.trophy1;
                goal1 = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button42_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void button42_MouseEnter(object sender, EventArgs e)
        {
            button42.BackgroundImage = Properties.Resources.red_hover;
        }

        private void button42_MouseLeave(object sender, EventArgs e)
        {
            button42.BackgroundImage = Properties.Resources.red;
        }

        private void button30_MouseEnter(object sender, EventArgs e)
        {
            button30.BackgroundImage = Properties.Resources.red_hover;
        }

        private void button30_MouseLeave(object sender, EventArgs e)
        {
            button30.BackgroundImage = Properties.Resources.red;
        }

        private void button31_MouseEnter(object sender, EventArgs e)
        {
            button31.BackgroundImage = Properties.Resources.red_hover;
        }

        private void button31_MouseLeave(object sender, EventArgs e)
        {
            button31.BackgroundImage = Properties.Resources.red;
        }

        private void button32_MouseEnter(object sender, EventArgs e)
        {
            button32.BackgroundImage = Properties.Resources.red_hover;
        }

        private void button32_MouseLeave(object sender, EventArgs e)
        {
            button32.BackgroundImage = Properties.Resources.red;
        }

        private void button33_MouseEnter(object sender, EventArgs e)
        {
            button33.BackgroundImage = Properties.Resources.red_hover;
        }

        private void button33_MouseLeave(object sender, EventArgs e)
        {
            button33.BackgroundImage = Properties.Resources.red;
        }

        private void button34_MouseEnter(object sender, EventArgs e)
        {
            button34.BackgroundImage = Properties.Resources.red_hover;
        }

        private void button34_MouseLeave(object sender, EventArgs e)
        {
            button34.BackgroundImage = Properties.Resources.red;
        }

        private void button35_MouseEnter(object sender, EventArgs e)
        {
            button35.BackgroundImage = Properties.Resources.red_hover;
        }

        private void button35_MouseLeave(object sender, EventArgs e)
        {
            button35.BackgroundImage = Properties.Resources.red;
        }

        private void button11_MouseEnter(object sender, EventArgs e)
        {
            button11.BackgroundImage = Properties.Resources.red_hover;
        }

        private void button11_MouseLeave(object sender, EventArgs e)
        {
            button11.BackgroundImage = Properties.Resources.red;
        }

        private void button12_MouseEnter(object sender, EventArgs e)
        {
            button12.BackgroundImage = Properties.Resources.red_hover;
        }

        private void button12_MouseLeave(object sender, EventArgs e)
        {
            button12.BackgroundImage = Properties.Resources.red;
        }

        private void button13_MouseEnter(object sender, EventArgs e)
        {
            button13.BackgroundImage = Properties.Resources.red_hover;
        }

        private void button13_MouseLeave(object sender, EventArgs e)
        {
            button13.BackgroundImage = Properties.Resources.red;
        }
        private void button14_MouseEnter(object sender, EventArgs e)
        {
            button14.BackgroundImage = Properties.Resources.red_hover;
        }

        private void button14_MouseLeave(object sender, EventArgs e)
        {
            button14.BackgroundImage = Properties.Resources.red;
        }
        private void button15_MouseEnter(object sender, EventArgs e)
        {
            button15.BackgroundImage = Properties.Resources.red_hover;
        }

        private void button15_MouseLeave(object sender, EventArgs e)
        {
            button15.BackgroundImage = Properties.Resources.red;
        }
        private void button16_MouseEnter(object sender, EventArgs e)
        {
            button16.BackgroundImage = Properties.Resources.red_hover;
        }

        private void button16_MouseLeave(object sender, EventArgs e)
        {
            button16.BackgroundImage = Properties.Resources.red;
        }
        private void button36_MouseEnter(object sender, EventArgs e)
        {
            button36.BackgroundImage = Properties.Resources.red_hover;
        }

        private void button36_MouseLeave(object sender, EventArgs e)
        {
            button36.BackgroundImage = Properties.Resources.red;
        }
        private void button17_MouseEnter(object sender, EventArgs e)
        {
            button17.BackgroundImage = Properties.Resources.red_hover;
        }

        private void button17_MouseLeave(object sender, EventArgs e)
        {
            button17.BackgroundImage = Properties.Resources.red;
        }
        private void button18_MouseEnter(object sender, EventArgs e)
        {
            button18.BackgroundImage = Properties.Resources.red_hover;
        }

        private void button18_MouseLeave(object sender, EventArgs e)
        {
            button18.BackgroundImage = Properties.Resources.red;
        }
        private void button37_MouseEnter(object sender, EventArgs e)
        {
            button37.BackgroundImage = Properties.Resources.red_hover;
        }

        private void button37_MouseLeave(object sender, EventArgs e)
        {
            button37.BackgroundImage = Properties.Resources.red;
        }
        private void button19_MouseEnter(object sender, EventArgs e)
        {
            button19.BackgroundImage = Properties.Resources.red_hover;
        }

        private void button19_MouseLeave(object sender, EventArgs e)
        {
            button19.BackgroundImage = Properties.Resources.red;
        }
        private void button20_MouseEnter(object sender, EventArgs e)
        {
            button20.BackgroundImage = Properties.Resources.red_hover;
        }

        private void button20_MouseLeave(object sender, EventArgs e)
        {
            button20.BackgroundImage = Properties.Resources.red;
        }
        private void button38_MouseEnter(object sender, EventArgs e)
        {
            button38.BackgroundImage = Properties.Resources.red_hover;
        }

        private void button38_MouseLeave(object sender, EventArgs e)
        {
            button38.BackgroundImage = Properties.Resources.red;
        }
        private void button39_MouseEnter(object sender, EventArgs e)
        {
            button39.BackgroundImage = Properties.Resources.red_hover;
        }

        private void button39_MouseLeave(object sender, EventArgs e)
        {
            button39.BackgroundImage = Properties.Resources.red;
        }
        private void button21_MouseEnter(object sender, EventArgs e)
        {
            button21.BackgroundImage = Properties.Resources.red_hover;
        }

        private void button21_MouseLeave(object sender, EventArgs e)
        {
            button21.BackgroundImage = Properties.Resources.red;
        }
        private void button22_MouseEnter(object sender, EventArgs e)
        {
            button22.BackgroundImage = Properties.Resources.red_hover;
        }

        private void button22_MouseLeave(object sender, EventArgs e)
        {
            button22.BackgroundImage = Properties.Resources.red;
        }
        private void button23_MouseEnter(object sender, EventArgs e)
        {
            button23.BackgroundImage = Properties.Resources.red_hover;
        }

        private void button23_MouseLeave(object sender, EventArgs e)
        {
            button23.BackgroundImage = Properties.Resources.red;
        }
        private void button24_MouseEnter(object sender, EventArgs e)
        {
            button24.BackgroundImage = Properties.Resources.red_hover;
        }

        private void button24_MouseLeave(object sender, EventArgs e)
        {
            button24.BackgroundImage = Properties.Resources.red;
        }
        private void button25_MouseEnter(object sender, EventArgs e)
        {
            button25.BackgroundImage = Properties.Resources.red_hover;
        }

        private void button25_MouseLeave(object sender, EventArgs e)
        {
            button25.BackgroundImage = Properties.Resources.red;
        }
        private void button26_MouseEnter(object sender, EventArgs e)
        {
            button26.BackgroundImage = Properties.Resources.red_hover;
        }

        private void button26_MouseLeave(object sender, EventArgs e)
        {
            button26.BackgroundImage = Properties.Resources.red;
        }
        private void button27_MouseEnter(object sender, EventArgs e)
        {
            button27.BackgroundImage = Properties.Resources.red_hover;
        }

        private void button27_MouseLeave(object sender, EventArgs e)
        {
            button27.BackgroundImage = Properties.Resources.red;
        }
        private void button28_MouseEnter(object sender, EventArgs e)
        {
            button28.BackgroundImage = Properties.Resources.red_hover;
        }

        private void button28_MouseLeave(object sender, EventArgs e)
        {
            button28.BackgroundImage = Properties.Resources.red;
        }
        private void button29_MouseEnter(object sender, EventArgs e)
        {
            button29.BackgroundImage = Properties.Resources.red_hover;
        }

        private void button29_MouseLeave(object sender, EventArgs e)
        {
            button29.BackgroundImage = Properties.Resources.red;
        }
        private void button2_MouseUp(object sender, MouseEventArgs e)
        {
            if (goal1 == true && goal2 == false)
            {
                pictureBox1.Width = 185;
                button2.BackgroundImage = ChildrenLearning.Properties.Resources.tropy2;
                goal2 = true;
            }
        }

        private void button3_MouseUp(object sender, MouseEventArgs e)
        {
            if(goal1 == true && goal2 == true && goal3 == false)
            {
                pictureBox1.Width = 258;
                button3.BackgroundImage = ChildrenLearning.Properties.Resources.tropy3;
                goal3 = true;
            }
        }

        private void button4_MouseUp(object sender, MouseEventArgs e)
        {
            if (goal1 == true && goal2 == true && goal3 == true && goal4 == false)
            {
                pictureBox1.Width = 342;
                button4.BackgroundImage = ChildrenLearning.Properties.Resources.trophy4;
                goal4 = true;
            }
        }
    }
}
