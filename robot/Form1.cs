using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace robot
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics grafika = this.CreateGraphics();
            Pen lapsi = new Pen(Color.Black, 3);
            SolidBrush greenbrush = new SolidBrush(Color.Green);
            SolidBrush lightbluebrush = new SolidBrush(Color.DeepSkyBlue);
            SolidBrush yellowbrush = new SolidBrush(Color.GreenYellow);
            SolidBrush lightgraybrush = new SolidBrush(Color.LightGray);
            SolidBrush graybrush = new SolidBrush(Color.DarkGray);
            SolidBrush darkgray = new SolidBrush(Color.Gray);


            //koka
            Rectangle rect1 = new Rectangle(140, 30, 140, 120);
            grafika.DrawRectangle(lapsi, rect1);
            grafika.FillRectangle(graybrush, rect1);

            Rectangle rect17 = new Rectangle(160, 10, 100, 18);
            grafika.DrawRectangle(lapsi, rect17);
            grafika.FillRectangle(lightgraybrush, rect17);

            Rectangle rect8 = new Rectangle(120, 50, 18, 75);
            grafika.DrawRectangle(lapsi, rect8);
            grafika.FillRectangle(lightgraybrush, rect8);


            Rectangle rect9 = new Rectangle(282, 50, 18, 75);
            grafika.DrawRectangle(lapsi, rect9);
            grafika.FillRectangle(lightgraybrush, rect9);



            Rectangle rect = new Rectangle(100, 65, 40, 40);
            grafika.DrawArc(lapsi, rect, 90, 180);
            grafika.FillPie(lightbluebrush, rect, 90, 180);

            Rectangle rect10 = new Rectangle(280, 65, 40, 40);
            grafika.DrawArc(lapsi, rect10, -90, 180);
            grafika.FillPie(lightbluebrush, rect10, -90, 180);


            //syte

            Rectangle rect4 = new Rectangle(150, 50, 120, 50);
            grafika.DrawEllipse(lapsi, rect4);
            grafika.FillEllipse(new SolidBrush(Color.LightGray), rect4);

            Rectangle rect2 = new Rectangle(170, 60, 30, 30);
            grafika.DrawEllipse(lapsi, rect2);
            grafika.FillEllipse(greenbrush, rect2);

            Rectangle rect3 = new Rectangle(220, 60, 30, 30);
            grafika.DrawEllipse(lapsi, rect3);
            grafika.FillEllipse(greenbrush, rect3);

            //goja
            Rectangle rect5 = new Rectangle(170, 120, 80, 20);
            grafika.DrawRectangle(lapsi, rect5);
            grafika.FillRectangle(yellowbrush, rect5);


            //the neck
            Rectangle rect7 = new Rectangle(160, 150, 90, 40);
            grafika.DrawRectangle(lapsi, rect7);
            grafika.FillRectangle(darkgray, rect7);


            //trupi
            Rectangle rect6 = new Rectangle(90, 190, 230, 170);
            grafika.DrawRectangle(lapsi, rect6);
            grafika.FillRectangle(graybrush, rect6);
            

            //figurat brenda trupit
            Rectangle rect11 = new Rectangle(130,200,150,70);
            grafika.DrawRectangle(lapsi, rect11);
            grafika.FillRectangle(greenbrush, rect11);


            Rectangle rect12 = new Rectangle(110, 310, 30, 30);
            grafika.DrawRectangle(lapsi, rect12);
            grafika.FillRectangle(lightbluebrush, rect12);

            Rectangle rect13 = new Rectangle(150, 310, 30, 30);
            grafika.DrawEllipse(lapsi, rect13);
            grafika.FillEllipse(yellowbrush, rect13);

            Rectangle rect14 = new Rectangle(190, 310, 30, 30);
            grafika.DrawEllipse(lapsi, rect14);
            grafika.FillEllipse(yellowbrush, rect14);


            Rectangle rect15 = new Rectangle(230, 310, 30, 30);
            grafika.DrawEllipse(lapsi, rect15);
            grafika.FillEllipse(yellowbrush, rect15);



            Point[] pikat = { new Point(290,310),
            new Point(270,340),
            new Point(310,340)};
            grafika.DrawPolygon(lapsi, pikat);
            grafika.FillPolygon(new SolidBrush(Color.Red), pikat);








            // duart
            // e majta

            Rectangle rect23 = new Rectangle(75, 200, 15, 40);
            grafika.DrawRectangle(lapsi, rect23);
            grafika.FillRectangle(graybrush, rect23);

            Rectangle rect24 = new Rectangle(55, 195, 20, 140);
            grafika.DrawRectangle(lapsi, rect24);
            grafika.FillRectangle(graybrush, rect24);



            Rectangle rect25 = new Rectangle (50, 335 ,30, 30);
            grafika.DrawEllipse(lapsi, rect25);

            // e djathta 
            Rectangle rect26 = new Rectangle(320, 200, 15, 40);
            grafika.DrawRectangle(lapsi, rect26);
            grafika.FillRectangle(graybrush, rect26);


            Rectangle rect27 = new Rectangle(335, 195, 20, 140);
            grafika.DrawRectangle(lapsi, rect27);
            grafika.FillRectangle(graybrush, rect27);


            Rectangle rect28 = new Rectangle(330, 335, 30, 30);
            grafika.DrawEllipse(lapsi, rect28);

            //kembet
            //e majta
            Rectangle rect30 = new Rectangle(120, 360, 50, 120);
            grafika.DrawRectangle(lapsi, rect30);
            grafika.FillRectangle(darkgray, rect30);


            Rectangle rect32 = new Rectangle(115, 470, 60, 60);
            grafika.DrawArc(lapsi, rect32,180,180);
            grafika.FillPie(graybrush, rect32, 180, 180);
            grafika.DrawLine(lapsi, new Point(115, 500), new Point(175, 500));


            //e djathta
            Rectangle rect31 = new Rectangle(240, 360, 50, 120);
            grafika.DrawRectangle(lapsi, rect31);
            grafika.FillRectangle(darkgray, rect31);

            Rectangle rect33 = new Rectangle(235, 470, 60, 60);
            grafika.DrawArc(lapsi, rect33,180,180);
            grafika.DrawLine(lapsi, new Point(235, 500), new Point(295, 500));
            grafika.FillPie(graybrush, rect33, 180, 180);

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}   
