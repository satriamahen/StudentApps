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
    public partial class StoryForm : Form
    {
        bool micOn = true;
        System.Windows.Forms.Timer t = new System.Windows.Forms.Timer();

        public StoryForm()
        {
            InitializeComponent();
            t.Interval = 1000;
            t.Tick += new EventHandler(Timer_Tick);
            //t.Start();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (micOn == true)
            {
                button1.BackgroundImage = StudentApps.Properties.Resources.muted__1_;
                micOn = false;
            }

            else if (micOn == false)
            {
                button1.BackgroundImage = StudentApps.Properties.Resources.microphone__1_;
                micOn = true;
            }

        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            
        }

        private void subtitle_Click(object sender, EventArgs e)
        {

        }

        async Task UseDelay(int sec)
        {
            await Task.Delay(sec); // wait for 1 second
        }

        private async void StoryForm_Load(object sender, EventArgs e)
        {
            await UseDelay(5000);
            subtitle.Text = " Ipsum Lorem sit Amet Dolor ";
            storyBoard.Image = StudentApps.Properties.Resources.pict1;
            await UseDelay(2000);
            subtitle.Text = " sit Amet Dolor Ipsum Lorem ";
        }

        private void button2_MouseEnter(object sender, EventArgs e)
        {
            button2.BackgroundImage = StudentApps.Properties.Resources.button_Art_hover;
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.BackgroundImage = StudentApps.Properties.Resources.button_Art;
        }

        private void storyBoard_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Profile profile = new Profile();
            profile.Show();
        }
    }
}
