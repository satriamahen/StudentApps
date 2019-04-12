using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChildrenLearning
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
    }
}
