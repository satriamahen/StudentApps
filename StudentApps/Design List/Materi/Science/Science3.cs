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
    public partial class Science3 : Form
    {
        public Science3()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();

            Science4 Menu = new Science4();

            Menu.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            this.button1.BackgroundImage = StudentApps.Properties.Resources.button_Art___Copy;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            this.button1.BackgroundImage = StudentApps.Properties.Resources.button_Art;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();

            LevelSelect Menu = new LevelSelect();

            Menu.Show();
        }
    }
}
