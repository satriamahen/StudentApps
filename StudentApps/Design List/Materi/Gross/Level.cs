using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentApps.Design_List.Materi.Gross
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();

            Form2 Menu = new Form2();

            Menu.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();

            Form3 Menu = new Form3();

            Menu.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();

            Form4 Menu = new Form4();

            Menu.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();

            Form5 Menu = new Form5();

            Menu.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();

            Form6 Menu = new Form6();

            Menu.Show();
        }

        
        private void button7_MouseEnter(object sender, EventArgs e)
        {
            button7.BackgroundImage = Properties.Resources.button_Art_hover;
        }

        private void button7_MouseLeave(object sender, EventArgs e)
        {
            button7.BackgroundImage = Properties.Resources.button_Art;
        }

        private void button7_MouseClick(object sender, MouseEventArgs e)
        {
            this.Hide();

            Profile Menu = new Profile();

            Menu.Show();
        }
    }
}
