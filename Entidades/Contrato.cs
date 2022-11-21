using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Financeira1.Entidades
{
    class Contrato
    {
        //ATRIBUTOS
        public int Numero { get; set; }
        public string Contratante { get; set; }
        public double Valor { get; set; }
        public int Prazo { get; set; }

        //CONSTRUTORES
        public Contrato()
        {
        }

        public Contrato(int numero, string contratante, double valor, int prazo)
        {
            this.Numero = numero;
            this.Contratante = contratante;
            this.Valor = valor;
            this.Prazo = prazo;
        }

        //MÉTODOS
        public virtual double CalcularPrestacao()
        {
            return  this.Valor / this.Prazo;
        }

        public virtual string ExibirInfo()
        {
            return "";
        }
    }
}
