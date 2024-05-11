
using PIM_III_ADS_VENDAS.Controller;
using PIM_III_ADS_VENDAS.Model;
using WinFormsTimer = System.Windows.Forms.Timer;

namespace PIM_III_ADS_VENDAS.View
{
    public partial class LoginCompra : Form
    {
        private PessoaModel pessoaModel;
        private PessoaController pessoaController;
        private Teclado teclado;
        private WinFormsTimer timer;

        public LoginCompra()
        {
            InitializeComponent();
            pessoaModel = new PessoaModel();
            pessoaController = new PessoaController();
            this.WindowState = FormWindowState.Maximized;

            timer = new WinFormsTimer();
            timer.Interval = 600000; //aumentar tempo para 60
            timer.Tick += Timer_Tick;

            timer.Start();

        }

        private void TextBox1_Click(object sender, EventArgs e)
        {
            // Verifica se o teclado ainda não foi instanciado
            if (teclado == null)
            {
                // Cria uma nova instância do teclado
                teclado = new Teclado();
            }

            // Define a TextBox clicada como o TextBox de destino do teclado
            teclado.SetTargetTextBox(sender as TextBox);

            teclado.Show();
        }

        private void btnComprar_Click(object sender, EventArgs e)
        {
            pessoaController.Nome = txbNome.Text;
            pessoaController.Email = txbEmail.Text;

            pessoaModel.LoginCompra(pessoaController);

            if (pessoaModel.Mensagem.Equals(""))
            {
                Vendas vendas = new Vendas(pessoaController);
                vendas.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show(pessoaModel.Mensagem);
            }
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            this.Close();
            TelaMenu menu = new TelaMenu();
            menu.Show();
            timer.Stop();
        }

        private void btnCadastrarSe_Click(object sender, EventArgs e)
        {
            CadastroVisitante cadastroVisitante = new CadastroVisitante();
            cadastroVisitante.Show();
            this.Hide();
        }



    }
}
