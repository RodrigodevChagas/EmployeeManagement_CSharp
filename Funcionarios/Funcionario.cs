using System;

namespace SashaBank.Funcionario
{
    public abstract class Funcionario
    {
        public Funcionario(string cpf, double salario)
        {
            CPF = cpf;
            Salario = salario;
            TotalDeFuncionarios++;
        }
        public static int TotalDeFuncionarios { get; private set; }
        public string Nome { get; set; }
        public string CPF { get; private set; }
        public double Salario { get; protected set; }

        static void ExibeDados(Funcionario funcionario)
        {
            Console.WriteLine("NOME: " + funcionario.Nome);
            Console.WriteLine("Salario inicial: " + funcionario.Salario);
            funcionario.AumentaSalario();
            Console.WriteLine("Salario com aumento: " + funcionario.Salario);
            Console.WriteLine("Bonificacao: " + funcionario.GetBonificacao());
            Console.WriteLine("Numero de funcionarios na empresa: " + Funcionario.TotalDeFuncionarios);
        }
        public abstract void AumentaSalario();

        public abstract double GetBonificacao();

    }
}
