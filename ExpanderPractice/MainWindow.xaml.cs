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

namespace ExpanderPractice
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }


        private void expFirstExpander_Expanded(object sender, RoutedEventArgs e)
        {
            expSecondExpander.IsExpanded = false;
        }

        private void expSecondExpander_Expanded(object sender, RoutedEventArgs e)
        {
            expFirstExpander.IsExpanded = false;
        }
    }
}
