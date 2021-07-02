using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Media.Effects;
using System.Resources;
using System.Reflection;
using System.Threading;
using System.Globalization;
using WpfAppLabHome.Resources;
using System.Runtime.CompilerServices;
using System.ComponentModel;
using Microsoft.Win32;
using System.Collections;
using System.Drawing;
using Color = System.Windows.Media.Color;

namespace WpfAppLabHome
{
    public partial class MainWindow
    {
        public System.Windows.Shapes.Rectangle RectangleCreate()
        {
            System.Windows.Shapes.Rectangle rectangle = new();

            rectangle.Height = Math.Abs(startPosition.Y - currentPosition.Y);
            rectangle.Width = Math.Abs(startPosition.X - currentPosition.X);

            rectangle.Fill = new SolidColorBrush(currentColor);



            double left = Math.Min(startPosition.X, currentPosition.X);
            double top = Math.Min(startPosition.Y, currentPosition.Y);
            Canvas.SetLeft(rectangle, left);
            Canvas.SetTop(rectangle, top);
            return rectangle;
        }
        public Ellipse EllipseCreate()
        {
            Ellipse ellipse = new();


            //https://docs.microsoft.com/en-us/dotnet/api/system.windows.shapes.ellipse?view=net-5.0 same with rectangle
            ellipse.Height = Math.Abs(startPosition.Y - currentPosition.Y);
            ellipse.Width = Math.Abs(startPosition.X - currentPosition.X);

            ellipse.Fill = new SolidColorBrush(currentColor);

            double left = Math.Min(startPosition.X, currentPosition.X);
            double top = Math.Min(startPosition.Y, currentPosition.Y);
            Canvas.SetLeft(ellipse, left);
            Canvas.SetTop(ellipse, top);
            return ellipse;
        }
    }
}
