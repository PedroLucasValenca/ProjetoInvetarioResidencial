using Controllers;
using Modelo;
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

namespace WpfView
{
    /// <summary>
    /// Lógica interna para TipoUsoView.xaml
    /// </summary>
    public partial class TipoUsoView : Window
    {
        public TipoUsoView()
        {
            InitializeComponent();
        }

        private void CadastrarTipoUsoButton_Click(object sender, RoutedEventArgs e)
        {
            TiposUsoController tipoUsoController = new TiposUsoController();

            TipoUso tipoUso = new TipoUso();

            tipoUso.NomeTipoUso = NomeTipoUsoLabel.Text;
            tipoUso.Descricao = NomeTipoUsoLabel.Text;

        }
    }
}
