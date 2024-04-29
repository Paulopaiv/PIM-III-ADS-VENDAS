using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIM_III_ADS_2P17_AVALIACAO.Controle
{
    internal class VendasControle
    {
		private bool inteiro;
		private bool meia;
		private bool isento;

        public VendasControle()
        {
        }

        public VendasControle(bool inteiro, bool meia, bool isento)
        {
            this.inteiro = inteiro;
            this.meia = meia;
            this.isento = isento;
        }

        public bool Isento
		{
			get { return isento; }
			set { isento = value; }
		}

		public bool Meia
		{
			get { return meia; }
			set { meia = value; }
		}

		public bool Inteiro
		{
			get { return inteiro; }
			set { inteiro = value; }
		}
	}
}
