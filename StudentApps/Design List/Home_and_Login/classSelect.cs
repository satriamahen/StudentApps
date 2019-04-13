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
    public partial class classSelect : Form
    {
        public classSelect()
        {
            InitializeComponent();
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.BackgroundImage = StudentApps.Properties.Resources.ButtonPG_hover;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackgroundImage = StudentApps.Properties.Resources.ButtonPG;
        }

        private void button2_MouseEnter(object sender, EventArgs e)
        {
            button2.BackgroundImage = StudentApps.Properties.Resources.ButtonDifabel_hover;
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.BackgroundImage = StudentApps.Properties.Resources.ButtonDifabel;
        }

        private void button3_MouseEnter(object sender, EventArgs e)
        {
            button3.BackgroundImage = StudentApps.Properties.Resources.ButtonTkA_hover;
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            button3.BackgroundImage = StudentApps.Properties.Resources.ButtonTkA;
        }

        private void button4_MouseEnter(object sender, EventArgs e)
        {
            button4.BackgroundImage = StudentApps.Properties.Resources.ButtonTkB_hover;
        }

        private void button4_MouseLeave(object sender, EventArgs e)
        {
            button4.BackgroundImage = StudentApps.Properties.Resources.ButtonTkB;
        }

        private void button1_MouseUp(object sender, MouseEventArgs e)
        {
            this.Hide();
            Login form3 = new Login();
            form3.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
