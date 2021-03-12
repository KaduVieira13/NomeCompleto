using System;

namespace NomeCompleto
{
    class Program
    {
        static void Main(string[] args)
        {
         string nome;
         string sobrenome;
         string nomeCompleto;
         string nomeCatalogo;

         Console.WriteLine("------------------------------------------");
         Console.WriteLine("|Veja seu nome em diferentes perspectivas.|");
         Console.WriteLine("------------------------------------------");
         Console.WriteLine();
         Console.Write("Digite seu primeiro nome: ");
         nome = Console.ReadLine();
         
         Console.Write("Digite seu sobrenome: ");
         sobrenome = Console.ReadLine();
         Console.WriteLine();
         nomeCompleto = $"{nome} {sobrenome}";
         nomeCatalogo = $"{sobrenome.ToUpper()}, {nome}";
         Console.WriteLine($"Nome Completo: {nomeCompleto}");
         Console.WriteLine($"Nome Catálogo: {nomeCatalogo}");
        }
    }
}
