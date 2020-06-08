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
using System.Windows.Shapes;
using Mofeto.DesktopApplication.ViewModels;

namespace Mofeto.DesktopApplication.Views
{
    /// <summary>
    /// Interaktionslogik für AddBrandWindow.xaml
    /// </summary>
    public partial class AddBrandWindow : Window
    {
        public AddBrandWindow()
        {
            InitializeComponent();
            DataContext = new AddBrandViewModel();
        }
    }
}
