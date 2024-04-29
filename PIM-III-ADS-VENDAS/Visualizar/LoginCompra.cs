using PIM_III.View;
using PIM_III_ADS_2P17;
using PIM_III_ADS_2P17.Controle;
using PIM_III_ADS_2P17_AVALIACAO.Controle;

namespace PIM_III_ADS_2P17_AVALIACAO.Visualizar
{
    public partial class LoginCompra : Form
    {
       PessoaModel pessoaModel=new PessoaModel();
        public LoginCompra()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }

        PessoaControle pessoa = new PessoaControle();

        private void btnComprar_Click(object sender, EventArgs e)
        {
            pessoa.Nome = txbNome.Text;
            pessoa.Email = txbEmail.Text;

            pessoaModel.LoginCompra(pessoa);

            if (pessoaModel.Mensagem.Equals($"Olá, {pessoa.Nome}! Bem-vindo(a)!"))
            {
                Vendas vendas = new Vendas();
                vendas.Show();
                MessageBox.Show(pessoaModel.Mensagem);
            }
            else
            {
                MessageBox.Show(pessoaModel.Mensagem);
            }
        }

        private void btnCadastrarSe_Click(object sender, EventArgs e)
        {
            CadastroVisitante cadastroVisitante = new CadastroVisitante();
            cadastroVisitante.Show();
        }
    }
}
