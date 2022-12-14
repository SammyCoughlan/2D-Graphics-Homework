using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2D_Graphics_Homework
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            //i have a palette i want to use but only know the hex values for them, so i learned how to make a color from a hex code via https://stackoverflow.com/questions/26171975/set-windows-forms-background-color-to-hex-value

            string[] HexPalette = { "#071040", "#3D4F73", "#72A6A6", "#F5F088", "#F5A54E", "#F53F45" };
            Color[] Palette = new Color[6];
            FontFamily fontFamily = new FontFamily("Arial");
            Font font = new Font(fontFamily, 16, FontStyle.Regular);

            for (int i = 0; i < 6; i++)
            {
                Palette[i] = ColorTranslator.FromHtml(HexPalette[i]);
            }

            Graphics g = e.Graphics;
            SolidBrush Brush1 = new SolidBrush(Palette[0]);
            SolidBrush Brush2 = new SolidBrush(Palette[1]);
            SolidBrush Brush3 = new SolidBrush(Palette[2]);
            SolidBrush Brush4 = new SolidBrush(Palette[3]);
            SolidBrush Brush5 = new SolidBrush(Palette[4]);
            SolidBrush Brush6 = new SolidBrush(Palette[5]);
            SolidBrush BlackBrush = new SolidBrush(Color.Black);
            Pen Brush1Pen = new Pen(Brush1);
            Pen Brush2Pen = new Pen(Brush2);
            Pen Brush3Pen = new Pen(Brush3);
            Pen Brush4Pen = new Pen(Brush4);
            Pen Brush5Pen = new Pen(Brush5);
            Pen Brush6Pen = new Pen(Brush6);
            Pen BlackPen = new Pen(BlackBrush);

            
            //Banner
            Rectangle TitleBox = new Rectangle(200, 30, 420, 50);
            e.Graphics.FillRectangle(Brush3, TitleBox);
            Brush1Pen.Width = 5.0f;
            e.Graphics.DrawRectangle(Brush1Pen, TitleBox);
            string Title = "Choose your Character!";
            e.Graphics.DrawString(Title, font, Brush4, 300, 45);

            //Player choice
            Rectangle Player1 = new Rectangle(200, 100, 200, 300);
            e.Graphics.FillRectangle(Brush2, Player1);
            e.Graphics.DrawRectangle(Brush1Pen, Player1);

            Rectangle Player2 = new Rectangle(420, 100, 200, 300);
            e.Graphics.FillRectangle(Brush2, Player2);
            e.Graphics.DrawRectangle(Brush1Pen, Player2);

            //Little menu button in the top left
            Rectangle menu = new Rectangle(0, 0, 50, 50);
            e.Graphics.FillRectangle(Brush4, menu);
            Brush5Pen.Width = 3.0f;
            e.Graphics.DrawRectangle(Brush5Pen, menu);

            e.Graphics.DrawLine(Brush5Pen, 10, 15, 40, 15);
            e.Graphics.DrawLine(Brush5Pen, 10, 25, 40, 25);
            e.Graphics.DrawLine(Brush5Pen, 10, 35, 40, 35);


            //Hexagon as the back button
            string Back = "Back";
            Point[] Hexagon = new Point[] { new Point(738,378), new Point(777, 378), new Point(797, 408), new Point(777, 438), new Point(737, 438), new Point(717, 408) };
            e.Graphics.FillPolygon(Brush6, Hexagon);
            e.Graphics.DrawPolygon(Brush5Pen, Hexagon);
            e.Graphics.DrawString(Back, font, Brush5, 730, 400);

            //Player 1 profile || HUMAN
            Rectangle BoundRectangle = new Rectangle(215, 150, 170, 200);
            e.Graphics.FillEllipse(Brush3, BoundRectangle);
            Rectangle BoundEye1 = new Rectangle(250, 225, 25, 25);
            e.Graphics.FillEllipse(Brush4, BoundEye1);
            Rectangle BoundEye2 = new Rectangle(325, 225, 25, 25);
            e.Graphics.FillEllipse (Brush4, BoundEye2);
            //e.Graphics.DrawPie(Brush5Pen, 275, 230, 50, 50, 45, 90);
            Point[] Triangle = new Point[] { new Point(300, 250), new Point(290, 280), new Point(310, 280) };
            e.Graphics.FillPolygon(Brush5, Triangle);
            Brush6Pen.Width = 3.0f;
            e.Graphics.DrawArc(Brush6Pen, 245, 260, 100, 50, 30, 100);
            string Player1Name = "Steve";
            e.Graphics.DrawString(Player1Name, font, Brush6, 270, 378);

            //player 2 profile || Pac Man
            Rectangle tempp2 = new Rectangle(435, 150, 170, 200);
            e.Graphics.FillPie(Brush4, tempp2, 20, 320);
            Rectangle EyeBound3 = new Rectangle(485, 220, 25, 25);
            e.Graphics.FillEllipse(BlackBrush, EyeBound3);
            string Player2Name = "Pacman";
            e.Graphics.DrawString(Player2Name, font, Brush6, 478, 378);

            Brush1.Dispose();
            Brush2.Dispose();
            Brush3.Dispose();
            Brush4.Dispose();
            Brush5.Dispose();
            Brush6.Dispose();
            BlackBrush.Dispose();

            Brush1Pen.Dispose();
            Brush2Pen.Dispose();
            Brush3Pen.Dispose();
            Brush4Pen.Dispose();
            Brush5Pen.Dispose();
            Brush6Pen.Dispose();
            BlackPen.Dispose();






        }
    }
}
