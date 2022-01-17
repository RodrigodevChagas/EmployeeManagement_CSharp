using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SashaBank.Funcionario
{
    public class Designer : Funcionario
    {
        public Designer(string cpf) : base(cpf, 3000) { }

        public override void AumentaSalario()
        {
            Salario *= 1.11;
        }

        public override double GetBonificacao()
        {
            return Salario * 0.17;
        }

    }
}
