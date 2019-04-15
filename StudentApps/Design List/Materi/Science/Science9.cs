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
    public partial class Science9 : Form
    {
        public Science9()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();

            LevelSelect Menu = new LevelSelect();

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
            button1.BackgroundImage = StudentApps.Properties.Resources.button_Art_hover;
        }

        private void button1_MouseMove(object sender, MouseEventArgs e)
        {

        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackgroundImage = StudentApps.Properties.Resources.button_Art;
        }
    }
}
