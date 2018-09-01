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
    public partial class Arithmetic : UserControl
    {
        public Arithmetic()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            {
                Random r = new Random();
                a = r.Next(10);
                b = r.Next(10);
                operators = r.Next(1, 5);



                switch (operators)
                {
                    case 1:
                        Image img = Image.FromFile("if_add_2460234");
                        var ops = "+";
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
}
