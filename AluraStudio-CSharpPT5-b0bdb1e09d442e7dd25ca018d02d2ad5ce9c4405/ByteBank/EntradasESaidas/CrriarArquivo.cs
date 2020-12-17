using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace EntradasESaidas
{
    public class CrriarArquivo
    {
        public void CriandoArquivo()
        {
            var caminhoNovoArquivo = "ImportandoContaCorrente.csv";

            using (var fluxoDeArquivo = new FileStream(caminhoNovoArquivo , FileMode.Create))
            {
                var contaCorrenteLinha = "1234,22345,10.50,Sabrina Bernardini";
                var encoding = Encoding.UTF8;

                var bytes = encoding.GetBytes(contaCorrenteLinha);

                fluxoDeArquivo.Write(bytes, 0, bytes.Length);
            }

        }
        public void CriandoArquivoComWriter()
        {
            var caminhoNovoArquivo = "ImportandoContaCorrente2.csv";

            using (var fluxoDeArquivo = new FileStream(caminhoNovoArquivo, FileMode.Create))
            using (var escritor = new StreamWriter(fluxoDeArquivo))
            {
                escritor.Write("222,33454,45.75,Daniel Freire");
            }
        }

        public void EntradaConsole()
        {
            using (var fluxoDeEntrada = Console.OpenStandardInput())
            {
                var buffer = new byte[1024]; // 1 kb

                while (true)
                {
                    var bytesLidos = fluxoDeEntrada.Read(buffer, 0, 1024);
                    Console.WriteLine($"Bytes lidos = {bytesLidos}");
                }
            }
        }

    }
}
