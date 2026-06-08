using System;

class Program
{
    public class Funcionario
    {
        private string nome;
        private string matricula;
        private double salario;

        public virtual double CalcularSalario()
        {
            return salario;
        }
    
    public class clt: Funcionario
        {
            public double salariofixo { get; set;}

            public override double CalcularSalario()
            {
                return salario;
            }
        }
        public class vendedor : Funcionario
        {
            public double salariofixo { get; set; }
            public double comissãovendasporcentagem10 {get; set;}

            public override double CalcularSalario()
            {
                return salario + (comissãovendasporcentagem10 * 0.10);
            }
        }
        public class gerente : Funcionario
        {
            public double salariofixo { get; set;}
            public double bonuxfixo1500reais { get; set;}

            public override double CalcularSalario()
            {
                return salario + 1500;
            }
        }
        public double Salario
        {
            get
            {
                return salario;
            }
            set
            {
                if (value >= 0)
                {
                    salario = value;
                }
            }
        }
    }
}
