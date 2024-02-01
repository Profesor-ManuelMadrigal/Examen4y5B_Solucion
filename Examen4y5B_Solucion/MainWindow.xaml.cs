﻿using Examen4y5B_Solucion;
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

namespace Examen4y5B_Solucion
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private MainWindowVM vm;
        public MainWindow()
        {
            InitializeComponent();

            vm = new MainWindowVM();

            this.DataContext = vm;
        }

        private void ButtonEliminar_Click(object sender, RoutedEventArgs e)
        {
            vm.Eliminar();
        }

        private void ButtonLimpiar_Click(object sender, RoutedEventArgs e)
        {
            vm.LimpiarSeleccion();
        }
    }
}
