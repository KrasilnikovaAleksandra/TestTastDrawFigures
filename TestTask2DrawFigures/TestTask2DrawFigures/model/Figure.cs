using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestTask2DrawFigures.model
{
   public class Figure
    {
       private string name;
       private int countPoints;

       public Figure()
       {        
       }

       public Figure(string name, int countPoints)
       {
           this.name = name;
           this.countPoints = countPoints;
       }

       public string Name
       {
           get { return name; }
           set { name = value; }
       }

       public int CountPoints
       {
           get { return countPoints; }
           set { countPoints = value; }
       }
       
    }
}
