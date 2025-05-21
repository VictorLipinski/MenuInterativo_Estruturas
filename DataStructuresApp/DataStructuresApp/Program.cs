using System;
using DataStructures;
using Algorithms;
using System.Collections.Generic;

namespace DataStructuresApp
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Escolha uma opção:");
                Console.WriteLine("1. Vetores");
                Console.WriteLine("2. Matrizes");
                Console.WriteLine("3. Listas");
                Console.WriteLine("4. Filas");
                Console.WriteLine("5. Pilhas");
                Console.WriteLine("6. Algoritmos de Pesquisa");
                Console.WriteLine("0. Sair");

                int opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        GerenciarVetor();
                        break;
                    case 2:
                        GerenciarMatriz();
                        break;
                    case 3:
                        GerenciarLista();
                        break;
                    case 4:
                        GerenciarFila();
                        break;
                    case 5:
                        GerenciarPilha();
                        break;
                    case 6:
                        GerenciarPesquisa();
                        break;
                    case 0:
                        Console.WriteLine("Encerrando...");
                        return;
                    default:
                        Console.WriteLine("Opção inválida!");
                        break;
                }
            }
        }

        private static void GerenciarVetor()
        {
            var vetor = new Vetor(5);
            int opcao;
            do
            {
                Console.Clear();
                Console.WriteLine("Operações no Vetor:");
                Console.WriteLine("1. Inserir Elemento");
                Console.WriteLine("2. Remover Elemento");
                Console.WriteLine("3. Exibir Elementos");
                Console.WriteLine("4. Consultar Elemento");
                Console.WriteLine("0. Voltar");
                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        Console.Write("Digite o elemento a ser inserido: ");
                        int elem = int.Parse(Console.ReadLine());
                        vetor.InserirElemento(elem);
                        break;
                    case 2:
                        vetor.RemoverElemento();
                        break;
                    case 3:
                        vetor.ExibirElementos();
                        break;
                    case 4:
                        Console.Write("Digite o elemento a ser consultado: ");
                        int consulta = int.Parse(Console.ReadLine());
                        vetor.ConsultarElemento(consulta);
                        break;
                    case 0:
                        break;
                    default:
                        Console.WriteLine("Opção inválida!");
                        break;
                }
                Console.WriteLine("Pressione qualquer tecla para continuar...");
                Console.ReadKey();
            } while (opcao != 0);
        }

        private static void GerenciarMatriz()
        {
            var matriz = new Matriz(3, 3);
            int opcao;
            do
            {
                Console.Clear();
                Console.WriteLine("Operações na Matriz:");
                Console.WriteLine("1. Inserir Elemento");
                Console.WriteLine("2. Exibir Elementos");
                Console.WriteLine("3. Consultar Elemento");
                Console.WriteLine("0. Voltar");
                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        Console.Write("Digite a linha do elemento: ");
                        int linha = int.Parse(Console.ReadLine());
                        Console.Write("Digite a coluna do elemento: ");
                        int coluna = int.Parse(Console.ReadLine());
                        Console.Write("Digite o elemento a ser inserido: ");
                        int elemento = int.Parse(Console.ReadLine());
                        matriz.InserirElemento(linha, coluna, elemento);
                        break;
                    case 2:
                        matriz.ExibirElementos();
                        break;
                    case 3:
                        Console.Write("Digite a linha do elemento: ");
                        int linhaConsulta = int.Parse(Console.ReadLine());
                        Console.Write("Digite a coluna do elemento: ");
                        int colunaConsulta = int.Parse(Console.ReadLine());
                        matriz.ConsultarElemento(linhaConsulta, colunaConsulta);
                        break;
                    case 0:
                        break;
                    default:
                        Console.WriteLine("Opção inválida!");
                        break;
                }
                Console.WriteLine("Pressione qualquer tecla para continuar...");
                Console.ReadKey();
            } while (opcao != 0);
        }

        private static void GerenciarLista()
        {
            var lista = new Lista();
            int opcao;
            do
            {
                Console.Clear();
                Console.WriteLine("Operações na Lista:");
                Console.WriteLine("1. Inserir Elemento");
                Console.WriteLine("2. Remover Elemento");
                Console.WriteLine("3. Exibir Elementos");
                Console.WriteLine("4. Consultar Elemento");
                Console.WriteLine("0. Voltar");
                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        Console.Write("Digite o elemento a ser inserido: ");
                        int elem = int.Parse(Console.ReadLine());
                        lista.InserirElemento(elem);
                        break;
                    case 2:
                        lista.RemoverElemento();
                        break;
                    case 3:
                        lista.ExibirElementos();
                        break;
                    case 4:
                        Console.Write("Digite o elemento a ser consultado: ");
                        int consulta = int.Parse(Console.ReadLine());
                        lista.ConsultarElemento(consulta);
                        break;
                    case 0:
                        break;
                    default:
                        Console.WriteLine("Opção inválida!");
                        break;
                }
                Console.WriteLine("Pressione qualquer tecla para continuar...");
                Console.ReadKey();
            } while (opcao != 0);
        }

        private static void GerenciarFila()
        {
            var fila = new Fila();
            int opcao;
            do
            {
                Console.Clear();
                Console.WriteLine("Operações na Fila:");
                Console.WriteLine("1. Inserir Elemento");
                Console.WriteLine("2. Remover Elemento");
                Console.WriteLine("3. Exibir Elementos");
                Console.WriteLine("4. Consultar Elemento");
                Console.WriteLine("0. Voltar");
                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        Console.Write("Digite o elemento a ser inserido: ");
                        int elem = int.Parse(Console.ReadLine());
                        fila.InserirElemento(elem);
                        break;
                    case 2:
                        fila.RemoverElemento();
                        break;
                    case 3:
                        fila.ExibirElementos();
                        break;
                    case 4:
                        Console.Write("Digite o elemento a ser consultado: ");
                        int consulta = int.Parse(Console.ReadLine());
                        fila.ConsultarElemento(consulta);
                        break;
                    case 0:
                        break;
                    default:
                        Console.WriteLine("Opção inválida!");
                        break;
                }
                Console.WriteLine("Pressione qualquer tecla para continuar...");
                Console.ReadKey();
            } while (opcao != 0);
        }

        private static void GerenciarPilha()
        {
            var pilha = new Pilha();
            int opcao;
            do
            {
                Console.Clear();
                Console.WriteLine("Operações na Pilha:");
                Console.WriteLine("1. Inserir Elemento");
                Console.WriteLine("2. Remover Elemento");
                Console.WriteLine("3. Exibir Elementos");
                Console.WriteLine("4. Consultar Elemento");
                Console.WriteLine("0. Voltar");
                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        Console.Write("Digite o elemento a ser inserido: ");
                        int elem = int.Parse(Console.ReadLine());
                        pilha.InserirElemento(elem);
                        break;
                    case 2:
                        pilha.RemoverElemento();
                        break;
                    case 3:
                        pilha.ExibirElementos();
                        break;
                    case 4:
                        Console.Write("Digite o elemento a ser consultado: ");
                        int consulta = int.Parse(Console.ReadLine());
                        pilha.ConsultarElemento(consulta);
                        break;
                    case 0:
                        break;
                    default:
                        Console.WriteLine("Opção inválida!");
                        break;
                }
                Console.WriteLine("Pressione qualquer tecla para continuar...");
                Console.ReadKey();
            } while (opcao != 0);
        }

        private static void GerenciarPesquisa()
        {
            List<int> lista = new List<int> { 1, 3, 5, 7, 9, 11 };
            int opcao;
            do
            {
                Console.Clear();
                Console.WriteLine("Operações de Pesquisa:");
                Console.WriteLine("1. Busca Sequencial");
                Console.WriteLine("2. Busca Binária");
                Console.WriteLine("0. Voltar");
                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        Console.Write("Digite o elemento a ser buscado: ");
                        int chaveSeq = int.Parse(Console.ReadLine());
                        int resultadoSeq = Pesquisa.BuscaSequencial(lista, chaveSeq);
                        if (resultadoSeq != -1)
                            Console.WriteLine($"Elemento encontrado na posição {resultadoSeq}.");
                        else
                            Console.WriteLine("Elemento não encontrado.");
                        break;
                    case 2:
                        Console.Write("Digite o elemento a ser buscado: ");
                        int chaveBin = int.Parse(Console.ReadLine());
                        int resultadoBin = Pesquisa.BuscaBinaria(lista, chaveBin);
                        if (resultadoBin != -1)
                            Console.WriteLine($"Elemento encontrado na posição {resultadoBin}.");
                        else
                            Console.WriteLine("Elemento não encontrado.");
                        break;
                    case 0:
                        break;
                    default:
                        Console.WriteLine("Opção inválida!");
                        break;
                }
                Console.WriteLine("Pressione qualquer tecla para continuar...");
                Console.ReadKey();
            } while (opcao != 0);
        }
    }
}
