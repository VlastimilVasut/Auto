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

namespace Auto
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Vehicle auto1 = new Vehicle();
            auto1.Brand = "Škoda";
            auto1.Type = "Osobní auto";

            Vehicle auto2 = new Vehicle();
            auto2.Brand = "VW";
            auto2.Type = "Dodávka";
    }
    }
}
