using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Media;

namespace StarCard
{
    public partial class nebulaBackground : Form
    {
        public nebulaBackground()
        {
            InitializeComponent();
        }

        private void nebulaBackground_Click(object sender, EventArgs e)
        {
            Graphics fg = this.CreateGraphics();
            Pen drawPen = new Pen(Color.Green, 10);
            SolidBrush drawBrush = new SolidBrush(Color.White);
            Graphics onScreen = this.CreateGraphics();
            Bitmap bm = new Bitmap(this.Width, this.Height);
            Graphics offScreen = Graphics.FromImage(bm);



            BackgroundImage = null;     //Waits then gets rid of these things
            titleLabel.Visible = false;
            nameLabel.Visible = false;
            Refresh();

            BackColor = Color.Black;    //changes back color to black
            Refresh();
            Thread.Sleep(500);

            offScreen.FillEllipse(drawBrush, 265, 111, 10, 10);  //draws star 1
            onScreen.DrawImage(bm, 0, 0);
            Thread.Sleep(500);

            offScreen.FillEllipse(drawBrush, 227, 190, 10, 10);   //star 2
            onScreen.DrawImage(bm, 0, 0);
            Thread.Sleep(500);

            offScreen.FillEllipse(drawBrush, 265, 111, 10, 10);    //star 3 
            onScreen.DrawImage(bm, 0, 0);


            offScreen.FillEllipse(drawBrush, 265, 111, 10, 10);    //star 4
            onScreen.DrawImage(bm, 0, 0);

            offScreen.FillEllipse(drawBrush, 265, 111, 10, 10);    //star 5 
            onScreen.DrawImage(bm, 0, 0);

            offScreen.FillEllipse(drawBrush, 265, 111, 10, 10);    //star 6
            onScreen.DrawImage(bm, 0, 0);


        }

        private void nebulaBackground_Load(object sender, EventArgs e)
        {
           
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
