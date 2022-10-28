using BindingClases.Modelo;
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

namespace BindingClases
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
        public MainWindow()
        {
            InitializeComponent();
            Persona noname = new Persona();
            Persona javi = new Persona("Javier", 44);
            Persona ian = new Persona("Ian", 21);
            FormularioStackPanel.DataContext = noname;
        }

        private void CumpleañosButton_Click(object sender, RoutedEventArgs e)
        {
            ((Persona)FormularioStackPanel.DataContext).Edad++;
        }

        private void VerEdad_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(((Persona)FormularioStackPanel.DataContext).Edad.ToString());
        }
    }
}
