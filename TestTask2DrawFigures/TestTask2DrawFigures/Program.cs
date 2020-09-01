using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using TestTask2DrawFigures.controller;

namespace TestTask2DrawFigures
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            StaticDataController staticDataController = new StaticDataController();

            Application.Run(new DrawFigures(staticDataController.ListFigures));
        }
    }
}
