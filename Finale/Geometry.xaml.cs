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
using System.Windows.Threading;
using ThinkLib;

namespace Finale
{
    /// <summary>
    /// Interaction logic for Geometry1.xaml
    /// </summary>
    public partial class Geometry : Window
    {
        MainWindow myMain;

        Turtle Siya;

        Random question = new Random();
        Random psuedoAnswer = new Random();
       
        public int QuestionNumbers;
        public double ans;
        public int time = 31;
        public DispatcherTimer timer;



        public Geometry()
        {
            

            InitializeComponent();

            Siya = new Turtle(canvas, 300, 500);
            Siya.LineBrush = Brushes.Aqua;
            Siya.BodyBrush = Brushes.Aqua;
            Siya.BrushWidth = 3;
            Siya.BrushDown = true;
            timer = new DispatcherTimer();
            timer.Interval = new TimeSpan(0, 0, 1);
            timer.Tick += timer_tick;
            timer.Start();
            

        }

        private void timer_tick(object sender, EventArgs e)
        {
            if(time > 10)
            {
                time--; 
                txtbTimer.Text = string.Format("{0}:{1}", time / 60, time % 60);
            }
            else
            {
                timer.Stop();
            }
        }

        private void Question1()
        {
            Triangle(400);

            btnOption1.Content = Answer1();
            btnOption2.Content = psuedoAnswer.Next(1, 50);
            btnOption3.Content = psuedoAnswer.Next(50, 100);
        }
        private void Question2()
        {
            Circle();
            btnOption1.Content = Answer2();
            btnOption2.Content = psuedoAnswer.Next(1, 50);
            btnOption3.Content = psuedoAnswer.Next(50, 100);
        }
        private void Question3()
        {
            StackedTriangle(400);
            btnOption1.Content = Answer3();
            btnOption2.Content = psuedoAnswer.Next(1, 50);
            btnOption3.Content = psuedoAnswer.Next(50, 100);
        }
        private void Question4()
        {
            StarShape();
            btnOption1.Content = Answer4();
            btnOption2.Content = psuedoAnswer.Next(1, 50);
            btnOption3.Content = psuedoAnswer.Next(50, 100);
        }
        private void Question5()
        {
            Octagon();
            btnOption1.Content = Answer5();
            btnOption2.Content = psuedoAnswer.Next(1, 50);
            btnOption3.Content = psuedoAnswer.Next(50, 100);
        }
        //private void Question6()
        //{
        //    StarShape();
        //}
        //private void Question7()
        //{
        //    StarShape();
        //}

        private void Triangle(int num)
        {
            Siya.Left(90);
            Siya.Forward(num);
            Siya.Stamp("13", -30, 100);
            Siya.Right(105);
            Siya.Stamp("53");
            Siya.Forward(num / 2);
            Siya.Stamp("5", -75, -50);
            Siya.Left(256);
            Siya.Forward(num);
            Siya.Stamp("X", 110, -200);

            Siya.WarpTo(470, 145);
            Siya.Forward(20);
            Siya.Left(90);
            Siya.Forward(22);
            Siya.Visible = false;
            txtQuestionSpace.Text = "The value of x is?";

        }

        private void StackedTriangle(int num)
        {
            Siya.Forward(-200);
            Siya.Left(90);
            Siya.Stamp("A", -15);
            Siya.Forward(num);
            Siya.Right(130);
            Siya.Stamp("47", -1, 12);
            Siya.Stamp("D", -20, -10);
            Siya.Forward(num + (num / 2) + 22);
            Siya.Right(140);
            Siya.Stamp("B", 5);
            Siya.Forward(num + 70);
            Siya.Stamp("C", -40, -150);
            Siya.Stamp("63", -10, -170);
            Siya.WarpTo(570, 500);
            Siya.Right(20);
            Siya.Forward(num + 100);



            Siya.WarpTo(510, 500);
            for (int a = 0; a < 2; a++)
            {
                for (int b = 0; b < 70; b++)
                {
                    Siya.Right(1);
                    Siya.Forward(0.5);
                }
            }
            Siya.Visible = false;
            txtQuestionSpace.Text = "The correct value of angle CBD is..";
        }
        private void Circle()
        {
            for (int i = 0; i < 360; i++)
            {
                if (i == 135 + 90)
                {
                    Siya.Stamp("C", -40);
                }
                Siya.Left(1);
                Siya.Forward(3);


            }
            Siya.WarpTo(300, 155);
            for (int j = 0; j < 2; j++)
            {
                Siya.Right(90);
                if (j == 0)
                {
                    Siya.Forward(75);
                    Siya.Stamp("2", 5);
                    Siya.Forward(75);
                }
                else
                {
                    Siya.Forward(170);
                }
                Siya.Visible = false;


                txtQuestionSpace.Text = "Arc length C has the value..";
            }
        }

        private void StarShape()
        {
            Siya.WarpTo(100, 200);
            int i = 0;
            while (i < 5)
            {
                Siya.Forward(400);
                Siya.Right(144);
                i += 1;
            }
            Siya.Visible = false;
            txtQuestionSpace.Text = "How many triangles are drawn in the image?";
        }

        private void Octagon()
        {
            Siya.WarpTo(400, 550);
            for (int i = 0; i < 8; i++)
            {
                Siya.Forward(300 - 100);
                Siya.Left(45);
            }
            Siya.Visible = false;
            txtQuestionSpace.Text = "What is the sum of interior angles in the above shape?";
        }



        // Answer Panel
        public double Answer1()
        {
            double hypotenuse = Math.Pow(13, 2);
            double adjascent = Math.Pow(5, 2);
            double opposite = Math.Sqrt(hypotenuse - adjascent);
            return opposite;


        }
        public double Answer2()
        {
            double theta = 90;
            double radius = 2;
            double arcLength = theta * radius;
            return arcLength;

        }
        public double Answer3()
        {
            double CDB = 180 - 63;
            double otherAngles = 47 + CDB;
            double CBD = 180 - otherAngles;
            return CBD;
        }
        public double Answer4()
        {
            double numOfTriangles = 8;

            return numOfTriangles;
        }

        public double Answer5()
        {
            double oneAngle = 135;
            double allAngles = oneAngle * 8;
            return allAngles;
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var result = MessageBox.Show(@"Do you want to return to the Main Menu?", "Close Game", MessageBoxButton.YesNo);
            if (result == MessageBoxResult.Yes)
            {
                myMain = new MainWindow();
                geometry.Hide();
                myMain.Show();
            }

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

            btnOption1.Content = ans;
            int answer = Convert.ToInt32(btnOption1.Content); //gets actual answer from button

            if (answer == ans) //checks if answer from button is the calculated answer
            {
                MessageBox.Show("Correct!");
                txtQuestionSpace.Clear();
                timer.Stop();
                Siya.Clear();
               
            }
        }
       
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {

            btnOption2.Content = psuedoAnswer.Next(1, 10);
            int answer = Convert.ToInt32(btnOption2.Content); //gets actual answer from button

            if (answer != ans) //checks if answer from button is the calculated answer
            {
                MessageBox.Show("Incorrect!");
                Siya.Clear();
            }
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {

            btnOption3.Content = psuedoAnswer.Next(1, 10);
            int answer = Convert.ToInt32(btnOption3.Content); //gets actual answer from button

            if (answer != ans) //checks if answer from button is the calculated answer
            {
                MessageBox.Show("Incorrect!");
                Siya.Clear();
            }
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            QuestionNumbers = question.Next(6);
            string counter = "";
            string ans = "";
         
            ans = string.Format("Answer{0}", i);
            MethodInfo mi = this.GetType()

            for (int i = 0; i < 5; i++)
            {
                //counter = string.Format("Question{0}", i);
                //ans = string.Format("Answer{0}",i);
                //MethodInfo mi = this.GetType()

                //switch (QuestionNumbers)
                //{

                //    case 1:
                //        Question1();
                //        ans = Answer1();
                //        break;
                //    case 2:
                //        Question2();
                //        ans = Answer2(); break;
                //    case 3:
                //        Question3();
                //        ans = Answer3(); break;
                //    case 4:
                //        Question4();
                //        ans = Answer4(); break;
                //    case 5:
                //        Question5(); ans = Answer2(); break;

            }
            counter++;
            }

            
            //answers[1] = psuedoAnswer1;
            //answers[2] = psuedoAnswer2
        }
    }
}


