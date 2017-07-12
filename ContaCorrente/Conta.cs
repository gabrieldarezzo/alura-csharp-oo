using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaixaEletronico
{
    class Conta
    {
        public int numero;
        public double Saldo { get; protected set; }
        public Cliente cliente;


        public Conta(Cliente cliente)
        {
            this.cliente = cliente;
        }

        private void SetSaldo(double value)
        {
            Saldo = value;
        }

        

        public void Saca(double valor)
        {
            this.SetSaldo(this.Saldo - valor);
        }

        public string GetTitular()
        {
            return this.cliente.GetNome();
        }        

        public virtual void Deposita(double valor){}

        public void Transferencia(double valor, Conta destino)
        {
            this.Saca(valor);
            destino.Deposita(valor);
        }



    }
}
