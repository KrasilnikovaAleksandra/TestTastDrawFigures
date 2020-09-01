using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TestTask2DrawFigures.controller;
using TestTask2DrawFigures.model;

namespace TestTask2DrawFigures
{
    public partial class DrawFigures : Form
    {
        private TextDescribeFigureController textDescribeFigureController = new TextDescribeFigureController();
        private TextDecsribeFigure textDecsribeFigure = new TextDecsribeFigure();
        private static string[] masStaticCharForParser = new string[] { "p", "c", "r", "b" };
        private Graphics g;
        private ArrayList listFigures;

        public DrawFigures(ArrayList listFigures)
        {
            InitializeComponent();
            g = pictureBox1.CreateGraphics();
            this.listFigures = listFigures;
            textDescribeFigureController.ListFigures = listFigures;
        }

        private void buttonCreateFigure_Click(object sender, EventArgs e)
        {
            string[] masCurrentString = textBoxForWriteDescrideFigure.Text.Split(new char[] { '-' });
            textDecsribeFigure.Name = masCurrentString[0].Replace(" ", "");
            int i = 1;
            while (i < masCurrentString.Length)
            {
                defineParametrFigure(masCurrentString[i]);
                i++;
            }
            try
            { 
                textDescribeFigureController.validate(textDecsribeFigure);
            }
            catch (Exception ex)
            {
                textBox1.Text = ex.Message;
                textBox1.Text += "\nДля просмотра справочной информации нажмите на кнопку 'Помощь'.";
            }
           
            textDescribeFigureController.drawFigure(textDecsribeFigure, this, listFigures);

        }

        private void defineParametrFigure(string subString)//подумать, как усовершенствовтаь
        {
            if (subString[0].ToString() == masStaticCharForParser[0])
            {
                textDecsribeFigure.TagP = subString.Remove(0, 2);
            }
            if (subString[0].ToString() == masStaticCharForParser[1])
            {
                textDecsribeFigure.TagC = subString.Remove(0, 2);
            }
            if ((subString[0].ToString() == masStaticCharForParser[2]))
            {
                if (subString[1].ToString() == " ")
                    textDecsribeFigure.TagR1 = subString.Remove(0, 1);


                if (subString[1].ToString() == "1")
                {
                    textDecsribeFigure.TagR1 = subString.Remove(0, 2);
                }
                else
                {
                    textDecsribeFigure.TagR2 = subString.Remove(0, 2);
                }
            }
            if (subString[0].ToString() == masStaticCharForParser[3])
            {
                textDecsribeFigure.TagB = subString.Remove(0, 2);
            }
        }

        public void DrawLine(ArrayList points, Color colorLine)
        {
            g.DrawLine(new Pen(colorLine), (Point)points[0], (Point)points[1]);
        }

        public void DrawRectangle(ArrayList points, Color colorLine, Color colorBackground)
        {
            Point point1 = (Point)points[0];
            Point point2 = (Point)points[1];
            int height = point2.Y - point1.Y;
            int weight = point2.X - point1.X;
            Rectangle currentRectangle = new Rectangle(point1.X, point1.Y, height, weight);

            g.DrawRectangle(new Pen(colorLine), currentRectangle);

            if (!colorBackground.Equals(null))
            {
                g.FillRectangle(new SolidBrush(colorBackground), currentRectangle.X + 1, currentRectangle.Y + 1, weight - 1, height - 1);
            }

        }

        public void DrawTriangle(ArrayList points, Color colorLine, Color colorBackground)
        {
            g.DrawPolygon(new Pen(colorLine), new[] { (Point)points[0], (Point)points[1], (Point)points[2] });
            if (!colorBackground.Equals(null))
            {
                g.FillPolygon(new SolidBrush(colorBackground), new[] { (Point)points[0], (Point)points[1], (Point)points[2] });
            }
        }

        public void DrawCircle(ArrayList points, Color colorLine, Color colorBackground)
        {
            Point pointCentre = (Point)points[0];
            Point point2 = (Point)points[1];
            int height = (pointCentre.Y - point2.Y) * 2;
            int weight = (pointCentre.X - point2.X) * 2;

            Rectangle currentRectangle = new Rectangle(point2.X, point2.Y, weight, height);
            g.DrawEllipse(new Pen(colorLine), currentRectangle);
            if (!colorBackground.Equals(null))
            {
                g.FillEllipse(new SolidBrush(colorBackground), currentRectangle.X + 1, currentRectangle.Y + 1, weight - 1, height - 1);
            }
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {


        }






    }
}
