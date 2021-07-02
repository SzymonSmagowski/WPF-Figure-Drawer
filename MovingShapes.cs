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
        public bool isStarting = false;
        public void Cnv_MouseLeftButtonUp(object sender, MouseEventArgs e)
        {

            deltaX.Clear();
            deltaY.Clear();
            _currentTT = null;
            isMoving = false;
            objectsPositions.Clear();
            return;
        }

        //https://stackoverflow.com/questions/46380682/wpf-move-element-with-mouse
        public List<System.Windows.Point?> objectsPositions = new List<System.Windows.Point?>();
        public TranslateTransform _currentTT = null;
        public List<double> deltaX = new List<double>();
        public List<double> deltaY = new List<double>();
        bool isMoving = false;

        
        public void cnv_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            
            if (selected.Count == 0)
            {
                return;
            }
            foreach (var i in selected)
            {
                if (i == (UIElement)sender)
                {
                    isStarting = true;
                    return;
                }
            }
            isStarting = true;
            
        }

        public void cnv_PreviewMouseMove(object sender, MouseEventArgs e)
        {

            if (!isStarting)
            {
                return;
            }

            MouseButtonEventArgs e1 = new(e.MouseDevice, e.Timestamp, MouseButton.Left);
            if (e1.LeftButton != MouseButtonState.Pressed)
            {
                
                return;
            }
            var mousePosition = Mouse.GetPosition(MainCanvas);
            for (int i = 0; i < selected.Count; i++)
            {

                objectsPositions.Add(selected[i].TransformToAncestor(MainCanvas).Transform(new System.Windows.Point(0, 0)));

                deltaX.Add(mousePosition.X - objectsPositions[i].Value.X);
                deltaY.Add(mousePosition.Y - objectsPositions[i].Value.Y);
            }
            var mousePoint = Mouse.GetPosition(MainCanvas);
            
            for (int i = 0; i < selected.Count; i++)
            {
                var offsetX = (_currentTT == null ? objectsPositions[i].Value.X : objectsPositions[i].Value.X - _currentTT.X) + deltaX[i] - mousePoint.X;
                var offsetY = (_currentTT == null ? objectsPositions[i].Value.Y : objectsPositions[i].Value.Y - _currentTT.Y) + deltaY[i] - mousePoint.Y;
                selected[i].RenderTransform = new TranslateTransform(-offsetX, -offsetY);
            }
        }
        public void cnv_PreviewMouseUp(object sender, MouseButtonEventArgs e)
        {

            if (e.LeftButton == MouseButtonState.Pressed)
            {
                return;
            }
            for (int i = 0; i < selected.Count; i++)
            {
                _currentTT = selected[i].RenderTransform as TranslateTransform;

            }
            deltaX.Clear();
            deltaY.Clear();
            _currentTT = null;
            isMoving = false;
            isStarting = false;
            objectsPositions.Clear();
        }
    }
}
