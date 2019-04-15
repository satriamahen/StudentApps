using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;

namespace StudentApps
{
    public partial class balok : Form
    {
        public bool drag = false;
        int cur_x, cur_y;
        Pen outline = new Pen(Color.Black);

        //Text

        Bitmap img = new Bitmap(Image.FromFile(@"D:\star.png"), 75, 75);
        Bitmap img2 = new Bitmap(Image.FromFile(@"D:\triangle.png"), 75, 75);
        TextBox txtnama = new TextBox();

        Label lblnama = new Label();
        Button newButton = new Button();


        //lego
        Rectangle lego1 = new Rectangle(50, 150, 50, 50);
        SolidBrush clego1 = new SolidBrush(Color.Blue);
        Rectangle lego2 = new Rectangle(50, 225, 50, 50);
        SolidBrush clego2 = new SolidBrush(Color.Red);
        Rectangle lego3 = new Rectangle(50, 300, 50, 75);
        SolidBrush clego3 = new SolidBrush(Color.Green);
        Rectangle lego4 = new Rectangle(150, 150, 75, 50);
        SolidBrush clego4 = new SolidBrush(Color.Purple);
        // ellipse = new 

        public balok()
        {
            InitializeComponent();

            txtnama.Location = new Point(300, 400);
            //txtnama.Text = "";
            this.Controls.Add(txtnama);

            lblnama.Text = " Nep";
            this.Controls.Add(lblnama);
            this.Controls.Add(newButton);

            newButton.Text = "Submit";
            newButton.Location = new Point(400, 400);
            newButton.Size = new Size(100, 30);
            newButton.Click += new EventHandler(newButton_Click);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics g = e.Graphics;
            //lego
            g.FillRectangle(clego1, lego1);
            g.DrawRectangle(outline, lego1);
            g.FillEllipse(clego2, lego2);
            g.DrawEllipse(outline, lego2);
            g.FillRectangle(clego3, lego3);
            g.DrawRectangle(outline, lego3);
            g.FillRectangle(clego4, lego4);
            g.DrawRectangle(outline, lego4);
            g.DrawImage(img, 150, 225);
            g.DrawImage(img2, 150, 325);
        }
        private void balok_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;


        }
        private void recmousedown(object sender, MouseEventArgs m)
        {
            if (m.Button != MouseButtons.Left)
                return;
            Rectangle lego1 = new Rectangle(50, 150, 50, 50);
            SolidBrush clego1 = new SolidBrush(Color.Blue);
            Rectangle lego2 = new Rectangle(50, 225, 50, 50);
            SolidBrush clego2 = new SolidBrush(Color.Red);
            Rectangle lego3 = new Rectangle(50, 300, 50, 75);
            SolidBrush clego3 = new SolidBrush(Color.Green);
            Rectangle lego4 = new Rectangle(150, 150, 75, 50);
            SolidBrush clego4 = new SolidBrush(Color.Purple);

            drag = true;
            cur_x = m.X;
            cur_y = m.Y;
        }

        private void recmousemove(object sender, MouseEventArgs m)
        {
            if (m.Button != MouseButtons.Left)
                return;

            lego1.X = m.X;
            lego1.Y = m.Y;
            lego2.X = m.X;
            lego2.Y = m.Y;
            lego3.X = m.X;
            lego3.Y = m.Y;
            lego4.X = m.X;
            lego4.Y = m.Y;
            Invalidate();
        }

        private void newButton_Click(object sender, EventArgs e)
        {
            WindowScreenshot(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), txtnama.Text + ".jpg", ImageFormat.Jpeg);
        }

        private void WindowScreenshot(String filepath, String filename, ImageFormat format)
        {
            ScreenCapture sc = new ScreenCapture();

            string fullpath = filepath + "\\" + filename;

            sc.CaptureWindowToFile(this.Handle, fullpath, format);
        }
    }
}
