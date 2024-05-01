﻿
using PIM_III_ADS_VENDAS.Controller;
using PIM_III_ADS_VENDAS.Service;
using PIM_III_ADS_VENDAS.View;

namespace PIM_III_ADS_VENDAS.Modelo
{
    internal class VendasModel
    {
        private VendasService vendasService = new VendasService();
        private PagamentoController pagamentoController;
        private VendasController vendasController;
        private PessoaController pessoaController;

        public VendasModel(VendasController vendasController, PagamentoController pagamentoController, PessoaController pessoaController)
        {
            this.vendasController = vendasController;
            this.pagamentoController = pagamentoController;
            this.pessoaController = pessoaController;
        }

        public void SalvarVenda()
        {
            string pagamentoAtual = pagamentoController.FormaDePagamento();
            string vendaAtual = vendasController.TipoDeIngresso();
            string codigoUsuario = pessoaController.Codigo;

            vendasService.RegistrarVenda(pagamentoAtual, codigoUsuario, vendaAtual);
        }
    }

}