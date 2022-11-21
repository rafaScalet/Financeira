using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Financeira1.Entidades
{
    class ContratoPessoaJurica : Contrato
    {
        //ATRIBUTOS
        public string CNPJ { get; set; }
        public string Inscricao { get; set; }

        //CONSTRUTORES
        public ContratoPessoaJurica()
        {
        }

        public ContratoPessoaJurica(int numero, string contratante, double valor, int prazo, string cNPJ, string inscricao) : base (numero, contratante, valor, prazo)
        {
            this.CNPJ = cNPJ;
            this.Inscricao = inscricao;
        }

        //MÉTODOS
        public override double CalcularPrestacao()
        {
            return (this.Valor / this.Prazo) + 3;
        }

        public override string ExibirInfo()
        {
            return ($"Valor do Contrato: R${(Valor).ToString("f2")} \n" +
                $"Prazo: {Prazo} meses \n" +
                $"Valor da Prestação: R${(CalcularPrestacao()).ToString("f2")}");
        }
    }
}
