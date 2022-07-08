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

            var colors = new List<DrawApplication.Colors.Color>
            {
                new DrawApplication.Colors.Color{Name="Kýrmýzý",Value=Color.Red},
                new DrawApplication.Colors.Color{Name="Mavi",Value=Color.Blue},
                new DrawApplication.Colors.Color{Name="Sarý",Value=Color.Yellow},
                new DrawApplication.Colors.Color{Name="Turuncu",Value=Color.Orange},
                new DrawApplication.Colors.Color{Name="Siyah",Value=Color.Black},
                new DrawApplication.Colors.Color{Name="Kahverengi",Value=Color.Brown},
                new DrawApplication.Colors.Color{Name="Mor",Value=Color.Purple},
                new DrawApplication.Colors.Color{Name="Pembe",Value=Color.Pink}
            };

            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1(shapes,colors));
        }
    }
}
