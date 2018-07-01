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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfView
{
    /// <summary>
    /// Interação lógica para MainWindow.xam
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void CadastrarButton_Click(object sender, RoutedEventArgs e)
        {
            ItensController itensController = new ItensController();

            Item item = new Item();

            item.NomeItem = NomeItemLabel.Text;
            item.Quantidade = int.Parse(QuantidadeLabel.Text);
            item.Descricao = DescricaoLabel.Text;

            if (DataArmazenamentoLabel.SelectedDate.HasValue)
            {
                item.DataArmazenamento = DataArmazenamentoLabel.SelectedDate.Value;

            }
            throw new NullReferenceException("O data não pode ser vazia!!");

            item.LocalID = ((Local)LocalArmazenamentoLabel.SelectedItem).LocalID;











        }

        private void LocalArmazenamentoLabel_Loaded(object sender, RoutedEventArgs e)
        {
            LocaisController locaisController = new LocaisController();

            Local local = new Local();

            LocalArmazenamentoLabel.ItemsSource = locaisController.ListarTodos();
        }
    }
}
