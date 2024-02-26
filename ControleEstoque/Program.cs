using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleEstoque
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcao = 50;
            int pos = 0;
            int qtd = 0;
            int itens = 0;
            string[,] livros = new string[3,6];
            while (opcao != 0){
                Console.WriteLine("Escolha uma opção do Menu:");
                Console.WriteLine("[1] Novo [4] Entrada Estoque \n [2] Listar Produtos[5] Saída Estoque \n [3] Remover Produtos[0] Saída");
                opcao = Int32.Parse(Console.ReadLine());
                switch (opcao) {
                    case 1:
                        Console.WriteLine("Informe o nome do brinquedo: ");
                        livros[itens, 0] = Console.ReadLine();
                        Console.WriteLine("Informe o preço: ");
                        livros[itens, 1] = Console.ReadLine();
                        Console.WriteLine("Informe o fabricante: ");
                        livros[itens, 2] = Console.ReadLine();
                        Console.WriteLine("Informe a idade indicada: ");
                        livros[itens, 3] = Console.ReadLine();
                        Console.WriteLine("Informe a categoria: ");
                        livros[itens, 4] = Console.ReadLine();
                        livros[itens, 5] = "0";
                        itens++;
                        Console.WriteLine("Brinquedo adicionado!");
                    break;
                    case 2:
                        for (int i = 0;i < itens; i++) {
                            if (livros[i,0] != null) {
                                Console.WriteLine(i+1 + ". " + livros[i, 0] + " - Estoque: " + livros[i, 5]);
                            }                            
                        }
                    break;
                    case 3:
                        Console.WriteLine("Digite a posição do brinquedo a ser removido: ");
                        Array.Clear(livros, Int32.Parse(Console.ReadLine()) - 1, 6);
                    break;
                    case 4:
                        Console.WriteLine("Informe a posição do Brinquedo: ");
                        pos = Int32.Parse(Console.ReadLine());
                        Console.WriteLine("Informe a quantidade de Entrada: ");
                        qtd = Int32.Parse(Console.ReadLine());
                        qtd = (Int32.Parse(livros[pos - 1, 5])) + qtd;
                        livros[pos - 1, 5] = qtd.ToString();
                        qtd = 0;
                        pos = 0;
                    break;
                    case 5:
                        Console.WriteLine("Informe a posição do Brinquedo: ");
                        pos = Int32.Parse(Console.ReadLine());
                        Console.WriteLine("Informe a quantidade de Saída: ");
                        qtd = Int32.Parse(Console.ReadLine());
                        qtd = Int32.Parse(livros[pos - 1, 5]) - qtd;
                        livros[pos - 1, 5] = qtd.ToString();
                        qtd = 0;
                        pos = 0;
                    break;


                }
            }
            
        }
    }
}
