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

        private void button6_Click_1(object sender, EventArgs e)
        {
            this.Hide();

            Level Menu = new Level();

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
