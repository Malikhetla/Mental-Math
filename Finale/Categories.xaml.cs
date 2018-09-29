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
using System.Windows.Shapes;

namespace Finale
{
    /// <summary>
    /// Interaction logic for Categories.xaml
    /// </summary>
    public partial class Categories : Window
    {
        MainWindow myMain;
        Arithmetic arith;
        Geometry Geometry;
        
        
        

        public Categories()
        {
            InitializeComponent();
        }
        private void Exit_bn (object sender, RoutedEventArgs e)
        {
            var result = MessageBox.Show(@"Do you want to return to the Main Menu?", "Close Game", MessageBoxButton.YesNo);
            if (result == MessageBoxResult.Yes)
            {
                myMain = new MainWindow(); 
                Cate.Hide();
                myMain.Show();
            }

        }
        private void Arithmetic_bn (object sender, RoutedEventArgs e)
        {
            arith = new Arithmetic(); 
            Cate.Hide();
            arith.Show();

        }
        private void Geometry_bn(object sender, RoutedEventArgs e)
        {
            Geometry = new Geometry();
            Cate.Hide();
            Geometry.Show();

        }
        private void Trigonometry_bn(object sender, RoutedEventArgs e)
        {

        }
    }

    internal class DialogResult
    {
    }
}
