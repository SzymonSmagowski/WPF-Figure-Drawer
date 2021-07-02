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
        public void Drawing(object sender, MouseEventArgs e)
        {
            if (shapeType == Type.ellipse || shapeType == Type.rectangle)
            {
                drawing = true;
                Canvas current = (Canvas)sender;
                startPosition = currentPosition = e.GetPosition(current);
            }
        }
        public void MovingMouse(object sender, MouseEventArgs e)
        {
            Canvas current = (Canvas)sender;
            currentPosition = e.GetPosition(current);
            if (drawing)
            {
                if (shapeType == Type.rectangle)
                {
                    if (unDone != null) ((Canvas)sender).Children.Remove(unDone);
                    currentShape = RectangleCreate();
                    unDone = currentShape;
                    current.Children.Add(unDone);
                }
                if (shapeType == Type.ellipse)
                {
                    if (unDone != null) ((Canvas)sender).Children.Remove(unDone);
                    currentShape = EllipseCreate();
                    unDone = currentShape;
                    current.Children.Add(unDone);
                }
            }
        }
        public void CompleteDrawing(object sender, MouseEventArgs e)
        {
            Canvas current = (Canvas)sender;

            if (drawing)
            {

                if (shapeType == Type.rectangle)
                {
                    drawing = false;
                    System.Windows.Shapes.Rectangle rectangle = RectangleCreate();
                    if (unDone != null) ((Canvas)sender).Children.Remove(unDone);
                    current.Children.Add(rectangle);
                    rectangle.MouseEnter += Select;
                    rectangle.MouseLeave += Leave;
                    rectangle.MouseRightButtonDown += RightClick;
                    rectangle.MouseLeftButtonDown += Left_Click;
                    current.InvalidateVisual();
                }
                if (shapeType == Type.ellipse)
                {
                    drawing = false;
                    Ellipse ellipse = EllipseCreate();

                    if (unDone != null) ((Canvas)sender).Children.Remove(unDone);
                    current.Children.Add(ellipse);

                    ellipse.MouseEnter += Select;
                    ellipse.MouseLeave += Leave;
                    ellipse.MouseRightButtonDown += RightClick;
                    ellipse.MouseLeftButtonDown += Left_Click;
                    current.InvalidateVisual();
                }
            }
            unDone = null;

            shapeType = Type.nothing;
        }
    }
}
