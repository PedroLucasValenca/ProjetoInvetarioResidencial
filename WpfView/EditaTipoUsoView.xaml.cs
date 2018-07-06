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
    /// Lógica interna para EditaTipoUsoView.xaml
    /// </summary>
    public partial class EditaTipoUsoView : Window
    {
        public EditaTipoUsoView(TipoUso tipoUso)
        {
            InitializeComponent();
            EditaIDTipoUsoLabel.Text = tipoUso.TipoUsoID.ToString();
            EditaNomeTipoUsoLabel.Text = tipoUso.NomeTipoUso;
            EditaDescricaoTipoUsoLabel.Text = tipoUso.Descricao;
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

        private void EditarTipoUsoButton_Click(object sender, RoutedEventArgs e)
        {
            TiposUsoController tipoUsoController = new TiposUsoController();

            TipoUso tipoUso = new TipoUso();

            tipoUso.TipoUsoID = int.Parse(EditaIDTipoUsoLabel.Text);
            tipoUso.NomeTipoUso = EditaNomeTipoUsoLabel.Text;
            tipoUso.Descricao = EditaDescricaoTipoUsoLabel.Text;

            tipoUsoController.Editar(tipoUso);

            MessageBox.Show("Tipo de Uso Alterado com Sucesso");
            this.Close();

           
        }

        private void ExcluirTipoUsoButton_Click(object sender, RoutedEventArgs e)
        {
            TipoUso tipoUso = new TipoUso();

            int TipoUsoID = int.Parse(EditaIDTipoUsoLabel.Text);

            TiposUsoController tiposUsoController = new TiposUsoController();

            tiposUsoController.Excluir(TipoUsoID);

            
             MessageBox.Show("Item Excluido com Sucesso!!");

             this.Close();

        }
    }
}
