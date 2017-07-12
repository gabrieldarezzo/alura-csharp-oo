using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaixaEletronico
{
    class ContaCorrente : Conta
    {
        public ContaCorrente(Cliente cliente) : base(cliente){ }

        public override void Deposita(double valor)
        {
            if (valor > 0)
            {
                this.Saldo += valor;
            }
        }
    }
}
