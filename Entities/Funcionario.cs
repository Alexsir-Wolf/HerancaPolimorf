using System;


namespace Exercicio_HerancaPolimorf.Entities
{
    class Funcionario
    {
        public string Nome { get; set; }
        public int Horas { get; set; }
        public double ValorPorHoras { get; set; }

        //CONSTRUTORES

        public Funcionario()
        {
        }

        public Funcionario(string nome, int horas, double valorPorHoras)
        {
            Nome = nome;
            Horas = horas;
            ValorPorHoras = valorPorHoras;
        }


        //  METODOS

        public virtual double Pagamento()
        {
            return Horas * ValorPorHoras;
        }
    }
}
