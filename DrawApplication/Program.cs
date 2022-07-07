using DrawApplication.Shapes;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DrawApplication
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var shapes = new List<Shape>
            {
                new Shapes.Rectangle {Id =1,Name="Dikdörtgen"},
                new Square {Id =2,Name="Kare"},
                new Ellipse {Id =3,Name="Elips"}
            };

            var colors = new List<Color>
            {
                Color.Red,
                Color.Green,
                Color.Blue
            };

            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1(shapes,colors));
        }
    }
}
