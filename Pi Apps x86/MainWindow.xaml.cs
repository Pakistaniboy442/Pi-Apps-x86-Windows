using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
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

namespace Pi_Apps_x86
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string picked = "no";
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ListBoxItem_Selected(object sender, RoutedEventArgs e)
        {
            Forward.IsEnabled = true;
            this.picked = "Browser";
        }

        private void ListBoxItem_Selected_1(object sender, RoutedEventArgs e)
        {
            Forward.IsEnabled = true;
        }

        private void ListBoxItem_Selected_2(object sender, RoutedEventArgs e)
        {
            Forward.IsEnabled = true;
        }

        private void ListBoxItem_Selected_3(object sender, RoutedEventArgs e)
        {
            Forward.IsEnabled = true;
        }

        private void Forward_Click(object sender, RoutedEventArgs e)
        {
            Menu.Visibility = Visibility.Hidden;
            if (this.picked == "Browser") { this.Browsers.Visibility = Visibility.Visible; }
        }
    }
}
