using AprendendoArray.Extensoes;
using ByteBank.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AprendendoArray
{
    class Program
    {
        static void Main(string[] args)
        {

            Ordenando();

            Console.ReadLine();

            static void Ordenando()
            {
                var conta = new List<ContaCorrente>
            {
                new ContaCorrente(223, 11111),
                new ContaCorrente(345, 34456),
                null,
                new ContaCorrente(999, 99876),
                new ContaCorrente(999, 12345)
            };


                //conta.Sort(new ComparadorContaCorrentePorAgencia());

                // var contasOrdenadas = conta.OrderBy(conta => conta.Numero);

                //IOrderedEnumerable<ContaCorrente> contasOrdenadas = conta.OrderBy(conta =>
                //{
                //    if (conta == null)
                //    {
                //        return int.MaxValue;
                //    }
                //    return conta.Numero;
                //});

                var contasOrdenadas = conta
                                      .Where(conta => conta != null)
                                      .OrderBy(conta => conta.Numero);

                foreach (var contas in contasOrdenadas)
                {
                    Console.WriteLine($"Conta Número: {contas.Numero}, ag: {contas.Agencia}");
                    
                }

            }
            
            static void MetodosExtensao()
            {
                List<int> idades = new List<int>();
                idades.AdicionarVarios<int>(1, 5, 14, 25, 38, 61);

                List<string> nomes = new List<string>();
                nomes.AdicionarVarios<string>("Adoniran", "Jimi Hendrix");

                //idades.AdicionarVarios(1, 5, 14, 25, 38, 61);
                //List<int> idades = new List<int>();

                //idades.Add(1);
                //idades.Add(5);
                //idades.Add(14);
                //idades.Add(25);
                //idades.Add(38);
                //idades.Add(61);

                //idades.Remove(5);

                //for (int i = 0; i < idades.Count; i++)
                //{
                //    Console.WriteLine(idades[i]);
                //}

            }

            static void TiposGenericos()
            {
                Lista<int> idades = new Lista<int>();

                idades.AdicionarVarios(63, 15, 21, 50);
                idades.Remover(15);

                Lista<string> cursos = new Lista<string>();
                cursos.AdicionarVarios("C# Parte 1", "C# Parte 2", "C# Parte 3");

                Lista<ContaCorrente> contas = new Lista<ContaCorrente>();
                contas.AdicionarVarios(new ContaCorrente(124, 54354), new ContaCorrente(201, 44354));

            }

            static void TestandoListaDeConta()
            {
                ListaDeContaCorrente lista = new ListaDeContaCorrente();

                //ContaCorrente[] contas = new ContaCorrente[]
                //    {
                //        new ContaCorrente(100, 40010),
                //        new ContaCorrente(101, 40011),
                //        new ContaCorrente(102, 40012),
                //        new ContaCorrente(103, 40013)
                //    };
                //lista.AdicionarVarios(contas);

                lista.AdicionarVarios(
                    new ContaCorrente(100, 40010),
                    new ContaCorrente(101, 40011),
                    new ContaCorrente(102, 40012),
                    new ContaCorrente(103, 40013)
                );
                //lista.Adicionar(new ContaCorrente(100, 40010));
                //lista.Adicionar(new ContaCorrente(101, 40011));
                //lista.Adicionar(new ContaCorrente(102, 40012));
                //lista.Adicionar(new ContaCorrente(103, 40013));

                //for (int i = 0; i < lista.Tamanho; i++)
                //{
                //    ContaCorrente conta = lista[i];
                //    Console.WriteLine($"{conta.Agencia}/{conta.Numero}");
                //}
                //AprendendoArrays();

            }

            static void AprendendoArrays()
                {

                int[] idades = new int[] { 15, 28, 35, 50, 28 };
                //int[] idades = new int[5];

                //idades[0] = 15;
                //idades[1] = 28;
                //idades[2] = 35;
                //idades[3] = 50;
                //idades[4] = 28;

                int acumulador = 0;
                for (int indice = 0; indice < idades.Length; indice++)
                {
                    acumulador += idades[indice];

                }

                int media = acumulador / idades.Length;

                Console.WriteLine(media);

                }

            static void TesteArrayContaCorrente()
            {
                ContaCorrente[] contas = new ContaCorrente[]
                {
                    new ContaCorrente(1234, 5545676),
                    new ContaCorrente(1234, 5545676),
                    new ContaCorrente(1234, 5545676)
                };

                for(int indice = 0; indice < contas.Length; indice++)
                {
                    ContaCorrente contaAtual = contas[indice];
                    Console.WriteLine($"Conta {indice} {contaAtual.Numero}");
                }
            }

        }
    }
}
