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
        public void Left_Click(object sender, MouseEventArgs e)
        {
            UIElement shape = (UIElement)sender;
            foreach (var i in selected)
            {
                if (shape == i)
                {
                    return;
                }

            }
            if (isMoving)
            {
                return;
            }

            Clear_selected();
            FrameworkElement fram;
            currentElem = shape;
            WidthBox.IsEnabled = true;
            HeightBox.IsEnabled = true;
            ColorComboBox.IsEnabled = true;
            AngleSlider.IsEnabled = true;
            DeleteButton.IsEnabled = true;
            RandomButton.IsEnabled = true;
            AngleNumber.Text = " °";
            AngleSlider.Value = 0;

            selected.Add(shape);
            DropShadowEffect shadow = new DropShadowEffect();
            shadow.BlurRadius = 70;

            fram = (FrameworkElement)currentElem;
            WidthBox.Text = fram.Width.ToString();
            HeightBox.Text = fram.Height.ToString();


            ColorComboBox.Background = ((Shape)currentElem).Fill;

            shadow.Color = Color.FromRgb(255, 255, 255);
            shadow.Direction = 270;
            shape.Effect = shadow;
        }
    }
}
