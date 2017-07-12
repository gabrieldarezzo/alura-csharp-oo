using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CaixaEletronico
{
    public partial class CaixaEletronico : Form
    {
        public CaixaEletronico()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            Conta cp1 = new ContaPoupanca();
            Cliente jose = new Cliente("Jose", "06/10/1992");
            cp1.numero = 1;

            cp1.cliente = jose;
            cp1.Deposita(100);

            MessageBox.Show(cp1.Saldo.ToString());
            

            Conta cc1 = new ContaCorrente();
            Cliente ronaldo = new Cliente("Ronaldo", "08/04/1989");
            cc1.numero = 2;
            cc1.cliente = jose;
            cc1.Deposita(100);


            TotalizadorDeContas totalizador = new TotalizadorDeContas();
            totalizador.Adiciona(cp1);
            totalizador.Adiciona(cp1);


            MessageBox.Show(totalizador.Total.ToString());


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            /*
            Conta contaJose = new Conta();
            Cliente jose = new Cliente("Jose", "06/10/1992");
            contaJose.numero = 1;

            contaJose.cliente = jose;
            contaJose.Deposita(2000.0);
            

            textoTitular.Text = contaJose.GetTitular();
            */
        }
    }
}