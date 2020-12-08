using System;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;

namespace Comida
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            ObservableCollection<Plato> lista = new ObservableCollection<Plato>(Plato.GetSamples(Environment.CurrentDirectory +"/Imagenes/"));
            PlatoListBox.ItemsSource = lista;
            TipoComboBox.ItemsSource = new string[] { "China", "Americana", "Mexicana" };
        }
    }
}
