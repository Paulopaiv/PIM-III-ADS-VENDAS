

using PIM_III_ADS_VENDAS.Controller;
using PIM_III_ADS_VENDAS.Model;

namespace PIM_III_ADS_VENDAS.View
{
    public partial class LoginCompra : Form
    {
        private PessoaModel pessoaModel;
        private PessoaController pessoaController;


        public LoginCompra()
        {
            InitializeComponent();
            pessoaModel = new PessoaModel();
            pessoaController = new PessoaController();
            this.WindowState = FormWindowState.Maximized;
        }


        private void btnComprar_Click(object sender, EventArgs e)
        {
            pessoaController.Nome = txbNome.Text;
            pessoaController.Email = txbEmail.Text;

            pessoaModel.LoginCompra(pessoaController);

            if (pessoaModel.Mensagem.Equals($"Olá, {pessoaController.Nome}! Bem-vindo(a)!"))
            {
                Vendas vendas = new Vendas(pessoaController);
                vendas.ShowDialog(); 
                this.Hide();
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
            cadastroVisitante.ShowDialog(); 
            this.Hide();
        }
    }
}
