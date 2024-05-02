
using PIM_III_ADS_VENDAS.Controller;
using PIM_III_ADS_VENDAS.Modelo;


namespace PIM_III_ADS_VENDAS.View
{

    public partial class Vendas : Form
    {
        private VendasController vendasController;
        private Pagamento pagamento;
        private PessoaController pessoaController;
        private VendasModel vendasModel;
        private PagamentoController pagamentoController;




        public Vendas(PessoaController pessoaController)
        {
            InitializeComponent();

            vendasController = new VendasController();
            pagamentoController = new PagamentoController();
            this.pessoaController = pessoaController; // Recebe o objeto PessoaController
            this.WindowState = FormWindowState.Maximized;
            pagamento = new Pagamento(vendasController, pessoaController); // Passa o objeto PessoaController
            vendasModel = new VendasModel(vendasController, pagamentoController, pessoaController);

        }

        private void btnInteiro_Click(object sender, EventArgs e)
        {
            vendasController.Inteiro = true;
            vendasController.Meia = false;
            vendasController.Isento = false;
                          
            pagamento.ShowDialog(); 
            this.Close();
        }

        private void btnMeia_Click(object sender, EventArgs e)
        {
            vendasController.Inteiro = false;
            vendasController.Meia = true;
            vendasController.Isento = false;

            pagamento.ShowDialog(); 
            this.Close();
        }

        private void btnIsento_Click(object sender, EventArgs e)
        {
            // Verifica se a idade é maior que 70
            if (pessoaController.IdadeDb > 70)
            {
                // Se a idade for maior que 70, define o tipo de ingresso como isento
                vendasController.Inteiro = false;
                vendasController.Meia = false;
                vendasController.Isento = true;
                vendasModel.SalvarVenda();
            }
            else
            {
                // Se a idade não for maior que 70, mostra uma mensagem de erro
                MessageBox.Show("A opção 'Isento' está disponível apenas para pessoas com mais de 70 anos.");
            }

            this.Close();
        }
    }

    
}
