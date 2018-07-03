using Controllers;
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
    /// Lógica interna para TipoUsoListaView.xaml
    /// </summary>
    public partial class TipoUsoListaView : Window
    {
        public TipoUsoListaView()
        {
            InitializeComponent();
        }

        private void TipoUsoDataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            TiposUsoController tiposUsoController = new TiposUsoController();

            TipoUsoDataGrid.ItemsSource = tiposUsoController.ListarTodos();
        }
    }
}
