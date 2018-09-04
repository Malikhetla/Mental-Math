using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThinkLib;

namespace DemoCode.Viewmodels
{
    class Geometry
    {
        Turtle Siya;
        public Geometry()
        {

        }
    }
}
//            InitializeComponent();
//            Siya = new Turtle(canvas, 300, 300);

//            Siya.BrushWidth = 3;
//            Siya.BrushDown = true;
//        }
//        private void Question1()
//        {
//            Triangle(100);
//        }
//        private void Question2()
//        {
//            Circle();
//        }
//        private void Question3()
//        {
//            StackedTriangle();
//        }

//        private void Triangle(int num)
//        {
//            Siya.Left(90);
//            Siya.Forward(num * 2);
//            Siya.Right(105);
//            Siya.Forward(num + 10);
//            Siya.Right(107);
//            Siya.Forward(200);
//            Siya.WarpTo(390, 125);
//            Siya.Forward(10);
//            Siya.Left(90);
//            Siya.Forward(15);
//            Siya.WarpTo(300, 300);
//            txtQuestionSpace.Text = "The value of x is?";
//        }
//        private void Circle()
//        {
//            for (int i = 0; i < 360; i++)
//            {
//                Siya.Left(1);
//                Siya.Forward(2.5);
//            }
//            Siya.WarpTo(300, 13);
//            for (int j = 0; j < 2; j++)
//            {
//                Siya.Right(90);
//                Siya.Forward(146);
//            }
//            Siya.WarpTo(300, 300);
//            txtQuestionSpace.Text = "Arc length C has the value..";
//        }
//        private void StackedTriangle()
//        {
//            Siya.Left(90);
//            Siya.Forward(200);
//            Siya.Right(130);
//            Siya.Forward(310);
//            Siya.Right(140);
//            Siya.Forward(240);
//            Siya.WarpTo(540, 300);
//            Siya.Right(20);
//            Siya.Forward(257);
//            Siya.WarpTo(540, 300);
//            Siya.Left(20);
//            Siya.Forward(50);

//            for (int a = 0; a < 2; a++)
//            {
//                for (int b = 0; b < 70; b++)
//                {
//                    Siya.Right(1);
//                    Siya.Forward(0.5);
//                }
//            }
//            txtQuestionSpace.Text = "The correct value of angle CBD is..";
//        }
//        private void btnGO_Click(object sender, RoutedEventArgs e)
//        {
//            Question1();
//        }
//    }
//}
