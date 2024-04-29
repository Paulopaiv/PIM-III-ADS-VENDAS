
using PIM_III_ADS_2P17_AVALIACAO.Controle;


namespace PIM_III.View 
{
    
    public partial class Vendas : Form
    {
        private VendasControle controle;
     
        public Vendas()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            this.controle = new VendasControle();
        }     

        private void btnInteiro_Click(object sender, EventArgs e)
        {
            controle.Inteiro = true;
            Pagamento pagamento = new Pagamento();
            pagamento.ShowDialog();            
            //SalvarInformacoes();
        }


        private void btnMeia_Click(object sender, EventArgs e)
        {
            controle.Meia = true;
            Pagamento pagamento = new Pagamento();
            pagamento.ShowDialog();
            //SalvarInformacoes();
        }

        private void btnIsento_Click(object sender, EventArgs e)
        {
            controle.Isento = true;
            Pagamento pagamento = new Pagamento();
            pagamento.ShowDialog();
            //SalvarInformacoes();
        }

    
    }
}
