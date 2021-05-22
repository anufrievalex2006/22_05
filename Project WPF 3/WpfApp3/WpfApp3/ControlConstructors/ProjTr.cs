using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media;

namespace WpfApp3.ControlConstructors
{
    class ProjTr
    {
        public static void Border()
        {
            MainWindow.b_ProjTr.Width = 250;
            MainWindow.b_ProjTr.BorderBrush = new SolidColorBrush(Color.FromArgb(255, 0, 0, 0));
            MainWindow.b_ProjTr.SetValue(Grid.RowProperty, 1);
            MainWindow.b_ProjTr.BorderThickness = new System.Windows.Thickness(2);
            MainWindow.b_ProjTr.HorizontalAlignment = System.Windows.HorizontalAlignment.Left;
        }
        public static void TreeView()
        {
            MainWindow.tv_ProjTr.Width = 250;
            MainWindow.tv_ProjTr.Background = new SolidColorBrush(Color.FromArgb(255, 45, 45, 45));
            MainWindow.tv_ProjTr.SetValue(Grid.RowProperty, 1);
            MainWindow.tv_ProjTr.HorizontalAlignment = System.Windows.HorizontalAlignment.Left;

            List<TreeViewItem> l = new List<TreeViewItem>(), l1 = new List<TreeViewItem>();
            l.Add(new TreeViewItem());
            l.Add(new TreeViewItem());
            l.Add(new TreeViewItem());
            l1.Add(new TreeViewItem());
            l1.Add(new TreeViewItem());
            l1.Add(new TreeViewItem());

            foreach (TreeViewItem el in l)
            {
                el.Foreground = new SolidColorBrush(Color.FromArgb(255, 0, 0, 0));
            }
            foreach (TreeViewItem le in l1)
            {
                le.Foreground = new SolidColorBrush(Color.FromArgb(255, 0, 0, 0));
            }
            l[0].Header = "123";
            l[1].Header = "456";
            l[2].Header = "789";
            l1[0].Header = "789";
            l1[1].Header = "456";
            l1[2].Header = "123";
            MainWindow.tv_ProjTr.Items.Add(l[0]);
            l[0].Items.Add(l[1]);
            l[1].Items.Add(l[2]);
            MainWindow.tv_ProjTr.Items.Add(l1[0]);
            l1[0].Items.Add(l1[1]);
            l1[1].Items.Add(l1[2]);
        }
    }
}
