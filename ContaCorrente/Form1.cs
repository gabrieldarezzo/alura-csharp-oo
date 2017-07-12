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

        Conta[] contas = new Conta[2];
       

        public CaixaEletronico()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            

            /*
            //for (int i = 0; i < contas.Length; i++) {
            foreach (Conta conta in contas)
            {
                MessageBox.Show("O saldo da conta é: " + conta.Saldo);
            }
            */

            /*
            Conta cp1 = new ContaPoupanca();
            Cliente jose = new Cliente("Jose", "06/10/1992");
            cp1.numero = 1;

            cp1.cliente = jose;
            cp1.Deposita(100);           
            

            Conta cc1 = new ContaCorrente();
            Cliente ronaldo = new Cliente("Ronaldo", "08/04/1989");
            cc1.numero = 2;
            cc1.cliente = jose;
            cc1.Deposita(100);


            TotalizadorDeContas totalizador = new TotalizadorDeContas();
            totalizador.Adiciona(cp1);
            totalizador.Adiciona(cp1);


            MessageBox.Show(totalizador.Total.ToString());
            */

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            contas[0] = new ContaPoupanca(new Cliente("Jose", "08/04/1989"));            
            contas[0].numero = 2;            
            contas[0].Deposita(300);


            contas[1] = new ContaCorrente(new Cliente("Gabriel", "06/10/1992"));            
            contas[1].numero = 2;            
            contas[1].Deposita(500);


            for (int i = 0; i < contas.Length; i++) {
                comboContas.Items.Add(contas[i].cliente.nome);
            }
               
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboContas_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indexSelecionado = comboContas.SelectedIndex;

            Conta contaSelecionada = contas[indexSelecionado];

            textoTitular.Text = contaSelecionada.GetTitular();
            textoSaldo.Text = contaSelecionada.Saldo.ToString();


        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}