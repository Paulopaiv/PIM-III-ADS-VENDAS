


using PIM_III_ADS_VENDAS.Controller;
using PIM_III_ADS_VENDAS.Model;

namespace PIM_III_ADS_VENDAS.View
{
    public partial class CadastroVisitante : Form
    {
        private PessoaModel pessoaModel;
        private PessoaController pessoaController;
        public CadastroVisitante()
        {
            InitializeComponent();
            this.pessoaModel = new PessoaModel();
            this.pessoaController = new PessoaController();
            this.WindowState = FormWindowState.Maximized;
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            LoginCompra loginCompra = new LoginCompra();
            loginCompra.Show();
            this.Close();
        }

        private void btnComprar_Click(object sender, EventArgs e)
        {
            pessoaController = new PessoaController(
                nome: txbNome.Text,
                idade: txbIdade.Text,
                email: txbEmail.Text,
                cep: txbCep.Text,
                codigo:"");

            pessoaModel.SalvaPessoa(pessoaController);

            if (pessoaModel.Mensagem.Equals("Cadastro realizado com sucesso."))
            {
                LimparCampos();
                MessageBox.Show(pessoaModel.Mensagem);
                Vendas vendas = new Vendas(pessoaController);
                vendas.Show();
            }
            else
            {
                MessageBox.Show(pessoaModel.Mensagem);
            }
            LimparCampos();
        }

        private void LimparCampos()
        {
            txbCep.Text = string.Empty;
            txbEmail.Text = string.Empty;
            txbIdade.Text = string.Empty;
            txbNome.Text = string.Empty;
        }
    }
}
