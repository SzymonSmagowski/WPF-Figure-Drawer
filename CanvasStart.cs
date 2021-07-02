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
        public void CanvasD(object sender, EventArgs e)
        {
            Canvas current = (Canvas)sender;
            current.MouseLeftButtonDown += Drawing;
            current.MouseLeftButtonUp += CompleteDrawing;
            current.MouseMove += MovingMouse;
            for (int i = 0; i < 4; i++)
            {
                Random rnd = new();
                if (rnd.Next() % 2 == 0)
                {

                    System.Windows.Shapes.Rectangle rectangle = new()
                    {
                        Height = rnd.Next() % 200,
                        Width = rnd.Next() % 300
                    };

                    rectangle.Fill = new SolidColorBrush(RandomColor());

                    current.Children.Add(rectangle);
                    double left = rnd.Next() % 1600;
                    double top = rnd.Next() % 800;
                    Canvas.SetLeft(rectangle, left);
                    Canvas.SetTop(rectangle, top);



                    Canvas.SetZIndex(rectangle, 0);
                    rectangle.MouseEnter += Select;
                    rectangle.MouseLeave += Leave;
                    rectangle.MouseRightButtonDown += RightClick;
                    rectangle.MouseLeftButtonDown += Left_Click;
                }
                else
                {
                    Ellipse ellipse = new()
                    {
                        Height = rnd.Next() % 200,
                        Width = rnd.Next() % 300
                    };

                    ellipse.Fill = new SolidColorBrush(RandomColor());

                    current.Children.Add(ellipse);
                    double left = rnd.Next() % 1600;
                    double top = rnd.Next() % 800;
                    Canvas.SetZIndex(ellipse, 0);


                    Canvas.SetLeft(ellipse, left);
                    Canvas.SetTop(ellipse, top);
                    ellipse.MouseEnter += Select;

                    ellipse.MouseLeave += Leave;
                    ellipse.MouseRightButtonDown += RightClick;
                    ellipse.MouseLeftButtonDown += Left_Click;
                }
            }

        }
    }
}
