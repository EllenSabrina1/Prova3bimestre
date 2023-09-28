using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova3bimestre
{
    internal class Medico: Funcionario
    {
        public string CRM {  get; set; }
        public string especialidade { get; set; }
        public double ValorHoraExtra {get; set; }

        public Medico(string CRM, string especialidade, double valorHoraExtra, string Nome, string CPF, int Matricula, int DataNascimento, string Sexo, double Salario) :base()
        {
            this.CRM = CRM;
            this.especialidade = especialidade;
            this.ValorHoraExtra = valorHoraExtra;
        }

        public override double TotalSalario(double beneficio)
        {
            double total = Salario + (Salario* 0.22);
            return total;

        }
    }
}
