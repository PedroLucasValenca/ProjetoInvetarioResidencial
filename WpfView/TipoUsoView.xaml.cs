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

            tipoUsoController.Adicionar(tipoUso);
            MessageBox.Show("Tipo de Uso adicionado com sucesso");
            this.Close();

        }

        private void ListarItemButton_Click(object sender, RoutedEventArgs e)
        {
            ItensListaView itensListaView = new ItensListaView();

            itensListaView.ShowDialog();
        }

        private void CriarLocacaoButton_Click(object sender, RoutedEventArgs e)
        {
            LocacaoView locacaoView = new LocacaoView();

            locacaoView.ShowDialog();
        }

        private void ListarLocacaoButton_Click(object sender, RoutedEventArgs e)
        {
            ListarLocacaoView listarLocacaoView = new ListarLocacaoView();

            listarLocacaoView.ShowDialog();
        }

        private void CriarItemButton_Click(object sender, RoutedEventArgs e)
        {
            ItemView itemView = new ItemView();

            itemView.ShowDialog();
        }


        private void CriarTipoUsoButton_Click(object sender, RoutedEventArgs e)
        {
            TipoUsoView tipoUsoView = new TipoUsoView();

            tipoUsoView.ShowDialog();
        }

        private void ListarTipoUsoButton_Click(object sender, RoutedEventArgs e)
        {
            TipoUsoListaView tipoUsoListaView = new TipoUsoListaView();

            tipoUsoListaView.ShowDialog();
        }

        private void CancelarTipoUsoButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
