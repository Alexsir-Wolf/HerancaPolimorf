using System;


namespace Exercicio_HerancaPolimorf.Entities
{
    class FuncionarioTerceirizado : Funcionario
    {
        public double CustoAdicional { get; set; }


        //CONSTRUTOR
        public FuncionarioTerceirizado()
        {
        }

        public FuncionarioTerceirizado(string nome, int horas, double valorPorHoras, double custoAdicional)
            : base (nome, horas, valorPorHoras)
        {
            CustoAdicional = custoAdicional;
        }


        //METODOS

        public override double Pagamento()
        {
            return base.Pagamento() + 1.1 * CustoAdicional;     // 1.1 = 110%
        }

    }
}
