using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIM_III_ADS_VENDAS.Controller
{
    internal class VendasController
    {
        private bool inteiro;
        private bool meia;
        private bool isento;

        public VendasController()
        {
        }

        public VendasController(bool inteiro, bool meia, bool isento)
        {
            this.inteiro = inteiro;
            this.meia = meia;
            this.isento = isento;

        }

        public string TipoDeIngresso()
        {
            if (Inteiro)
            {
                return "Inteiro";
            }
            else if (Meia)
            {
                return "Meia";
            }
            else
            {
                return "Isento";
            }
        }

        public bool Isento
        {
            get
            {
                return isento;
            }
            set
            {
                isento = value;
            }
        }

        public bool Meia
        {
            get
            {
                return meia;
            }
            set
            {
                meia = value;
            }
        }

        public bool Inteiro
        {
            get
            {
                return inteiro;
            }
            set
            {
                inteiro = value;
            }
        }
    }
}
