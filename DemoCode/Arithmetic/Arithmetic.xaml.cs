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

namespace DemoCode.Arithmetic
{
    /// <summary>
    /// Interaction logic for Arithmetic.xaml
    /// </summary>
    enum Choice { Arithmetic = 1, Geometry, Trigonometry };
    public partial class Arithmetic : UserControl
    {
        public int a;
        public int b;
        public int operators;
        public int answer;
        public Arithmetic()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Random r = new Random();
            a = r.Next(10);
            b = r.Next(10);
            operators = r.Next(1, 5);
            aLabel.Content = a;
            bLabel.Content = b;
            switch (operators)
            {
                case 1:
                    var ops = "+";
                    answer = a + b;
                    break;
                case 2:
                    ops = "-";
                    answer = a - b;
                    break;
                case 3:
                    ops = "*";
                    answer = a * b;
                    break;
                case 4:
                    ops = "/";
                    answer = a / b;
                    break;

            }
        }
    }
}
