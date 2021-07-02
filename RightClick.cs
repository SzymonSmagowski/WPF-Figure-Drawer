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
        public void RightClick(object sender, MouseEventArgs e)
        {
            if (isMoving)
            {
                return;
            }

            UIElement shape = (UIElement)sender;
            //we know which element is last

            currentElem = shape;
            FrameworkElement fram;
            Canvas.SetZIndex(shape, max++);
            foreach (var every in selected)
            {
                if (every == shape)
                {

                    selected.Remove(shape);
                    shape.Effect = null;
                    if (selected.Count != 0)
                    {
                        currentElem = selected[selected.Count - 1];
                    }
                    else
                    {
                        currentElem = null;
                    }

                    if (currentElem != null)
                    {
                        //here enable ones for one
                        WidthBox.IsEnabled = true;
                        HeightBox.IsEnabled = true;
                        ColorComboBox.IsEnabled = true;
                        AngleSlider.IsEnabled = true;
                        DeleteButton.IsEnabled = true;
                        RandomButton.IsEnabled = true;
                        AngleNumber.Text = " °";
                        AngleSlider.Value = 0;
                    }
                    else
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
                    if (currentElem != null)
                    {
                        fram = (FrameworkElement)currentElem;
                        ColorComboBox.Background = ((Shape)currentElem).Fill;
                        WidthBox.Text = fram.Width.ToString();
                        HeightBox.Text = fram.Height.ToString();
                    }
                    else
                    {
                        WidthBox.Text = "";
                        HeightBox.Text = "";
                        ColorComboBox.Text = "";
                    }
                    if (selected.Count == 0)
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
                    return;
                }
            }

            AngleSlider.Value = 0;
            AngleNumber.Text = " °";
            WidthBox.IsEnabled = true;
            HeightBox.IsEnabled = true;
            ColorComboBox.IsEnabled = true;
            AngleSlider.IsEnabled = true;
            DeleteButton.IsEnabled = true;
            RandomButton.IsEnabled = true;

            selected.Add(shape);
            DropShadowEffect effect = new();
            effect.BlurRadius = 70;

            fram = (FrameworkElement)currentElem;
            WidthBox.Text = fram.Width.ToString();
            HeightBox.Text = fram.Height.ToString();


            ColorComboBox.Background = ((Shape)currentElem).Fill;

            effect.Color = Color.FromRgb(255, 255, 255);
            effect.Direction = 270;
            shape.Effect = effect;
        }
    }
}
