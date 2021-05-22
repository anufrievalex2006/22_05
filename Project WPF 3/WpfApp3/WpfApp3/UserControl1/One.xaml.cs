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

namespace WpfApp3.UserControl1
{
    /// <summary>
    /// Логика взаимодействия для One.xaml
    /// </summary>
    public partial class One : UserControl
    {
        public One()
        {
            InitializeComponent();
        }

        private void btn_Click(object sender, RoutedEventArgs e)
        {
            if (MainWindow.cVis.PrTree == Visibility.Visible)
                MainWindow.cVis.PrTree = Visibility.Hidden;
            else
                MainWindow.cVis.PrTree = Visibility.Visible;
            MainWindow.ControllRefresh();
        }
    }
}
