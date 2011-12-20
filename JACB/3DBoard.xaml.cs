using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Media3D;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace JACB
{
    /// <summary>
    /// Interaction logic for _3DBoard.xaml
    /// </summary>
    public partial class _3DBoard : Window
    {
        public _3DBoard()
        {
            InitializeComponent();
            //Viewport2DVisual3D 

            int val = RenderCapability.Tier >> 16;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

        }
    }
}
