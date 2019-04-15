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
    public partial class Science1 : Form
    {
        public Science1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();

            Science2 Menu = new Science2();

            Menu.Show();
        }


        private void button1_MouseEnter(object sender, EventArgs e)
        {
            backbutton.BackgroundImage = StudentApps.Properties.Resources.button_Art___Copy;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            backbutton.BackgroundImage = StudentApps.Properties.Resources.button_Art;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();

            LevelSelect Menu = new LevelSelect();

            Menu.Show();
        }
    }
}
