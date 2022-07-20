using System;

namespace Pensionato_Ex_Vetor
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("---PENSIONATO---\n\n");

            Console.WriteLine("Digite a quantidade de estudantes: ");
            int quant = int.Parse(Console.ReadLine());

            Quarto[] q1 = new Quarto[quant];

            //Recebe os dados e faz a reserva de todos os quartos
            for (int i = 0; i < quant; i++)
            {
                Console.WriteLine("Digite o quarto a reservar: ");
                int quarto = int.Parse(Console.ReadLine());


                    // Testa se o quarto ja está reservado
                    while (q1[quarto] != null)
                    {

                        Console.WriteLine("JÁ RESERVADO - Digite o quarto a reservar: ");
                        quarto = int.Parse(Console.ReadLine());

                  }

                Console.WriteLine("Digite o nome do aluno: ");
                string nome = Console.ReadLine();
                Console.WriteLine("Digite o email do aluno: ");
                string email = Console.ReadLine();

                // Caso o quarto esteja vago, cria o objeto dentro do vetor e atribui dados aos seus atributos
                q1[quarto] = new Quarto
                {
                    Nome = nome,
                    Email = email,
                    Unidade = quarto

                };

            }
            Console.WriteLine("----------------------");


            //Exibe os quartos ocupados

            for (int i = 0; i < quant; i++)
            {
                Console.WriteLine("Quarto " + q1[i].Unidade);
                Console.WriteLine("----------------------");
                Console.WriteLine(q1[i].Nome + "\n");
                Console.WriteLine(q1[i].Email + "\n");
                Console.WriteLine("----------------------");

            }

        }
    }
}

