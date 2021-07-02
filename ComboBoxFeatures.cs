
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
    //for combo box https://www.codeproject.com/Articles/34332/Color-Picker-Combo-Box-2
    public partial class MainWindow
    {
        private void ColorComboBox_Initialized(object sender, EventArgs e)
        {

            PropertyInfo[] propInfoList = typeof(System.Drawing.Color).GetProperties(BindingFlags.Static |
                                          BindingFlags.DeclaredOnly | BindingFlags.Public);

            foreach (PropertyInfo c in propInfoList)
            {
                if (c.Name != "Transparent")
                {
                    ColorComboBox.Items.Add(c.Name);
                }


                System.Drawing.Color tmp = System.Drawing.Color.FromName(c.Name);

                //started to changing color of the text, but it was unnecessary
                tmpString = new SolidColorBrush(Color.FromArgb(tmp.A, tmp.R, tmp.G, tmp.B));
                if (tmp.R > 200)
                {
                    black = false;
                }
                else
                {
                    black = true;
                }
            }
        }
        private void ColorComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (currentElem == null)
            {
                return;
            }
            string comboColor = ColorComboBox.SelectedItem.ToString();
            Color color = (Color)System.Windows.Media.ColorConverter.ConvertFromString(comboColor);
            SolidColorBrush brush = new SolidColorBrush(color);
            Shape s = (Shape)currentElem;
            s.Fill = brush;
        }
    }
}

