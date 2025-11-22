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

namespace GS1_Future_Work
{
    /// <summary>
    /// Lógica interna para ColaboradowWindow.xaml
    /// </summary>
    public partial class ColaboradowWindow : Window
    {
        public ColaboradowWindow()
        {
            InitializeComponent();
            ListarCursos();
        }

        private void ListarCursos()
        {
            DataCursos.ItemsSource = null;
            DataCursos.ItemsSource = Repositorio.Cursos;
        }

        private void Button_Sair(object sender, RoutedEventArgs e)
        {
            var home = new MainWindow();
            home.Show();
            this.Close();
        }
    }
}
