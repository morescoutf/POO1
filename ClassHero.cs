using System;

class Program
{
    static void Main(string[] args)
    {
        // Declaração das variáveis
        string nomeProduto = "camiseta";
        int quantidadeItens = 50;
        double precoUnitario = 100.00;
        bool produtoAtivo = true;

        // Exibindo as informações usando concatenação
        Console.WriteLine("Informações do Produto:");
        Console.WriteLine("Nome: " + nomeProduto);
        Console.WriteLine("Quantidade: " + quantidadeItens);
        Console.WriteLine("Preço Unitário: R$" + precoUnitario);
        Console.WriteLine("Ativo para venda: " + produtoAtivo);
    }
}