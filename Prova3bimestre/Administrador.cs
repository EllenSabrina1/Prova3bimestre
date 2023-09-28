using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova3bimestre
{
    internal class Administrador: Funcionario
    {
        public string funcao {  get; set; }

        public Administrador(string funcao)
        {
            this.funcao = funcao;
        }

        public override double TotalSalario(double beneficio)
        {
            double total = Salario + 0.17;
            return total;

        }
    }
}
