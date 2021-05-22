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
using WpfApp3.ControlConstructors;
using WpfApp3.UserControl1;

namespace WpfApp3
{
    public struct ControllVisibility
    {
        public Visibility PrTree;
    }
    public partial class MainWindow : Window
    {
        public static ControllVisibility cVis = new ControllVisibility();
        public static TreeView tv_ProjTr = new TreeView();
        public static Border b_ProjTr = new Border();
        public MainWindow()
        {
            InitializeComponent();
            ProjTr.Border();
            ProjTr.TreeView();
            g_main.Children.Add(b_ProjTr);
            g_main.Children.Add(tv_ProjTr);
        }
        public static void ControllRefresh()
        {
            b_ProjTr.Visibility = cVis.PrTree;
            tv_ProjTr.Visibility = cVis.PrTree;
        }
    }
}
