using System;

namespace Controle_de_estoque
{
    [System.Serializable]
    internal class ebook: Produto, IEstoque
    {
        public string autor;
        private int vendas;

        public ebook(string nome, float preco, string autor)
        {
            this.nome = nome;
            this.preco = preco;
            this.autor = autor;
            
        }

        public void AdicionarEntrada()
        {
            Console.WriteLine(" Não é possível dar entrada no estoqueq de um E-book, pois é um produto digital.");
            Console.ReadLine();
           
        }

        public void AdicionarSaida()
        {
            {

                Console.WriteLine($"Adicionar vendas no curso:{nome}");
                Console.WriteLine("Digite a quantidade de vendas que deseja dar entrada:");
                int entrada = int.Parse(Console.ReadLine());
                vendas += entrada;
                Console.WriteLine("Saíde registradas.");
                Console.ReadLine();

            }
        }

        public void Exibir()
        {
            Console.WriteLine($"Nome: {nome}");
            Console.WriteLine($"autor: {autor}");
            Console.WriteLine($"Preço: {preco}");
            Console.WriteLine($"Vendas: {vendas}");
            Console.WriteLine("================");

        }
    }
}
