﻿using Controllers;
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
    public partial class ItemView : Window
    {
        public ItemView()
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
            else
            {
                throw new NullReferenceException("O data não pode ser vazia!!");
            }
            

            item.LocalID = ((Local)LocalArmazenamentoLabel.SelectedItem).LocalID;

            item.TipoUsoID = ((TipoUso)TipoUsoLabel.SelectedItem).TipoUsoID;

            itensController.Adicionar(item);

            MessageBox.Show("Item adicionado com sucesso");
            





        }

        private void LocalArmazenamentoLabel_Loaded(object sender, RoutedEventArgs e)
        {
            LocaisController locaisController = new LocaisController();

            Local local = new Local();

            LocalArmazenamentoLabel.ItemsSource = locaisController.ListarTodos();
        }

 


        private void CriarLocacaoButton_Click(object sender, RoutedEventArgs e)
        {
            LocacaoView locacaoView = new LocacaoView();

            locacaoView.ShowDialog();
        }

        private void ListarItemButton_Click(object sender, RoutedEventArgs e)
        {
            ItensListaView itensListaView = new ItensListaView();

            itensListaView.ShowDialog();
        }

        private void CriarItemButton_Click(object sender, RoutedEventArgs e)
        {
            ItemView itemView = new ItemView();

            itemView.ShowDialog();
        }

        private void ListarLocacaoButton_Click(object sender, RoutedEventArgs e)
        {
            ListarLocacaoView locacaoView = new ListarLocacaoView();

            locacaoView.ShowDialog();
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
            TiposUsoController tiposUsoController = new TiposUsoController();

            TipoUsoLabel.ItemsSource = tiposUsoController.ListarTodos();
        }
    }
}
