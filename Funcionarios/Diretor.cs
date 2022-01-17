using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SashaBank.Funcionario
{
    public class Diretor : Funcionario
    {
        public Diretor(string cpf) : base(cpf, 5000) { 
        }
        public override void AumentaSalario()
        {
            Salario *= 1.2;
        }
        public override double GetBonificacao()
        // Override faz o método desse arquivo, sobrepor o método do arquivo do qual ele herdou.
        {
            return Salario * 0.5 ;
        }
    }
}
