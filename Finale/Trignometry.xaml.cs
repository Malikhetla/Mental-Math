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
    /// Interaction logic for Trignometry.xaml
    /// </summary>
    public partial class Trignometry : Window
    {
        MainWindow myMain;
        Trignometry trig;
        public Trignometry()
        {
            InitializeComponent();
        }

        private void EXIT_bn(object sender, RoutedEventArgs e)
        {
            var result = MessageBox.Show(@"Do you want to return to the Main Menu?", "Close Game", MessageBoxButton.YesNo);
            if (result == MessageBoxResult.Yes)
            {
                myMain = new MainWindow();
                trig = new Trignometry();
                trig.Hide();
                myMain.Show();

            }

        }
    }
}
