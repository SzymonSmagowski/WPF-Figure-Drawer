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
        public FrameworkElement GetCurrentElem()
        {
            return (FrameworkElement)currentElem;
        }


        public void Clear_selected()
        {
            UIElement shape;
            foreach (var i in selected)
            {
                shape = i;
                shape.Effect = null;
            }
            selected.Clear();
        }
        public void Select(object sender, MouseEventArgs e)
        {
            Cursor = Cursors.Hand;
        }
        public void Leave(object sender, MouseEventArgs e)
        {
            Cursor = Cursors.Arrow;
        }
    }
}