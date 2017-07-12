using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaixaEletronico
{
    class Cliente
    {
        public string nome;
        public string dataNascimento;
        public string cpf;
        public string rg;
        public string logradouro;
        public string uf;
        public string cidade;        
        public string bairro;
        public string nrLogradouro;
        

        public int maiorIdade()
        {
            return 18;
        }

        public bool EhMaiorDeIdade()
        {
            if (Int32.Parse(this.pegarIdade()) > this.maiorIdade()) {
                return true;
            } else {
                return false;
            }            
        }

        public string GetNome()
        {
            return this.nome;
        }

        public Cliente(string nome, string dataNascimento)
        {
            this.nome = nome;
            this.dataNascimento = dataNascimento;            
        }


        public string pegarIdade()
        {
            return this.FormataDataNasc(this.dataNascimento);
        }


        public string FormataDataNasc(string dataParaFormatar)
        {
            DateTime dataNascimento = DateTime.ParseExact(dataParaFormatar, "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture);
            //DateTime data = DateTime.ParseExact("2008 - 01 - 20 21:12:34", "yyyy - MM - dd HH: mm: ss", System.Globalization.CultureInfo.InvariantCulture);

            DateTime dataAtual = DateTime.Now;            
            TimeSpan ts = dataAtual.Subtract(dataNascimento);
            double horasTotais = Math.Floor(ts.TotalDays / 365);
            return horasTotais.ToString();
        }
    }
}
