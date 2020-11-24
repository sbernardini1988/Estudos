using InterfaceHeranca.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InterfaceHeranca.Sistema;

namespace InterfaceHeranca
{
    class Program
    {
        static void Main(string[] args)
        {

            // CalcularBonificacao();

            UsarSistema();


            Console.ReadLine();

        }
        public static void UsarSistema()
        {
            SistemaInterno sistemaInterno = new SistemaInterno();

            Diretor Lucas = new Diretor("880.654.321.12");

            Lucas.Nome = "Lucas da Silva";
            Lucas.Senha = "1234";

            GerenteDeConta Roberto = new GerenteDeConta("223.454.675.44");
            Roberto.Nome = "Roberto de Jesus";
            Roberto.Senha = "abcd";

            sistemaInterno.Logar(Lucas, "acvb");

            ParceiroComercial parceiro = new ParceiroComercial();

            parceiro.Senha = "qqqq";

            sistemaInterno.Logar(parceiro, "qqqq"); 

        }
        public static void CalcularBonificacao()
        {

            GerenciadorBonificacao gerenciador = new GerenciadorBonificacao();
            Desenvolvedor Gabriela = new Desenvolvedor("332.456.765.90");

            Gabriela.Nome = "Gabriela Costa";

            Console.WriteLine("Funcionaria: " + Gabriela.Nome);
            Console.WriteLine("Documento: " + Gabriela.CPF);
            Console.WriteLine("Salario: " + Gabriela.Salario);

            Console.WriteLine("Bonificação Funcionario:" + Gabriela.GetBonificacao());

            Console.WriteLine("Total de Funcionarios: " + Funcionario.TotaldeFuncionarios);
            Gabriela.AumentarSalario();
            Console.WriteLine("aumento salario funcionario: " + Gabriela.Salario);

            gerenciador.Registrar(Gabriela);

            Diretor Lucas = new Diretor("880.654.321.12");

            Lucas.Nome = "Lucas da Silva";

            Console.WriteLine("Diretor: " + Lucas.Nome);
            Console.WriteLine("Documento: " + Lucas.CPF);
            Console.WriteLine("Salario: " + Lucas.Salario);

            Console.WriteLine("Bonificação Diretor:" + Lucas.GetBonificacao());

            Console.WriteLine("Total de Funcionarios: " + Funcionario.TotaldeFuncionarios);

            Lucas.AumentarSalario();
            Console.WriteLine("aumento salario funcionario: " + Lucas.Salario);

            gerenciador.Registrar(Lucas);

            Console.WriteLine("total bonificação: " + gerenciador.GetTotalBonificacao());

        }

    }
}
