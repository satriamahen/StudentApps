using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace WindowsFormsApp8
{
    public partial class Form3 : Form
    {
        WindowsMediaPlayer player = new WindowsMediaPlayer();
        public Form3()
        {
            InitializeComponent();
            player.URL = "anak-kambing-saya.mp3";
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();

            Form1 Menu = new Form1();

            Menu.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            player.controls.play();
        }
    }
}
