using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using TestTask2DrawFigures.model;
using System.Drawing;
using System.Text.RegularExpressions;

namespace TestTask2DrawFigures.controller
{
    class TextDescribeFigureController
    {
        private TextDecsribeFigure currentDescribeFugure;
        private DrawFigures currentView;
        private string[] typeColor = new string[] { "rgb", "rgba" };
        private ArrayList listFigures;

        public TextDescribeFigureController()
        {
        }

        public ArrayList ListFigures
        {
            set { listFigures = value; }
        }

        public void validate(TextDecsribeFigure currentDescribeFugure)
        {
            this.currentDescribeFugure = currentDescribeFugure;
            if (verifyNameFigure(currentDescribeFugure))
            {
                throw new Exception("Невалидное имя фигуры.");
            }
            string res = verifyTagP(currentDescribeFugure);
            if (res != null)
            {
                throw new Exception(res);
            }
   
            ///////////////////////////////////////////////////////////////////////////
        }

        private bool verifyNameFigure(TextDecsribeFigure currentDescribeFugure)
        {
            bool errorVerifyNameFigure = true;//ошибка есть
            foreach (Figure figureInStaticList in listFigures)
            {
                if (currentDescribeFugure.Name == figureInStaticList.Name)
                {
                    errorVerifyNameFigure = false;//ошибка нет
                }
            }
            return errorVerifyNameFigure;
        }

        private string verifyTagP(TextDecsribeFigure currentDescribeFugure)
        {
            string subString = currentDescribeFugure.TagP.Replace(" ", "");
            string resultString = SintaxVerify.verify(subString);
            return resultString;
        }

        private void semanticVerifyForTagP(string subString)
        {
           

            }
        

        public void drawFigure(TextDecsribeFigure currentDescribeFugure, DrawFigures currentView, ArrayList listFigures)
        {
            this.currentDescribeFugure = currentDescribeFugure;
            this.currentView = currentView;
            this.listFigures = listFigures;
            ArrayList points = new ArrayList();
            points = definePoints();
            Color currentColorLine = defineColorLineFigure();
            Color currentColorBackground = new Color();
            if (isTagB())
            {
                currentColorBackground = defineColorBackground();
            }

            if (currentDescribeFugure.Name.Equals("line") && points.Count == 2)
            {
                currentView.DrawLine(points, currentColorLine);
                //currentFugure = (Line)currentFugure;

            }
            if (currentDescribeFugure.Name.Equals("rectangle") && points.Count == 2)
            {
                currentView.DrawRectangle(points, currentColorLine, currentColorBackground);
            }

            if (currentDescribeFugure.Name.Equals("triangle") && points.Count == 3)
            {
                currentView.DrawTriangle(points, currentColorLine, currentColorBackground);
            }

            if (currentDescribeFugure.Name.Equals("circle") && points.Count == 1)
            {
                points.Add(countPointsAtRadiusForCircle((Point)points[0]));
                currentView.DrawCircle(points, currentColorLine, currentColorBackground);
            }

            if (currentDescribeFugure.Name.Equals("ellipse") && points.Count == 1)
            {
                points.Add(countPointsAtRadiusForEllipse((Point)points[0]));
                currentView.DrawCircle(points, currentColorLine, currentColorBackground);
            }

        }

        private Color defineColorLineFigure()
        {
            string subString = currentDescribeFugure.TagC.Replace(" ", "");
            return defineColor(subString);
        }

        private Color defineColorBackground()
        {
            string subString = currentDescribeFugure.TagB.Replace(" ", "");
            return defineColor(subString);
        }

        private Color defineColor(string stringParametrsColor)///проверка на пустоту// мб усовершенствововать
        {
            Color newColor = new Color();
            string[] masPatametrsColor = stringParametrsColor.Split(new[] { '(', ')' }, StringSplitOptions.RemoveEmptyEntries);
            if (typeColor[0] == masPatametrsColor[0])// rgb
            {
                string[] masRGB = masPatametrsColor[1].Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
                newColor = Color.FromArgb(Int32.Parse(masRGB[0]), Int32.Parse(masRGB[1]),
                Int32.Parse(masRGB[2]));
            }
            if (typeColor[1] == masPatametrsColor[0])// rgba
            {
                string[] masRGBA = masPatametrsColor[1].Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
                float a = float.Parse(masRGBA[3].Replace(".", ","));
                newColor = Color.FromArgb((int)(a * 255), Int32.Parse(masRGBA[0]), Int32.Parse(masRGBA[1]),
                Int32.Parse(masRGBA[2]));
            }

            return newColor;
        }

       
        private ArrayList definePoints()
        {
            ArrayList points = new ArrayList();
            Point point = new Point();
            string subString = currentDescribeFugure.TagP.Replace(" ", "");
            //////////////////////////////////////////////////////////////////
            string[] masSubString = subString.Split(new[] { '[', ']' }, StringSplitOptions.RemoveEmptyEntries);
            foreach (string s in masSubString)
            {
                string[] coordinatePoint = s.Split(new[] { ',' });
                try
                {
                    point.X = Int32.Parse(coordinatePoint[0]);
                    point.Y = Int32.Parse(coordinatePoint[1]);
                }
                catch
                {
                    throw new Exception("Ошибка в координате " + s);
                }
                
                points.Add(point);
            }
            return points;
        }

        private Point countPointsAtRadiusForCircle(Point centre)
        {
            Point point = new Point();
            point.X = centre.X - Int32.Parse(currentDescribeFugure.TagR1.Replace(" ", ""));
            point.Y = centre.Y - Int32.Parse(currentDescribeFugure.TagR1.Replace(" ", ""));
            return point;
        }

        private Point countPointsAtRadiusForEllipse(Point centre)
        {
            Point point = countPointsAtRadiusForCircle(centre);
            point.Y = centre.Y - Int32.Parse(currentDescribeFugure.TagR2.Replace(" ", ""));
            return point;
        }

        private bool isTagB()//ЕСЛИ ЕСТЬ ЦВЕТ ЗАКРАСКИ
        {
            if (String.IsNullOrEmpty(currentDescribeFugure.TagB))
            {
                return false;
            }
            return true;
        }

        private void paintOverFigure()
        {

        }


        /*public void drowTest1(drawFigures currentView)
        {
            this.currentView = currentView;
            Point p1 = new Point(50, 50);
            Point p2 = new Point(100, 100);
            currentView.DrowLine(p1, p2);
           
        }
        public void drowTest2(drawFigures currentView)
        {
            this.currentView = currentView;
            Point p1 = new Point(0, 0);
            Point p2 = new Point(450, 0);
            currentView.DrowLine(p1, p2);

        }
        public void drowTest3(drawFigures currentView)
        {
            this.currentView = currentView;
            Point p1 = new Point(50, 50);
            Point p2 = new Point(300, 100);
            currentView.DrowLine(p1, p2);

        }*/

    }
}
