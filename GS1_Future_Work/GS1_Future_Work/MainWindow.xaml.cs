using System.Runtime.CompilerServices;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace GS1_Future_Work
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            /*
            if (ComboTipo != null && ComboTipo.Items.Count > 1)
                ComboTipo.SelectedIndex = 1;
            */
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Button_Entrar(object sender, RoutedEventArgs e)
        {
            string nome = TxtUsuario.Text;
            string senha = TxtSenha.Text;

            Usuario usuario = null;

            foreach (var i in Repositorio.Usuarios)
            {
                if (i.Nome != null && i.Nome.Equals(nome))
                {
                    usuario = i;
                    break;
                }
            }

            if (usuario.Senha != senha)
            {
                MessageBox.Show("Senha incorreta.");
                return;
            }

            if (usuario.Tipo == "Admin")
            {
                var admin = usuario as Admin;
                var window = new AdminWindow();
                window.Show();
                this.Close();
            } else
            {
                var colaborador = usuario as Colaborador;
                var window = new ColaboradowWindow();
                window.Show();
                this.Close();
            }
        }

        private void Button_Cadastrar(object sender, RoutedEventArgs e)
        {
            string nome = TxtUsuario.Text;
            string senha = TxtSenha.Text;
            string tipo = (ComboTipo.SelectedIndex == 0) ? "Admin" : "Colaborador";

            Usuario novo;
            if (tipo == "Admin")
                novo = new Admin();
            else
                novo = new Colaborador();

            novo.Nome = nome;
            novo.Senha = senha;
            novo.Tipo = tipo;

            Repositorio.Usuarios.Add(novo);

            TxtUsuario.Text = "";
            TxtSenha.Text = "";
        }
    }
}