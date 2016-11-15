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

namespace WPF_Training
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private int crlProperty;
        public int CrlProperty  
        {
            get { return crlProperty; }
            set { crlProperty = value; }
        }

        public int MyPropertyyy
        {
            get { return (int)GetValue(MyPropertyyyyyProperty); }
            set { SetValue(MyPropertyyyyyProperty, value); }
        }

        // Using a DependencyProperty as the backing store for MyPropertyyy.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty MyPropertyyyyyProperty =
            DependencyProperty.Register(nameof(MyPropertyyy), typeof(int), typeof(MainWindow), new FrameworkPropertyMetadata(0));




        public MainWindow()
        {
            InitializeComponent();
        }
    }
}
