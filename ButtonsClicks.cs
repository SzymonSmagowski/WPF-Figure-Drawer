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
        public void RectangleClick(object sender, RoutedEventArgs e)
        {
            shapeType = Type.rectangle;
            currentColor = RandomColor();

            Cursor = Cursors.Cross;
        }
        public void EllipseClick(object sender, RoutedEventArgs e)
        {
            shapeType = Type.ellipse;
            currentColor = RandomColor();

            Cursor = Cursors.Cross;
        }
        public void DeleteClick(object sender, RoutedEventArgs e)
        {
            foreach (var s in selected)
            {
                var parent = ((FrameworkElement)s).Parent;
                ((Canvas)parent).Children.Remove(s);

            }
            selected.Clear();
            if (currentElem == null)
            {
                WidthBox.IsEnabled = false;
                HeightBox.IsEnabled = false;
                ColorComboBox.IsEnabled = false;
                AngleSlider.IsEnabled = false;
                DeleteButton.IsEnabled = false;
                RandomButton.IsEnabled = false;
                AngleNumber.Text = " °";
                AngleSlider.Value = 0;
                WidthBox.Text = "";
                HeightBox.Text = "";
            }
        }
        public void RandomClick(object sender, RoutedEventArgs e)
        {
            foreach (var s in selected)
            {
                ((Shape)s).Fill = new SolidColorBrush(RandomColor());

            }
        }
        public Color RandomColor()
        {
            Random rnd = new();
            return (Color)System.Windows.Media.ColorConverter.ConvertFromString(String.Format("#{0:X6}", rnd.Next(0x1000000)));
        }
    }
}
