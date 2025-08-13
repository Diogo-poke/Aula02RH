using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Aula02RH.Models.Enuns;

// Um comentario qualquer
namespace Aula02RH.Models
{
    public class Funcionario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public DateTime DataAdimissao { get; set; }
        public decimal Salario { get; set; }
        public TipoFuncionarioEnum TipoFuncionario { get; set; }

        public void ReajustarSalario()
        {
                Salario = Salario + (Salario * 10/100);
        }

        public string ExibirPeriodoExperiencia()
        {
            string periodoExperiencia = string.Format("Periodo de experiencia : {0} ate {1}",
            DataAdimissao,DataAdimissao.AddMonths(3));
             
             return periodoExperiencia;
        }
        
        public decimal CalculardescontaVT(decimal percentual)
        {
            decimal desconto = this.Salario * percentual/100;
            return desconto;
        }
    }
}