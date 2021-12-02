using System;

namespace Folha_de_pagamento
{
    class Program
    {
        static void Main(string[] args)
        {
            string strqtdfunc;
            string nome;
            string qtdhoras;
            string qtdvalor;
            string tercerizado;
            int qtdfunc;
            float valortotal;

            
            Console.WriteLine("Digite a quantidade de funcionarios desejados");
            strqtdfunc = Console.ReadLine();
            qtdfunc = int.Parse(strqtdfunc);

            string[] nomefuncionarios = new string[qtdfunc];
            string[] horafuncionarios = new string[qtdfunc];
            string[] valorfuncionarios = new string[qtdfunc];
            string[] tercerisadofuncionarios = new string[qtdfunc];
            
            for (int i = 0; i< qtdfunc; i++) 
            {
                Console.WriteLine("qual o nome do funcionario?");
                nome = Console.ReadLine();
                nomefuncionarios[i] = nome;


                Console.WriteLine("Quantas horas ele trabalhou?");
                qtdhoras = Console.ReadLine();
                horafuncionarios[i] = qtdhoras;

                Console.WriteLine("qual o valor da hora?");
                qtdvalor = Console.ReadLine();
                valorfuncionarios[i] = qtdvalor;

                Console.WriteLine("é tercerizado? (S/N)");
                tercerizado = Console.ReadLine();
                tercerisadofuncionarios[i] = tercerizado;

            }

            for (int i = 0; i < qtdfunc; i++) 
            {
                valortotal = 0;
                if (tercerisadofuncionarios[i] == "N")
                {
                    valortotal = float.Parse(valorfuncionarios[i]) * float.Parse(horafuncionarios[i]);
                }
                else if(tercerisadofuncionarios[i] == "S") 
                {
                    valortotal = float.Parse(valorfuncionarios[i]) * float.Parse(horafuncionarios[i]) * 1.1f;
                }

                Console.WriteLine("");
                Console.WriteLine("id do funcionario = "+i);
                Console.WriteLine("nome = "+nomefuncionarios[i]);
                Console.WriteLine("qtd horas trabalhadas = "+horafuncionarios[i]);
                Console.WriteLine("valor horas trabalhadas = "+valorfuncionarios[i]);
                Console.WriteLine("valor total das horas trabalhadas "+valortotal);
                Console.WriteLine("é tercerizado = "+tercerisadofuncionarios[i]);
            }
            Console.ReadKey();
        }
    }
}
