using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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

namespace Turntable_Control_Program.Control
{
    /// <summary>
    /// Device.xaml 的交互逻辑
    /// </summary>
    public partial class Device  
    {
        public string Name1 { get; set; }
        public string Com { get; set; }

        public string Bounds { get; set; }

        public string Angle { get; set; }

        public List<double> Data { get; set; }

        public Thread DataDeal;

        public void Connect_Click(object sender, RoutedEventArgs routedEventArgs)
        {
            Name1 = "IMU";
            Con.Text = Name1;
        }
        public Device()
        {
            
            InitializeComponent();
        }
    }
}
