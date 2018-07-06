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
    /// Lógica interna para EditarLocacaoView.xaml
    /// </summary>
    public partial class EditarLocacaoView : Window
    {
        public EditarLocacaoView()
        {
            InitializeComponent();
        }
    
        public EditarLocacaoView(Local local)
        {
            InitializeComponent();

            EditaIDLocacaoLabel.Text = local.LocalID.ToString();
            EditaNomeLocalLabel.Text = local.NomeLocal;
            EditaDescricaoLocalLabel.Text = local.Descricao;

        }

        private void EditaLocacaoButton_Click(object sender, RoutedEventArgs e)
        {
            LocaisController locaisController = new LocaisController();

            Local local = new Local();
            local.LocalID = int.Parse(EditaIDLocacaoLabel.Text);
            local.NomeLocal = EditaNomeLocalLabel.Text;
            local.Descricao = EditaDescricaoLocalLabel.Text;

            locaisController.Editar(local);

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

        private void CriarItemButton_Click(object sender, RoutedEventArgs e)
        {
            ItemView itemView = new ItemView();

            itemView.ShowDialog();
        }

        private void ListarItemButton_Click(object sender, RoutedEventArgs e)
        {
            ItensListaView itensListaView = new ItensListaView();

            itensListaView.ShowDialog();
        }

        private void ExcluirLocacaoButton_Click(object sender, RoutedEventArgs e)
        {
            Local local = new Local();
            local.LocalID = int.Parse(EditaIDLocacaoLabel.Text);

            LocaisController locaisController = new LocaisController();

            locaisController.Excluir(local.LocalID);

            this.Close();

        }
    }
}
