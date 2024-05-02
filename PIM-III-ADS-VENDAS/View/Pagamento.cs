using PIM_III_ADS_VENDAS.Controller;
using PIM_III_ADS_VENDAS.Model;

namespace PIM_III_ADS_VENDAS.View
{
    internal partial class Pagamento : Form
    {
        private PagamentoController pagamentoController;
        private VendasModel vendasModel;
        private VendasController vendasController; 
        private PessoaController pessoaController;
        private LoginCompra loginCompra;



        public Pagamento(VendasController vendasController, PessoaController pessoaController)
        {
            InitializeComponent();

            pagamentoController = new PagamentoController();
            this.vendasController = vendasController;
            this.pessoaController = pessoaController;

            loginCompra = new LoginCompra();
            vendasModel = new VendasModel(vendasController, pagamentoController, pessoaController);

            this.StartPosition = FormStartPosition.CenterScreen;
            pagamentoController.PtbQrCode = ptbQrCode;
        }

        private void BtnCredito_Click(object sender, EventArgs e)
        {
            pagamentoController.Credito = true;
            pagamentoController.Debito = false;
            pagamentoController.Pix = false;

            vendasModel.SalvarVenda();
            loginCompra.Show();
            this.Close();

        }

        private void BtnDebito_Click(object sender, EventArgs e)
        {
            pagamentoController.Credito = false;
            pagamentoController.Debito = true;
            pagamentoController.Pix = false;

            vendasModel.SalvarVenda();
            loginCompra.Show();
            this.Close();
        }

        private async void BtnPix_Click(object sender, EventArgs e)
        {
            pagamentoController.Credito = false;
            pagamentoController.Debito = false;
            pagamentoController.Pix = true;

            pagamentoController.GerarQrCoder();

            vendasModel.SalvarVenda();

            
            await Task.Delay(4000);
       
            loginCompra.Show();
            this.Close();
        }




        private void BtnCancelar_Click(object sender, EventArgs e)
        {
           
            loginCompra.Show();
            this.Close();
        }
    }
}
