using PIM_III_ADS_2P17.Controle;
using PIM_III_ADS_2P17_AVALIACAO.Controle;
using PIM_III_ADS_2P17_AVALIACAO.Visualizar;

namespace PIM_III.View
{
    public partial class CadastroVisitante : Form
    {
        private PessoaModel pessoaModel;
        private PessoaControle pessoa;
        public CadastroVisitante()
        {
            InitializeComponent();
            this.pessoaModel = new PessoaModel();
            this.pessoa = new PessoaControle();
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
            pessoa = new PessoaControle(
                nome: txbNome.Text,
                idade: txbIdade.Text,
                email: txbEmail.Text,
                cep: txbCep.Text,
                codigo:"");

            pessoaModel.SalvaPessoa(pessoa);

            if (pessoaModel.Mensagem.Equals("Cadastro realizado com sucesso."))
            {
                LimparCampos();
                MessageBox.Show(pessoaModel.Mensagem);
                Vendas vendas = new Vendas();
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
