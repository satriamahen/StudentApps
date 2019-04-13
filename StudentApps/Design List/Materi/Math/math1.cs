using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class math1 : Form
    {
        public math1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();

            Level Menu = new Level();

            Menu.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == "2" && textBox2.Text == "4")
            {
                this.Hide();

                Level Menu = new Level();

                Menu.Show();
            }
        }
    }
}
