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
    public partial class math2 : Form
    {
        public math2()
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
            if (textBox1.Text == "1" && textBox3.Text == "2")
            {
                this.Hide();

                Level Menu = new Level();

                Menu.Show();
            }
        }
    }
}
