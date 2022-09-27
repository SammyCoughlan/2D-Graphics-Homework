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

            string[] HexPalette = { "#071040", "#3D4F73", "#72A6A6", "#F2EEAE", "#F2BC79" };
            Color[] Palette = new Color[5];

            for (int i = 0; i < 5; i++)
            {
                Palette[i] = ColorTranslator.FromHtml(HexPalette[i]);
            }

            Graphics g = e.Graphics;
            SolidBrush Brush1 = new SolidBrush(Palette[0]);
            SolidBrush Brush2 = new SolidBrush(Palette[1]);
            SolidBrush Brush3 = new SolidBrush(Palette[2]);
            SolidBrush Brush4 = new SolidBrush(Palette[3]);
            SolidBrush Brush5 = new SolidBrush(Palette[4]);
            Pen Brush1Pen = new Pen(Brush1);
            Pen Brush2Pen = new Pen(Brush2);
            Pen Brush3Pen = new Pen(Brush3);
            Pen Brush4Pen = new Pen(Brush4);
            Pen Brush5Pen = new Pen(Brush5);

            Font basicText = new Font()

            Rectangle TitleBox = new Rectangle(200, 30, 400, 50);
            e.Graphics.FillRectangle(Brush3, TitleBox);
            Brush1Pen.Width = 5.0f;
            e.Graphics.DrawRectangle(Brush1Pen, TitleBox);
            string Title = "TITLE";
            e.Graphics.DrawString(Title, )
        }
    }
}
