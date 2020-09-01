using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestTask2DrawFigures.model
{
    class TextDecsribeFigure
    {
        private string name;
        private string tagP;
        private string tagC;
        private string tagB;
        //private string tagR;
        private string tagR1;
        private string tagR2;

        public TextDecsribeFigure()
        {
        }

        public string Name
        {
            get { return name;}
            set { name = value;}
        }

        public string TagP
        {
            get { return tagP; }
            set { tagP = value; }
        }

        public string TagB
        {
            get { return tagB; }
            set { tagB = value; }
        }

        public string TagC
        {
            get { return tagC; }
            set { tagC = value; }
        }
        public string TagR1
        {
            get { return tagR1; }
            set { tagR1 = value; }
        }
        public string TagR2
        {
            get { return tagR2; }
            set { tagR2 = value; }
        }

    }
}
