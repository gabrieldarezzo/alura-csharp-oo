using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaixaEletronico
{
    class ContaCorrente : Conta
    {
        public override void Deposita(double valor)
        {
            if (valor > 0)
            {
                this.Saldo += valor;
            }
        }
    }
}
