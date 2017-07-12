using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaixaEletronico
{
    class ContaPoupanca : Conta
    {
        public ContaPoupanca(Cliente cliente) : base(cliente){}

        //Rendimento de 10%
        public override void Deposita(double valor)
        {
            if (valor > 0)
            {
                this.Saldo += valor * 1.10;
            }
        }
    }
}
