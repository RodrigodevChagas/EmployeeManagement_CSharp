using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SashaBank.Funcionario
{
    class Program
    {
        static void Main(string[] args)
        {
            CalcularBonificacao();

            Console.ReadLine();
        }
        public static void CalcularBonificacao()
        {
            GerenciadorDeBonificacao gerenciador = new GerenciadorDeBonificacao();

            Funcionario carlos = new Auxiliar ("546.879.157-20");
            carlos.Nome = "Carlos";
            carlos.ExibeDados(carlos);

             


            Console.WriteLine();
            
            Funcionario rodrigo = new Designer ("043.054.971-20");
            rodrigo.Nome = "Rodrigo";
            rodrigo.ExibeDados(rodrigo);

            Console.WriteLine();

            Funcionario flavio = new GerenteDeConta ("034.504.791-50");
            flavio.Nome = "Flavio";
            flavio.ExibeDados(flavio);

            Console.WriteLine();

            Funcionario roberta = new Diretor("454.658.148-3");
            roberta.Nome = "Roberta";
            roberta.ExibeDados(roberta);

            gerenciador.Registrar(carlos);
            gerenciador.Registrar(flavio);
            gerenciador.Registrar(rodrigo);
            gerenciador.Registrar(roberta);

            Console.WriteLine();

            Console.WriteLine("Total de bonificações: " + gerenciador.GetTotalBonificacao());

        }
    }
}
