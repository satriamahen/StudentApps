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
    public partial class HomePage : Form
    {

        SelectClass selectClass = new SelectClass();

        public HomePage()
        {
            InitializeComponent();
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.BackgroundImage = Properties.Resources.MasukHover;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackgroundImage = Properties.Resources.Masuk;
        }

        private void button1_MouseUp(object sender, MouseEventArgs e)
        {
            this.Hide();
            selectClass.Show();
        }

        private void button2_MouseEnter(object sender, EventArgs e)
        {
            button2.BackgroundImage = Properties.Resources.DaftarHover;
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.BackgroundImage = Properties.Resources.Daftar;
        }

        private void button3_MouseEnter(object sender, EventArgs e)
        {
            button3.BackgroundImage = Properties.Resources.BeritaHover;
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            button3.BackgroundImage = Properties.Resources.Berita;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            news news = new news();
            news.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            regis regis = new regis();
            regis.Show();
        }
    }
}
