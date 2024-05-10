using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PIM_III_ADS_VENDAS.View
{
    public partial class TelaMenu : Form
    {
        public TelaMenu()
        {
            InitializeComponent();
        }

        private void btnCompra_Click(object sender, EventArgs e)
        {
            LoginCompra loginCompra = new LoginCompra();
            loginCompra.ShowDialog();
            this.Hide();
        }

        private void btnMapa_Click(object sender, EventArgs e)
        {
            Mapa mapa = new Mapa();
            mapa.ShowDialog();
            this.Hide();
        }
    }
}
