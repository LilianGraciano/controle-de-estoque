using System;

namespace Controle_de_estoque
{
    [System.Serializable]
    class ProdutoFisico : Produto, IEstoque
    {
        public float frete;
        private int estoque;

        public ProdutoFisico(string nome, float preco, float frete)
        {
            this.nome = nome;
            this.preco = preco;
            this.frete = frete;
        }
    

    public void AdicionarEntrada()
    {
        Console.WriteLine($"Adicionar entrada no estoque do produto: {nome}");
        Console.WriteLine("Digite a quantidade que deseja dar entrada:");
        int entrada = int.Parse(Console.ReadLine());
        estoque += entrada;
        Console.WriteLine("Entrada registrada");
        Console.ReadLine();
    }

        public void AdicionarSaida()
        {
            Console.WriteLine($"Adicionar sída no estoque do produto: {nome}");
            Console.WriteLine("Digite a quantidade que deseja dar baixa:");
            int entrada = int.Parse(Console.ReadLine());
            estoque -= entrada;
            Console.WriteLine("Saída registrada");
            Console.ReadLine();
        }

        public void Exibir()
        {
            Console.WriteLine($"Nome: {nome}");
            Console.WriteLine($"Frete: {frete}");
            Console.WriteLine($"Preço: {preco}");
            Console.WriteLine($"Estoque: {estoque}");
            Console.WriteLine("================");

        }
           
    }
    
}