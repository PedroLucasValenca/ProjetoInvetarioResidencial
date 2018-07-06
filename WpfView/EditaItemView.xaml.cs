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
    /// Lógica interna para EditaItemView.xaml
    /// </summary>
    public partial class EditaItemView : Window
    {
        public EditaItemView(Item item)
        {
            InitializeComponent();

            EditaIDItemLabel.Text = item.ItemID.ToString();
            EditaNomeItemLabel.Text = item.NomeItem;
            EditaDescricaoLabel.Text = item.Descricao;
            EditaQuantidadeLabel.Text = item.Quantidade.ToString();

            LocaisController locaisController = new LocaisController();
            EditaLocalArmazenamentoLabel.ItemsSource = locaisController.ListarTodos();
            EditaLocalArmazenamentoLabel.SelectedValuePath = "LocalID";
            EditaLocalArmazenamentoLabel.SelectedValue = item.LocalID;

            TiposUsoController tiposUsoController = new TiposUsoController();
            EditaTipoUsoLabel.ItemsSource = tiposUsoController.ListarTodos();
            EditaTipoUsoLabel.SelectedValuePath = "TipoUsoID";
            EditaTipoUsoLabel.SelectedValue = item.TipoUsoID;
            


        }

        private void EditaButton_Click(object sender, RoutedEventArgs e)
        {
            ItensController itensController = new ItensController();

            Item item = new Item();

            item.ItemID = int.Parse(EditaIDItemLabel.Text);
            item.NomeItem = EditaNomeItemLabel.Text;
            item.Descricao = EditaDescricaoLabel.Text;
            item.LocalID = int.Parse(EditaLocalArmazenamentoLabel.SelectedValuePath);
            item.TipoUsoID = int.Parse(EditaIDItemLabel.SelectedText);

            itensController.Editar(item);

            MessageBox.Show("Item Alterado com Sucesso!!");
            this.Close();

           

        }

        private void ExcluirButton_Click(object sender, RoutedEventArgs e)
        {
            int ItemID = int.Parse(EditaIDItemLabel.Text);
                
            ItensController itensController = new ItensController();

            itensController.Excluir(ItemID);

            MessageBox.Show("Item Excluido com Sucesso!!");

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

        private void TipoUsoLabel_Loaded(object sender, RoutedEventArgs e)
        {
           // TiposUsoController tiposUsoController = new TiposUsoController();

          //  EditaTipoUsoLabel.ItemsSource = tiposUsoController.ListarTodos();
           
        }

        private void LocalArmazenamentoLabel_Loaded(object sender, RoutedEventArgs e)
        {
            //LocaisController locaisController = new LocaisController();

            //EditaLocalArmazenamentoLabel.ItemsSource = locaisController.ListarTodos();
        }
    }
}
