using System;

namespace ArrayInstancias
{
    class Program
    {
        static void Main(string[] args)
        {
            int quarto;
            Estudante[] quartosDisponiveis = new Estudante[10];

            Console.WriteLine("Digite a quantidade de quartos a serem alugados");
            quarto = int.Parse(Console.ReadLine());

            for (int i = 0; i < quarto; i++)
            {
                Console.WriteLine("Digite o nome do estudante:");
                String nome = Console.ReadLine();
                Console.WriteLine("Digite o email do estudante:");
                String email = Console.ReadLine();
                Console.WriteLine("Digite o numero do quarto que o estudante deseja alugar:");
                int nQuarto = int.Parse(Console.ReadLine());
                quartosDisponiveis[nQuarto] = new Estudante{Nome = nome, Email = email};
            }

            Console.WriteLine("Os quartos alugados sâo:");
            for (int i = 0; i < quartosDisponiveis.Length; i++)
            {
                if (quartosDisponiveis[i] != null) 
                {
                    Console.WriteLine("Quarto: "+i
                        + quartosDisponiveis[i].ToString());

                }
            }  
        }
    }
}
