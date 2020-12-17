using ByteBank.Modelos;
using System;
using System.IO;
using System.Text;
using System.Text.Unicode;

namespace EntradasESaidas
{
    class Program
    {
        static void Main(string[] args)
        {
            //FileStreampuramente();

            //var arquivo = "Contas.txt";

            //using (var fluxoArquivo = new FileStream(arquivo, FileMode.Open))
            //using (var leitor = new StreamReader(fluxoArquivo)) //nao precisa de preocupação com o buffer.
            //{
            //    while (!leitor.EndOfStream)
            //    {
            //        var linha = leitor.ReadLine();
            //        var contaCorrente = ConverterStringParaContaCorrente(linha);
            //        Console.WriteLine($"Conta corrente Agencia: {contaCorrente.Agencia} Numero: {contaCorrente.Numero}. Saldo: {contaCorrente.Saldo}.");
            //    }
            //}

            //var criar = new CrriarArquivo();

            // criar.CriandoArquivo();
            //criar.CriandoArquivoComWriter();
            using (var fluxoDeEntrada = Console.OpenStandardInput())
            using (var fs = new  FileStream("EntradaConsole.txt", FileMode.Create))
            {
                var buffer = new byte[1024]; // 1 kb

                while (true)
                {
                    var bytesLidos = fluxoDeEntrada.Read(buffer, 0, 1024);
                    fs.Write(buffer, 0, bytesLidos);
                    fs.Flush();
                    Console.WriteLine($"Bytes lidos = {bytesLidos}");
                }

            }
                
            


        }
        static void EscreverBuffer(byte[] buffer)
        {
            foreach (var meuByte in buffer)
            {
                var encoding = Encoding.Default;
                var texto = encoding.GetString(buffer);

                Console.WriteLine(texto);
            }
         
        }
        static void FileStreampuramente()
        {
            var arquivo = "Contas.txt";

            using (var fluxoDoArquivo = new FileStream(arquivo, FileMode.Open))
            {
                var buffer = new byte[1024];

                fluxoDoArquivo.Read(buffer, 0, 1024);

                var quantidadeBytesLidos = -1;

                while (quantidadeBytesLidos != 0)
                {
                    quantidadeBytesLidos = fluxoDoArquivo.Read(buffer, 0, 1024);
                    EscreverBuffer(buffer);
                }
            }
        }
        static ContaCorrente ConverterStringParaContaCorrente(string linha)
        {
            var campos = linha.Split();

            var agencia = campos[0];
            var numero = campos[1];
            var saldo = campos[2].Replace('.', ',');
            var nomeTitular = campos[3];

            var agenciaInt = int.Parse(agencia);
            var numeroInt = int.Parse(numero);
            var saldoDouble = Double.Parse(saldo);

            var titular = new Cliente();
            titular.Nome = nomeTitular;

            var resultado = new ContaCorrente(agenciaInt, numeroInt);
            resultado.Depositar(saldoDouble);

            resultado.Titular = titular;

            return resultado;
        }
    }
}
