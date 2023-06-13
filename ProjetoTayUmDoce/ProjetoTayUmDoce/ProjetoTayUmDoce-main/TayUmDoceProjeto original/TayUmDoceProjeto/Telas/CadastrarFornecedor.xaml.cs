﻿using System;
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
using TayUmDoceProjeto.Telas;

namespace TayUmDoceProjeto.Telas
{
    /// <summary>
    /// Lógica interna para CadastrarFornecedor.xaml
    /// </summary>
    public partial class CadastrarFornecedor : Window
    {
        public CadastrarFornecedor()
        {
            
        }
        private void btDoce_Click(object sender, RoutedEventArgs e)
        {
            CadastrarDoce form = new CadastrarDoce();
            form.ShowDialog();
        }

        private void btCliente_Click(object sender, RoutedEventArgs e)
        {
            CadastrarCliente form = new CadastrarCliente();
            form.ShowDialog();
        }

        private void btVenda_Click(object sender, RoutedEventArgs e)
        {
            CadastrarVenda form = new CadastrarVenda();
            form.ShowDialog();
        }

        private void btFuncionario_Click(object sender, RoutedEventArgs e)
        {
            CadastrarFuncionario form = new CadastrarFuncionario();
            form.ShowDialog();
        }
        private void btEntrega_Click(object sender, RoutedEventArgs e)
        {
            CadastrarEntrega form = new CadastrarEntrega();
            form.ShowDialog();
        }

    }
}
