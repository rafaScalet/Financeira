using System;
using System.Globalization;
using System.Collections.Generic;

namespace Financeira1.Entidades
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Contrato> lista = new List<Contrato>();

            Console.WriteLine("----Financeira----");
            Console.WriteLine();

            Console.Write("Pessoa Física ou Jurídica ( F / J ): ");
            char escolha = char.Parse(Console.ReadLine());
            Console.Write("Número do Contrato: ");
            int numero = int.Parse(Console.ReadLine());
            Console.Write("Nome do Contratante: ");
            string nome = Console.ReadLine();
            Console.Write("Valor do Contrato: R$");
            double valor = double.Parse(Console.ReadLine());
            Console.Write("Prazo (em meses): ");
            int prazo = int.Parse(Console.ReadLine());

            if (escolha == 'F' || escolha == 'f')
            {
                Console.Write("CPF: ");
                string cpf = Console.ReadLine();
                Console.Write("Idade: ");
                int idade = int.Parse(Console.ReadLine());
                lista.Add(new ContratoPessoaFisica(numero, nome, valor, prazo, cpf, idade));
            }
            else if (escolha == 'J' || escolha == 'j')
            {
                Console.Write("CNPJ: ");
                string cnpj = Console.ReadLine();
                Console.Write("Inscrição Estadual: ");
                string inscricao = Console.ReadLine();
                lista.Add(new ContratoPessoaJurica(numero, nome, valor, prazo, cnpj, inscricao));
            }

            foreach (Contrato c in lista)
            {
                Console.WriteLine();
                Console.WriteLine("DADOS DO CONTRATO: ");
                Console.WriteLine();
                Console.WriteLine(c.ExibirInfo());
            }
        }
    }
}
