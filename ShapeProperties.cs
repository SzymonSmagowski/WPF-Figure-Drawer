using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;


namespace WpfAppLabHome
{
    
        public class ShapeProperties : INotifyPropertyChanged
        {
            private String width;
            public string Width
            {
                get
                {
                    return width;
                }
                set
                {
                    width = value;
                    OnPropertyRaised("Width");
                }
            }
            private String height;

            public event PropertyChangedEventHandler PropertyChanged;

            public string Height
            {
                get
                {
                    return height;
                }
                set
                {
                    height = value;
                    OnPropertyRaised("Height");
                }
            }
            public ShapeProperties()
            {
            
                width = "";
                height = "";
            
                
            }
            private void OnPropertyRaised(string propertyname)
            {
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs(propertyname));
                    
                    if (propertyname == "Width")
                    {
                        if (Width == "")
                        {
                            MainWindow.Instance.ChangingSize("Width", 0);
                            return;
                        }
                        for(int i=0; i < Width.Length; i++)
                        {
                            char tmp = Width[i];
                            if (!Char.IsDigit(tmp))
                            {
                                return;
                            }
                        }
                    MainWindow.Instance.ChangingSize("Width", Int32.Parse(Width));
                    //wywolanie metody
                    //https://stackoverflow.com/questions/10240449/c-sharp-call-function-from-outside-current-class
                }
                else
                    {
                        if (Height == "")
                        {
                            MainWindow.Instance.ChangingSize("Height", 0);
                            return;
                        }
                    for (int i = 0; i < Height.Length; i++)
                        {
                            char tmp = Height[i];
                            if (!Char.IsDigit(tmp))
                                {
                                    return;
                                }
                        }
                    MainWindow.Instance.ChangingSize("Height", Int32.Parse(Height));
                    //wywolanie metody
                }
                }
            }

        
    }
}

//styleItems
//https://docs.microsoft.com/pl-pl/dotnet/api/system.windows.controls.itemscontrol.itemcontainerstyle?view=net-5.0