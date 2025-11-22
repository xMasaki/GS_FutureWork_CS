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
    /// Lógica interna para AdminWindow.xaml
    /// </summary>
    public partial class AdminWindow : Window
    {
        public AdminWindow()
        {
            InitializeComponent();
        }

        private void Button_Adicionar(object sender, RoutedEventArgs e) 
        {
            string titulo = TxtCurso.Text;
            string professor = TxtProfessor.Text;
            string duracao = TxtDuracao.Text;

            var curso = new Curso
            {
                Titulo = titulo,
                Professor = professor,
                Duracao = duracao
            };

            Repositorio.Cursos.Add(curso);

            TxtCurso.Text = "";
            TxtProfessor.Text = "";
            TxtDuracao.Text = "";

        }

        private void Button_Sair(object sender, RoutedEventArgs e)
        {
            var main = new MainWindow();
            main.Show();
            this.Close();
        }



    }
}
