using System;
using System.Collections.Generic;
using System.Globalization;
using Exercicio_HerancaPolimorf.Entities;

namespace Exercicio_HerancaPolimorf
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Entre com numero de funcionários: ");
            int n = int.Parse(Console.ReadLine());

            List<Funcionario> lista = new List<Funcionario>();

            for(int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Dados do Funcionário #{i}: ");          //interpolação use $ no inicio.
                Console.Write("Funcionário é terceiro? (s/n) ");
                char terceiro = char.Parse(Console.ReadLine());
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Horas trabalhadas: ");
                int horas = int.Parse(Console.ReadLine());
                Console.Write("Valor por horas: ");
                double valorPorhoras = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                if(terceiro == 's')
                {
                    Console.Write("Despesa adicional: ");
                    double despesaAdd = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    lista.Add(new FuncionarioTerceirizado(nome, horas, valorPorhoras, despesaAdd));
                }
                else
                {
                    lista.Add(new Funcionario(nome, horas, valorPorhoras));
                }
            }

            Console.WriteLine();
            Console.WriteLine("Pagamentos: ");
            foreach(Funcionario func in lista)
            {
                Console.WriteLine(func.Nome + " - $ " + func.Pagamento().ToString("f2"), CultureInfo.InvariantCulture);
            }




        }
    }
}
