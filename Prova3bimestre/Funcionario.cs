using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova3bimestre
{
    internal class Funcionario
    {
        public string Nome {  get; set; }
        public string CPF { get; set; }
        public int Matricula { get; set; }
        public int DataNascimento { get; set; }
        public string Sexo { get; set; }
        public double Salario { get; set; }

        public Funcionario()
        { }
        public Funcionario(string Nome, string CPF, int Matricula, int DataNascimento,string Sexo, double Salario)
        {
            this.Nome = Nome;
            this.CPF = CPF;
            this.Matricula = Matricula;
            this.DataNascimento = DataNascimento;
            this.Sexo = Sexo;
            this.Salario = Salario;
        }

        public virtual double TotalSalario(double beneficio)
        {
            double total = Salario + beneficio;
            return total;

        }
    }
}
