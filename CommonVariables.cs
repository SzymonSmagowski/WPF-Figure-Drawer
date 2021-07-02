using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;
using System.Windows.Shapes;

namespace WpfAppLabHome
{
    public partial class MainWindow
    {
        public enum Type
        {
            nothing,
            rectangle,
            ellipse
        }
        private String pathToFile = "";
        public String PathToFile
        {
            get { return pathToFile; }
            set
            {
                if (pathToFile != value)
                {
                    pathToFile = value;

                }
            }
        }
        public bool english = true;
        public int max = 0;
        public static List<UIElement> selected = new List<UIElement>();
        public bool drawing = false;
        UIElement unDone = null;

        ShapeProperties ShapeProps = new();
        public static MainWindow Instance = null;

        public Type shapeType = Type.nothing;
        Shape currentShape = null;
        System.Windows.Point startPosition;
        System.Windows.Point currentPosition;
        System.Windows.Media.Color currentColor;
        public SolidColorBrush tmpString;
        public SolidColorBrush backColor;
        public bool black = true;
        public UIElement currentElem = null;
    }
}
