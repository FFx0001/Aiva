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

namespace AivaBot.Views {
    /// <summary>
    /// Interaktionslogik für HomeViewModel.xaml
    /// </summary>
    public partial class Home : MahApps.Metro.Controls.MetroContentControl {
        public Home() {
            InitializeComponent();
            this.DataContext = new ViewModels.HomeViewModel();
        }
    }
}