using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SignUpDemo
{
    public partial class Form3 : Form
    {
     
        public Form3()
        {
            InitializeComponent();
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;

            pictureBox7.SizeMode = PictureBoxSizeMode.StretchImage;
            //pictureBox8.SizeMode = PictureBoxSizeMode.StretchImage;

            //pictureBox9.SizeMode = PictureBoxSizeMode.StretchImage;


        }


        private void bunifuCustomLabel1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel3_Click_1(object sender, EventArgs e)
        {
            Application.Exit();

        }

        //private void panel1_Paint(object sender, PaintEventArgs e)
        //{

        //    Graphics v = e.Graphics;
        //    DrawRoundRect(v, Pens.Blue, e.ClipRectangle.Left, e.ClipRectangle.Top, e.ClipRectangle.Width - 1, e.ClipRectangle.Height - 1, 10);
        //    //Without rounded corners
        //    //e.Graphics.DrawRectangle(Pens.Blue, e.ClipRectangle.Left, e.ClipRectangle.Top, e.ClipRectangle.Width - 1, e.ClipRectangle.Height - 1);
        //    base.OnPaint(e);
        //}

        

        private void Form3_Load(object sender, EventArgs e)
        {
        }

        private void bunifuCustomLabel2_Click(object sender, EventArgs e)
        {

        }
    }
}


