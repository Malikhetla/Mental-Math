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

namespace Finale
{
    /// <summary>
    /// Interaction logic for Arithmetic.xaml
    /// </summary>
    //private BitmapImage[] ;
    public partial class Arithmetic : Window
    {
        public int a;
        public int b;
        public int operators;
        public int answer;
        public string ops;
        
        MainWindow myMain;
        public BitmapImage[] thePics;

        public Arithmetic()
        {
            
            InitializeComponent();
         
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            var result = MessageBox.Show(@"Do you want to return to the Main Menu?", "Close Game", MessageBoxButton.YesNo);
            if (result == MessageBoxResult.Yes)
            {
                myMain = new MainWindow();
                myMain.Show();
                
                Arith.Hide();

            }

        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
