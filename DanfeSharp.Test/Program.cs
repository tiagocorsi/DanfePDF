using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DanfePDF.Esquemas.NFe;
using DanfePDF.Modelo;
using DanfePDF;

namespace DanfePDF.Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var modelo = DanfeViewModelCreator.CriarDeArquivoXml(@"C:\Users\tiago\OneDrive\Área de Trabalho\NFe35231228950650000117550010000011021574310182.XML");

            using (var danfe = new Danfe(modelo))
            {
                danfe.Gerar();
                danfe.Salvar(@"C:\Users\tiago\OneDrive\Área de Trabalho\NFe35231228950650000117550010000011021574310182.PDF");
            }
        }
    }
}
