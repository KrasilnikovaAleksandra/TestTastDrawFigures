using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using TestTask2DrawFigures.model;

namespace TestTask2DrawFigures.controller
{
    class StaticDataController
    {
        private ArrayList listFigures;


        public StaticDataController()
        {
            listFigures = new ArrayList();
            createTypeFigures();
        }

        private void createTypeFigures()
        {
            listFigures.Add(new Figure("line", 2));
            listFigures.Add(new Figure("rectangle", 2));
            listFigures.Add(new Figure("triangle", 3));
            listFigures.Add(new Figure("circle", 1));
            listFigures.Add(new Figure("ellipse", 1));
           
        }
        public ArrayList ListFigures
        {
            get { return listFigures; }
        }

       /* public string getName(int i)
        {
            Figure currentFigure = (Figure)listFigures[i];
            return currentFigure.Name;
        }

        public int getCountPoints(int i)
        {
            Figure currentFigure = (Figure)listFigures[i];
            return currentFigure.CountPoints;
        }*/
    }
}
