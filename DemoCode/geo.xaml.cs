﻿using System;
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
using DemoCode.Viewmodels;



namespace DemoCode
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

        public void Arithmetic_Clicked(object sender, RoutedEventArgs e)
        {
            DataContext = new Arithmetic.Arithmetic();
        }

        private void Geometry_Clicked(object sender, RoutedEventArgs e)
        {
            DataContext = new Geometry.Geometric();

        }

        private void Trigonometry_Clicked(object sender, RoutedEventArgs e)
        {
            DataContext = new Trigonometry.Trigonometry();
        }

        private void btnStart_Clicked(object sender, RoutedEventArgs e)
        {
           

        }
    }
}
    
    

