
using System;
using Aula02RH.Models;
using Aula02RH.Models.Enuns;


namespace Aula02RH
{
    public class Program
    {
        static void Main(string[] args)
        {
            
           /* Funcionario f = new Funcionario();
            f.Id = 10 ;
            f.Nome = "Neymar";
            f.Cpf = "12345678910";
            f.DataAdimissao = DateTime.Parse("01/01/2010");
            f.Salario = 100.000M;
            f.TipoFuncionario = TipoFuncionarioEnum.Aprendiz;

            string mensagem = f.ExibirPeriodoExperiencia();
            Console.WriteLine(mensagem)*/
            Funcionario func = new Funcionario();

         Console.WriteLine("Digite o Id do funcionario : ");
         func.Id = int.Parse(Console.ReadLine());

         Console.WriteLine("Digite o nome do funcionario:");
         func.Nome = Console.ReadLine();

          Console.WriteLine("Digite o Cpf:");
         func.Cpf = Console.ReadLine();

         Console.WriteLine("Digite a data de Admissão:");
         func.DataAdimissao = DateTime.Parse(Console.ReadLine());
         
        Console.WriteLine("Digite o Salario: ");
         func.Salario = decimal.Parse(Console.ReadLine());

         Console.WriteLine("Escolha o tipo de funcionario(1 - CLT/ 2 - Aprendiz): ");
         int opcao = int.Parse(Console.ReadLine());

         func.TipoFuncionario = (opcao == 1) ? TipoFuncionarioEnum.CLT : TipoFuncionarioEnum.Aprendiz;
         
         func.ReajustarSalario();
         decimal valorDescontoVT = func.CalculardescontaVT(6);

         Console.WriteLine("=====================");
         Console.WriteLine($"O salario reajusta do e {func.Salario}.\n");
         Console.WriteLine($"O Desconto do Vt e {valorDescontoVT}.\n");
        Console.WriteLine("========================");

        }
        
        
    }
}
