
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
        private void FlagClick(object sender, RoutedEventArgs e)
        {
            if (english == true)
            {
                //https://www.youtube.com/watch?v=QZtW9S-WvPA&t=425s
                
                english = false;
                ResourceManager rm = new("WpfAppLabHome.Resources.StringsPl", Assembly.GetExecutingAssembly());
                ResourceManager flag = new("WpfAppLabHome.Resources.Flags", Assembly.GetExecutingAssembly());
                FlagButtonName.Source = ToImage((byte[])flag.GetObject("polandFlag"));
                AngleLabel.Text = rm.GetString("AngleLabel");
                ColorLabel.Text = rm.GetString("ColorLabel");
                DeleteText.Text = rm.GetString("DeleteButton");
                EllipseText.Text = rm.GetString("EllipseButton");
                ExportButtonText.Text = rm.GetString("ExportButton");
                HeightLabel.Text = rm.GetString("HeightLabel");
                RandomButtonText.Text = rm.GetString("RandomColorsButton");
                RectangleText.Text = rm.GetString("RectangleButton");
                WidthLabel.Text = rm.GetString("WidthLabel");
            }
            else
            {

                english = true;
                ResourceManager rm2 = new("WpfAppLabHome.Resources.StringsE", Assembly.GetExecutingAssembly());
                ResourceManager flag = new("WpfAppLabHome.Resources.Flags", Assembly.GetExecutingAssembly());
                FlagButtonName.Source = ToImage((byte[])flag.GetObject("englandFlag"));
                AngleLabel.Text = rm2.GetString("AngleLabel");
                ColorLabel.Text = rm2.GetString("ColorLabel");
                DeleteText.Text = rm2.GetString("DeleteButton");
                EllipseText.Text = rm2.GetString("EllipseButton");
                ExportButtonText.Text = rm2.GetString("ExportButton");
                HeightLabel.Text = rm2.GetString("HeightLabel");
                RandomButtonText.Text = rm2.GetString("RandomColorsButton");
                RectangleText.Text = rm2.GetString("RectangleButton");
                WidthLabel.Text = rm2.GetString("WidthLabel");
            }
        }
        private BitmapImage ToImage(byte[] array)
        {
            //from stack as well i forgot link
            using (var ms = new System.IO.MemoryStream(array))
            {
                var image = new BitmapImage();
                image.BeginInit();
                image.CacheOption = BitmapCacheOption.OnLoad;
                image.StreamSource = ms;
                image.EndInit();
                return image;
            }
        }
    }
}

